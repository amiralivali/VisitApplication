using Microsoft.EntityFrameworkCore;
using Visit.Shared;

namespace Visit.DAL
{
    public class BimarRepository
    {
        VisitDbContext db;
        public BimarRepository()
        {
            db = new VisitDbContext();
        }
        public async Task<bool> InsertAsync(User user,Bimar bimar)
        {
            var tran = db.Database.BeginTransaction();
            try
            {
                await db.Users.AddAsync(user);
                await db.SaveChangesAsync();
                bimar.BimarID = user.ID;
                await db.Bimars.AddAsync(bimar);
                await db.SaveChangesAsync();
                tran.Commit();
                return true;
            }
            catch(Exception ex)
            {
                await ex.AddLogAsync();
                tran.Rollback();
                return false;
            }
        }
        public async Task<bool> DeleteAsync(int id)
        {
            var tran = db.Database.BeginTransaction();
            try
            {
                var user = db.Users.Include(d => d.Bimar).ThenInclude(d => d.Visits).Where(d => d.ID == id).Single();
                db.Visits.RemoveRange(user.Bimar.Visits);
                db.Users.Remove(user);
                await db.SaveChangesAsync();
                tran.Commit();
                return true;
            }
            catch(Exception ex)
            {
                await ex.AddLogAsync();
                tran.Rollback();
                return false;
            }
        }
        public async Task<bool> UpdateAsync(BimarInfo info)
        {
            var tran = db.Database.BeginTransaction();
            try
            {
                var user = new User()
                {
                    ID = info.BimarID
                };
                db.Users.Attach(user);
                user.FirstName= info.FirstName;
                user.LastName = info.LastName;
                user.MobileNumber = info.MobileNumber;
                user.Picture = info.Picture;
                db.Entry(user).State = EntityState.Modified;
                var bimar = new Bimar()
                {
                    BimarID = info.BimarID,
                };
                db.Bimars.Attach(bimar);
                bimar.NationalCode = info.NationalCode;
                db.Entry(bimar).State = EntityState.Modified;
                await db.SaveChangesAsync();
                tran.Commit();
                return true;
            }
            catch(Exception ex)
            {
                await ex.AddLogAsync();
                tran.Rollback();
                return false;
            }
        }
        public async Task<List<BimarDto>> SelectAsync(string search)
        {
            try
            {
                var Bimars = await db.Bimars.AsNoTracking().Select(b => new BimarDto()
                {
                    BimarID = b.BimarID,
                    FirstName = b.User.FirstName,
                    LastName = b.User.LastName,
                    NationalCode = b.NationalCode,
                }).ToListAsync();
                return Bimars.Where(b => search == "" ||
                b.FirstName.Contains(search) ||
                b.LastName.Contains(search) ||
                b.NationalCode.Contains(search)).ToList();
            }
            catch(Exception ex)
            {
                await ex.AddLogAsync();
                return null;
            }
        }
        public async Task<BimarInfo> GetBimarAsync(string nc, string Mobile)
        {
            try
            {
                var user = await db.Users.Include(b=> b.Bimar).Where(b => b.Bimar.NationalCode == nc && b.MobileNumber == Mobile).SingleOrDefaultAsync();
                if (user != null)
                {
                    return new BimarInfo()
                    {
                        BimarID = user.ID,
                        FirstName = user.FirstName,
                        LastName = user.LastName,
                        NationalCode = nc,
                        MobileNumber = user.MobileNumber,
                        Picture = user.Picture,
                    };
                }
                else
                { 
                    return null;
                }
            }
            catch (Exception ex)
            {
                await ex.AddLogAsync();
                return null;
            }
        }
        public async Task<bool> ExistAsync(string nc,string Mobile)
        {
            var check = await db.Bimars.Where(b => b.NationalCode == nc && b.User.MobileNumber == Mobile).AnyAsync();
            return check;
        }
        public async Task<bool> DuplicateNationalCodeAsync(string nc, int bimarID = 0)
        {
            bool duplicate = false;
            if (bimarID == 0)
            {
                duplicate = await db.Bimars.Where(x => x.NationalCode == nc).AnyAsync();
            }
            else
            {
                duplicate = await db.Bimars.Where(x => x.NationalCode == nc && x.BimarID != bimarID).AnyAsync();
            }
            return duplicate;
        }
        public async Task<bool> DuplicateMobileAsync(string mobile, int id = 0)
        {
            bool duplicate = false;
            if (id == 0)
            {
                duplicate = await db.Users.Where(x => x.MobileNumber == mobile).AnyAsync();
            }
            else
            {
                duplicate = await db.Users.Where(x => x.MobileNumber == mobile && x.ID != id).AnyAsync();
            }
            return duplicate;
        }
    }
}
