using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyackredimanager = new IhtiyacKrediManager();
            IKrediManager taşıtKrediManager = new TaşıtKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService fileLogerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager, new DatabaseLoggerService());
            
            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyackredimanager , taşıtKrediManager };
           // basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
