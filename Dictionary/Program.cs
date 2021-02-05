using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> plaka = new Dictionary<int, string>();
            plaka.Add(78, "Karabük");
            plaka.Add(34, "İstanbul");
            plaka.Add(55, "Samsun");
            plaka.Add(67, "Zonguldak");
            plaka.Add(01, "Adana");

            foreach (var item in plaka)
            {
                Console.WriteLine(item);
            }

        }
    }
}
