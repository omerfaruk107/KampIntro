using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Price = 15;
            product1.Name = "Elma";
            product1.Description = "Amasya elması";

            Product product2 = new Product();
            product2.Price = 20;
            product2.Name = "Armut";
            product2.Description = "Bal gibi armut";

            Product[] products = new Product[] {product1,product2};

            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Description);
                Console.WriteLine("--------------------");
            }

            Console.WriteLine("-----------Methods--------------\n");

            //insttance

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);
            




        }
    }
}

//Don't repeat yourself... -DRY- Clean Code - Best Practice
