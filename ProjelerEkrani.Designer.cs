namespace IsYonetimSistemi
{
    partial class ProjelerEkrani
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel3 = new Panel();
            geridonbtn = new Button();
            panel4 = new Panel();
            panel1 = new Panel();
            projeaditxtbox = new TextBox();
            projeeklebtn = new Button();
            musteriidtxtbox = new TextBox();
            bitistarihidate = new DateTimePicker();
            btarihidate = new DateTimePicker();
            aciklamatxtbox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            projeatamabtn = new Button();
            atarihidate = new DateTimePicker();
            rolbox = new ComboBox();
            projebox = new ComboBox();
            calisanbox = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            projelerdata = new DataGridView();
            dataGridView2 = new DataGridView();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)projelerdata).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.sidepanel1;
            panel3.Controls.Add(geridonbtn);
            panel3.Location = new Point(0, 58);
            panel3.Name = "panel3";
            panel3.Size = new Size(183, 678);
            panel3.TabIndex = 18;
            // 
            // geridonbtn
            // 
            geridonbtn.BackColor = Color.Transparent;
            geridonbtn.BackgroundImage = Properties.Resources.button;
            geridonbtn.FlatStyle = FlatStyle.Flat;
            geridonbtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            geridonbtn.Location = new Point(35, 87);
            geridonbtn.Name = "geridonbtn";
            geridonbtn.Size = new Size(115, 40);
            geridonbtn.TabIndex = 16;
            geridonbtn.UseVisualStyleBackColor = false;
            geridonbtn.Click += geridonbtn_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.BackgroundImage = Properties.Resources.Projeler;
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1338, 58);
            panel4.TabIndex = 19;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(projeaditxtbox);
            panel1.Controls.Add(projeeklebtn);
            panel1.Controls.Add(musteriidtxtbox);
            panel1.Controls.Add(bitistarihidate);
            panel1.Controls.Add(btarihidate);
            panel1.Controls.Add(aciklamatxtbox);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(256, 119);
            panel1.Name = "panel1";
            panel1.Size = new Size(409, 294);
            panel1.TabIndex = 20;
            // 
            // projeaditxtbox
            // 
            projeaditxtbox.Location = new Point(167, 30);
            projeaditxtbox.Name = "projeaditxtbox";
            projeaditxtbox.Size = new Size(194, 23);
            projeaditxtbox.TabIndex = 21;
            // 
            // projeeklebtn
            // 
            projeeklebtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            projeeklebtn.Location = new Point(167, 230);
            projeeklebtn.Name = "projeeklebtn";
            projeeklebtn.Size = new Size(194, 37);
            projeeklebtn.TabIndex = 20;
            projeeklebtn.Text = "Kaydet";
            projeeklebtn.UseVisualStyleBackColor = true;
            projeeklebtn.Click += projeeklebtn_Click;
            // 
            // musteriidtxtbox
            // 
            musteriidtxtbox.Location = new Point(167, 190);
            musteriidtxtbox.Multiline = true;
            musteriidtxtbox.Name = "musteriidtxtbox";
            musteriidtxtbox.Size = new Size(194, 21);
            musteriidtxtbox.TabIndex = 18;
            // 
            // bitistarihidate
            // 
            bitistarihidate.Location = new Point(167, 150);
            bitistarihidate.Name = "bitistarihidate";
            bitistarihidate.Size = new Size(194, 23);
            bitistarihidate.TabIndex = 17;
            // 
            // btarihidate
            // 
            btarihidate.Location = new Point(167, 110);
            btarihidate.Name = "btarihidate";
            btarihidate.Size = new Size(194, 23);
            btarihidate.TabIndex = 16;
            // 
            // aciklamatxtbox
            // 
            aciklamatxtbox.Location = new Point(167, 70);
            aciklamatxtbox.Multiline = true;
            aciklamatxtbox.Name = "aciklamatxtbox";
            aciklamatxtbox.Size = new Size(194, 21);
            aciklamatxtbox.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.Location = new Point(45, 190);
            label5.Name = "label5";
            label5.Size = new Size(80, 21);
            label5.TabIndex = 13;
            label5.Text = "Müşteri id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(46, 152);
            label4.Name = "label4";
            label4.Size = new Size(79, 21);
            label4.TabIndex = 12;
            label4.Text = "Bitiş tarihi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(45, 112);
            label3.Name = "label3";
            label3.Size = new Size(115, 21);
            label3.TabIndex = 11;
            label3.Text = "Başlangıç tarihi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(46, 70);
            label2.Name = "label2";
            label2.Size = new Size(73, 21);
            label2.TabIndex = 10;
            label2.Text = "Açıklama";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(46, 32);
            label1.Name = "label1";
            label1.Size = new Size(71, 21);
            label1.TabIndex = 9;
            label1.Text = "Proje adı";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Controls.Add(projeatamabtn);
            panel2.Controls.Add(atarihidate);
            panel2.Controls.Add(rolbox);
            panel2.Controls.Add(projebox);
            panel2.Controls.Add(calisanbox);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(256, 482);
            panel2.Name = "panel2";
            panel2.Size = new Size(409, 240);
            panel2.TabIndex = 21;
            // 
            // projeatamabtn
            // 
            projeatamabtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            projeatamabtn.Location = new Point(167, 200);
            projeatamabtn.Name = "projeatamabtn";
            projeatamabtn.Size = new Size(194, 37);
            projeatamabtn.TabIndex = 22;
            projeatamabtn.Text = "Kaydet";
            projeatamabtn.UseVisualStyleBackColor = true;
            // 
            // atarihidate
            // 
            atarihidate.Location = new Point(167, 160);
            atarihidate.Name = "atarihidate";
            atarihidate.Size = new Size(194, 23);
            atarihidate.TabIndex = 31;
            // 
            // rolbox
            // 
            rolbox.FormattingEnabled = true;
            rolbox.Location = new Point(167, 120);
            rolbox.Name = "rolbox";
            rolbox.Size = new Size(194, 23);
            rolbox.TabIndex = 30;
            // 
            // projebox
            // 
            projebox.FormattingEnabled = true;
            projebox.Location = new Point(167, 80);
            projebox.Name = "projebox";
            projebox.Size = new Size(194, 23);
            projebox.TabIndex = 29;
            // 
            // calisanbox
            // 
            calisanbox.FormattingEnabled = true;
            calisanbox.Location = new Point(167, 40);
            calisanbox.Name = "calisanbox";
            calisanbox.Size = new Size(194, 23);
            calisanbox.TabIndex = 28;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label9.Location = new Point(46, 162);
            label9.Name = "label9";
            label9.Size = new Size(95, 21);
            label9.TabIndex = 27;
            label9.Text = "Atama tarihi";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label8.Location = new Point(46, 122);
            label8.Name = "label8";
            label8.Size = new Size(33, 21);
            label8.TabIndex = 26;
            label8.Text = "Rol";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.Location = new Point(45, 42);
            label7.Name = "label7";
            label7.Size = new Size(108, 21);
            label7.TabIndex = 25;
            label7.Text = "Çalışan seçimi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.Location = new Point(46, 82);
            label6.Name = "label6";
            label6.Size = new Size(46, 21);
            label6.TabIndex = 24;
            label6.Text = "Proje";
            // 
            // projelerdata
            // 
            projelerdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            projelerdata.Location = new Point(681, 119);
            projelerdata.Name = "projelerdata";
            projelerdata.Size = new Size(645, 294);
            projelerdata.TabIndex = 22;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(681, 482);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(645, 240);
            dataGridView2.TabIndex = 23;
            // 
            // ProjelerEkrani
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1338, 734);
            Controls.Add(dataGridView2);
            Controls.Add(projelerdata);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProjelerEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Projeler Ekrani";
            Load += ProjelerEkrani_Load;
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)projelerdata).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Button geridonbtn;
        private Panel panel4;
        private Panel panel1;
        private Panel panel2;
        private DataGridView projelerdata;
        private DataGridView dataGridView2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox musteriidtxtbox;
        private DateTimePicker bitistarihidate;
        private DateTimePicker btarihidate;
        private TextBox aciklamatxtbox;
        private Button projeeklebtn;
        private TextBox projeaditxtbox;
        private Label label6;
        private Label label9;
        private Label label8;
        private Label label7;
        private DateTimePicker atarihidate;
        private ComboBox rolbox;
        private ComboBox projebox;
        private ComboBox calisanbox;
        private Button projeatamabtn;
    }
}