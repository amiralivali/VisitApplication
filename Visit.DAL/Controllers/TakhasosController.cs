using Microsoft.AspNetCore.Mvc;
using Visit.BLL;
using Visit.Shared;

namespace Visit.API.Controllers
{
    public class TakhasosController : BaseController
    {
        TakhasosService takhasosService;
        public TakhasosController()
        {
            takhasosService = new TakhasosService();
        }
        [HttpPost]
        public async Task<OprationResult> InsertAsync([FromBody]Doctor_TakhasosInfo info)
        { 
            var result = await takhasosService.InsertAsync(info);
            return result;
        }
        [HttpGet]
        public async Task<OprationResult<List<TakhasosInfo>>> SelectAsync()
        {
            var result = await takhasosService.SelectAsync();
            return result;
        }
    }
}
