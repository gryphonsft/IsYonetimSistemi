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

        private CalisanlarRepository repo;
        public CalisanlarEkrani()
        {
            InitializeComponent();
            repo = new CalisanlarRepository();
            Pozisyoncombobox(pozisyonbox);
            CalisanVerileriYukle();
            PozisyonVerileriYukle();
        }


        private void kaydetbtn_Click(object sender, EventArgs e)
        {
            CalisanlarRepository repo = new CalisanlarRepository();

            int cinsiyet = 0;

            if (erkekradio.Checked)
            {
                cinsiyet = 1;
            }
            else if (kadinradio.Checked)
            {
                cinsiyet = 2;
            }


            repo.CalisanEkle(adtxtbox.Text, pozisyonbox.Text, maastext.Text, telefonbox.Text, datebox.Text, cinsiyet);

            CalisanVerileriYukle();
            //  TextBoxTemizle();
            MessageBox.Show("Çalışan başarıyla eklendi!");
        }
        public void Pozisyoncombobox(ComboBox comboBox)
        {
            DataTable dt = repo.PozisyonlariYukle();
            pozisyonbox.Items.Clear();

            foreach (DataRow row in dt.Rows)
            {
                pozisyonbox.Items.Add(row["Pozisyonadi"].ToString());
            }
        }
        public void CalisanVerileriYukle()
        {
            DataTable dt = repo.CalisanlariYukle();
            calisanlardata.DataSource = dt;
        }

        public void PozisyonVerileriYukle()
        {
            DataTable dt = repo.PozisyonlariYukle();
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
            CalisanlarRepository repo = new CalisanlarRepository();
            repo.PozisyonEkle(pozisyonadıtxtbox.Text);
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
        public void calisanlariYukle()
        {
            CalisanlarRepository repo = new CalisanlarRepository();
            repo.CalisanlariYukle();
        }
        public void pozisyonlariYukle()
        {
            CalisanlarRepository repo = new CalisanlarRepository();
            repo.PozisyonlariYukle();
        }

        private void geridonbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
