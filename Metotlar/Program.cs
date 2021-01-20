using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Do not repeat yourself - DRY

            Product product1 = new Product();
            product1.Adi = "Elma";
            product1.Fiyati = 15;
            product1.Aciklama = "Amasya elması";

            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Fiyati = 80;
            product2.Aciklama = "Diyarbakır karpuzu";

            Product[] products = new Product[] {product1, product2 };

            // type-safe -- tip güvenli java ve csharp
            
            foreach  (Product product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("----------------");
            }

            Console.WriteLine("--------Metodlar--------");
            
            //instance - örnek
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12, 10);
            sepetManager.Ekle2("elma", "Yeşil elma", 8, 9);
            sepetManager.Ekle2("karpuz", "Diyarbakır karpuzu", 80, 8);


        }
    }
}
