using Kavenegar;
using Visit.Shared;

namespace Visit.BLL
{
    public class SmsService
    {
        public OprationResult Send(string smsText)
        {
            var senderClient = Constance.SenderClient;
            var receptor = "09925746745";//به دلیل کامل نبودن احراز هویت نمیتوان به شماره های دیگر ارسال شود
            var message = smsText;
            var api = new KavenegarApi(Constance.API);
            var result = api.Send(senderClient, receptor, message);
            if (result.Status == 5)
            {
                return OprationResult.Success(Messages.Send);
            }
            else
            {
                return OprationResult.RunTimeError();
            }
        }
    }
}
