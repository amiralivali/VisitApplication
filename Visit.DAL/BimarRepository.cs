﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Infrastructure.Interception;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                db.Users.Add(user);
                await db.SaveChangesAsync();
                bimar.BimarID = user.ID;
                db.Bimars.Add(bimar);
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
                var user = db.Users.Where(u => u.ID == id).Single();
                db.Users.Remove(user);
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
        public async Task<bool> UpdateAsync(BimarInfo info)
        {
            var tran = db.Database.BeginTransaction();
            try
            {
                var user = db.Users.Where(b => b.ID == info.BimarID).Single();
                user.FirstName = info.FirstName;
                user.LastName = info.LastName;
                user.MobileNumber = info.MobileNumber;
                user.Email = info.Email;
                user.Picture = info.Picture;
                var bimar = db.Bimars.Where(b => b.BimarID == info.BimarID).Single();
                bimar.NationalCode = info.NationalCode;
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
                ex.AddLog();
                return null;
            }
        }
        public async Task<bool> ExistAsync(string Nc,string Mobile)
        {
            bool exist = await db.Bimars.Where(b => b.NationalCode == Nc && b.User.MobileNumber == Mobile).AnyAsync();
            return exist;
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
        public async Task<bool> DuplicateEmailAsync(string email, int id = 0)
        {
            bool duplicate = false;
            if (id == 0)
            {
                duplicate = await db.Users.Where(x => x.Email == email).AnyAsync();
            }
            else
            {
                duplicate = await db.Users.Where(x => x.Email == email && x.ID != id).AnyAsync();
            }
            return duplicate;
        }
    }
}
