using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading;

namespace ListBoxApplication1
{
    class Program
    {
         static void Main(string[] args)
        {
            Console.Write("Kaç Kişi Kayıt Edeceksiniz: ");
            int dng = Convert.ToInt32(Console.ReadLine());



            string[] sifre = new string[dng];
            string[] isim = new string[dng];
            for (int i = 0; i < sifre.Length; i++)
            {
            a1:
                Console.Clear();
                Console.Write("'Kayıt İçin' Kullanıcı Adı Giriniz: ");
                isim[i] = Console.ReadLine();
                Console.Write("'Kayıt İçin' Şifre Giriniz: ");
                sifre[i] = Console.ReadLine();
                if (isim[i] == sifre[i])
                {
                    
                    Console.Write("Şifre Ve Kullanıcı Adı Aynı Olamaz!");
                    isim[i] = "";
                    sifre[i] = "";
                    Thread.Sleep(2000);
                    goto a1;
                }
                Thread.Sleep(1500);
            }
            Console.Clear();
            
            int hak = 0;
            for (int i = 0; i < isim.Length; i++)
            {
            a3:
                Console.Write("'Giriş İçin' Kullanıcı Adı Giriniz: ");
                string login_username = Console.ReadLine();
                Console.Write("'Giriş İçin' Şifre Giriniz: ");
                string login_pass = Console.ReadLine();
            
                if (login_username == isim[i] && login_pass == sifre[i])
                {
                    Console.WriteLine("Tebrikler Hoşgeldiniz.");
                    break;
                    Console.WriteLine("Selam");
                    
                }
                else
                {
                    Console.WriteLine("Yanlış Şifre Veya Kullanıcı Adı !");
                    hak++;
             goto a3;
                }

            }
            Console.Clear();
            














                Console.ReadKey();
            }

        }
    }


