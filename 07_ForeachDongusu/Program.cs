using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachDongusu
{
    class Program
    {
        static void Main(string[] args)
        {
            TemelKodlar();
            Console.WriteLine();

            Console.ReadLine();
        }

        public static void TemelKodlar()
        {
            Console.WriteLine("Çift Sayıları Yazdırma");
            int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 285, 6578, 1245 };
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine(number);
                }
            }

            Console.WriteLine("List içinden yazdırma");
            List<int> numbers1 = new List<int>() { 1, 2, 3, 4, 5, 8 };
            foreach (int number in numbers1)
            {
                Console.WriteLine(number);
            }
        }


        public static void SınavSistemiUygulamasi()
        {
            int i, j, k;
            Console.Write("Sınıfıntaki öğrenci sayısı: ");
            int ogrenciAdedi = Convert.ToInt32(Console.ReadLine());

            string[] ogrenciAdlari = new string[ogrenciAdedi];
            double[] ogrenciNotOrtalamaları = new double[ogrenciAdedi];

            for (i = 0; i < ogrenciAdedi; i++)
            {
                Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
                ogrenciAdlari[i] = Console.ReadLine();

                double totalExamResult = 0;

                //Her öğrenci için 3 adet sınav notu girişi alıyoruz
                for (j = 0; j < 3; j++)
                {
                    Console.Write($"{ogrenciAdlari[i]} adlı öğrencinin {j + 1}. sınav notunu giriniz: ");
                    double value = Convert.ToDouble(Console.ReadLine());
                    totalExamResult += value; // notları topluyoruz
                }

                Console.WriteLine();

                ogrenciNotOrtalamaları[i] = totalExamResult / 3;


                //Öğrencilerin sınav ortalaması
                for (k = 0; k < ogrenciAdedi; k++)
                {
                    Console.WriteLine("----------------------------------");

                    Console.WriteLine($"{ogrenciAdlari[i]} adlı öğrencinin ortalaması: {ogrenciNotOrtalamaları[k]}");

                    //Öğrencilerin geçip kalma durumu
                    if (ogrenciNotOrtalamaları[k] >= 50)
                    {
                        Console.WriteLine($"{ogrenciAdlari[i]} adlı öğrenci dersi geçti.");
                    }
                    else
                    {
                        Console.WriteLine($"{ogrenciAdlari[i]} adlı öğrenci dersten kaldı.");
                    }
                }
            }
        }
    }
}
