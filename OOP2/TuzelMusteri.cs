using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //COORPORATE
    //miras-inheritance-asıl olayı müşteri de olan her özellik artık tüzelde de gerçkete de vardır.
    class TuzelMusteri:Musteri
    {

        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }

    }
}
