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
        private readonly ProjelerRepository repo1 = new ProjelerRepository();
        public ProjelerEkrani()
        {
            InitializeComponent();
            ProjeleriYukle();
        }

        private void ProjelerEkrani_Load(object sender, EventArgs e)
        {

        }
        private void projeeklebtn_Click(object sender, EventArgs e)
        {
            int? musteriID = int.TryParse(musteriidtxtbox.Text, out int id) ? id : (int?)null;
            repo1.ProjeEkle(projeaditxtbox.Text,aciklamatxtbox.Text,btarihidate.Text,bitistarihidate.Text,musteriID);
            ProjeleriYukle();
            MessageBox.Show("Proje Başarıyla eklendi!");
        }
        private void geridonbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void ProjeleriYukle()
        {
            DataTable dtt = repo1.ProjeleriListele();
            projelerdata.DataSource = dtt;
        }

        
    }
}
