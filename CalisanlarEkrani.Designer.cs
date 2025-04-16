namespace IsYonetimSistemi
{
    partial class CalisanlarEkrani
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
            panel1 = new Panel();
            kaydetbtn = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            kadinradio = new RadioButton();
            erkekradio = new RadioButton();
            datebox = new DateTimePicker();
            pozisyonbox = new ComboBox();
            telefonbox = new TextBox();
            maastext = new TextBox();
            adtxtbox = new TextBox();
            calisanlardata = new DataGridView();
            panel2 = new Panel();
            pozisyonkaydet = new Button();
            label7 = new Label();
            pozisyonadıtxtbox = new TextBox();
            pozisyonlardata = new DataGridView();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            geridonbtn = new Button();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)calisanlardata).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pozisyonlardata).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(kaydetbtn);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(kadinradio);
            panel1.Controls.Add(erkekradio);
            panel1.Controls.Add(datebox);
            panel1.Controls.Add(pozisyonbox);
            panel1.Controls.Add(telefonbox);
            panel1.Controls.Add(maastext);
            panel1.Controls.Add(adtxtbox);
            panel1.Location = new Point(256, 119);
            panel1.Name = "panel1";
            panel1.Size = new Size(409, 294);
            panel1.TabIndex = 0;
            // 
            // kaydetbtn
            // 
            kaydetbtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            kaydetbtn.Location = new Point(183, 229);
            kaydetbtn.Name = "kaydetbtn";
            kaydetbtn.Size = new Size(194, 37);
            kaydetbtn.TabIndex = 14;
            kaydetbtn.Text = "Kaydet";
            kaydetbtn.UseVisualStyleBackColor = true;
            kaydetbtn.Click += kaydetbtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.Location = new Point(75, 197);
            label6.Name = "label6";
            label6.Size = new Size(65, 21);
            label6.TabIndex = 13;
            label6.Text = "Cinsiyet";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.Location = new Point(75, 160);
            label5.Name = "label5";
            label5.Size = new Size(82, 21);
            label5.TabIndex = 12;
            label5.Text = "Giriş tarihi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(75, 131);
            label4.Name = "label4";
            label4.Size = new Size(59, 21);
            label4.TabIndex = 11;
            label4.Text = "Telefon";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(75, 102);
            label3.Name = "label3";
            label3.Size = new Size(47, 21);
            label3.TabIndex = 10;
            label3.Text = "Maaş";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(75, 73);
            label2.Name = "label2";
            label2.Size = new Size(71, 21);
            label2.TabIndex = 9;
            label2.Text = "Pozisyon";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(75, 44);
            label1.Name = "label1";
            label1.Size = new Size(82, 21);
            label1.TabIndex = 8;
            label1.Text = "Adı soyadı";
            // 
            // kadinradio
            // 
            kadinradio.AutoSize = true;
            kadinradio.Location = new Point(291, 200);
            kadinradio.Name = "kadinradio";
            kadinradio.Size = new Size(55, 19);
            kadinradio.TabIndex = 7;
            kadinradio.TabStop = true;
            kadinradio.Text = "Kadın";
            kadinradio.UseVisualStyleBackColor = true;
            // 
            // erkekradio
            // 
            erkekradio.AutoSize = true;
            erkekradio.Location = new Point(212, 200);
            erkekradio.Name = "erkekradio";
            erkekradio.Size = new Size(53, 19);
            erkekradio.TabIndex = 6;
            erkekradio.TabStop = true;
            erkekradio.Text = "Erkek";
            erkekradio.UseVisualStyleBackColor = true;
            // 
            // datebox
            // 
            datebox.Location = new Point(183, 158);
            datebox.Name = "datebox";
            datebox.Size = new Size(194, 23);
            datebox.TabIndex = 5;
            // 
            // pozisyonbox
            // 
            pozisyonbox.FormattingEnabled = true;
            pozisyonbox.Location = new Point(183, 71);
            pozisyonbox.Name = "pozisyonbox";
            pozisyonbox.Size = new Size(194, 23);
            pozisyonbox.TabIndex = 4;
            // 
            // telefonbox
            // 
            telefonbox.Location = new Point(183, 129);
            telefonbox.Multiline = true;
            telefonbox.Name = "telefonbox";
            telefonbox.Size = new Size(194, 23);
            telefonbox.TabIndex = 3;
            // 
            // maastext
            // 
            maastext.Location = new Point(183, 100);
            maastext.Multiline = true;
            maastext.Name = "maastext";
            maastext.Size = new Size(194, 23);
            maastext.TabIndex = 2;
            // 
            // adtxtbox
            // 
            adtxtbox.Location = new Point(183, 44);
            adtxtbox.Multiline = true;
            adtxtbox.Name = "adtxtbox";
            adtxtbox.Size = new Size(194, 23);
            adtxtbox.TabIndex = 0;
            // 
            // calisanlardata
            // 
            calisanlardata.BackgroundColor = Color.Silver;
            calisanlardata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            calisanlardata.Location = new Point(681, 119);
            calisanlardata.Name = "calisanlardata";
            calisanlardata.Size = new Size(645, 292);
            calisanlardata.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Controls.Add(pozisyonkaydet);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(pozisyonadıtxtbox);
            panel2.Location = new Point(256, 482);
            panel2.Name = "panel2";
            panel2.Size = new Size(409, 240);
            panel2.TabIndex = 2;
            // 
            // pozisyonkaydet
            // 
            pozisyonkaydet.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            pozisyonkaydet.Location = new Point(183, 129);
            pozisyonkaydet.Name = "pozisyonkaydet";
            pozisyonkaydet.Size = new Size(194, 37);
            pozisyonkaydet.TabIndex = 15;
            pozisyonkaydet.Text = "Kaydet";
            pozisyonkaydet.UseVisualStyleBackColor = true;
            pozisyonkaydet.Click += pozisyonkaydet_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.Location = new Point(75, 66);
            label7.Name = "label7";
            label7.Size = new Size(96, 21);
            label7.TabIndex = 15;
            label7.Text = "Pozisyon adı";
            // 
            // pozisyonadıtxtbox
            // 
            pozisyonadıtxtbox.Location = new Point(183, 64);
            pozisyonadıtxtbox.Name = "pozisyonadıtxtbox";
            pozisyonadıtxtbox.Size = new Size(194, 23);
            pozisyonadıtxtbox.TabIndex = 0;
            // 
            // pozisyonlardata
            // 
            pozisyonlardata.BackgroundColor = Color.Silver;
            pozisyonlardata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pozisyonlardata.Location = new Point(681, 482);
            pozisyonlardata.Name = "pozisyonlardata";
            pozisyonlardata.Size = new Size(244, 240);
            pozisyonlardata.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.employee;
            pictureBox1.Location = new Point(614, 71);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.jobs;
            pictureBox2.Location = new Point(614, 422);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(51, 59);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
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
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.sidepanel1;
            panel3.Controls.Add(geridonbtn);
            panel3.Location = new Point(0, 58);
            panel3.Name = "panel3";
            panel3.Size = new Size(183, 678);
            panel3.TabIndex = 17;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.BackgroundImage = Properties.Resources.Çalışanlar1;
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1338, 58);
            panel4.TabIndex = 18;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Transparent;
            panel5.BackgroundImage = Properties.Resources.calisanlabel;
            panel5.BackgroundImageLayout = ImageLayout.Center;
            panel5.Location = new Point(256, 64);
            panel5.Name = "panel5";
            panel5.Size = new Size(313, 53);
            panel5.TabIndex = 19;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Transparent;
            panel6.BackgroundImage = Properties.Resources.pozisyonlabel;
            panel6.BackgroundImageLayout = ImageLayout.Center;
            panel6.Location = new Point(256, 422);
            panel6.Name = "panel6";
            panel6.Size = new Size(313, 54);
            panel6.TabIndex = 20;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Transparent;
            panel7.BackgroundImage = Properties.Resources.calisanlistesilabel;
            panel7.BackgroundImageLayout = ImageLayout.Center;
            panel7.Location = new Point(681, 64);
            panel7.Name = "panel7";
            panel7.Size = new Size(313, 53);
            panel7.TabIndex = 20;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Transparent;
            panel8.BackgroundImage = Properties.Resources.pozisyonlistesilabel;
            panel8.BackgroundImageLayout = ImageLayout.Center;
            panel8.Location = new Point(681, 422);
            panel8.Name = "panel8";
            panel8.Size = new Size(244, 54);
            panel8.TabIndex = 21;
            // 
            // CalisanlarEkrani
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1338, 734);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(pictureBox2);
            Controls.Add(pozisyonlardata);
            Controls.Add(panel2);
            Controls.Add(calisanlardata);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CalisanlarEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CalisanlarEkrani";
            Load += CalisanlarEkrani_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)calisanlardata).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pozisyonlardata).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private RadioButton kadinradio;
        private RadioButton erkekradio;
        private DateTimePicker datebox;
        private ComboBox pozisyonbox;
        private TextBox telefonbox;
        private TextBox maastext;
        private TextBox adtxtbox;
        private Button kaydetbtn;
        private DataGridView calisanlardata;
        private Panel panel2;
        private Button pozisyonkaydet;
        private Label label7;
        private TextBox pozisyonadıtxtbox;
        private DataGridView pozisyonlardata;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button geridonbtn;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
    }
}