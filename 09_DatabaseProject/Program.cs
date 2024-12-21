using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    public class Program
    {
        public static SqlConnection connection;
        public static SqlCommand command;
        public static SqlDataAdapter dataAdapter;
        public static DataSet dataSet;

        public static void Baglanti()
        {
            connection = new SqlConnection(@"Data Source=DESKTOP-FTQEI8G\SQLEXPRESS;
                                                           Initial Catalog=EgitimKampiDb;
                                                           Integrated Security=True");
        }

        public static void Category()
        {
            try
            {
                connection.Open();
                command = new SqlCommand("Select * From TblCategory", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                connection.Close();

                foreach (DataRow row in dataTable.Rows)
                {
                    foreach (var item in row.ItemArray)
                    {
                        Console.WriteLine(item.ToString());
                    }

                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message);
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        public static void Product()
        {
            connection.Open();
            command = new SqlCommand("Select ProductName,ProductPrice,CategoryName from TblProduct " +
                                     "inner join TblCategory " +
                                     "on TblProduct.CategoryId=TblCategory.CategoryId", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.Close();

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.WriteLine(item.ToString());
                }

                Console.WriteLine();
            }
        }

        public static void Order()
        {
            try
            {
                connection.Open();
                command = new SqlCommand("Select * From TblOrder", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                connection.Close();

                foreach (DataRow row in dataTable.Rows)
                {
                    foreach (var item in row.ItemArray)
                    {
                        Console.WriteLine(item.ToString());
                    }

                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message);
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        static void Main(string[] args)
        {
            Baglanti(); // Bağlantıyı başlatın

            int tableNumber;

            do
            {
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("1-Kategoriler");
                Console.WriteLine("2-Ürünler");
                Console.WriteLine("3-Siparişler");
                Console.WriteLine("4-Çıkış Yap");

                bool isValidInput = false;
                do
                {
                    Console.Write("Lütfen getirmek istediğiniz tablo numarısını giriniz: ");
                    string input = Console.ReadLine();
                    // Girişi kontrol et
                    isValidInput = int.TryParse(input, out tableNumber);
                    if (!isValidInput)
                    {
                        Console.WriteLine("Hatalı giriş yaptınız! Lütfen sadece sayı giriniz.");
                    }
                } while (!isValidInput);


                Console.WriteLine("----------------------------------------------------");

                switch (tableNumber)
                {
                    case 1:
                        Category();
                        break;
                    case 2:
                        Product();
                        break;
                    case 3:
                        Order();
                        break;
                    case 4:
                        Console.WriteLine("Çıkış yapılıyor...");
                        break;
                    default:
                        Console.WriteLine("Hatalı Numara !");
                        break;
                }

                // Kullanıcıya devam etmek isteyip istemediğini soralım
                if (tableNumber != 4) // Eğer çıkış seçilmemişse menüyü tekrar göster
                {
                    Console.WriteLine("Bir tuşa basarak menüye geri dönün...");
                    Console.ReadKey(); // Kullanıcıdan bir tuş girişi bekler
                    Console.Clear(); // Konsolu temizler
                }

            } while (tableNumber != 4); // 4 seçilirse döngüden çıkılır

            Console.WriteLine("Programdan çıkış yapıldı. Hoşça kalın!");
        }

    }
}
