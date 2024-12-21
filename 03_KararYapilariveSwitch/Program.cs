using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _03_KararYapilariveSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            int secim = 0;
            Console.WriteLine("---------------------------------");
            Console.WriteLine("IF ELSE YAPISI");
            Console.WriteLine("MOD İŞLEMİ");
            Console.WriteLine("SWITCH CASE YAPISI");
            Console.WriteLine("HESAP MAKİNESİ");
            Console.WriteLine("---------------------------------");

            Console.Write("Yapılacak İşlemi Seçiniz.");
            secim = Convert.ToInt32(Console.ReadLine());

            switch (secim)
            {
                case 1:
                    IfElse();
                    break;
                case 2:
                    ModIslemi();
                    break;
                case 3:
                    SwitchCase();
                    break;
                case 4:
                    HesapMakinesi();
                    break;
            }


            Console.ReadLine();
        }

        public static void IfElse()
        {
            int vize = 0, final = 0;
            float ortalama = 0;
            string result = null;

            Console.Write("Vize Notu: ");
            vize = Convert.ToInt32(Console.ReadLine());

            Console.Write("Final Notu: ");
            final = Convert.ToInt32(Console.ReadLine());


            ortalama = (float)((vize * 0.4) + (final * 0.6));
            Console.WriteLine("Sınavların ortalaması: " + ortalama);

            if (ortalama > 0 & ortalama <= 50)
            {
                result = "FF";
            }

            if (ortalama > 50 & ortalama <= 70)
            {
                result = "CC";
            }

            if (ortalama > 70 & ortalama <= 84)
            {
                result = "BB";
            }

            if (ortalama > 84)
            {
                result = "AA";
            }

            Console.WriteLine(result);
        }

        public static void ModIslemi()
        {

            Console.Write("Lütfen sayıyı giriniz: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Sayı çifttir.");
            }
            else
            {
                Console.WriteLine("Sayı tektir");
            }
        }

        public static void SwitchCase()
        {
            int secim = 0;
            Console.WriteLine("C# Eğitim Kampı Restoran\n" +
                              "\n" +
                              "---------------------------------------\n" +
                              "1- Ana Yemekler\n" +
                              "2- Çorbalar\n" +
                              "3- Pizzalar\n" +
                              "4- İçecekler\n" +
                              "5- Tatlılar\n" +
                              "---------------------------------------\n");
            secim = Convert.ToInt32(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    Console.WriteLine("Ana Yemekler 200 TL");
                    break;
                case 2:
                    Console.WriteLine("Çorbalar 80 TL");
                    break;
                case 3:
                    Console.WriteLine("Pizzalar 100 TL");
                    break;
                case 4:
                    Console.WriteLine("İçecekler 30 TL");
                    break;
                case 5:
                    Console.WriteLine("Tatlıar 110 TL");
                    break;
                default:
                    Console.WriteLine("Yanlış İşlem.");
                    break;
            }
        }

        public static void HesapMakinesi()
        {
            int sayi1 = 0, sayi2 = 0, sonuc = 0;
            char symbol;

            Console.Write("1. sayıyı giriniz: ");
            sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2. sayıyı giriniz: ");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lütfen yapıcağınız işlemi giriniz: ");
            symbol = Convert.ToChar(Console.ReadLine());

            switch (symbol)
            {
                case '+':
                    sonuc = sayi1 + sayi2;
                    Console.WriteLine("Toplam: " + sonuc);
                    break;

                case '-':
                    sonuc = sayi1 - sayi2;
                    Console.WriteLine("Fark: " + sonuc);
                    break;

                case '*':
                    sonuc = sayi1 * sayi2;
                    Console.WriteLine("Çarpım: " + sonuc);
                    break;

                case '/':
                    sonuc = sayi1 / sayi2;
                    Console.WriteLine("Bölüm: " + sonuc);
                    break;

            }
        }
    }
}
