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
            panel3.SuspendLayout();
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
            // ProjelerEkrani
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1338, 734);
            Controls.Add(panel4);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProjelerEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Projeler Ekrani";
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Button geridonbtn;
        private Panel panel4;
    }
}