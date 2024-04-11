using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace TankActivity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Run();
            for(;;){}
        }

        private static async void Run()
        {
            string thisPath = Directory.GetParent(System.Reflection.Assembly.GetExecutingAssembly().Location).FullName;
            string code = File.ReadAllText(Path.Combine(thisPath, "YourTank.cs"));
            HttpClient client = new HttpClient();
            Console.WriteLine("Uploading...");
            ulong id = (ulong)Random.Shared.NextInt64();
            await client.PostAsync($"https://highscores.neonrogue.net/uploadmap/tanks", new StringContent($"{id:D21}{Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(code))}"));
            Console.WriteLine("Done!");
            Console.WriteLine("Press Enter to exit");
            Environment.Exit(0);
        }
    }
}
