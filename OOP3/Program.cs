using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseloggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();
            
           // List<ILoggerService> loggers = new List<ILoggerService>() {new FileLoggerService(), new SmsLoggerService()};

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKrediManager(), new List<ILoggerService>{ new DatabaseLoggerService(), new SmsLoggerService()});

            // 18-21. satırdaki kod bloklarının ikisi de aynı görevi görüyor

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager };

            //basvuruManager.KrediOnBilgilendirmesi(krediler);
        }
    }
}
