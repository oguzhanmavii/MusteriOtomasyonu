using System;
using System.Collections.Generic;
using System.Text;

namespace MusteriOtomasyonu
{
    class SmsLogServices:ILoggerServices
    {
        public void Log()
        {
            Console.WriteLine("Sms Başarılı Bir Şekilde Yollandı..");
        }
    }
}
