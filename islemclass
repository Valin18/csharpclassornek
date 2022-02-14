using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        public static class islem
        {
            public const double pi = 3.14;
            public const double e = 2.718;

            public static double topla(double a, double b)
            {
                return a + b;
            }

            public static double cıkar(double a, double b)
            {
                return a - b;
            }

            public static double carp(double a, double b)
            {
                return a * b;
            }

            public static double bol(double a, double b)
            {
                return a / b;
            }
            public static double us_al(double a, double b)
            {
                return Math.Pow(a, b);
            }
            public static double faktoriyel_hesapla(double a)
            {
                double toplam = 0;
                double ilksayi = a;
                for (int j = 1; j <= a; j++)
                {
                   toplam *= j;
                    
                }
                return toplam;
            }
            public static double buyuk_sayi(double a, double  b)
            {
                if (a > b)
                    return a;
                else if (b > a)
                    return b;
                else
                    return a;
            }
            public static double kucuk_sayi(double a, double b)
            {
                if (a < b)
                    return a;
                else if (b < a)
                    return b;
                else
                    return a;
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Yapmak İstediğiniz İşlemi Seçin\n1-Toplama\n2-Çıkarma\n3-Çarpma\n4-Bölme\n5-Üs Al\n6-Faktöriyel Hesaplama\n7-Büyük Sayıyı Göster\n8-Küçük Sayıyı Göster");
            int secim = Convert.ToInt32(Console.ReadLine());
            if (secim == 1)  
            {
                Console.Clear();
                Console.WriteLine("Toplama İşlemi Yapan Program");
                Console.WriteLine("---------------------------");
                Console.Write("İlk Sayıyı Giriniz: ");
                double s1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("İkinci Sayıyı Giriniz: ");
                double s2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Sonuç: " + islem.topla(s1, s2));
            }
             if (secim == 2)  
            {
                Console.Clear();
                Console.WriteLine("Çıkarma İşlemi Yapan Program");
                Console.WriteLine("---------------------------");
                Console.Write("İlk Sayıyı Giriniz: ");
                double s1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("İkinci Sayıyı Giriniz: ");
                double s2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Sonuç: " + islem.cıkar(s1, s2));
            }
             if (secim == 3)  
            {
                Console.Clear();
                Console.WriteLine("Çarpma Yapan Program");
                Console.WriteLine("---------------------------");
                Console.Write("İlk Sayıyı Giriniz: ");
                double s1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("İkinci Sayıyı Giriniz: ");
                double s2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Sonuç: " + islem.carp(s1, s2));
            }
             if (secim == 4)  
            {
                Console.Clear();
                Console.WriteLine("Bölme Yapan Program");
                Console.WriteLine("---------------------------");
                Console.Write("İlk Sayıyı Giriniz: ");
                double s1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("İkinci Sayıyı Giriniz: ");
                double s2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Sonuç: " + islem.bol(s1, s2));
            }
             if (secim == 5)  
            {
                Console.Clear();
                Console.WriteLine("İşlem Üssü Alan Program");
                Console.WriteLine("---------------------------");
                Console.Write("Tabanı Giriniz: ");
                double s1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Üs Giriniz: ");
                double s2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("İşlemin Üs Sonucu: " + islem.us_al(s1, s2));
            }
             if (secim == 6)  
            {
                Console.Clear();
                Console.WriteLine("Faktöriyel Hesaplayan Program");
                Console.WriteLine("---------------------------");
                Console.Write("Faktöriyeli Alınacak Sayıyı Giriniz: ");
                double s1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Sayının Faktöriyeli: " + islem.faktoriyel_hesapla(s1));
            }
             if (secim == 7)  
            {
                Console.Clear();
                Console.WriteLine("Büyük Sayı Gösteren Program");
                Console.WriteLine("---------------------------");
                Console.Write("İlk Sayıyı Giriniz: ");
                double s1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("İkinci Sayıyı Giriniz: ");
                double s2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Büyük Sayı: " + islem.buyuk_sayi(s1, s2));
            }
             if (secim == 8)
             {
                 Console.Clear();
                 Console.WriteLine("Küçük Sayı Gösteren Program");
                 Console.WriteLine("---------------------------");
                 Console.Write("İlk Sayıyı Giriniz: ");
                 double s1 = Convert.ToDouble(Console.ReadLine());
                 Console.Write("İkinci Sayıyı Giriniz: ");
                 double s2 = Convert.ToDouble(Console.ReadLine());
                 Console.WriteLine("Küçük Sayı: " + islem.kucuk_sayi(s1, s2));
             }
             else
             {
                 Console.Clear();
                 Console.WriteLine("Yanlış Bir Sayı Tuşladınız !");
             }   
            Console.ReadKey();
        }
    }
}
