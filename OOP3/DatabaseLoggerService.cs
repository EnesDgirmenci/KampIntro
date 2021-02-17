using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class DatabaseLoggerService : ILoggerService
    {//log kaydının veritabanına yaptığı kaydın simülasyonu
        public void Log()
        {
            Console.WriteLine("loglama işlemi Veritabanına yazma şeklinde başarılı bir şekilde tamamlandı");
        }
    }
}
