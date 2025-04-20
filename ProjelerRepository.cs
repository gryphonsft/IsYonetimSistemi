using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace IsYonetimSistemi
{
    internal class ProjelerRepository
    {
        private readonly DatabaseHelper _dbHelper = new DatabaseHelper();
        DataTable dtt = new DataTable();
        //DataTable ile Proje listeleme ekle.
        //Proje durumunu raporlama sayfasında belirlemek.
        public void ProjeEkle(string ProjeAdi, string Aciklama, string Bastarihi, string Bitistarihi,int? Musteriid) 
        {
            string query = "INSERT INTO Projeler (ProjeAdi, Aciklama, Bastarihi, Bitistarihi, Musteriid) VALUES (@ProjeAdi, @Aciklama, @Bastarihi, @Bitistarihi, @Musteriid)";

            _dbHelper.ExecuteQuery(query, cmd =>
            {
                cmd.Parameters.AddWithValue("@ProjeAdi", ProjeAdi);
                cmd.Parameters.AddWithValue("@Aciklama", Aciklama);
                cmd.Parameters.AddWithValue("@Bastarihi", Bastarihi);
                cmd.Parameters.AddWithValue("@Bitistarihi", Bitistarihi);

                if (Musteriid.HasValue) // Eğer müşteriye bir proje yapılıyorsa, Musteriid bir değer kazanır
                {
                    cmd.Parameters.AddWithValue("@Musteriid", Musteriid);
                }
                else // Eğer kendi şirketime bir proje yapılıyorsa, Musteriid bir değer kazanmaz.
                {
                    cmd.Parameters.AddWithValue("@Musteriid", DBNull.Value);

                }
            });
        }
        public DataTable ProjeleriListele()
        {

            using (var connection = new SqliteConnection("Data Source=database.db"))
            {
                connection.Open();

                string sql = "SELECT ProjeAdi,Aciklama,Bastarihi,Bitistarihi,Musteriid FROM Projeler";

                using (var command = new SqliteCommand(sql, connection))
                using (var reader = command.ExecuteReader())
                {
                    dtt.Load(reader);
                }


            }
            return dtt;
        }
        public bool MusteriVarMi(int id)
        {
            using (var conn = new SqliteConnection("Data Source=database.db"))
            {
                conn.Open();
                var cmd = new SqliteCommand("SELECT COUNT(*) FROM Musteriler WHERE ID = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);

                long count = (long)cmd.ExecuteScalar();
                return count > 0;
            }
        }
        public void ProjeSilme()
        {
            
        }
        public void ProjeDuzenleme()
        {

        }


    }
}
