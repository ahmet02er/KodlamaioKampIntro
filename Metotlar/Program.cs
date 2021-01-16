using System;

namespace Metotlar
{
    class Program
    {
       
        static void Main(string[] args)
        {

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 30;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = { urun1, urun2};

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-------------");
            }

            Console.WriteLine("-------------Metot1-------------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            Console.WriteLine("-------------Metot2-------------------");
            sepetManager.Ekle2("Armut", "Deveci Armut", 12.5, 50);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 10, 20);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 15, 150);
        }
    }
}
