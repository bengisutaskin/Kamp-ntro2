using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    { //interfacelerde o interface'i implement eden classın referans numarasını tutabilir
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
           
            IKrediManager tasitKrediManager = new TasitKrediManager();
           
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileoggerService = new FileLoggerService();



            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager,databaseLoggerService);
            //istediğin krediyi yazabilirsin



            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager};

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
