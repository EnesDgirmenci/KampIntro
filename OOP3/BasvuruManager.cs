using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {//IKrediMAnager diğer kredi türlerinin de referans numarasını tuttuğu için 
     //yani gönderdiğimiz referans numarasına ait olan hesaplayı çalıştıracak
     //(ILoggerService loggerService) metod injection yaptık
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices)
        {//Başvuran bilgilerini değerlendirme
            krediManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
