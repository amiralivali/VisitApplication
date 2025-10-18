using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visit.DAL;
using Visit.Shared;

namespace Visit.BLL
{
    public class DoctorService
    {
        DoctorRepository repository;
        public DoctorService()
        {
            repository = new DoctorRepository();
        }
        public async Task<OprationResult> CheckDataAsync(DoctorInfo info)
        {
            if (info.IsValid)
            {
                if (info.DoctorID > 0)
                {
                    if (await repository.DuplicateNezamAsync(info.CodeNezamPezeshki, info.DoctorID))
                    {
                        return OprationResult.Duplicate(Messages.NationalCode);
                    }
                    else if (await repository.DuplicateMobileAsync(info.MobileNumber, info.DoctorID))
                    {
                        return OprationResult.Duplicate(Messages.Mobile);
                    }
                    else
                    {
                        return OprationResult.Success(Messages.Update);
                    }
                }
                else
                {
                    if (await repository.DuplicateNezamAsync(info.CodeNezamPezeshki))
                    {
                        return OprationResult.Duplicate(Messages.NationalCode);
                    }
                    else if (await repository.DuplicateMobileAsync(info.MobileNumber))
                    {
                        return OprationResult.Duplicate(Messages.Mobile);
                    }
                    else
                    {
                        return OprationResult.Success(Messages.Insert);
                    }
                }
            }
            else
            {
                return OprationResult.UnSuccess(info.Message);
            }
        }
        public async Task<OprationResult> InsertAsync(DoctorInfo info)
        {
            var checkData = await CheckDataAsync(info);
            if (checkData.IsSuccess)
            {
                User user = info.MapToUser();
                Doctor doctor = info.MapToDoctor();
                bool check = await repository.InsertAsync(user, doctor);
                if (check)
                {
                    return checkData;
                }
                else
                {
                    return OprationResult.RunTimeError();
                }
            }
            else
            {
                return checkData;
            }
        }
        public async Task<OprationResult> UpdateAsync(DoctorInfo info)
        {
            var checkData = await CheckDataAsync(info);
            if (checkData.IsSuccess)
            {
                bool check = await repository.UpdateAsync(info);
                if (check)
                {
                    return checkData;
                }
                else
                {
                    return OprationResult.RunTimeError();
                }
            }
            else
            {
                return checkData;
            }
        }
        public async Task<OprationResult> DeleteAsync(int id)
        {
            bool check = await repository.DeleteAsync(id);
            if (check)
            {
                return OprationResult.Success(Messages.Delete);
            }
            else
            {
                return OprationResult.RunTimeError();
            }
        }
        public async Task<OprationResult<List<DoctorDto>>> SelectAsync(string search = "")
        {
            var doctors = await repository.SelectAsync(search);
            if (doctors != null)
            {
                return OprationResult<List<DoctorDto>>.Success(doctors);
            }
            else
            {
                return OprationResult<List<DoctorDto>>.RunTimeError();
            }
        }
        public async Task<bool> ExistAsync(string Nezam, string Mobile)
        {
            var exist = await repository.ExistAsync(Nezam, Mobile);
            return exist;
        }

        public async Task<OprationResult<DoctorInfo>> GetDoctorAsync(string nezam, string mobile)
        {
            var doctor=await repository.GetDoctorAsync(nezam, mobile);
            if (doctor != null)
            {
                return OprationResult<DoctorInfo>.Success(doctor);
            }
            else
            {
                return OprationResult<DoctorInfo>.RunTimeError();
            }
        }
    }
}
