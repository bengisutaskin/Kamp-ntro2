using System;

namespace OOP2
{
    class Program
    {

        //şirket adı burada benle alakalı değil.Ben bir şahısım.Bu bir hatadır.
        //Zamanla şirket adı olan bireysel müşteriler zamanla da TC NO su olan tüzel müşterilerle
        //Zamanla adı soyadı olan tüzel müşterilerle karşılaşılır.Bu bir yazılım hatasıdır.

        //Gerçek Müşteri-Tüzel Müşteri. İkisi müşteri ama farklı tip müşteridir.O yüzden birbirinin yerine kullanılamazlar.
        //SOLİD bu teknik solidin L harfidir.
        //Bu sorun için gerçekmüşteri ve tüzel müşteri olarak 2 class oluşturmamız lazım.
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Bengisu";
            musteri1.Soyadi = "TAŞKIN";
            musteri1.TcNo = "12345678910";

            //kodlama.io

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();
            //Bir yerde new görürsen "referans no" olarak anla.

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

        }
    }
}
