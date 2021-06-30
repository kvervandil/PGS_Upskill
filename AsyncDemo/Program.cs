using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncDemo
{
    class Program
    {
        public static async Task Main()
        {
            Task<int> numbers = GetNoOfChars();
            int numbersLoaded = await numbers;
            Console.WriteLine($"{numbersLoaded}");

            Task<int> downloading = DownloadDocsMainPageAsync();
            Console.WriteLine($"{nameof(Main)}: Launched downloading.");
            int bytesLoaded = await downloading;
            Console.WriteLine($"{nameof(Main)}: Downloaded {bytesLoaded} bytes.");

            Console.ReadLine();
        }

        private static async Task<int> DownloadDocsMainPageAsync()
        {
            Console.WriteLine($"{nameof(DownloadDocsMainPageAsync)}: About to start downloading.");

            var client = new HttpClient();
            byte[] content = await client.GetByteArrayAsync("https://docs.microsoft.com/en-us/");

            Console.WriteLine($"{nameof(DownloadDocsMainPageAsync)}: Finished downloading.");
            return content.Length;
        }

        private static async Task<int> GetNoOfChars()
        {

            Console.WriteLine("start calculating");

            var result = await Calculate("234234234234234234234");

            return result;
        }

        private static async Task<int> Calculate(string word)
        {
            int no = 0;

            foreach (var c in word)
            {
                await Task.Delay(50);
                no++;
            }

            return no;
        }
    }
}
