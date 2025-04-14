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
            exitbtn = new Button();
            pictureBox1 = new PictureBox();
            calisansayisi = new Label();
            label1 = new Label();
            calisanlarbtn = new Button();
            havadurumu = new Label();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(90, 59, 153);
            panel1.Controls.Add(exitbtn);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(calisansayisi);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(calisanlarbtn);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(171, 577);
            panel1.TabIndex = 0;
            // 
            // exitbtn
            // 
            exitbtn.BackColor = Color.White;
            exitbtn.FlatStyle = FlatStyle.Flat;
            exitbtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            exitbtn.Location = new Point(3, 521);
            exitbtn.Name = "exitbtn";
            exitbtn.Size = new Size(165, 44);
            exitbtn.TabIndex = 2;
            exitbtn.Text = "Çıkış";
            exitbtn.UseVisualStyleBackColor = false;
            exitbtn.Click += exitbtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.employee;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // calisansayisi
            // 
            calisansayisi.AutoSize = true;
            calisansayisi.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            calisansayisi.Location = new Point(82, 33);
            calisansayisi.Name = "calisansayisi";
            calisansayisi.Size = new Size(17, 20);
            calisansayisi.TabIndex = 0;
            calisansayisi.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(45, 8);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 4;
            label1.Text = "Çalışan Sayısı :";
            // 
            // calisanlarbtn
            // 
            calisanlarbtn.BackColor = Color.White;
            calisanlarbtn.FlatStyle = FlatStyle.Flat;
            calisanlarbtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            calisanlarbtn.Location = new Point(3, 59);
            calisanlarbtn.Name = "calisanlarbtn";
            calisanlarbtn.Size = new Size(165, 44);
            calisanlarbtn.TabIndex = 0;
            calisanlarbtn.Text = "Çalışanlar";
            calisanlarbtn.UseVisualStyleBackColor = false;
            calisanlarbtn.Click += calisanlarbtn_Click;
            // 
            // havadurumu
            // 
            havadurumu.AutoSize = true;
            havadurumu.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            havadurumu.Location = new Point(856, 9);
            havadurumu.Name = "havadurumu";
            havadurumu.Size = new Size(12, 20);
            havadurumu.TabIndex = 5;
            havadurumu.Text = ".";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.cloudy;
            pictureBox2.Location = new Point(805, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(45, 63);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(987, 577);
            Controls.Add(pictureBox2);
            Controls.Add(havadurumu);
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
            ResumeLayout(false);
            PerformLayout();
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
    }
}
