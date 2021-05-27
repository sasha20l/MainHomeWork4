using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HomeWork4_1
{
    class HttpHandler
    {
        private static readonly string _requestUri = "https://jsonplaceholder.typicode.com/posts";
        private static readonly HttpClient _httpClient = new HttpClient();

        public static async Task<Post> GetPostAsync(int postId)
        {
            try
            {
                var response = await _httpClient.GetAsync($"{_requestUri}/{postId}");
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Post>(content);
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
