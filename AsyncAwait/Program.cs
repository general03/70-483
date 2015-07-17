using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace AsyncAwait
{
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine(DownloadContent().Result);

            Console.ReadKey();
        }

        /// <summary>
        /// Asynchronous method with async keyword
        /// </summary>
        public static async Task<string> DownloadContent()
        {
            using(HttpClient client = new HttpClient())
            {
                // Wait the end of this asynchronous method to return the result
                return await client.GetStringAsync("http://www.microsoft.com");
            }
        }
    }
}
