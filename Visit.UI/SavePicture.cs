using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visit.Shared;

namespace Visit.UI
{
    public static class SavePicture
    {
        public static async Task<OprationResult<string>> Save(string filePath)
        {
            var httpClient = HttpClientHelper.GetInstance();
            var result = await httpClient.PostAsync<OprationResult<string>,string>(RouteConstants.SavePhoto,filePath);
            return result;
        }
    }
}
