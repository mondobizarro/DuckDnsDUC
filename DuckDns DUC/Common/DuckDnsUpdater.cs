using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DuckDns_DUC.Common
{
    public class DuckDnsUpdater
    {
        public async Task<Boolean> UpdateAsync(string domain, string token, string InterfaceId)
        {
          
            string userAgent = "Mozilla/5.0";
            var ipAddress = Utils.GetNetworkInterfaces().Where(x=> x.Id == InterfaceId).First().DireccionIPv4;

            string url = $"http://www.duckdns.org/update?domains={domain}&token={token}&ip={ipAddress}";

            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, url);
                    request.Headers.Add("User-Agent", userAgent);

                    HttpResponseMessage response = await httpClient.SendAsync(request);
                    response.EnsureSuccessStatusCode();

                    string responseBody = await response.Content.ReadAsStringAsync();
                    return true;
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine($"Request error: {e.Message}");
                    return false;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"An error occurred: {e.Message}");
                    return false;
                }
            }
        }
    }
}
