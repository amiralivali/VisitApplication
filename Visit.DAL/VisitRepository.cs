using System.Transactions;
using Microsoft.EntityFrameworkCore;
using Visit.Shared;

namespace Visit.DAL
{
    public class VisitRepository
    {
        VisitDbContext db;
        public VisitRepository()
        {
            db = new VisitDbContext();
        }
        public async Task<List<VisitDto>> SelectAsync(int id,string search)
        {
            try
            {
                var visits = await db.Visits.Include(d=>d.Doctor.User).Include(b=>b.Bimar.User).Where(v => v.BimarID == id || v.DoctorID == id)
                    .Where(v => search == "" ||
                    v.Bimar.User.FirstName.Contains(search) ||
                    v.Bimar.User.LastName.Contains(search) ||
                    v.Doctor.User.FirstName.Contains(search) ||
                    v.Doctor.User.LastName.Contains(search) ||
                    v.Time.ToString().Contains(search) ||
                    v.Date.ToString().Contains(search)).ToListAsync();
                return visits.Select(v => new VisitDto()
                {
                    FullNameBimar = v.Bimar.User.FirstName + " " + v.Bimar.User.LastName,
                    FullNameDoctor = v.Doctor.User.FirstName + " " + v.Doctor.User.LastName,
                    DateTime = v.Date
                }).ToList();
            }
            catch (Exception ex)
            {
                ex.AddLog();
                return null;
            }
        }
        public async Task<bool> InsertAsync(Visit info)
        {
            var tran=db.Database.BeginTransaction();
            try
            {
                await db.Visits.AddAsync(info);
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
    }
}
