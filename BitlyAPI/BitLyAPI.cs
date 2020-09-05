using Newtonsoft.Json;
using System;
using System.Configuration;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace BitlyAPI
{
    public class BitLyAPI
    {
        // Acess Token BitLy: caa5bad2e1c1e5ef99ce8eed4b0724a16fc4b69e
        private string _bitLyApiUrl;
        private string _bitLyApiToken;

        public BitLyAPI()
        {
            _bitLyApiUrl = ConfigurationManager.AppSettings["BitLyApiUrl"];
            _bitLyApiToken = ConfigurationManager.AppSettings["BitLyApiToken"];
        }

        public async Task<string> ShortenAsync(string longUrl)
        {
            return await Task.Run(() => Shorten(longUrl));
        }

        private string Shorten(string longUrl)
        {
            if (CheckAcessToken())
            {
                return "Não foi possível encurtar a URL!";
            }

            using (HttpClient client = new HttpClient())
            {
                string temp = string.Format(_bitLyApiUrl, _bitLyApiToken, WebUtility.UrlEncode(longUrl));
                var response = client.GetAsync(temp).Result;

                if (!response.IsSuccessStatusCode)
                {
                    return "Não foi possível encurtar a URL!";
                }

                var message = response.Content.ReadAsStringAsync().Result;
                dynamic obj = JsonConvert.DeserializeObject(message);
                // return obj.results[longUrl].shortUrl;
                return "teste";
            }
        }

        private bool CheckAcessToken()
        {
            if (string.IsNullOrEmpty(_bitLyApiToken))
            {
                return false;
            }

            string temp = string.Format(_bitLyApiUrl, _bitLyApiToken, "google.com");

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync(temp).Result;
                return response.IsSuccessStatusCode;
            }
        }
    }
}
