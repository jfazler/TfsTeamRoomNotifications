using System;
using System.Net.Http;
using System.Security;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace TfsTeamRoomNotifications
{
    public static class Helper
    {
        #region HttpClient Calls
        public static async Task<string> GetJsonDataAsString(string sUrl)
        {
            return await GetJsonDataAsString(sUrl, "", Properties.Settings.Default.PersonalAccessToken);
        }

        public static async Task<string> GetJsonDataAsString(string sUrl, string username, string password)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(
                    new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic",
                    Convert.ToBase64String(
                        System.Text.ASCIIEncoding.ASCII.GetBytes(
                            string.Format("{0}:{1}", username, password))));

                using (HttpResponseMessage response = client.GetAsync(sUrl).Result)
                {
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    //Console.WriteLine(responseBody);
                    return responseBody;
                }
            }
        }
        #endregion HttpClient Calls
    }
}
