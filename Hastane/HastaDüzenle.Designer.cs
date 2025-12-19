namespace Hastane
{
    partial class HastaDüzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastaDüzenle));
            button1 = new Button();
            cmbCinsiyyet = new ComboBox();
            txtSifre = new TextBox();
            mskTel = new MaskedTextBox();
            mskTCno = new MaskedTextBox();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.Location = new Point(231, 463);
            button1.Name = "button1";
            button1.Size = new Size(203, 47);
            button1.TabIndex = 29;
            button1.Text = "Düzenle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // cmbCinsiyyet
            // 
            cmbCinsiyyet.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cmbCinsiyyet.FormattingEnabled = true;
            cmbCinsiyyet.Location = new Point(231, 365);
            cmbCinsiyyet.Name = "cmbCinsiyyet";
            cmbCinsiyyet.Size = new Size(203, 39);
            cmbCinsiyyet.TabIndex = 28;
            // 
            // txtSifre
            // 
            txtSifre.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtSifre.Location = new Point(231, 419);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(203, 38);
            txtSifre.TabIndex = 27;
            // 
            // mskTel
            // 
            mskTel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            mskTel.Location = new Point(231, 310);
            mskTel.Mask = "(999) 000-0000";
            mskTel.Name = "mskTel";
            mskTel.Size = new Size(203, 38);
            mskTel.TabIndex = 26;
            // 
            // mskTCno
            // 
            mskTCno.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            mskTCno.Location = new Point(231, 256);
            mskTCno.Mask = "00000000000";
            mskTCno.Name = "mskTCno";
            mskTCno.Size = new Size(203, 38);
            mskTCno.TabIndex = 25;
            // 
            // txtSoyad
            // 
            txtSoyad.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtSoyad.Location = new Point(231, 202);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(203, 38);
            txtSoyad.TabIndex = 24;
            // 
            // txtAd
            // 
            txtAd.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtAd.Location = new Point(231, 148);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(203, 38);
            txtAd.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.Location = new Point(87, 367);
            label7.Name = "label7";
            label7.Size = new Size(138, 35);
            label7.TabIndex = 22;
            label7.Text = "Cinsiyyet :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.Location = new Point(142, 422);
            label6.Name = "label6";
            label6.Size = new Size(83, 35);
            label6.TabIndex = 21;
            label6.Text = "Şifre :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.Location = new Point(107, 312);
            label5.Name = "label5";
            label5.Size = new Size(118, 35);
            label5.TabIndex = 20;
            label5.Text = "Telefon :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(31, 258);
            label4.Name = "label4";
            label4.Size = new Size(194, 35);
            label4.TabIndex = 19;
            label4.Text = "TC Kimlik No :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(125, 204);
            label2.Name = "label2";
            label2.Size = new Size(100, 35);
            label2.TabIndex = 18;
            label2.Text = "Soyad :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(161, 150);
            label1.Name = "label1";
            label1.Size = new Size(64, 35);
            label1.TabIndex = 17;
            label1.Text = "Ad :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label3);
            panel1.Location = new Point(-7, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(573, 123);
            panel1.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Constantia", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.FromArgb(5, 69, 99);
            label3.Location = new Point(4, 32);
            label3.Name = "label3";
            label3.Size = new Size(565, 58);
            label3.TabIndex = 1;
            label3.Text = "Hasta Düzenleme Paneli";
            // 
            // HastaDüzenle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.LightBlue;
            ClientSize = new Size(558, 534);
            Controls.Add(button1);
            Controls.Add(cmbCinsiyyet);
            Controls.Add(txtSifre);
            Controls.Add(mskTel);
            Controls.Add(mskTCno);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "HastaDüzenle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hasta Bilgi Düzenle";
            Load += HastaDüzenle_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ComboBox cmbCinsiyyet;
        private TextBox txtSifre;
        private MaskedTextBox mskTel;
        private MaskedTextBox mskTCno;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Label label3;
    }
}