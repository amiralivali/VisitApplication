using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Web.Routing;
using Visit.Shared;
using static Visit.Shared.UserRole;

namespace Visit.UI
{
    public  class UserCheckSmsHandler
    {
        HttpClientHelper httpClientHelper;
        public UserCheckSmsHandler()
        {
            httpClientHelper = new HttpClientHelper();
        }
        public async Task<OprationResult> SendSmsIfUserExistsAsync(string randomCode,string ncNezam, string mobile)
        {
            var check = await UserExistsAsync(ncNezam, mobile);
            if (check)
            {
                var result = await SendSmsAsync(randomCode);
                return result;
            }
            else
            {
                return OprationResult.UnSuccess(Messages.NotExist);
            }
        }

        private async Task<bool> UserExistsAsync(string ncNezam,string mobile)
        {
            string route;
            if (UserRole.CurrentRole == Role.Bimar)
            {
                route = string.Format(RouteConstants.ExistBimar, ncNezam, mobile);
            }
            else
            {
                route = string.Format(RouteConstants.ExistDoctor, ncNezam, mobile);
            }
            bool check = await httpClientHelper.GetAsync<bool>(route);
            return check;
        }

        public async Task<OprationResult> SendSmsAsync(string randomCode)
        {
            string text = Messages.SmsText + Environment.NewLine + randomCode;
            var checkSms = await httpClientHelper.PostAsync<OprationResult, string>(RouteConstants.SendSms, text);
            return checkSms;
        }
    }
}
