using Microsoft.AspNetCore.Mvc;
using Visit.BLL;
using Visit.Shared;

namespace Visit.API.Controllers
{
    public class PhotoController : BaseClassController
    {
        [HttpPost]
        public async Task<OprationResult<string>> SaveAsync([FromBody]string filePath)
        { 
            PhotoService photoService = new PhotoService();
            var result = await photoService.SaveAsync(filePath);
            return result;
        }
    }
}
