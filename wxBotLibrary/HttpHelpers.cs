using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace wxBotLibrary
{
    public static class HttpHelpers
    {
        public static async Task<string> PostStringFromUri(string url, object param)
        {
            HttpClientHandler handler = new HttpClientHandler();
            handler.UseDefaultCredentials = true;
            using (var client = new HttpClient(handler))
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.Timeout = new TimeSpan(0, 10, 0);
                HttpResponseMessage response = null;
                if (param == null)
                {
                    response = await client.PostAsync(url, null);
                }
                else
                {
                    JsonSerializerSettings jsetting = new JsonSerializerSettings();
                    jsetting.DefaultValueHandling = DefaultValueHandling.Ignore;
                    var str = new StringContent(JsonConvert.SerializeObject(param, Formatting.Indented, jsetting), Encoding.UTF8, "application/json");
                    response = await client.PostAsync(url, str);
                    response.EnsureSuccessStatusCode();
                }
                var responseJson = await response.Content.ReadAsStringAsync();
                return responseJson;
            }
        }

        public  static async Task<string> GetStringFromUri(string url)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.Timeout = new TimeSpan(0, 10, 0);

                HttpResponseMessage response = null;
                response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var responseJson = await response.Content.ReadAsStringAsync();

                    return responseJson;
                }

                return "";
            }
        }
    }
}
