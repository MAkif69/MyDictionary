using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(100, "Matemtaik Soru Bankası");
            myDictionary.Add(101, "Tarih Soru Bankası");
            myDictionary.Add(102, "Coğrafya Soru Bankası");

            myDictionary.List();
        }
    }
}
