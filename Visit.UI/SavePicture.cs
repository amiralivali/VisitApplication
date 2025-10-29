using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visit.UI
{
    public static class SavePicture
    {
        public static async Task<string> Save(string filePath)
        {
            var httpClient = HttpClientHelper.GetInstance();
            var result = await httpClient.PostAsync<string,string>(RouteConstants.SavePhoto,filePath);
            return result;
        }
    }
}
