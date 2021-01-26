using System;

namespace MyDictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> myDictionary = new MyDictionary<string, string>();
            myDictionary.Add("Car", "Araba");
            myDictionary.Add("Book", "Kitap");
            myDictionary.Add("Computer", "Bilgisayar");
            myDictionary.Add("Kalem", "Pen");
            myDictionary.List();
        }
    }
}
