using Microsoft.EntityFrameworkCore;
using Visit.Shared;

namespace Visit.DAL
{
    public class DoctorRepository
    {
        VisitDbContext db;
        public DoctorRepository()
        {
            db = new VisitDbContext();
        }
        public async Task<bool> InsertAsync(User user,Doctor doctor)
        {
            var tran = db.Database.BeginTransaction();
            try
            {
                await db.Users.AddAsync(user);
                await db.SaveChangesAsync();
                doctor.DoctorID = user.ID;
                await db.Doctors.AddAsync(doctor);
                await db.SaveChangesAsync();
                tran.Commit();
                return true;
            }
            catch(Exception ex)
            {
                ex.AddLog();
                tran.Rollback();
                return false;
            }
        }
        public async Task<bool> DeleteAsync(int id)
        {
            var tran = db.Database.BeginTransaction();
            try
            { 
                var user = db.Users.Include(d=>d.Doctor).ThenInclude(d=>d.Visits).Where(d => d.ID == id).Single();
                db.Visits.RemoveRange(user.Doctor.Visits);
                db.Users.Remove(user);
                await db.SaveChangesAsync();
                tran.Commit();
                return true;
            }
            catch (Exception ex)
            {
                ex.AddLog();
                tran.Rollback();
                return false;
            }
        }
        public async Task<bool> UpdateAsync(DoctorInfo info)
        {
            var tran = db.Database.BeginTransaction();
            try
            {
                var user = db.Users.Where(d => d.ID == info.DoctorID).Single();
                var doctor = db.Doctors.Where(d => d.DoctorID == info.DoctorID).Single();
                user.FirstName = info.FirstName;
                user.LastName = info.LastName;
                user.MobileNumber = info.MobileNumber;
                user.Picture = info.Picture;
                doctor.CodeNezamPezeshki = info.CodeNezamPezeshki;
                doctor.StartWorkingTime = info.StartTime;
                doctor.EndWorkingTime = info.EndTime;
                await db.SaveChangesAsync();
                tran.Commit();
                return true;
            }
            catch(Exception ex)
            {
                ex.AddLog();
                tran.Rollback();
                return false;
            }
        }
        public async Task<List<DoctorDto>> SelectAsync(string search)
        {
            try
            {
                var doctors = await db.Doctors.Include(d => d.User)
                    .Include(d => d.Doctor_Takhasoses)
                    .ThenInclude(d => d.Takhasos).AsNoTracking()
                    .Select(d => new DoctorDto()
                    {
                        DoctorID = d.DoctorID,
                        FullName = d.User.FirstName + " " + d.User.LastName,
                        Picture = d.User.Picture,
                        Takhasos = d.Doctor_Takhasoses.Select(d => d.Takhasos).Select(x => new TakhasosInfo()
                        {
                            ID = x.ID,
                            Titel = x.Titel,
                        }).ToList(),
                        StartTime = d.StartWorkingTime,
                        EndTime = d.EndWorkingTime,
                    }).ToListAsync();
                return doctors.Where(d => search == "" ||
                d.FullName.Contains(search) ||
                d.Takhasos.Any(t=>t.Titel.Contains(search)) ||
                d.StartTime.ToString().Contains(search) ||
                d.EndTime.ToString().Contains(search)).ToList();
            }
            catch(Exception ex)
            {
                ex.AddLog();
                return null;
            }
        }
        public async Task<bool> ExistAsync(string Nezam, string Mobile)
        {  
            var exist = await db.Doctors.Where(b => b.CodeNezamPezeshki == Nezam && b.User.MobileNumber == Mobile).AnyAsync();
            return exist;
        }
        public async Task<DoctorInfo> GetDoctorAsync(string Nezam, string Mobile)
        {
            try
            {
                var user = await db.Users.Include(u => u.Doctor).Where(d => d.Doctor.CodeNezamPezeshki == Nezam && d.MobileNumber == Mobile).SingleAsync();
                return new DoctorInfo()
                {
                    DoctorID = user.ID,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    CodeNezamPezeshki = Nezam,
                    MobileNumber = user.MobileNumber,
                    Picture = user.Picture,
                    StartTime=user.Doctor.StartWorkingTime,
                    EndTime=user.Doctor.EndWorkingTime,
                };
            }
            catch (Exception ex)
            {
                ex.AddLog();
                return null;
            }
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
        public async Task<bool> DuplicateNezamAsync(string nezamPezeshki, int doctorID = 0)
        {
            bool duplicate = false;
            if (doctorID == 0)
            {
                duplicate = await db.Doctors.Where(x => x.CodeNezamPezeshki == nezamPezeshki).AnyAsync();
            }
            else
            {
                duplicate = await db.Doctors.Where(x => x.CodeNezamPezeshki == nezamPezeshki && x.DoctorID != doctorID).AnyAsync();
            }
            return duplicate;
        }
    }
}
