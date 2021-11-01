using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] kurslar = new string[] { "java", "c#", "Javascript" };
            
            

            
                for (int i = 0; i < kurslar.Length; i++)
                {
                Console.WriteLine(kurslar[i]);
                }

            Console.WriteLine("\nfor bittiii\n");


            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
