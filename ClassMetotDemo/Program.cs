using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Bengisu";
            musteri1.Soyadi = "Taşkın";
            musteri1.MusteriNo = 159632;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Mustafa";
            musteri2.Soyadi = "Taşkın";
            musteri2.MusteriNo = 147852;

            Musteri musteri3  = new Musteri();
            musteri3.Adi = "Fatma Nur";
            musteri3.Soyadi = "Taşkın";
            musteri3.MusteriNo = 125896;


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            foreach (Musteri  musteri in musteriler)
            {
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Soyadi);
                Console.WriteLine(musteri.MusteriNo);
                Console.WriteLine("--------------------");


            }
            Console.WriteLine();
            Console.WriteLine("Müşteri Ekleme");
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            Console.WriteLine("MÜŞTERİ EKLENDİ");

            Console.WriteLine();
            Console.WriteLine("Müşteri Silme");
            MusteriManager musteriManager1 = new MusteriManager();
            musteriManager.Silme(musteri3);
            Console.WriteLine("MÜŞTERİ SİLİNDİ");



              
            
        }
    }
}
