﻿// 1. Sorunun Çözümü
// Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

Console.Write("Girmek İstediğiniz Sayıyı Yazınız : ");
int sayiAdeti= Convert.ToInt32(Console.ReadLine());

int[] sayilar = new int[sayiAdeti];

for(int i = 0; i < sayiAdeti; i++)
{
    Console.WriteLine("Lütfen {0}. Sayısı Giriniz:",i+1);
    sayilar[i] = Convert.ToInt32(Console.ReadLine());
}

Console.Write("Girilen Çift Sayılar : ");
int ciftsayilar=0;


for(int i = 0; i<= sayiAdeti; i++)
{
    if (sayilar[i] % 2 == 0)
    {
        ciftsayilar++;
        Console.WriteLine(sayilar[i]+ " ");
    }
    
}  


// 2. Sorunun Çözümü
// Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.


Console.Write("Hangi Sayının Bölünmesini İstersiniz: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Kaç Adet Sayı Girmek İstersiniz: ");
int n = int.Parse(Console.ReadLine());
int[] sayiDizisi = new int[sayiAdeti];
for (int i=0; i<sayiAdeti; i++)
{
    Console.Write("Lütfen {0}. Sayısı Giriniz: ", i + 1);
    sayiDizisi[i] = int.Parse(Console.ReadLine());
}

Console.Write("Girmiş Olduğunuz Çift Sayılar: ");
int bolonebilenSayi = 0;
for (int i=0; i<sayiAdeti; i++)
{
    if (sayiDizisi[i] % m == 0 || sayiDizisi[i] == m)
    {
        bolonebilenSayi++;
        Console.Write(sayiDizisi[i] + " ");
    }
}


// 3. Sorunun Çözümü
// Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.


Console.Write("Kaç Adet Kelime Girmek İstersiniz ?");
int a = int.Parse(Console.ReadLine());
string[] kelimeDizisi = new string[a];
for (int i=0; i<a; i++)
{
     Console.Write("Lütfen {0}. Kelimeyi Giriniz: ", i + 1);
      sayiDizisi[i] = (Console.ReadLine());
}

Array.Reverse(kelimeDizisi);
Console.Write("Girmiş Olduğunuz Kelimeler: ");
for (int i=0; i<a; i++)
{
        Console.Write(kelimeDizisi[i] + " ");
    
}



// 4. Sorunun Çözümü
// Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

Console.Write("Bir Cümle Yazınız: ");
String bbb = Console.ReadLine();

int harf = bbb.Length;
string[] bos = bbb.Split(' ');
int bosluksuzharf = harf - (bos.Length - 1);
Console.WriteLine("Toplam Kelime: " + bos.Length + " Toplam Harf: " + bosluksuzharf);