﻿using System;

namespace ArrayClassMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sort
            int[] sayilar = { 23, 12, 86, 72, 3, 11, 17 };
            Console.WriteLine("Sırasız Dizi");
            foreach (var sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }
            Console.WriteLine("Sıralı Dizi");
            Array.Sort(sayilar);
            foreach (var sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }
            //Clear : sayı dizisi elemanlarını kullanarak 2. indexten itibaren 2 tane elemanı 0 lar
            Console.WriteLine("Array Clear");
            Array.Clear(sayilar, 2,3);
            foreach (var sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }
            //Reverse : verdiğimiz diziyi tersine çevirir
            Console.WriteLine("Array Reverse");
            Array.Reverse(sayilar);
            foreach (var sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }
            //İndexOf Verdiğmiz elemanın indexsini döner..
            Console.WriteLine("Array İndexof");
           
            Console.WriteLine(Array.IndexOf(sayilar, 23));
            //Resize : yeniden boyutlandırma
            Console.WriteLine("Array Resize");
            Array.Resize<int>(ref sayilar, 9);
            sayilar[8] = 99;
            foreach (var sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }
            Console.ReadLine();
            
        }
    }
}