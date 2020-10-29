using System;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var youtube = new YouTube.Api(new System.Net.Http.HttpClient(), "AIzaSyCsT1f-DOazcH0YJ0BK4l16xTcQlNSZq-k");

            var channel = await youtube.Channels("UCruQg25yVBppUWjza8AlyZA");

            Console.WriteLine(channel.Title);

            Console.ReadLine();
        }
    }
}