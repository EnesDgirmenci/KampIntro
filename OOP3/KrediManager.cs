using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{//İnterface ler genelde operasyonlarda kullanılır, şablon ve referans tutucu olarak kullanılır
 //Birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız 
    interface IKrediManager
    {
        public void Hesapla();
        void BiseyYap();
    }
}
