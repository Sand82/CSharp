using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;

namespace Program
{
    public class Program
    {
        private static string newline = "\r\n";

        private static Dictionary<string, int> SesionCount = new ();

        public static async Task Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            HttpClient httpClient = new HttpClient();

            var port = 12345;

            TcpListener TcpListener = new TcpListener(IPAddress.Loopback, port);
            TcpListener.Start();                      

            while (true) 
            {
                var client = TcpListener.AcceptTcpClient();
                using (var stream = client.GetStream())
                {
                    var buffer = new byte[1000000];

                    var byteData = await stream.ReadAsync(buffer, 0, buffer.Length);

                    var requestSting = Encoding.UTF8.GetString(buffer, 0, byteData);

                    var sid = Guid.NewGuid().ToString();

                    var match = Regex.Match( requestSting, @"sid=[^\n]*\n");

                    if (match.Success)
                    {
                       var sidData = match.Value.Split("; ").ToArray();
                       sid = sidData[0].Substring(4);
                    }

                    if (!SesionCount.ContainsKey(sid))
                    {
                        SesionCount.Add(sid, 0);
                    }

                    SesionCount[sid]++;

                    Console.WriteLine(SesionCount[sid]);

                    Console.WriteLine(requestSting);

                    Console.WriteLine(new string('=', 60));

                    string html = $"<h1>Hello from Sand {DateTime.Now}</h1>";

                    int htmlLenght = html.Length;

                    string responce = "HTTP/1.1 200 OK" + newline +
                        "SandServer: 2023" + newline +
                        "Content-Type: text/plain; charSet=utf8" + newline +
                        $"Set-cookie: sid={sid}" + newline + 
                        "Set-cookie: lang=bg" + newline +
                        //"Content-Disposition: attachment; fileName=sand.txt" + newline +
                        "ContentLenght: htmlLenght: " + htmlLenght + newline + newline
                        + html + newline;

                    byte[] byteResponse = Encoding.UTF8.GetBytes(responce);

                    stream.Write(byteResponse);                   
                }                
            }

            //await ReadData(client);
            
        }

        private static async Task ReadData(HttpClient client)
        {
            var url = "https://softuni.bg/";

            var response = await client.GetAsync(url);
            response.Headers.Add("X-ServerVersion", "1.0.0");
            response.Headers.Add("X-ServerAuthorUsername", "Sand82");

            var data = String.Join(Environment.NewLine, response.Headers.Select(x => x.Key + ": " + String.Join("; ",x.Value.Distinct())));

            Console.WriteLine(data);
        }
    }
}