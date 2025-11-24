using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Visit.Shared;
using Polly;
using Polly.Retry;


namespace Visit.UI
{
    internal class HttpClientHelper
    {
        HttpClient httpClient;
        private static HttpClientHelper instance;
        private readonly AsyncRetryPolicy<HttpResponseMessage> retryPolicy;
        private HttpClientHelper()
        {
            httpClient = new HttpClient()
            {
                BaseAddress = new Uri(RouteConstants.BaseUrl)
            };
            retryPolicy = Policy
                .Handle<HttpRequestException>()                 // خطاهای شبکه
                .OrResult<HttpResponseMessage>(r => !r.IsSuccessStatusCode) // پاسخ ناموفق
                .WaitAndRetryAsync(
                    3,
                    retryAttempt => TimeSpan.FromSeconds(retryAttempt)
                );
        }
        public static HttpClientHelper GetInstance()
        {
            if (instance == null)
            {
                instance = new HttpClientHelper();
            }
            return instance;
        }
        public async Task<T> GetAsync<T>(string route)
        {
            var req = new HttpRequestMessage(HttpMethod.Get, route);
            //string curl = req.ToCurl();
            var response = await retryPolicy.ExecuteAsync(() => httpClient.SendAsync(req));
            if (!response.IsSuccessStatusCode)
            {
                Exception ex = new Exception();
                //ex.AddLog(curl);
                return default(T);
            }
            string content = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<T>(content);
            return result;
        }
        public async Task<Tout> PostAsync<Tout, Tin>(string route,Tin data)
        {
            string json = JsonConvert.SerializeObject(data);
            Func<HttpRequestMessage> createRequest = () =>
                 new HttpRequestMessage(HttpMethod.Post, route)
                 {
                     Content = new StringContent(json, Encoding.UTF8, "application/json")
                 };
            //var curl = req.ToCurl();
            var response = await retryPolicy.ExecuteAsync(() =>
            {
                var req = createRequest();
                return httpClient.SendAsync(req);
            });
            if (!response.IsSuccessStatusCode)
            {
                Exception ex = new Exception();
                //ex.AddLog(curl);
                return default(Tout);
            }
            string content = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<Tout>(content);
            return result;
        }
    }
}
