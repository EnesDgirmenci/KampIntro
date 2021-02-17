using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class EsnafKedisiManager : IKrediManager
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Esnaf kredisi ödeme planı hesaplama aracı çalıştı");
        }
    }
}
