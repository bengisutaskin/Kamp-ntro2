using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle (Musteri musteri)
        {
            Console.WriteLine( "Yeni Müşteri Eklendi : " + musteri.Adi + "  " + musteri.Soyadi + "Müşteri No : " + musteri.MusteriNo );

        }

        public void Silme ( Musteri musteri)
        {
            Console.WriteLine(" Müşteri Silindi : "+ musteri.Adi+ "  "+ musteri.Soyadi+"/n"+ "Müşteri No : "+ musteri.MusteriNo);
        }

        public void Liste (Musteri musteri)
        {
            Console.WriteLine("Müşteri Listesi : "+ "/n"+ "Müşteri Adı Soyadı : " + musteri.Adi+ "  " + musteri.Soyadi + "  " +"/n"
                + "Müşteri No : "+musteri.MusteriNo);
        }
    }
}
