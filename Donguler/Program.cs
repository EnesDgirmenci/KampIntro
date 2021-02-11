using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";
            string kurs4 = "python";
            string kurs5 = "angular";
            string kurs6 = "C++";

            //array - dizi
            //buraya veritabanındaki kursları da çektirebilirsin
            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme kampı",
                                              "Programlamaya başlangıç için temel kurs",
                                              "Java",
                                              "python",
                                              "angular",
                                              "C#" };

            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa sonu - footer");
        }
    }
}
