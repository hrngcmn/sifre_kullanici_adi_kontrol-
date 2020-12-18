using System;
using System.Data;
namespace uygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad, sifre;
            string ka, pas;
            int i, a;
            i = 0;
            a = 0;
            ad = "harun";
            sifre = "abc123";
            while (i < 1)
            {
                Console.WriteLine("..... Kullanıcı adınız yazınız .....");
                ka = Console.ReadLine();
                if (ka == ad)
                {
                    Console.WriteLine("..... Doğru kullanıcı adı girişi yaptınız .....");
                    i = 2;
                }
                if (ka != ad)
                {
                    Console.WriteLine("..... Böyle bir kullanıcı adı yok tekrar deneyiniz .....");
                    i = 0;
                }
            }
            while (a < 3)
            {
                Console.WriteLine("..... Şifrenizi giriniz .....");
                pas = Console.ReadLine();
                if (sifre == pas)
                {
                    Console.WriteLine(".... Doğru sifre girisi yaptınız .....");
                    a = 4;
                }
                if (sifre != pas)
                {
                    Console.WriteLine("..... Yanlış giriş yaptınız .....");
                    a++;
                }
                if (a == 1)
                {
                    Console.WriteLine("..... 2 hakkın var .....");
                }
                if (a == 2)
                {
                    Console.WriteLine("..... SON DENEME HAKKINIZ .....");
                }
            }
        }
    }
}
