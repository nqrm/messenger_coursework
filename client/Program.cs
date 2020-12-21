using System;
using System.IO;
using System.Net;
using System.Text.Json;
using Server;

namespace client
{
    class Program
    {
        static void Main(string[] args)
        {
            message msg = new message();
            string usr = "";
            string text = "";
            Console.Write("Enter username: ");
            usr = Console.ReadLine();
            Console.Write("Enter message: ");
            text = Console.ReadLine();
            msg.username = usr;
            msg.text = text;
            string json = JsonSerializer.Serialize(msg);
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:5000/api/Communication");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }

            for (int id = 0; id < 10; id++)
            {
                GetDataAsync(id);
            }
            Console.ReadKey();
        }

        static async System.Threading.Tasks.Task GetDataAsync(int id)
        {
            WebRequest request = WebRequest.Create("http://localhost:5000/api/Communication/"+ id.ToString());
            WebResponse response = await request.GetResponseAsync();
            using (Stream stream = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    message msg1 = JsonSerializer.Deserialize<message>(reader.ReadToEnd());
                    Console.WriteLine(msg1.username + " " + msg1.text);
                }
            }
            response.Close();
        }
    }
}
