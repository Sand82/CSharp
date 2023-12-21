using System.Net;
using System.Text;

namespace Program
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            HttpClient client = new HttpClient();

            await ReadData(client);
            
        }

        private static async Task ReadData(HttpClient client)
        {
            var url = "https://softuni.bg/";

            var response = await client.GetAsync(url);
            response.Headers.Add("X-ServerVersion", "1.0.0");
            response.Headers.Add("X-ServerAuthorUsername", "Sand82");

            var data = String.Join(Environment.NewLine, response.Headers.Select(x => x.Key + ": " + x.Value.First()));

            Console.WriteLine(data);
        }
    }
}