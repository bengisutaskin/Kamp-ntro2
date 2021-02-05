using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class Urun
    {
        public int Id { get; set; }
        public string  Adi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }

        Urun urun1 = new Urun();
        urun1.Adi = "elma";
        urun1.Fiyati = 15;
        urun1.Aciklama = "Amasya elması";

    }
}
