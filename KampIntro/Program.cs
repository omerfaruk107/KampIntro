using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety 
            string kategoriEtiketi = "Kategori";
            int krediMiktari = 3400;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.45;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Artış Oku");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Azalış Oku");
            }
            else
            {
                Console.WriteLine("Değişim yok oku");
            }

            if (sistemeGirisYapmisMi == false)
            {
                Console.WriteLine("Kayıt Ol Butonunu Göster");
            }
            else
            {
                Console.WriteLine("Hoşgeldiniz");
            }
                

            Console.WriteLine(kategoriEtiketi);

        }
    }
}
