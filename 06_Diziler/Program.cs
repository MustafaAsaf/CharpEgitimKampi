using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            TemelDiziOrnekleri();
            Console.WriteLine();
            DiziMetodlari();
            Console.WriteLine();
            DizilerOrnekler();

            Console.ReadLine();
        }

        public static void TemelDiziOrnekleri()
        {
            string[] sehirler = { "Prag", "Roma", "Atina", "Ankara", "Bursa" };
            for (int i = 0; i < sehirler.Length; i++)
            {
                Console.WriteLine(sehirler[i]);
            }

            string[] renkler = new string[4];
            renkler[0] = "Siyah";
            renkler[1] = "Bordo";
            renkler[2] = "Mavi";
            renkler[3] = "Beyaz";
            Console.WriteLine(renkler[0]);

            int[] myArray = { 47, 85, 96, 87, 32, 152, 658, 140 };
            int maxnumber = myArray[0];
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] > maxnumber)
                {
                    maxnumber = myArray[i];
                }
            }

            Console.WriteLine(maxnumber);
        }
        public static void DiziMetodlari()
        {
            string[] names = { "yusuf", "mehmet", "buse", "bahar", "irem", "ahmet" };
            int index = Array.IndexOf(names, "irem");
            Console.WriteLine(index);

            int[] numbers = { 80, 61, 10, 20, 1, 55, 45, 79, 88 };
            Console.WriteLine("Dizinin en küçük elemanı: " + numbers.Min() + "Dizinin en büyük elemanı: " + numbers.Max());

        }
        public static void DizilerOrnekler()
        {
            int[] numbers = { 80, 61, 10, 20, 1, 55, 45, 79, 88 };

            Console.WriteLine("Çift Sayılar");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }

            Console.WriteLine();

            Console.WriteLine("Tek Sayılar");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    Console.WriteLine(numbers[i]);
                }
            }

        }
    }
}
