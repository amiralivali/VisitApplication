using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Visit.UI
{
    internal class HttpClientHelper
    {
        HttpClient httpClient;
        private readonly HttpClientHandler httpHandler;
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
            var response = await httpClient.GetAsync(route);
            string content = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<T>(content);
            return result;
        }
        public async Task<Tout> PostAsync<Tout, Tin>(string route,Tin data)
        {
            string json = JsonConvert.SerializeObject(data);
            StringContent stringContent = new StringContent(json, Encoding.UTF8, "application/json"); 
            var response = await httpClient.PostAsync(route,stringContent);
            string content = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<Tout>(content);
            return result;
        }
    }
}
