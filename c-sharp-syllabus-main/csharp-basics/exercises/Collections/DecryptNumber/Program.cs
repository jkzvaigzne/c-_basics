﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace DecryptNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cryptedNums = new List<string>
            {
                "())(",
                "*$(#&",
                "!!!!!!!!!!",
                "$*^&@!",
                "!)(^&(#@",
                "!)(#&%(*@#%"
            };

            string symbols = ")!@#$%^&*(";

            var key = symbols
                .Select((c, i) => new { Char = c, Number = (i + 1).ToString()[0] })
                .ToDictionary(item => item.Char, item => item.Number);

            var nums = cryptedNums.Select(crypted =>
                string.Concat(crypted.Select(c => key.ContainsKey(c) ? key[c] : c))
            ).ToList();

            foreach (var num in nums)
            {
                Console.WriteLine($"Numbers: {num}");
            }

            Console.Read();
        }
    }
}
