using System;

namespace Classİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Bengisu";
            int yas = 20;

            kurs kurs1 = new kurs();
            kurs1.KursAdi = "C#";
            kurs1.KursunEgitmeni = "Bengisu Taşkın";
            kurs1.İzlenmeOrani = 98;

            kurs kurs2 = new kurs();
            kurs2.KursAdi = "Java";
            kurs2.KursunEgitmeni = "Kerem";
            kurs2.İzlenmeOrani = 64;

            kurs kurs3 = new kurs();
            kurs3.KursAdi = "Python";
            kurs3.KursunEgitmeni = "Berkay";
            kurs3.İzlenmeOrani = 80;

            kurs kurs4 = new kurs();
            kurs4.KursAdi = "C++";
            kurs4.KursunEgitmeni = "Ayşe";
            kurs4.İzlenmeOrani = 100;
            //Console.WriteLine(kurs1.KursAdi+" : " + kurs1.KursunEgitmeni);

            kurs[] kurslar = new kurs[] { kurs1, kurs2, kurs3, kurs4 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.KursunEgitmeni+" : "+kurs.İzlenmeOrani);
            }

            


             
        }
    }

    class kurs
    {
        public string KursAdi { get; set; }
        public  string   KursunEgitmeni{ get; set; }
        public int İzlenmeOrani { get; set; }
    }

   








}
