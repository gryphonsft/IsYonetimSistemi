namespace IsYonetimSistemi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            projelerbtn = new Button();
            exitbtn = new Button();
            pictureBox1 = new PictureBox();
            calisansayisi = new Label();
            label1 = new Label();
            calisanlarbtn = new Button();
            havadurumu = new Label();
            pictureBox2 = new PictureBox();
            saveFileDialog1 = new SaveFileDialog();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(90, 59, 153);
            panel1.Controls.Add(projelerbtn);
            panel1.Controls.Add(exitbtn);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(calisansayisi);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(calisanlarbtn);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(203, 577);
            panel1.TabIndex = 0;
            // 
            // projelerbtn
            // 
            projelerbtn.BackColor = Color.Transparent;
            projelerbtn.BackgroundImage = Properties.Resources.projelerr;
            projelerbtn.FlatStyle = FlatStyle.Flat;
            projelerbtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            projelerbtn.Location = new Point(12, 156);
            projelerbtn.Name = "projelerbtn";
            projelerbtn.Size = new Size(165, 44);
            projelerbtn.TabIndex = 7;
            projelerbtn.UseVisualStyleBackColor = false;
            projelerbtn.Click += projelerbtn_Click;
            // 
            // exitbtn
            // 
            exitbtn.BackColor = Color.Transparent;
            exitbtn.BackgroundImage = Properties.Resources.cikis;
            exitbtn.FlatStyle = FlatStyle.Flat;
            exitbtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            exitbtn.Location = new Point(12, 521);
            exitbtn.Name = "exitbtn";
            exitbtn.Size = new Size(165, 44);
            exitbtn.TabIndex = 2;
            exitbtn.UseVisualStyleBackColor = false;
            exitbtn.Click += exitbtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.employee;
            pictureBox1.Location = new Point(12, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // calisansayisi
            // 
            calisansayisi.AutoSize = true;
            calisansayisi.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            calisansayisi.Location = new Point(153, 30);
            calisansayisi.Name = "calisansayisi";
            calisansayisi.Size = new Size(15, 17);
            calisansayisi.TabIndex = 0;
            calisansayisi.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(54, 32);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 4;
            label1.Text = "Çalışan Sayısı :";
            // 
            // calisanlarbtn
            // 
            calisanlarbtn.BackColor = Color.Transparent;
            calisanlarbtn.BackgroundImage = Properties.Resources.calisanlar;
            calisanlarbtn.FlatStyle = FlatStyle.Flat;
            calisanlarbtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            calisanlarbtn.Location = new Point(12, 92);
            calisanlarbtn.Name = "calisanlarbtn";
            calisanlarbtn.Size = new Size(165, 44);
            calisanlarbtn.TabIndex = 0;
            calisanlarbtn.UseVisualStyleBackColor = false;
            calisanlarbtn.Click += calisanlarbtn_Click;
            // 
            // havadurumu
            // 
            havadurumu.AutoSize = true;
            havadurumu.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            havadurumu.ForeColor = Color.White;
            havadurumu.Location = new Point(672, 92);
            havadurumu.Name = "havadurumu";
            havadurumu.Size = new Size(12, 20);
            havadurumu.TabIndex = 5;
            havadurumu.Text = ".";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.cloudy;
            pictureBox2.Location = new Point(672, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(45, 63);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = Properties.Resources.wallpaper4;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(havadurumu);
            panel2.Controls.Add(pictureBox2);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(201, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(786, 577);
            panel2.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 237, 237);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(987, 577);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button calisanlarbtn;
        private Button exitbtn;
        private Label calisansayisi;
        private Label label1;
        private Label havadurumu;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private SaveFileDialog saveFileDialog1;
        private Button projelerbtn;
        private Panel panel2;
    }
}
