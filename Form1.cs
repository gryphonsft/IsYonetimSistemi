using Microsoft.Data.Sqlite;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace IsYonetimSistemi
{
    public partial class Form1 : Form
    {
        public string _databasePath = "database.db";
        public Form1()
        {
            InitializeComponent();
            veriTabaniOlustur();
            CalisanSayisiAl();
        }
        public async void Form1_Load(object sender, EventArgs e)
        {
            await HavaDurumuAl();
        }
        private void veriTabaniOlustur()
        {
            if (!File.Exists(_databasePath))
            {
                using (var connection = new SqliteConnection($"Data Source={_databasePath}"))
                {
                    connection.Open();


                    string createCalisanlar = @"CREATE TABLE IF NOT EXISTS Calisanlar (
                                                id INTEGER PRIMARY KEY AUTOINCREMENT,
                                                adsoyad TEXT NOT NULL,
                                                pozisyon TEXT NOT NULL,
                                                maas REAL NOT NULL,
                                                telefon TEXT NOT NULL,
                                                gtarih TEXT NOT NULL,
                                                cinsiyet INTEGER)";

                    string createPozisyonlar = @"CREATE TABLE IF NOT EXISTS Pozisyonlar (
                                                id INTEGER PRIMARY KEY AUTOINCREMENT,
                                                Pozisyonadi TEXT NOT NULL)";

                    string createProjeler = @"CREATE TABLE IF NOT EXISTS Projeler (
                                              id INTEGER PRIMARY KEY AUTOINCREMENT,
                                              ProjeAdi TEXT NOT NULL,
                                              Aciklama TEXT,
                                              Bastarihi DATE,
                                              Bitistarihi DATE,
                                              Musteriid INTEGER,  
                                              FOREIGN KEY (Musteriid) REFERENCES Musteriler(id))";

                    string createProjeatamasi = @"CREATE TABLE IF NOT EXISTS Projeatamasi (
                                                  Calisanid INTEGER,
                                                  Projeid INTEGER,
                                                  Rol TEXT,
                                                  AtamaTarihi DATE,
                                                  PRIMARY KEY (Calisanid, Projeid),
                                                  FOREIGN KEY (Calisanid) REFERENCES Calisanlar(id) ON DELETE CASCADE,
                                                  FOREIGN KEY (Projeid) REFERENCES Projeler(id) ON DELETE CASCADE)";

                    string createMusteriler = @"CREATE TABLE IF NOT EXISTS Musteriler(
                                                id INTEGER PRIMARY KEY AUTOINCREMENT,
                                                Ad TEXT,
                                                Iletisim TEXT,
                                                Eklenmetarihi DATE,
                                                Aciklama TEXT)";



                    using (var command = new SqliteCommand(createCalisanlar, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    using (var command = new SqliteCommand(createPozisyonlar, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    using (var command = new SqliteCommand(createProjeler, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    using (var command = new SqliteCommand(createProjeatamasi, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    using (var command = new SqliteCommand(createMusteriler, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                }

                MessageBox.Show("Tablolar kontrol edildi, eksikler tamamlandý.");
            }
        }

        private void calisanlarbtn_Click(object sender, EventArgs e)
        {
            CalisanlarEkrani calisanekrani = new CalisanlarEkrani();
            calisanekrani.Show();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void CalisanSayisiAl()
        {

            string connectionString = "Data Source=database.db;";


            using (SqliteConnection conn = new SqliteConnection(connectionString))
            {
                try
                {

                    conn.Open();


                    string query = "SELECT COUNT(*) FROM Calisanlar";


                    using (SqliteCommand cmd = new SqliteCommand(query, conn))
                    {

                        int calisanSayisi = Convert.ToInt32(cmd.ExecuteScalar());


                        calisansayisi.Text = $"{calisanSayisi}";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluþtu: " + ex.Message);
                }
            }
        }
        public async Task HavaDurumuAl()
        {
            var settings = new SettingsHelper();
            string api = settings.apiAl();
            string url = settings.urlAl();
            string sehir = settings.sehirAl();

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string myurl = $"{url}?q={sehir}&appid={api}&units=metric&lang=tr";

                    HttpResponseMessage response = await client.GetAsync(myurl);

                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        var weatherData = JsonConvert.DeserializeObject<WeatherResponse>(json);

                        havadurumu.Text = $"Þehir: {weatherData?.Name}\n" +
                                          $"Sýcaklýk: {weatherData?.Main?.Temp}°C\n";
                    }
                    else
                    {
                        string errorMessage = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"API isteði baþarýsýz oldu. Hata: {response.StatusCode}\n{errorMessage}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bir hata oluþtu: {ex.Message}");
                }
            }
        }
        private void projelerbtn_Click(object sender, EventArgs e)
        {
            ProjelerEkrani projelerEkrani = new ProjelerEkrani();
            projelerEkrani.Show();
        }
        public class WeatherApi
        {
            public string? api { get; set; }
            public string? apiurl { get; set; }
        }
        public class WeatherResponse
        {
            public string? Name { get; set; }
            public MainWeather? Main { get; set; }
            public Weather[]? Weather { get; set; }
        }

        public class MainWeather
        {
            public float Temp { get; set; }
        }

        public class Weather
        {
            public string? Description { get; set; }
        }

          
        }
    }




