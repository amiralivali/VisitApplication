using Microsoft.AspNetCore.Mvc;
using Visit.BLL;
using Visit.Shared;

namespace Visit.API.Controllers
{
    public class VisitController : BaseController
    {
        VisitService visitService;
        public VisitController()
        {
            visitService = new VisitService();
        }
        [HttpPost]
        public async Task<OprationResult> InsertAsync([FromBody]VisitInfo info)
        { 
            var result = await visitService.InsertAsync(info);
            return result;
        }
        [HttpGet]
        public async Task<OprationResult<List<VisitDto>>> SelectAsync(int id,string search)
        {
            var result = await visitService.SelectAsync(id,search);
            return result;
        }
    }
}
