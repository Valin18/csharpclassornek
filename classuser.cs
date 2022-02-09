using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp2
{
    internal class Program
    {
        class user
        {
            public string username;
            public string password;


          public  void GirisBilgileriYazdır()
            {
                Console.WriteLine("Merhaba, {0}", username);
                Console.WriteLine("Hesap Şifresi: {0}", password);
            }


            public user(string  username,string password) {
            
                
                 void GirisBilgileriYazdır()
                {
                    Console.WriteLine("Merhaba, {0}", username);
                    Console.WriteLine("Hesap Şifresi: {0}",password);
                }
            
            
            }
           public void KayıtBilgisiYazdır()
            {
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("Hesabınız Başarıyla Oluşturuldu.");
                Console.WriteLine("---------------------------------------------");
                Thread.Sleep(1000);
                Console.WriteLine("Hesap Kullanıcı Adı: {0}", username);
                Console.WriteLine("Giriş İçin Kullanılacak Hesap Şifresi: {0}", password);

            }
            public user(string username, string password, string r_password) { 
            
                void KayıtBilgisiYazdır()
                {
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("       Hesabınız Başarıyla Oluşturuldu.");
                    Console.WriteLine("---------------------------------------------");
                    Thread.Sleep(1000);
                    Console.WriteLine("Hesap Kullanıcı Adı: {0}", username);
                    Console.WriteLine("Giriş İçin Kullanılacak Hesap Şifresi: {0}", password);

                }
            
            
            
            
            }








        }
        static void Main(string[] args)
        {
            Console.WriteLine("Eğer Bir Hesabınız Varsa '1' Eğer Bir Hesabınız Yoksa '2'yi Tuşlayınız");
            int secim = Convert.ToInt32(Console.ReadLine());
            if (secim == 1)
            {
                Console.Clear();
                Console.WriteLine("Programa Hoşgeldiniz.");
                Thread.Sleep(1000);
                Console.WriteLine("--------------------------------------");
                Thread.Sleep(500);
                Console.Write("Kullanıcı Adınızı Giriniz: ");
                string isim = Console.ReadLine();
                Console.Write("Şifrenizi Giriniz: ");
                string sifre = Console.ReadLine();
                Console.Clear();
                user kullanıcı = new user(isim, sifre);
                kullanıcı.username = isim;
                kullanıcı.password = sifre;
                kullanıcı.GirisBilgileriYazdır();
                Console.ReadKey();

            }
            else if (secim == 2)
            {
                Console.Clear();
                Console.WriteLine("Programa Hoşgeldiniz.");
                Thread.Sleep(1000);
                Console.WriteLine("--------------------------------------");
                Thread.Sleep(750);
                Console.Write("Kayıt Olmak İstediğiniz Kullanıcı Adını Yazınız: ");
                string isim = Console.ReadLine();
                Thread.Sleep(250);
                Console.Write("Şifre Giriniz: ");
                string sifre = Console.ReadLine();
                Thread.Sleep(250);
                Console.Write("Aynı Şifreyi Tekrar Giriniz: ");
                string t_sifre = Console.ReadLine();
                Thread.Sleep(750);
                    if (t_sifre == sifre)
                    {
                        user kullanıcı = new user(isim, sifre, t_sifre);
                        kullanıcı.username=isim;
                        kullanıcı.password=sifre;
                        kullanıcı.KayıtBilgisiYazdır();

                    }
                    else
                    {
                        Thread.Sleep(1000);
                        Console.WriteLine("--------------------------------------");
                        Console.WriteLine("Girilen Şifreler Aynı Değil.");
                        Console.ReadKey();
                    }

            }
            else
            {
                Console.WriteLine("Yanlış Rakam !");
                Console.ReadKey();
            }
        }
    }
}
