using System;

namespace Kampİntro2
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 320000;
            double faizOrani = 1.45;
            bool sistemeGirisYamisMi = false;
            double dolarınDun = 7.35;
            double dolarBugun = 7.45;
            if (dolarınDun > dolarBugun)
            {
                Console.WriteLine("Azalış butonu");

            }
            else if (dolarınDun < dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }
            if (sistemeGirisYamisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine(" Giriş yap butonu");
            }
            Console.WriteLine(kategoriEtiketi);


        }
    }
}
