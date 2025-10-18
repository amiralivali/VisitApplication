using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Visit.DAL;
using Visit.Shared;

namespace Visit.BLL
{
    public class BimarService
    {
        BimarRepository repository;
        public BimarService()
        {
            repository = new BimarRepository();
        }

        public async Task<OprationResult> CheckDataAsync(BimarInfo info)
        {
            if (info.IsValid)
            {
                if (info.BimarID > 0)
                {
                    if (await repository.DuplicateNationalCodeAsync(info.NationalCode, info.BimarID))
                    {
                        return OprationResult.Duplicate(Messages.NationalCode);
                    }
                    else if (await repository.DuplicateMobileAsync(info.MobileNumber, info.BimarID))
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
                    if (await repository.DuplicateNationalCodeAsync(info.NationalCode))
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
        public async Task<OprationResult> InsertAsync(BimarInfo info)
        {
            var checkData = await CheckDataAsync(info);
            if (checkData.IsSuccess)
            {
                User user = info.MapToUser();
                Bimar bimar = info.MapToBimar();
                bool check = await repository.InsertAsync(user, bimar);
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
        public async Task<OprationResult> UpdateAsync(BimarInfo info)
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
        public async Task<OprationResult<List<BimarDto>>> SelectAsync(string search)
        {
            var Bimars = await repository.SelectAsync(search);
            if (Bimars != null)
            {
                return OprationResult<List<BimarDto>>.Success(Bimars);
            }
            else
            {
                return OprationResult<List<BimarDto>>.RunTimeError();
            }
        }
        public async Task<bool> ExistAsync(string nc, string Mobile)
        {
            var check = await repository.ExistAsync(nc, Mobile);
            return check;
        }
        public async Task<OprationResult<BimarInfo>>GetBimarAsync(string nc, string mobile)
        {
            var bimar = await repository.GetBimarAsync(nc, mobile);
            if (bimar != null)
            {
                return OprationResult<BimarInfo>.Success(bimar);
            }
            else
            {
                return OprationResult<BimarInfo>.RunTimeError();
            }
        }
    }
}
