using System;

namespace Dortislem
{
    class Program
    {
        static void Main(string[] args)
        {
            Matematik matematik = new Matematik();
            matematik.Topla(10, 20);
            matematik.Cikarma(5, 3);
            matematik.Bolme(200, 5);
            matematik.Carpma(9, 7);
        }
    }
}
