using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DeepInCShape
{
    class 初识异步编程
    {
        private static Action onInput;

        static void Main(string[] args)
        {
            onInput += PrintPageLength;
            Console.ReadKey();
            onInput.Invoke();

            Console.ReadKey();

        }

        async static void PrintPageLength()
        {
            int result = (await GetPageLengthAsync("http://www.bilibili.com/"));
            Console.WriteLine(result);
        }

        static async Task<int> GetPageLengthAsync(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                Task<string> fetchTextTask = client.GetStringAsync(url);
                int length = (await fetchTextTask).Length;
                return length;
            }
        }
    }
}
