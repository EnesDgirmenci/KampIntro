using System;

namespace OOP3
{
    class FileLoggerService : ILoggerService
    {//log kaydının bir dosyaya yaptığı kaydın simülasyonu
        public void Log()
        {
            Console.WriteLine("loglama işlemi Dosya üzerine yazma şeklinde başarılı bir şekilde tamamlandı");
        }
    }
}
