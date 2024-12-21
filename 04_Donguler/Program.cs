using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            int tercih = 0;
            Console.WriteLine("---------------------------------");
            Console.WriteLine("For Döngüsü ile 1-100 arası çift sayılar");
            Console.WriteLine("While Dongusu");
            Console.WriteLine("Asal Sayı Bulma");
            Console.WriteLine("BasamakToplama");
            Console.WriteLine("---------------------------------");
            tercih = Convert.ToInt32(Console.ReadLine());

            switch (tercih)
            {
                case 1:
                    ForDongusu();
                    break;
                case 2:
                    AsalSayıYazdırma();
                    break;
                case 3:
                    WhileDongusu();
                    break;
                case 4:
                    BasamakToplama();
                    break;

                default:
                    Console.WriteLine("Hatalı Sayı Girildi.");
                    break;
            }

            Console.ReadLine();
        }

        public static void ForDongusu()
        {
            int i;
            //Çift Sayıları Ekrana Yazdırma.
            for (i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
        public static void AsalSayıYazdırma()
        {
            for (int number = 2; number <= 100; number++)
            {
                bool isPrime = true;

                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Console.Write(number + " ");
                }
            }
        }
        public static void WhileDongusu()
        {
            int i = 1;
            while (i <= 10)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                    i++;
                }
            }
        }
        public static void BasamakToplama()
        {
            int sayi, total = 0, i, figure;
            Console.Write("Lütfen 3 basamaklı sayı giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < 3; i++)
            {
                figure = sayi % 10;
                sayi = sayi - figure;
                sayi = sayi / 10;
                total += figure;
            }
            Console.WriteLine("Toplam: " + total);
        }
    }
}
