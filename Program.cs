using System;
using System.Collections.Generic;
using System.IO;

namespace TeleprompterConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = ReadFrom("sampleQuotes.txt");
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
        }

        static IEnumerable<string> ReadFrom(string file)
        {
            string line;
            using (var reader = File.OpenText(file))
            {
                while((line = reader.ReadLine()) != null)
                {
                    var words = line.Split(' ');
                    foreach(var word in words)
                    {
                        yield return word + " ";
                    }
                    yield return Environment.NewLine;
                }
            }
        }
    }
}
