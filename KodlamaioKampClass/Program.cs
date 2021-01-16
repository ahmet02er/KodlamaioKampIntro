using System;

namespace KodlamaioKampClass
{
    class Program
    {
        static void Main(string[] args)
        {
            urunler urun1 = new urunler();
            urun1.urunAd = "Masaüstü Bilgisayar";
            urun1.urunFiyat = 3500;
            urun1.urunResmi = "1. Ürün Resmi";

            urunler urun2 = new urunler();
            urun2.urunAd = "Dizüstü Bilgisayar";
            urun2.urunFiyat = 6500;
            urun2.urunResmi = "2. Ürün Resmi";

            urunler urun3 = new urunler();
            urun3.urunAd = "Tablet";
            urun3.urunFiyat = 1500;
            urun3.urunResmi = "3. Ürün Resmi";

            urunler[] urunListe = { urun1, urun2, urun3 };

            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
            Console.WriteLine("------------------------------------");

            for (int i = 0; i < urunListe.Length; i++)
            {
                Console.WriteLine("Ürün : " + urunListe[i].urunAd + " " + "Fiyatı : " + urunListe[i].urunFiyat + " " + urunListe[i].urunResmi);
            }

            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
            Console.WriteLine("------------------------------------");

            foreach (urunler liste in urunListe)
            {
                Console.WriteLine("Ürün : " + liste.urunAd + " " + "Fiyatı: " + liste.urunFiyat + " " + liste.urunResmi);
            }

            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
            Console.WriteLine("------------------------------------");

            int x = 0;
            while (x < urunListe.Length)
            {
                Console.WriteLine("Ürün : " + urunListe[x].urunAd + " " + "Fiyatı: " + urunListe[x].urunFiyat + " " + urunListe[x].urunResmi);
                x++;
            }

            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
            Console.WriteLine("------------------------------------");
        }
        class urunler
        {
            public string urunAd { get; set; }
            public string urunResmi { get; set; }
            public int urunFiyat { get; set; }
        }
    }
}
