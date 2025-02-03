using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L14_HttpProgect
{
    internal class HttpMethod
    {
        public async Task<string> GetContent(string url)
        {
            using var client = new HttpClient();
            var response = await client.GetAsync(url);
            return await response.Content.ReadAsStringAsync();
        }
        public async Task<string> PostContent(string url, string strContent)
        {
            using var client = new HttpClient();
            var urlForPost = url + "post";
            var response = await client.PostAsync(urlForPost, new StringContent(strContent));
            return await response.Content.ReadAsStringAsync();
        }
        public async Task<string> PutContent(string url, string strContent)
        {
            using var client = new HttpClient();
            var urlForRut = url + "put";
            var response = await client.PutAsync(urlForRut, new StringContent(strContent));
            return await response.Content.ReadAsStringAsync();
        }
        public async Task<string> DeleteContent(string url)
        {
            using var client = new HttpClient();
            var urlForDelete = url + "delete";
            var response = await client.DeleteAsync(urlForDelete);
            return await response.Content.ReadAsStringAsync();
        }

    }
}
