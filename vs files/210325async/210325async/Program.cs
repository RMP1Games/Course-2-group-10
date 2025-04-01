using System;
using static System.Net.WebRequestMethods;
using System.Threading.Tasks;

namespace _210325async
{
    public class _210325async
    {
        public static async Task<string> FetchDataAsync(string url)
        {
            try
            {
                var client = new HttpClient();
                return await client.GetStringAsync(url);
            }
            catch (Exception ex)
            {
                return $"Ошибка при загрузке данных c использованием ({url}): {ex.Message}";
            }
        }

        public static async Task Main()
        {
            List<string> urls = new List<string>
        {"https://jsonplaceholder.typicode.com/posts/1","https://dog.ceo/api/breeds/image/random","https://randomuser.me/api/", "https://invalid-api.example"};
            var tasks = urls.Select(url => FetchDataAsync(url)).ToList();
            var results = await Task.WhenAll(tasks);

            foreach (var result in results)
            {
                Console.WriteLine(result);
                Console.WriteLine(" ");
                Console.WriteLine("--------------------");
                Console.WriteLine(" ");
            }
        }
    }
}