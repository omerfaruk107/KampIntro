using System;
using System.Collections.Generic;
using System.Text;

namespace Math
{
    class DortIslem
    {
        public void Topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam = "+ toplam);
        }

        public void Cıkar(int sayi1, int sayi2)
        {
            int sonuc = sayi1 - sayi2;
            Console.WriteLine("Sonuç = "+sonuc);
        }
    }
}
