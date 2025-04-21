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
            DataTable dtt = new DataTable();

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
        public DataTable ComboBoxicinProjeleriGetir()
        {
            DataTable dtt = new DataTable();
            using (var connection = new SqliteConnection("Data Source=database.db"))
            {
                connection.Open();
                string sql = "SELECT id,ProjeAdi,Aciklama,Bastarihi,Bitistarihi,Musteriid FROM Projeler";

                using (var command = new SqliteCommand(sql,connection))
                using (var reader = command.ExecuteReader())
                {
                    dtt.Load(reader);
                }
            }

            return dtt;
        }
        public void ProjeAtamaEkle(int Calisanid,int Projeid,string Rol,string AtamaTarihi)
        {
            //Calisanid, Projeid, Rol, AtamaTarihi

            string query = "INSERT INTO Projeatamasi (Calisanid,Projeid,Rol,AtamaTarihi) VALUES (@Calisanid,@Projeid,@Rol,@AtamaTarihi)";
            _dbHelper.ExecuteQuery(query, cmd =>
            {
                cmd.Parameters.AddWithValue("@Calisanid", Calisanid);
                cmd.Parameters.AddWithValue("@Projeid", Projeid);
                cmd.Parameters.AddWithValue("@Rol", Rol);
                cmd.Parameters.AddWithValue("@AtamaTarihi", AtamaTarihi);            
            });

        }
        public DataTable ProjeAtamalariListele()
        {
            DataTable dtt = new DataTable();

            using (var connection = new SqliteConnection("Data Source=database.db"))
            {
                connection.Open();

                string query = @"SELECT pa.Calisanid, c.adsoyad, pa.Projeid, p.ProjeAdi, pa.Rol, pa.AtamaTarihi, p.Musteriid
                         FROM Projeatamasi pa
                         JOIN Calisanlar c ON pa.Calisanid = c.id
                         JOIN Projeler p ON pa.Projeid = p.id";

                using (var command = new SqliteCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    dtt.Load(reader);
                }
            }
            return dtt;
        }

        public DataTable ComboBoxicinMusterileriGetir()
        {
            DataTable dtt = new DataTable();
            using (var connection = new SqliteConnection("Data Source=database.db"))
            {
                connection.Open();
                string sql = "SELECT id,ad FROM Musteriler";

                using (var command = new SqliteCommand(sql, connection))
                using (var reader = command.ExecuteReader())
                {
                    dtt.Load(reader);
                }
            }

            return dtt;
        }
        public void ProjeSilme()
        {
            
        }
        public void ProjeDuzenleme()
        {

        }
        


    }
}
