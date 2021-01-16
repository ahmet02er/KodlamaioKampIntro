using System;

namespace DegerveReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
           // int, decimal, float, double, bool= Değertip
           // array, class, interface = Referans


            Console.WriteLine("Ahmet ÖZER");
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 kaç olur?
            Console.WriteLine(sayi1);

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar2 kaç olur?
            Console.WriteLine(sayilar2[0]);
        }
    }
}
