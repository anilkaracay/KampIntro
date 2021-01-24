using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyatıi = 15;
            string aciklama = "Amasya Elması";

           Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Acıklama = "Amasya Elması";

            Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Acıklama = "Diyarbakır Karpuzu";

           
            

            Product[] urunler = new Product[] {urun1, urun2 };

            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Acıklama);
                Console.WriteLine("******");

            }

            Console.WriteLine("------------Metotlar---------------");
            //instance
            //encapsluation

            SepetManager sepetmanager = new SepetManager();
            sepetmanager.Ekle(urun1);
            sepetmanager.Ekle(urun2);
            



        }
    }
}
