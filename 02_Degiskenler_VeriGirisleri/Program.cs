using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _02_Degiskenler_VeriGirisleri
{
    class Program
    {
        static void Main(string[] args)
        {

            DoubleDegiskenler();
            Console.WriteLine();
            StringVeriGirisi();
            Console.WriteLine();
            IntVeriGirisi();
            Console.WriteLine();
            OndalikliSayiDonsumleri();
            Console.WriteLine();
            CharVeriGirisi();

            Console.ReadLine();
        }

        public static void CharVeriGirisi()
        {
            char cinsyet;

            Console.Write("Lütfen cinsiyet seçiniz: ");
            cinsyet = char.Parse(Console.ReadLine());

            Console.WriteLine("Seçtiğiniz cinsiyet: " + cinsyet);
        }
        public static void DoubleDegiskenler()
        {

            double applePrice = 14.85, orangePrice = 20.95, strawberryPrice = 45, potatoPrice = 9.74, tomatoPrice = 6.88;

            Console.WriteLine("***** Fiyat Listesi *****");
            Console.WriteLine();

            Console.WriteLine("---- Elma Birim Fiyatı: " + applePrice +
                              "\n---- Portakal Birim Fiyatı: " + orangePrice +
                              "\n---- Çilek Birim Fiyatı: " + strawberryPrice +
                              "\n---- Patates Birim Fiyatı: " + potatoPrice +
                              "\n---- Domates Birim Fiyatı: " + tomatoPrice);


            double appleGram = 1.245, orangeGram = 2.650, strawGram = 0.750, potatoGram = 4.859, tomatoGram = 3.745, totalPrice = 0;

            Console.WriteLine();

            Console.WriteLine("Alınan Ürün: ELma, Birim Fiyatı: " + applePrice
                + ", Gramaj: " + appleGram + ", Toplam Tutar: " + appleGram * applePrice);
            Console.WriteLine("Alınan Ürün: Portakal, Birim Fiyatı: " + orangePrice
                + ", Gramaj: " + orangeGram + ", Toplam Tutar: " + orangeGram * orangePrice);
            Console.WriteLine("Alınan Ürün: Çilek, Birim Fiyatı: " + strawberryPrice
                + ", Gramaj: " + strawGram + ", Toplam Tutar: " + strawGram * strawberryPrice);
            Console.WriteLine("Alınan Ürün: Patates, Birim Fiyatı: " + potatoPrice
                + ", Gramaj: " + potatoGram + ", Toplam Tutar: " + potatoGram * potatoPrice);
            Console.WriteLine("Alınan Ürün: Domates, Birim Fiyatı: " + tomatoPrice
                + ", Gramaj: " + tomatoGram + ", Toplam Tutar: " + tomatoGram * tomatoPrice);

            Console.WriteLine();

            totalPrice = (appleGram * applePrice) + (orangeGram * orangePrice) + (strawGram * strawberryPrice) + (potatoGram * potatoPrice) + (tomatoGram * tomatoPrice);

            Console.WriteLine("Toplam Tutar: " + totalPrice + " TL");


        }
        public static void StringVeriGirisi()
        {
            string passengername, passengersurname, passengerdistrict, passengercity, passengerage, passengeridentitynumber;

            Console.Write("Yolcu Adı: "); passengername = Console.ReadLine();

            Console.Write("Yolcu Soyadı: "); passengersurname = Console.ReadLine();

            Console.Write("İLçe Bilgisi: "); passengerdistrict = Console.ReadLine();

            Console.Write("Şehir Bilgisi: "); passengercity = Console.ReadLine();

            Console.Write("Yaş Bilgisi: "); passengerage = Console.ReadLine();

            Console.Write("TC Kimlik Numarası: "); passengeridentitynumber = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Yolcu Adı Soyadı: " + passengername + " " + passengersurname +
                " -- TC Kimlik Numarası: " + passengeridentitynumber + " -- Yolcu Yaşı: " + passengerage +
                " -- Adres Bilgisi: " + passengerdistrict + "/" + passengercity);

        }
        public static void IntVeriGirisi()
        {
            int shoesPrice = 1000, computerPrice = 2000, chairPrice = 5000, tvPrice = 12000;
            int shoesCount = 0, computerCount = 0, chairCount = 0, tvCount = 0;

            Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            shoesCount = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            computerCount = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            tvCount = Convert.ToInt32(Console.ReadLine());

            int totalPrice = (shoesCount * shoesPrice + computerCount * computerPrice) + (chairCount * chairPrice + tvPrice * tvCount);

            Console.WriteLine("Toplam Ödemeniz gereken tutar: " + totalPrice);


        }
        public static void OndalikliSayiDonsumleri()
        {
            double vize = 0, final = 0, result = 0;

            Console.Write("Vize Notunuzu Giriniz: ");
            vize = Convert.ToDouble(Console.ReadLine());

            Console.Write("Final Notunuzu Giriniz: ");
            final = Convert.ToDouble(Console.ReadLine());

            result = (vize * 0.4) + (final * 0.6);

            Console.WriteLine();
            Console.WriteLine("Ortalamanız: " + result);
        }
    }
}
