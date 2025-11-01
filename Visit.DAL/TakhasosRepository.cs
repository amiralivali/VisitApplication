using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Visit.Shared;

namespace Visit.DAL
{
    public class TakhasosRepository
    {
        VisitDbContext db;
        public TakhasosRepository()
        {
            db = new VisitDbContext();
        }
        public async Task<List<TakhasosInfo>> SelectAsync()
        {
            try
            {
                var takhasoses = await db.Takhasoses.ToListAsync();
                return takhasoses.Select(t => new TakhasosInfo()
                {
                    ID = t.ID,
                    Titel = t.Titel,
                }).ToList();
            }
            catch (Exception ex)
            {
                ex.AddLog();
                return null;
            }   
        }
        public async Task<bool> InsertAsync(Doctor_Takhasos takhasos)
        { 
            var tran=db.Database.BeginTransaction();
            try
            {
                await db.Doctor_Takhasoses.AddAsync(takhasos);
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
    }
}
