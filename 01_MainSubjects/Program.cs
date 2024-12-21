using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    class Program
    {
        static void Main(string[] args)
        {

            Yazdırma();

            StringDegiskenler();

            IntDegiskenler();

            Console.ReadLine();

        }


        public static void Yazdırma()
        {
            Console.WriteLine("Merhaba Dünya!");

            Console.WriteLine("***** Yemek Kategorileri *****");
            Console.WriteLine();
            Console.WriteLine("1- Çorbalar");
            Console.WriteLine("2- Ana Yemekler");
            Console.WriteLine("3- Soğuk Başlangıçlar");

        }

        public static void StringDegiskenler()
        {
            string customerName, customerSurname, customerPhone, customerEmail, district, city;


            customerName = "Asaf";
            customerSurname = "Çelik";
            customerPhone = "+90 555 555 55 55";
            customerEmail = "deneme@gmail.com";
            district = "Çankaya";
            city = "Ankara";

            Console.WriteLine("***** Rezervasyon Kartı *****");
            Console.WriteLine();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            Console.WriteLine("İletişim: " + customerPhone);
            Console.WriteLine("Email Adresi: " + customerEmail);
            Console.WriteLine("Adres: " + district + "/" + city);
            Console.WriteLine("-----------------------------------");
        }

        public static void IntDegiskenler()
        {
            int hamburgerCount = 2, cokeCount = 2, waterCount = 0, friesCount = 3, pizzaCount = 1, lemonadeCount = 1;

            int totalPrice = 0;

            int hamburgerPrice = 170;
            int cokePrice = 50;
            int waterPrice = 15;
            int friesPrice = 50;
            int pizzaPrice = 180;
            int lemonadePrice = 40;



            Console.WriteLine("***** Restoran Menü Fiyatları *****");
            Console.WriteLine();
            Console.WriteLine("---- Hamburger Fiyatı: " + hamburgerPrice + "TL");
            Console.WriteLine("---- Kola Fiyatı: " + cokePrice + "TL");
            Console.WriteLine("---- Su Fiyatı: " + waterPrice + "TL");
            Console.WriteLine("---- Kızartma Fiyatı: " + friesPrice + "TL");
            Console.WriteLine("---- Pizza Fiyatı: " + pizzaPrice + "TL");
            Console.WriteLine("---- Limonata Fiyatı: " + lemonadePrice + "TL");
            Console.WriteLine();



            totalPrice = (hamburgerPrice * hamburgerCount) + (cokeCount * cokePrice) + (waterCount * waterPrice) + (friesCount * friesPrice) + (pizzaCount * pizzaPrice) + (lemonadeCount * lemonadePrice);

            Console.WriteLine("-------------------------------");
            Console.WriteLine("Hamburger Tutarı: " + (hamburgerPrice * hamburgerCount) + " TL");
            Console.WriteLine("Kola Tutarı: " + (cokeCount * cokePrice) + " TL");
            Console.WriteLine("Su Tutarı: " + (waterCount * waterPrice) + " TL");
            Console.WriteLine("Kızartma Tutarı: " + (friesCount * friesPrice) + " TL");
            Console.WriteLine("Pizza Tutarı: " + (pizzaCount * pizzaPrice) + " TL");
            Console.WriteLine("Limonata Tutarı: " + (lemonadeCount * lemonadePrice) + " TL");
            Console.WriteLine();
            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + " TL");
        }
    }
}
