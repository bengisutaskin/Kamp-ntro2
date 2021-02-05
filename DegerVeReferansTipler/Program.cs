using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 ?? 30

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] =999;
            //sayilar1[0]?? 999

            //sonuçlarının farklı olmasının nedeni değer ve referans tipleridir.
            //bellekte steck ve heap diye iki alan vardır. int sayi dediğinde değer tip olanlar steckte gerçekleşir.(sayi1=10, sayi2=20)Sayi1'in değeri=10 diye okuruz.
            //sayi1=sayi2 dediğimizde artik sayi1'e tanımladığımız değeri unutur.Sonradan tanimladığımız sayi2 değerinin sayi1'le ilgisi olmadığı için onu okumaz.
            //steckte sayilar1 tanımladık . new dediğimizde heapte bir alan oluşur. heap bir adres değeri tutar.
            //steckte sayilar2 tanımladık.Onu newleyince hapte bir alan oluşur.New heapte bellekten bir adres oluştur demek.
            //sayilar1=sayilar2 şöyle okunur: sayilar1'in referans numarası sayılar2'nin referans numarasına eşittir.sayilar[0] 999 old. için sayilar1[0] da 999 diye okunur.


        }
    }
}
