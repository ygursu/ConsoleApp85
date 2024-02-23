using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace klavydentabanyukseklikgirilenparelelkenaralani
{
    class Program
    {
        static void Main(string[] args)
        {
      

            int taban, yukseklik, alan;

            Console.WriteLine("Lütfen paralelkenarın tabanını giriniz");
            taban = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen paralelkenarın yüksekliğini giriniz");
            yukseklik = Int32.Parse(Console.ReadLine());

            alan = taban * yukseklik;

            Console.WriteLine("Paralel kenarın alanı:" + alan);
            Console.ReadLine();


        }
    }
}
