using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] { "ömer","onur","ali osman" };

            foreach (var x in isimler)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("-------------------------------\n");

            List<string> isimler2 = new List<string> {"ömer", "onur","kerem","ali osman" };

            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
        }
    }
}
