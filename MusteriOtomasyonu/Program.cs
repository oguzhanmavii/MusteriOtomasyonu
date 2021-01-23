using System;
using System.Collections.Generic;

namespace MusteriOtomasyonu
{
    class Program
    {
        static void Main(string[] args)
        {

            IKrediManager ihtiyacKredisiManager = new İhtiyacKredisiManager();

            IKrediManager tasitKredisiManager = new TasitKredisiManager();

            IKrediManager konutKredisiManager = new KonutKredisiManager();

            List<ILoggerServices> loggers = new List<ILoggerServices> {new DatabaseLogServices(), new FileLogServices(),new SmsLogServices()};


            BaglantıManager baglantı = new BaglantıManager();

            baglantı.Ekle(ihtiyacKredisiManager, loggers);

        }
    }
}
