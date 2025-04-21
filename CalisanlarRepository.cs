using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace IsYonetimSistemi
{
    class CalisanlarRepository
    {
        private readonly DatabaseHelper _dbHelper = new DatabaseHelper();
        

        public void CalisanEkle(string adsoyad, string pozisyon, string maas, string telefon, string gtarih, int cinsiyet)
        {
            string query = "INSERT INTO Calisanlar (adsoyad, pozisyon, maas, telefon, gtarih, cinsiyet) VALUES (@adsoyad, @pozisyon, @maas, @telefon, @gtarih, @cinsiyet)";
            _dbHelper.ExecuteQuery(query, cmd =>
            {
                cmd.Parameters.AddWithValue("@adsoyad", adsoyad);
                cmd.Parameters.AddWithValue("@pozisyon", pozisyon);
                cmd.Parameters.AddWithValue("@maas", maas);
                cmd.Parameters.AddWithValue("@telefon", telefon);
                cmd.Parameters.AddWithValue("@gtarih", gtarih);
                cmd.Parameters.AddWithValue("@cinsiyet", cinsiyet);

            });
        }
        public void PozisyonEkle(string Pozisyonadi)
        {
            string query = "INSERT INTO Pozisyonlar (Pozisyonadi) VALUES (@Pozisyonadi)";

            _dbHelper.ExecuteQuery(query, cmd =>
            {
                cmd.Parameters.AddWithValue("@Pozisyonadi", Pozisyonadi);

            });
        }

        public DataTable CalisanlariListele()
        {
            DataTable dt = new DataTable();

            using (var connection = new SqliteConnection("Data Source=database.db"))
            {
                connection.Open();

                string sql = "SELECT id, adsoyad, pozisyon, maas, telefon, gtarih, cinsiyet FROM Calisanlar";

                using (var command = new SqliteCommand(sql, connection))
                using (var reader = command.ExecuteReader())
                {
                    dt.Load(reader);
                }


            }
            return dt;
        }
        

        public DataTable PozisyonlariListele()
        {
            DataTable dt = new DataTable();

            using (var connection = new SqliteConnection("Data Source=database.db"))
            {
                connection.Open();
                string sql = "SELECT * FROM Pozisyonlar";
                using (var command = new SqliteCommand(sql, connection))
                using (var reader = command.ExecuteReader())
                {
                    dt.Load(reader);
                }

            }
            return dt;
        }
        public DataTable RolleriListele()
        {
            DataTable dt = new DataTable();
            using (var connection = new SqliteConnection("Data Source=database.db"))
            {
                connection.Open();
                string sql = "SELECT id,roladi FROM Roller";
                using (var command = new SqliteCommand(sql, connection))
                using (var reader = command.ExecuteReader())
                {
                    dt.Load(reader);
                }

            }

            return dt;
        }

        public DataTable ComboBoxicinCalisanlariGetir()
        {
            DataTable dt = new DataTable();

            using (var connection = new SqliteConnection("Data Source=database.db"))
            {
                connection.Open();
                string sql = "SELECT id, adsoyad, pozisyon FROM Calisanlar"; 
                using (var command = new SqliteCommand(sql, connection))
                using (var reader = command.ExecuteReader())
                {
                    dt.Load(reader);
                }
            }

            return dt;
        }

    }
}
