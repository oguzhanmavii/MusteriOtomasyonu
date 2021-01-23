using System;
using System.Collections.Generic;
using System.Text;

namespace MusteriOtomasyonu
{
    class FileLogServices:ILoggerServices
    {
        public void Log()
        {
            Console.WriteLine("Dosya Başarılı Bir Şekilde Loglandı..");
        }
    }
}
