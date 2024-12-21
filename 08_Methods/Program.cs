using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string x, y, z;

            CustomerCard("Yusuf","Yazici");
            Console.WriteLine();
            Toplam(1,2,3);
            Console.WriteLine();
            

            Console.Write("Ülke adını giriniz: "); x = Console.ReadLine();
            Console.Write("Başkenti giriniz: "); y = Console.ReadLine();
            Console.Write("Bayrak Rengini Giriniz: "); z = Console.ReadLine();
            Console.WriteLine(CountryCard(x, y, z));
            Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı - Beyaz"));
            Console.WriteLine();

            Console.WriteLine(Examresult("Hasan", 80, 55, 85));
            Console.WriteLine(Examresult("Süleyman", 100, 90, 32));

            Console.ReadLine();
        }


        /// <summary>
        /// Geriye Değer Döndürmeyen String Parametreli Metot
        /// </summary>
        /// <param name="name">Ad</param>
        /// <param name="surname">Soyad</param>
        public static void CustomerCard(string name, string surname)
        {
            Console.WriteLine("Müşteri: " + name + " " + surname);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="number1">Sayı 1</param>
        /// <param name="number2">Sayı 2</param>
        /// <param name="number3">Sayı 3</param>
        public static void Toplam(int number1, int number2, int number3)
        {
            int result = number1 + number2 + number3; 
            Console.WriteLine(result);
        }


        /// <summary>
        /// Geriye Değer Döndüren String Parametreli Metotlar
        /// </summary>
        /// <returns></returns>
        static string CountryCard(string countryName, string capital, string flagColor) 
        {
            string cardInfo = "Ülke: " + countryName + " - Başkent: " + capital + " - Bayrak Rengi: " + flagColor;
            return cardInfo;
        }

        /// <summary>
        /// Örnek Uygulama
        /// </summary>
        /// <param name="student">Öğrenci</param>
        /// <param name="exam1">Sınav 1</param>
        /// <param name="exam2">Sınav 2</param>
        /// <param name="exam3">Sınav 3</param>
        /// <returns></returns>
        static string Examresult(string student, int exam1, int exam2, int exam3)
        {
            int result = (exam1 + exam2 + exam3) / 3;
            if (result >= 50)
            {
                    return student + " isimli öğrenci sınavı geçti. " + "Ortalama: " + result;
            }
            else
            {
                    return student + " isimli öğrenci sınavı geçemedi. Ortalama: " + result;
            }
        }
    }
}
