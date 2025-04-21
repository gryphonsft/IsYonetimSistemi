using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsYonetimSistemi
{
    public partial class ProjelerEkrani : Form
    {
        private readonly ProjelerRepository projelerRepository = new ProjelerRepository();
        private readonly CalisanlarRepository calisanlarRepository = new CalisanlarRepository();
        public ProjelerEkrani()
        {
            InitializeComponent();

            ProjeleriYukle();
            ProjeAtamalariniYukle();

            ComboboxlarıYukle();
        }

        private void ProjelerEkrani_Load(object sender, EventArgs e)
        {

        }
        public void ComboboxlarıYukle()
        {
            try
            {
                CalisanComboBoxVeri();
                ProjelerComboBoxVeri();
                RollerComboBox();
                MusteriComboBoxVeri();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata : " + ex);
            }

        }
        private void projeeklebtn_Click(object sender, EventArgs e)
        {
          
            int? musteriID = musteribox.SelectedValue != null && musteribox.SelectedValue != DBNull.Value? (int?)musteribox.SelectedValue: null;

            projelerRepository.ProjeEkle(projeaditxtbox.Text, aciklamatxtbox.Text, btarihidate.Text, bitistarihidate.Text, musteriID);
            ProjeleriYukle();
            ProjeAtamalariniYukle();
            MessageBox.Show("Proje Başarıyla eklendi!");
        }
        private void geridonbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void ProjeleriYukle()
        {
            DataTable dtt = projelerRepository.ProjeleriListele();
            projelerdata.DataSource = dtt;
        }
        public void ProjeAtamalariniYukle()
        {
            DataTable dtt = projelerRepository.ProjeAtamalariListele();
            atanmisprojelerdata.DataSource = dtt;

            atanmisprojelerdata.DataBindingComplete += (s, e) =>
            {
                Renklendirme();
            };

        }
        public void Renklendirme()
        {
            foreach (DataGridViewRow row in atanmisprojelerdata.Rows)
            {

                if (row.Cells["Musteriid"].Value != DBNull.Value && row.Cells["Musteriid"].Value != null)
                {

                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                }
                else
                {

                    row.DefaultCellStyle.BackColor = Color.LightGray;
                }
            }
        }
        public void MusteriComboBoxVeri()
        {
            ProjelerRepository repo = new ProjelerRepository();
            
            DataTable dt = repo.ComboBoxicinMusterileriGetir();

           
            dt.Columns.Add("musterigosterim", typeof(string));

            foreach (DataRow row in dt.Rows)
            {
                row["musterigosterim"] = $"{row["ad"]}";  
            }

         
            musteribox.DisplayMember = "musterigosterim";  
            musteribox.ValueMember = "id";  

          
            musteribox.DataSource = dt;
        }



        private void projeatamabtn_Click(object sender, EventArgs e)
        {
            int calisanId = Convert.ToInt32(calisanbox.SelectedValue);
            int projeId = Convert.ToInt32(projebox.SelectedValue);
            string rol = rolbox.Text;
            string atamaTarihi = atarihidate.Text;

            ProjelerRepository repo = new ProjelerRepository();
            repo.ProjeAtamaEkle(calisanId, projeId, rol, atamaTarihi);
            ProjeAtamalariniYukle();
            MessageBox.Show("Proje ataması başarılı!");

        }

        public void CalisanComboBoxVeri()
        {
            
            CalisanlarRepository repo = new CalisanlarRepository();
            DataTable dt = repo.ComboBoxicinCalisanlariGetir();

            dt.Columns.Add("CalisanGosterim", typeof(string));

            foreach (DataRow row in dt.Rows)
            {
                row["CalisanGosterim"] = $"{row["adsoyad"]} - {row["pozisyon"]}";
            }

            calisanbox.DisplayMember = "CalisanGosterim";
            calisanbox.ValueMember = "id";
            calisanbox.DataSource = dt;
        }
        public void ProjelerComboBoxVeri()
        {
            ProjelerRepository repo = new ProjelerRepository();
            DataTable dt = repo.ComboBoxicinProjeleriGetir();

            projebox.DisplayMember = "ProjeAdi";
            projebox.ValueMember = "id";
            projebox.DataSource = dt;
        }
        public void RollerComboBox()
        {
            CalisanlarRepository repo = new CalisanlarRepository();
            DataTable dt = repo.RolleriListele();

            rolbox.DisplayMember = "roladi";
            rolbox.ValueMember = "id";
            rolbox.DataSource = dt;
        }

        
    }
}
