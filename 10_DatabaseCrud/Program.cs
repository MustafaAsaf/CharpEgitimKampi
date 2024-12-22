using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    public class Program
    {
        public static SqlConnection connection;
        public static SqlCommand command;
        public static SqlDataAdapter dataAdapter;
        public static DataSet dataSet;

        static void Main(string[] args)
        {
            AnaMenu(); // Program ana menüden başlar
        }
        public static void Baglanti()
        {
            connection = new SqlConnection(@"Data Source=DESKTOP-FTQEI8G\SQLEXPRESS;
                                             Initial Catalog=EgitimKampiDb;
                                             Integrated Security=True");
        }
        public static void AnaMenu()
        {
            Baglanti();
            int tableNumber;
            bool isValidInput;

            do
            {
                Console.Clear();
                Console.WriteLine("Menü Sipariş İşlem Paneli");
                Console.WriteLine();
                Console.WriteLine("1-Kategori İşlemleri");
                Console.WriteLine("2-Ürün İşlemleri");
                Console.WriteLine("0-Çıkış");
                Console.WriteLine("------------------------------");

                do
                {
                    Console.Write("İşlem Seçiniz: ");
                    string input = Console.ReadLine();
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
                        KategoriIslemleriMenu(); // Kategori İşlemleri alt menüsüne geç
                        break;
                    case 2:
                        UrunIslemleriMenu(); // Ürün İşlemleri alt menüsüne geç
                        break;
                    case 0:
                        Console.WriteLine("Çıkış Yapılıyor...");
                        break;
                    default:
                        Console.WriteLine("Hatalı Numara !");
                        break;
                }

            } while (tableNumber != 0); // 0 seçilirse döngüden çıkılır

            Console.WriteLine("Programdan çıkış yapıldı. Hoşça kalın!");
        }

        #region Kategori İşlemleri
        public static void KategoriIslemleriMenu()
        {
            int selection;
            bool isValidInput;

            do
            {
                Console.Clear();
                Console.WriteLine("Kategori İşlemleri");
                Console.WriteLine("1-Kategori Görüntüle");
                Console.WriteLine("2-Kategori Ekle");
                Console.WriteLine("0-Geri");
                Console.WriteLine("------------------------------");

                do
                {
                    Console.Write("İşlem Seçiniz: ");
                    string input = Console.ReadLine();
                    isValidInput = int.TryParse(input, out selection);
                    if (!isValidInput)
                    {
                        Console.WriteLine("Hatalı giriş yaptınız! Lütfen sadece sayı giriniz.");
                    }
                } while (!isValidInput);

                switch (selection)
                {
                    case 1:
                        KategoriGoruntule(); //Kategorilerin görüntülenmesi
                        break;
                    case 2:
                        KategoriEkleme(); // Kategori ekleme işlemi
                        break;
                    case 0:
                        Console.WriteLine("Ana menüye dönülüyor...");
                        break;
                    default:
                        Console.WriteLine("Hatalı seçim yaptınız!");
                        break;
                }

                if (selection != 0)
                {
                    Console.WriteLine("Devam etmek için bir tuşa basın...");
                    Console.ReadKey();
                }

            } while (selection != 0); // 0 seçilirse kategori menüsünden çıkılır
        }
        public static void UrunIslemleriMenu()
        {
            int selection;
            bool isValidInput;

            do
            {
                Console.Clear();
                Console.WriteLine("Ürün İşlemleri");
                Console.WriteLine("1-Ürün Görüntüle");
                Console.WriteLine("2-Ürün Ekle");
                Console.WriteLine("3-Ürün Sil");
                Console.WriteLine("4-Ürün Güncelle");
                Console.WriteLine("0-Geri");
                Console.WriteLine("------------------------------");

                do
                {
                    Console.Write("İşlem Seçiniz: ");
                    string input = Console.ReadLine();
                    isValidInput = int.TryParse(input, out selection);
                    if (!isValidInput)
                    {
                        Console.WriteLine("Hatalı giriş yaptınız! Lütfen sadece sayı giriniz.");
                    }
                } while (!isValidInput);

                switch (selection)
                {
                    case 1:
                        UrunGoruntule(); //Ürünlerin Görüntülenmesi
                        break;
                    case 2:
                        UrunEkleme(); // Ürün ekleme işlemi
                        break;
                    case 3:
                        UrunSil(); //Ürüm silme işlemi
                        break;
                    case 4:
                        UrunGuncelleme(); //Ürün Güncelleme İşlemi
                        break;
                    case 0:
                        Console.WriteLine("Ana menüye dönülüyor...");
                        break;
                    default:
                        Console.WriteLine("Hatalı seçim yaptınız!");
                        break;
                }

                if (selection != 0)
                {
                    Console.WriteLine("Devam etmek için bir tuşa basın...");
                    Console.ReadKey();
                }

            } while (selection != 0); // 0 seçilirse ürün menüsünden çıkılır
        }
        public static void KategoriEkleme()
        {
            Console.Clear();
            Console.WriteLine("Kategori Ekleme");
            Console.Write("Kategori adı giriniz: ");
            string categoryName = Console.ReadLine();

            connection = new SqlConnection(@"Data Source=DESKTOP-FTQEI8G\SQLEXPRESS;
                                             Initial Catalog=EgitimKampiDb;
                                             Integrated Security=True");
            connection.Open();
            command = new SqlCommand("INSERT INTO TblCategory (CategoryName) VALUES (@p1)", connection);
            command.Parameters.AddWithValue("@p1", categoryName);
            command.ExecuteNonQuery();
            connection.Close();

            Console.WriteLine("Kategori başarıyla eklendi!");
        }
        public static void KategoriGoruntule()
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


        /// <summary>
        ///  Kategori ID'sinin geçerli olup olmadığını kontrol eden yardımcı metot
        /// </summary>
        /// <param name="categoryId">Kategori ID'si</param>
        /// <returns></returns>
        public static bool CategoryIdExists(int categoryId)
        {
            connection.Open();
            command = new SqlCommand("SELECT COUNT(*) FROM TblCategory WHERE CategoryId = @categoryId", connection);
            command.Parameters.AddWithValue("@categoryId", categoryId);
            int count = (int)command.ExecuteScalar();
            connection.Close();

            return count > 0; // Eğer kategori varsa, count > 0 döner
        }
        #endregion

        #region Ürün İşlemleri
        public static void UrunGoruntule()
        {
            connection.Open();
            command = new SqlCommand("Select ProductId,ProductName,ProductPrice,CategoryName from TblProduct " +
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
        public static void UrunEkleme()
        {
            Console.Clear();
            Console.WriteLine("Ürün Ekleme");

            // Ürün adı al
            Console.Write("Ürün adı giriniz: ");
            string productName = Console.ReadLine();

            // Ürün fiyatı al
            Console.Write("Ürün fiyatı giriniz: ");
            decimal productPrice;
            while (!decimal.TryParse(Console.ReadLine(), out productPrice) || productPrice <= 0)
            {
                Console.Write("Geçerli bir fiyat giriniz: ");
            }

            // Kategori ID'si al
            int categoryId;
            bool isValidCategoryId;
            do
            {
                Console.Write("Kategori ID giriniz: ");
                isValidCategoryId = int.TryParse(Console.ReadLine(), out categoryId);

                if (isValidCategoryId)
                {
                    // Kategori ID'sinin TblCategory tablosunda var olup olmadığını kontrol et
                    if (!CategoryIdExists(categoryId))
                    {
                        Console.WriteLine("Hatalı kategori ID! Bu ID ile bir kategori bulunmamaktadır.");
                        isValidCategoryId = false; // Geçersiz kategori, tekrar denetle
                    }
                }
                else
                {
                    Console.WriteLine("Lütfen geçerli bir sayı giriniz.");
                }

            } while (!isValidCategoryId); // Geçerli kategori ID girene kadar döngü devam eder

            // Ürünü ekleme işlemi
            connection.Open();
            command = new SqlCommand(
                "INSERT INTO TblProduct (ProductName, ProductPrice, CategoryId, ProductStatus) VALUES (@p1, @p2, @p3, @p4)",
                connection);
            command.Parameters.AddWithValue("@p1", productName);
            command.Parameters.AddWithValue("@p2", productPrice);
            command.Parameters.AddWithValue("@p3", categoryId);
            command.Parameters.AddWithValue("@p4", true); // Ürün durumu aktif
            command.ExecuteNonQuery();
            connection.Close();

            Console.WriteLine("Ürün başarıyla eklendi!");
        }
        public static void UrunSil()
        {
            Console.Write("Silinecek Ürün ID'si: ");
            int productId = Convert.ToInt32(Console.ReadLine());

            Baglanti();
            connection.Open();

            command = new SqlCommand("Delete From TblProduct Where ProductId=@productId", connection);
            command.Parameters.AddWithValue("@productId", productId);
            command.ExecuteNonQuery();

            connection.Close();

            Console.WriteLine("Ürün Silinmiştir.");


        }
        public static void UrunGuncelleme()
        {
            Console.Clear();
            Console.Write("Güncellenecek ürün ID numarasını giriniz: ");
            int productId = Convert.ToInt32(Console.ReadLine());

            // Öncelikle ürün ID'sinin geçerli olup olmadığını kontrol et
            if (!ProductExists(productId))
            {
                Console.WriteLine("Bu ID'ye sahip bir ürün bulunmamaktadır.");
                return;  // Geçerli olmayan ID'yi işlemeye gerek yok, fonksiyondan çık
            }

            // Geçerli ürünse, diğer bilgiler alınır
            Console.Write("Güncellenecek ürünün adını giriniz: ");
            string productName = Console.ReadLine();

            Console.Write("Güncellenecek ürünün fiyatını giriniz: ");
            decimal productPrice = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Güncellenecek ürünün kategori ID'sini giriniz: ");
            int categoryId = Convert.ToInt32(Console.ReadLine());

            // Veritabanına bağlan
            connection.Open();

            // SQL sorgusunun doğru şekilde yazıldığından emin olalım.
            command = new SqlCommand("UPDATE TblProduct SET ProductName=@productName, ProductPrice=@productPrice, CategoryId=@categoryId, ProductStatus=@productStatus WHERE ProductId=@productId", connection);

            // Parametreleri ekle
            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@productPrice", productPrice);
            command.Parameters.AddWithValue("@categoryId", categoryId);
            command.Parameters.AddWithValue("@productStatus", true);  // Ürün durumu aktif
            command.Parameters.AddWithValue("@productId", productId);  // Güncellenmesi gereken ürün ID'si

            // SQL sorgusunu çalıştır
            command.ExecuteNonQuery();
            connection.Close();

            Console.WriteLine("Ürün başarıyla güncellendi!");
        }


        /// <summary>
        ///  Ürün ID'sinin geçerli olup olmadığını kontrol eden yardımcı metot
        /// </summary>
        /// <param name="productId">Ürün ID'si</param>
        /// <returns></returns>
        public static bool ProductExists(int productId)
        {
            connection.Open();
            command = new SqlCommand("SELECT COUNT(*) FROM TblProduct WHERE ProductId = @productId", connection);
            command.Parameters.AddWithValue("@productId", productId);
            int count = (int)command.ExecuteScalar();
            connection.Close();

            return count > 0; // Eğer ürün varsa, count > 0 döner
        }
        #endregion

    }
}
