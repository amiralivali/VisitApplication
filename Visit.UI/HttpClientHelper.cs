using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Polly.Retry;
using Visit.Shared;

namespace Visit.UI
{
    internal class HttpClientHelper
    {
        HttpClient httpClient;
        private static HttpClientHelper instance;
        private HttpClientHelper()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(RouteConstants.BaseUrl);
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
            //polly
            var req = new HttpRequestMessage(HttpMethod.Get, route)
            {
                RequestUri = new Uri(RouteConstants.BaseUrl + route)
            };
            var curl = req.ToCurl();
            var response = await httpClient.SendAsync(req);
            if (!response.IsSuccessStatusCode)
            {
                var ex = new Exception();
                ex.AddLog(curl);
                return default(T);
            }
            string content = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<T>(content);
            return result;
        }
        public async Task<Tout> PostAsync<Tout, Tin>(string route,Tin data)
        {
            //polly
            string json = JsonConvert.SerializeObject(data);
            StringContent stringContent = new StringContent(json, Encoding.UTF8, "application/json");
            var req = new HttpRequestMessage(HttpMethod.Post, route)
            {
                Content = stringContent,
                RequestUri = new Uri(RouteConstants.BaseUrl + route)
            };
            var curl = req.ToCurl();
            var response = await httpClient.SendAsync(req);
            if (!response.IsSuccessStatusCode)
            {
                var ex = new Exception();
                ex.AddLog(curl);
                return default(Tout);
            }
            string content = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<Tout>(content);
            return result;
        }
    }
}
