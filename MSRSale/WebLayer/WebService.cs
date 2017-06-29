using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MSRSale.WebLayer
{
    public class WebService
    {
        public async Task<string> checklogin(string username, string password)
        {
            using (var client = new HttpClient())
            {
                string loginurl = "http://msrfieldsales.azurewebsites.net/api/Services/ValidateLogin?username={0}&password={1}";

                string url = string.Format(loginurl, username, password);

                var jsondata = await client.GetStringAsync(url);

                return JsonConvert.DeserializeObject<string>(jsondata);

            }
        }
    }
}
