using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace cowsay
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string quotes_path = "";
            if (args.Length > 0)
                quotes_path = args[0];
            string[] quotes = null;
            if (File.Exists(quotes_path))
                quotes = File.ReadAllLines(quotes_path, Encoding.UTF8);
            if (quotes == null)
                quotes = new string[1] { $"I am waiting for quotes to say :) ; Quotes Path: {quotes_path}" };
            Console.WriteLine($"Cow will say {quotes.Length} different quotes:");
            Console.WriteLine("");
            do
            {
                foreach (string quote in quotes)
                {
                    Console.WriteLine(quote);
                    await Task.Delay(5000);
                }
            } while (true);
        }
    }
}
