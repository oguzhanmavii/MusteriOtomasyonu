using System;
using System.Collections.Generic;
using System.Text;

namespace MusteriOtomasyonu
{
    class DatabaseLogServices:ILoggerServices
    {
        public void Log()
        {
            Console.WriteLine("Veritabanı Başarılı Bir Şekilde Loglandı..");
        }
    }
}
