using System;
using System.Text.RegularExpressions;

namespace _01Arriving
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex =
@"(?<name>[^!@#$?])(?<length>[0-9])(?<code>)";
            string input = Console.ReadLine();
            MatchCollection matched = Regex.Matches(input, regex);

            foreach (Match date in matched)
            {
                var name = date.Groups["name"].Value;
                var length = date.Groups["length"].Value;
                var code = date.Groups["code"].Value;


                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }









            //string[] input = Console.ReadLine().Split("=");
            //
            //string peakName = input[0];
            //string[] lengthAndGeohash = input[1].Split("<<");
            //string length = lengthAndGeohash[0];
            //string geohash = lengthAndGeohash[1];
            //
            //string regex = @"[^!@#$?]";
            //
            //MatchCollection matched =
            //              Regex.Matches(peakName, regex);
            //
            //
            //

            //char[] oddChars = { '!', '@', '#', '$', '?' };
            //if (peakName.Contains('!'))
            //{
            //    peakName.Remove(peakName.IndexOf('!'),1);
            //}
            //
            //Console.WriteLine(peakName);
        }
    }
}
