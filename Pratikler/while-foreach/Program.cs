﻿using System;

namespace while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //while
            //1 den başlayarak console dan girilen sayıya kadar sayı dahil ortalama hesaplayp konsola yazdıran program
            Console.WriteLine("Lütfen bir sayı giriniz : ");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while(sayac<=sayi)
            {
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine("Ortalamanız : "+toplam/sayi);
            //a-z tüm harfleri consola yazdırma
            char character = 'a';
            while (character<'z')
            {
                Console.Write(character);
                character++;
            }
            Console.WriteLine("*****************************");
            string[] arabalar = { "BMW", "FORD", "TOYOTA", "NISSAN" };
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}