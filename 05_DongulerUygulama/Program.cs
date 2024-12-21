using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_DongulerUygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            int tercih = 0;
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Dik Üçgen");
            Console.WriteLine("Baklava Dilimi");
            Console.WriteLine("Piramit");
            Console.WriteLine("Ters Piramit");
            Console.WriteLine("---------------------------------");
            tercih = Convert.ToInt32(Console.ReadLine());

            switch (tercih)
            {
                case 1:
                    DikUcgen();
                    break;
                case 2:
                    BaklavaDilimi();
                    break;
                case 3:
                    Piramit();
                    break;
                case 4:
                    TersPiramit();
                    break;

                default:
                    Console.WriteLine("Hatalı Sayı Girildi.");
                    break;
            }

            Console.ReadLine();
        }

        public static void TersPiramit()
        {
            Console.Write("Sayı Giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i >= 1; i--)
            {
                for (int j = n; j > i; j--)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public static void Piramit()
        {
            Console.Write("Sayı Giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = n; j > i; j--)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public static void BaklavaDilimi()
        {
            Console.Write("Baklava dilimi için satır sayısını giriniz: ");
            int n = int.Parse(Console.ReadLine());

            // Üst kısım (gövde yukarı)
            for (int i = 1; i <= n; i++)
            {
                // Boşluklar
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                // Yıldızlar
                for (int k = 1; k <= (2 * i) - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // Alt kısım (gövde aşağı)
            for (int i = n - 1; i >= 1; i--)
            {
                // Boşluklar
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                // Yıldızlar
                for (int k = 1; k <= (2 * i) - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public static void DikUcgen()
        {
            int i, y;

            for (i = 0; i < 5; i++)
            {
                for (y = 0; y <= i; y++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
