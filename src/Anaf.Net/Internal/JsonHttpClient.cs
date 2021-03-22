using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Anaf.Net.Internal
{
    public class JsonHttpClient: HttpClient
    {
        public string MediaType => "application/json";

        public async Task<T> GetAsync<T>(string uri)
        {
            var response = await GetAsync(new Uri(uri));
            if (!response.IsSuccessStatusCode) return default;
            var result = await response.Content.ReadAsStringAsync();

            return !result.Contains("error")
                ? JsonConverter.DeserializeObject<T>(result)
                : default;
        }

        public async Task<IEnumerable<T>> GetListAsync<T>(string uri)
        {
            var response = await GetAsync(new Uri(uri));

            if (!response.IsSuccessStatusCode) return Enumerable.Empty<T>();
            var result = await response.Content.ReadAsStringAsync();

            return !result.Contains("error")
                ? JsonConverter.DeserializeObject<List<T>>(result)
                : Enumerable.Empty<T>();
        }

        public async Task<TR> PostAsync<T, TR>(string uri, T data)
        {
            var content = new StringContent(JsonConverter.SerializeObject(data), Encoding.UTF8, MediaType);

            var response = await PostAsync(new Uri(uri), content);
            if (!response.IsSuccessStatusCode) return default;

            var result = await response.Content.ReadAsStringAsync();
            if (result.Contains("error")) return default;

            var output = JsonConverter.DeserializeObject<TR>(result);
            return output;
        }
    }
}