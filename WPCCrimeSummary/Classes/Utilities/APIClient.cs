using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace WPCCrimeSummary.Classes.Utilities
{
    public class APIClient
    {
        private HttpClient _client;

        public APIClient()
        {
            _client = new HttpClient();
        }

        public string GetResponse(string _APIRoute, string _EndPoint)
        {
            var httpResponse = _client.GetAsync(new Uri($"{_APIRoute}/{_EndPoint}")).Result;

            string content = httpResponse.Content.ReadAsStringAsync().Result;    

            return content;
        }
    }
}
