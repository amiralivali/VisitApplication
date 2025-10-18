using Kavenegar;
using Microsoft.AspNetCore.Mvc;
using Visit.BLL;
using Visit.Shared;

namespace Visit.API.Controllers
{
    public class BimarController : BaseController
    {
        BimarService bimarService;
        public BimarController()
        {
            bimarService = new BimarService();
        }
        [HttpPost]
        public async Task<OprationResult> InsertAsync([FromBody] BimarInfo info)
        { 
            var result = await bimarService.InsertAsync(info);
            return result;
        }
        [HttpGet]
        public async Task<OprationResult> DeleteAsync(int id)
        {
            var result = await bimarService.DeleteAsync(id);
            return result;
        }
        [HttpPost]
        public async Task<OprationResult> UpdateAsync([FromBody] BimarInfo info)
        {
            var result = await bimarService.UpdateAsync(info);
            return result;
        }
        [HttpGet]
        public async Task<OprationResult<List<BimarDto>>> SelectAsync(string search)
        {
            var result = await bimarService.SelectAsync(search);
            return result;
        }
        [HttpGet]
        public async Task<OprationResult<BimarInfo>> GetBimar(string nc, string mobile)
        { 
            var result=await bimarService.GetBimarAsync(nc, mobile);
            return result;
        }
        [HttpGet]
        public async Task<bool> ExistBimarAsync(string nc, string mobile)
        {
            var result = await bimarService.ExistAsync(nc, mobile);
            return result;
        }
    }
}
