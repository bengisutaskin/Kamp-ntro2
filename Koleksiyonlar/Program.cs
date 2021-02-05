using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"Bengisu","Engin","Nursu","Kerem" };

            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5];
            //isimler[4] = "İlker";

            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);
            //Yeni bir new dedikten sonra bellekte yeni elemanlar oluşur.Yani 5 eleman tanımladım ama sadece bir tanesi ilker gerisi boş alan çünkü tanımlamadım.[0]'ı boşluk olarak yazar.
            //Kısacası adres değişiyor.
            //list yazınca ampule bas ekle
            //ctrl+k ctrl+c metin yapar ctrl+k ctrl+u geri alır
            
            List<string> isimler2 = new List<string> { "Bnegisu", "Engin", "Nursu", "Kerem" };
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
