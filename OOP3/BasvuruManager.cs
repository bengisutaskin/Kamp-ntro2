using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {   //Method injection
        public void BasvuruYap(IKrediManager krediManager,List<ILoggerService> loggerService)
        {
            //başvuran bilgilerini değerlendirme
            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();
            //bunu böyle yaparsam (BasvuruYapın içine IKrediManager krediManager yazmadan)tüm başvurular konut kredisi üstünden hesaplanır

            krediManager.Hesapla();
            //şu an buraya hangi krediyi gönderirsem o çalışır
           
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }

        internal void BasvuruYap(IKrediManager konutKrediManager, ILoggerService databaseLoggerService)
        {
            throw new NotImplementedException();
        }
    }
}
