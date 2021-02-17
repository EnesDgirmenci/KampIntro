using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {//interfaceler de o interface i implemente eden clasın referans numarasını tutabilir.
         //Kredi türü oluşturma
         //kredi türleri için yeni instance oluşturma
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();


            //log kaydı oluşturma
            //log kaydı oluşturma yöntemleri için yeni instance oluşturma
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();




            //tüm bu kodlar yazıldıktan sonra sisteme yeni bir kredi türü ve
            //yeni bir loglama yöntemi oluşturulduğu zaman bu yeni oluşumların
            //kodlarının varolan kodlara zarar verip vermediğini öğrenmek için
            //ikisinden de 1 er tane oluşturduk
            IKrediManager esnafKredisiManager = new EsnafKedisiManager();
            ILoggerService smsLoggerService = new SmsLoggerService();




            //burada IKrediManagerdan konutKrediManager a ait olan referans numarasını yolladığımız için
            //konutKrediManager ın Hesapla aracı çalışıyor
            //--------------------------------------------------
            //database üzerine kaydı databaseLoggerService yazarak injection yaptık
            //dosya üzerine kaydı da fileLoggerService yazarak injection yapabiliriz
            //---------------------------------------------------
            //birden fazla log yöntemi tercih edeceğimiz zaman da başvuru manager da oluşturduğumuz
            //foreach döngüsüne burdan belirlediğimiz logger yöntemlerini yolluyoruz
            //---------------------------------------------------
            // ayrıca new List<ILoggerService> {new DatabaseLoggerService(), new SmsLoggerService()} yöntemi yerine
            //List<ILoggerService>logers=new List<ILoggerService> { new SmsLoggerService, new FileLoggerService}
            //yöntemini kullanırsak kodlardaki karmaşayı da azaltırız
            
            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(esnafKredisiManager, new List<ILoggerService> {new DatabaseLoggerService(), new SmsLoggerService()});





            //IKrediManager ismindeki bir liste oluşturup BaşvuruManager projesinden bu listeyi çağırttık
            //ihtiyacKrediManager a ait olan referans numarasını BasvuruManager classındaki 
            //foreach döngüsündeki hesaplama aracına yolladık
            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager };


            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
