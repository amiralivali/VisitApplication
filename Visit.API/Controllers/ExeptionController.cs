using Microsoft.AspNetCore.Mvc;
using Visit.BLL;
using Visit.Shared;

namespace Visit.API.Controllers
{
    public class ExeptionController : BaseClassController
    {
        [HttpPost]
        public async Task InsertAsync([FromBody]Exception ex)
        {
            ExeptionService exeptionService = new ExeptionService();
            await exeptionService.InsertAsync(ex);
        }
    }
}
