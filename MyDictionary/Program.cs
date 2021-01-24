using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int> liste = new MyDictionary<int>();
            liste.Add(16);
            liste.Add(15);
            liste.Add(14);
            liste.Add(13);
            liste.Add(12);
            liste.Add(11);
            Console.WriteLine(liste[0]);
            Console.WriteLine(liste.Length);

        }
    }
}
