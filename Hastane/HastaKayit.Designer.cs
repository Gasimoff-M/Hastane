namespace Hastane
{
    partial class HastaKayit
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
            label3 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtAd = new TextBox();
            txtSoyAd = new TextBox();
            mskTc = new MaskedTextBox();
            mskTel = new MaskedTextBox();
            txtSifre = new TextBox();
            cmbCinsiyyet = new ComboBox();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Constantia", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.FromArgb(5, 69, 99);
            label3.Location = new Point(46, 32);
            label3.Name = "label3";
            label3.Size = new Size(435, 58);
            label3.TabIndex = 1;
            label3.Text = "Hasta Kayıt Paneli";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label3);
            panel1.Location = new Point(-6, -8);
            panel1.Name = "panel1";
            panel1.Size = new Size(526, 123);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(162, 143);
            label1.Name = "label1";
            label1.Size = new Size(64, 35);
            label1.TabIndex = 3;
            label1.Text = "Ad :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(126, 197);
            label2.Name = "label2";
            label2.Size = new Size(100, 35);
            label2.TabIndex = 4;
            label2.Text = "Soyad :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(32, 251);
            label4.Name = "label4";
            label4.Size = new Size(194, 35);
            label4.TabIndex = 5;
            label4.Text = "TC Kimlik No :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.Location = new Point(108, 305);
            label5.Name = "label5";
            label5.Size = new Size(118, 35);
            label5.TabIndex = 6;
            label5.Text = "Telefon :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.Location = new Point(143, 414);
            label6.Name = "label6";
            label6.Size = new Size(83, 35);
            label6.TabIndex = 7;
            label6.Text = "Şifre :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.Location = new Point(88, 357);
            label7.Name = "label7";
            label7.Size = new Size(138, 35);
            label7.TabIndex = 8;
            label7.Text = "Cinsiyyet :";
            // 
            // txtAd
            // 
            txtAd.Font = new Font("Constantia", 13.8F);
            txtAd.Location = new Point(232, 141);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(203, 36);
            txtAd.TabIndex = 9;
            // 
            // txtSoyAd
            // 
            txtSoyAd.Font = new Font("Constantia", 13.8F);
            txtSoyAd.Location = new Point(232, 195);
            txtSoyAd.Name = "txtSoyAd";
            txtSoyAd.Size = new Size(203, 36);
            txtSoyAd.TabIndex = 10;
            // 
            // mskTc
            // 
            mskTc.Font = new Font("Constantia", 13.8F);
            mskTc.Location = new Point(232, 249);
            mskTc.Mask = "00000000000";
            mskTc.Name = "mskTc";
            mskTc.Size = new Size(203, 36);
            mskTc.TabIndex = 11;
            mskTc.ValidatingType = typeof(int);
            // 
            // mskTel
            // 
            mskTel.Font = new Font("Constantia", 13.8F);
            mskTel.Location = new Point(232, 303);
            mskTel.Mask = "(999) 000-0000";
            mskTel.Name = "mskTel";
            mskTel.Size = new Size(203, 36);
            mskTel.TabIndex = 12;
            // 
            // txtSifre
            // 
            txtSifre.Font = new Font("Constantia", 13.8F);
            txtSifre.Location = new Point(232, 412);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(203, 36);
            txtSifre.TabIndex = 13;
            // 
            // cmbCinsiyyet
            // 
            cmbCinsiyyet.Font = new Font("Constantia", 13.8F);
            cmbCinsiyyet.FormattingEnabled = true;
            cmbCinsiyyet.Items.AddRange(new object[] { "Erkek", "Kadın" });
            cmbCinsiyyet.Location = new Point(232, 355);
            cmbCinsiyyet.Name = "cmbCinsiyyet";
            cmbCinsiyyet.Size = new Size(203, 36);
            cmbCinsiyyet.TabIndex = 14;
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.Location = new Point(232, 456);
            button1.Name = "button1";
            button1.Size = new Size(203, 47);
            button1.TabIndex = 15;
            button1.Text = "Kayıt Yap";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // HastaKayit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(513, 534);
            Controls.Add(button1);
            Controls.Add(cmbCinsiyyet);
            Controls.Add(txtSifre);
            Controls.Add(mskTel);
            Controls.Add(mskTc);
            Controls.Add(txtSoyAd);
            Controls.Add(txtAd);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "HastaKayit";
            Text = "HastaKayit";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtAd;
        private TextBox txtSoyAd;
        private MaskedTextBox mskTc;
        private MaskedTextBox mskTel;
        private TextBox txtSifre;
        private ComboBox cmbCinsiyyet;
        private Button button1;
    }
}