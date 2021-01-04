using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sayi_tahmin_odev
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********************Sayi Tahmin Oyununa Hoşgeldiniz*********************");
            Console.WriteLine("Zorluk Seviyesini Seçiniz");
            Console.WriteLine("1-Kolay Seviye için 1'e basınız(1-10 aralığı):");
            Console.WriteLine("2-Orta Seviye için 2'ye basınız(1-25 aralığı):");
            Console.WriteLine("3-Zor Seviye için 3'e basınız(1-50 aralığı):");
            int zorluk;
            while (true)
            {
                zorluk = int.Parse(Console.ReadLine());
                if (zorluk == 1 || zorluk == 2 || zorluk == 3)
                {
                    break;

                }

                else
                {
                    Console.WriteLine("Yanlış Bir seçim yaptınız tekrar deneyiniz.");
                }

            }
            int haksayisi;
            int sayitahmin;
            Random rnd = new Random();
            if (zorluk == 1)
            {
                sayitahmin = rnd.Next(10);
                haksayisi = 3;
            }
            else if (zorluk == 2)
            {
                sayitahmin = rnd.Next(25);
                haksayisi = 5;
            }
            else
            {
                sayitahmin = rnd.Next(50);
                haksayisi = 7;

            }

            for (int i = 1; i <= haksayisi; i++)
            {
                Console.WriteLine("Tahmin ettiniz sayı:");

                int girilensayi = int.Parse(Console.ReadLine());

                if (sayitahmin == girilensayi)
                {
                    Console.WriteLine("Tebrikler Doğru Tahmin Ettiniz Girilen Sayı =" + sayitahmin);
                    break;
                }
                else
                {


                    Console.WriteLine("Yanlış Tahmin Ettiniz Tekrar Deneyiniz");
                    Console.WriteLine("Kalan Tahmin Hakkınız:" + (haksayisi - i));
                    Console.WriteLine("****************************************");
                }
                if (i == haksayisi)
                {
                    Console.WriteLine("Kazanamadınız... Tutulan Sayı=" + sayitahmin);

                }
            }


            Console.ReadLine();
        }
    }
    
}
