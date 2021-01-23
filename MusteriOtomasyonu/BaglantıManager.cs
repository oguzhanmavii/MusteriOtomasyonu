using System;
using System.Collections.Generic;
using System.Text;

namespace MusteriOtomasyonu
{
    class BaglantıManager
    {
        public void Ekle(IKrediManager krediManager,List<ILoggerServices> loggerServices)
        {

            krediManager.Hesapla();

            foreach (var loggers in loggerServices)
            {
                loggers.Log();

            }


        }
    }
}
