﻿//System.Collections namespace

using System.Collections;

ArrayList list = new ArrayList();
//list.Add("Ayse");
//list.Add(2);
//list.Add(true);
//list.Add('A');


//içerisindeki verilere erişim
//Console.WriteLine(list[1]);
//foreach (var item in list)
//{
//    Console.WriteLine(item);
//}

//AddRange
Console.WriteLine("****** Add Range ******");
//string[] renkler = {"kırmızı","sarı","yesil"};
List<int> sayilar = new List<int>(){1,8,3,7,9,92,5};
//list.AddRange(renkler);
list.AddRange(sayilar);

foreach (var item in list)
{
    Console.WriteLine(item);
}

//sort
Console.WriteLine("***** Sort ***** ");
list.Sort();

foreach (var item in list)
{
    Console.WriteLine(item);
}
 //Binary Search
 Console.WriteLine("****** Binary Search *****");
 Console.WriteLine(list.BinarySearch(9));

 // Reverse
 Console.WriteLine("***** Reverse *****");
 list.Reverse();
 foreach (var item in list)
 {
     Console.WriteLine(item);
 }

 //Clear
 Console.WriteLine("***** Clear *****");
 list.Clear();

 foreach (var item in list)
 {
    Console.WriteLine(item);
 }