using System;

namespace KodlamaioKampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;

            if (sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("Hoş Geldin Ahmet");
            }
            else
            {
                Console.WriteLine("Lütfen Giriş Yap");
            }

            Console.WriteLine(kategoriEtiketi);
        }
    }
}
