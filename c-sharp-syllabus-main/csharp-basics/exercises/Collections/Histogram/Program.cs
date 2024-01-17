using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Histogram
{
    class Program
    {
        private const string FilePath = "../../../midtermscores.txt";
        private const int MinScore = 0;
        private const int MaxScore = 100;
        private const int CurrentRange = 10;
        private const int NumBuckets = 10;
        private const string Format = "{0:D2} - {1:D2}";
        private const string ScoreKey = "100";

        static void Main()
        {
            var histogram = GenerateHistogram(GetScores());
            OutputHistogram(histogram);
            
            Console.Read();
        }

        static int[] GetScores() =>
            File.ReadAllText(FilePath).Split().Select(int.Parse).ToArray();

        static void AddScore(Dictionary<string, int> histogram, int score)
        {
            if (score >= MinScore && score <= MaxScore)
            {
                int index = score / CurrentRange;
                string key = (index == NumBuckets) ? ScoreKey : string.Format(Format, index * CurrentRange, index * CurrentRange + CurrentRange - 1);
                histogram[key]++;
            }
        }

        static Dictionary<string, int> GenerateHistogram(int[] scores)
        {
            var histogram = new Dictionary<string, int>(
                Enumerable.Range(0, NumBuckets)
                    .Select(i => string.Format(Format, i * CurrentRange, i * CurrentRange + CurrentRange - 1))
                    .Concat(new[] { ScoreKey })
                    .ToDictionary(key => key, _ => 0)
            );

            foreach (var score in scores)
                AddScore(histogram, score);

            return histogram;
        }

        static void OutputHistogram(Dictionary<string, int> histogram) =>
            histogram.ToList().ForEach(h => Console.WriteLine($"{h.Key}: {new string('*', h.Value)}"));
    }
}
