using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar1
{
    class SepetManager
    {
        //naming convention
        //syntax-yazım değişimi
        //ne ekleyeciğini söylemek istediğini metoda vermen lazım bu parametredir
        //(Urun urun) bir class ancak Ekle2(...)(içi) class değil
        public void Ekle(Urun urun)
        {
            Console.WriteLine(" Tebrikler,Sepete Eklendi : " + urun.Adi);

        }
        //böyle de yazılır ama çok hata verebilir böyle yazma
        public void Ekle2(string urunAdi, string aciklama, double fiyati, int stokAdedi)
        {
            Console.WriteLine("Tebrikler Sepete Eklendi : " + urunAdi);
        }
    }
}
