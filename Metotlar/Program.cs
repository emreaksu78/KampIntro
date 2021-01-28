using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyati = 10;
            urun1.Aciklama = "Amasya Elması";

            Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 20;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Product[] urunler = new Product[] {urun1, urun2 };  // Bu tarz yazınca ürün bilgilerini her ürün için sayfada yazdırıyor.                                                           Hepsiburada ana sayfası gibi tek tek gösteriyor.

            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("------------------------------");
                Console.WriteLine("Tebrikler. Sepete eklendi : " + urun.Aciklama);

            }

            Console.WriteLine("----------Metotlar------------");


            SepetManager sepetManager = new SepetManager();         //Bu tarzda her ürün için ayrıca, yapılan işlemi yazdırıyor.Ürün1 i                                                         sepete eklediğimizde ürün1 içi "ekle" komutu çalışıyor.
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            


        }
    }
}
