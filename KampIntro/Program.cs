using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety 
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double DolarDun = 7.45;
            double DolarBugun = 7.45;

            if (DolarDun>DolarBugun)
            {
                Console.WriteLine("Azalış butonu");

            }
            else if (DolarDun<DolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butoun");

            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            
        }

    }
}
