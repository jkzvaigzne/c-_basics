using System;
using System.Collections.Generic;

namespace PhoneBook
{
    public class PhoneDirectory
    {
        private SortedDictionary<string, string> _data;

        public PhoneDirectory()
        {
            _data = new SortedDictionary<string, string>();
        }

        public string GetNumber(string name) => _data.TryGetValue(name, out string number) ? number : string.Empty;


        public void PutNumber(string name, string number)
        {
            if (name == null || number == null)
            {
                throw new Exception("name and number cannot be null");
            }

            _data[name] = number;
        }
    }
}