using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace IsYonetimSistemi
{
    public partial class CalisanlarEkrani : Form
    {
        private readonly CalisanlarRepository calisanRepo = new CalisanlarRepository();

        
        public CalisanlarEkrani()
        {
            InitializeComponent();  
            Pozisyoncombobox(pozisyonbox);
            CalisanVerileriYukle();
            PozisyonVerileriYukle();
        }


        private void kaydetbtn_Click(object sender, EventArgs e)
        {
            

            int cinsiyet = 0;

            if (erkekradio.Checked)
            {
                cinsiyet = 1;
            }
            else if (kadinradio.Checked)
            {
                cinsiyet = 2;
            }


            calisanRepo.CalisanEkle(adtxtbox.Text, pozisyonbox.Text, maastext.Text, telefonbox.Text, datebox.Text, cinsiyet);

            CalisanVerileriYukle();
           
            MessageBox.Show("Çalışan başarıyla eklendi!");
        }
        public void Pozisyoncombobox(ComboBox comboBox)
        {
            DataTable dt = calisanRepo.PozisyonlariListele();
            pozisyonbox.Items.Clear();

            foreach (DataRow row in dt.Rows)
            {
                pozisyonbox.Items.Add(row["Pozisyonadi"]);
            }
        }
        public void CalisanVerileriYukle()
        {
            DataTable dt = calisanRepo.CalisanlariListele();
            calisanlardata.DataSource = dt;
        }

        public void PozisyonVerileriYukle()
        {
            DataTable dt = calisanRepo.PozisyonlariListele();
            pozisyonlardata.DataSource = dt;
        }

        public void TextBoxTemizle()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
            }
        }

        private void pozisyonkaydet_Click(object sender, EventArgs e)
        {

            calisanRepo.PozisyonEkle(pozisyonadıtxtbox.Text);
            MessageBox.Show("Pozisyon başarıyla eklendi");
            PozisyonVerileriYukle();
            Pozisyoncombobox(pozisyonbox);
        }

        private void calisanlardata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void CalisanlarEkrani_Load(object sender, EventArgs e)
        {
        }
       
        private void geridonbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
