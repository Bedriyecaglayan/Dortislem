using System;
using System.Collections.Generic;
using System.Text;

namespace Dortislem
{
    class Matematik
    {
        public void Topla (int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("toplam : " + toplam);
        }
        public void Cikarma (int sayi1, int sayi2)
        {
            int sonuc = sayi1 - sayi2;
            Console.WriteLine("sonuç : " + sonuc);
        }

        public void Bolme (int sayi1, int sayi2)
        {
            int sonuc = sayi1 / sayi2;
            Console.WriteLine("sonuc : " + sonuc);
        }
        
        public void Carpma (int sayi1, int sayi2)
        {
            int sonuc = sayi1 * sayi2;
            Console.WriteLine(" sonuc : " + sonuc);
        }
    }
}
