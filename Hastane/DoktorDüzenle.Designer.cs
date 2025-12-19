namespace Hastane
{
    partial class DoktorDüzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoktorDüzenle));
            button1 = new Button();
            cmbBrans = new ComboBox();
            txtSifre = new TextBox();
            mskTC = new MaskedTextBox();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            label7 = new Label();
            label6 = new Label();
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
            button1.Location = new Point(216, 424);
            button1.Name = "button1";
            button1.Size = new Size(203, 47);
            button1.TabIndex = 43;
            button1.Text = "Düzenle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // cmbBrans
            // 
            cmbBrans.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cmbBrans.FormattingEnabled = true;
            cmbBrans.Location = new Point(216, 323);
            cmbBrans.Name = "cmbBrans";
            cmbBrans.Size = new Size(203, 39);
            cmbBrans.TabIndex = 42;
            // 
            // txtSifre
            // 
            txtSifre.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtSifre.Location = new Point(216, 380);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(203, 38);
            txtSifre.TabIndex = 41;
            // 
            // mskTC
            // 
            mskTC.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            mskTC.Location = new Point(216, 269);
            mskTC.Mask = "00000000000";
            mskTC.Name = "mskTC";
            mskTC.Size = new Size(203, 38);
            mskTC.TabIndex = 39;
            // 
            // txtSoyad
            // 
            txtSoyad.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtSoyad.Location = new Point(216, 215);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(203, 38);
            txtSoyad.TabIndex = 38;
            // 
            // txtAd
            // 
            txtAd.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtAd.Location = new Point(216, 161);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(203, 38);
            txtAd.TabIndex = 37;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.Location = new Point(110, 325);
            label7.Name = "label7";
            label7.Size = new Size(96, 35);
            label7.TabIndex = 36;
            label7.Text = "Branş :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.Location = new Point(127, 382);
            label6.Name = "label6";
            label6.Size = new Size(83, 35);
            label6.TabIndex = 35;
            label6.Text = "Şifre :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(16, 271);
            label4.Name = "label4";
            label4.Size = new Size(194, 35);
            label4.TabIndex = 33;
            label4.Text = "TC Kimlik No :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(110, 217);
            label2.Name = "label2";
            label2.Size = new Size(100, 35);
            label2.TabIndex = 32;
            label2.Text = "Soyad :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(146, 163);
            label1.Name = "label1";
            label1.Size = new Size(64, 35);
            label1.TabIndex = 31;
            label1.Text = "Ad :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label3);
            panel1.Location = new Point(-22, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(619, 123);
            panel1.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Constantia", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.FromArgb(5, 69, 99);
            label3.Location = new Point(20, 32);
            label3.Name = "label3";
            label3.Size = new Size(593, 58);
            label3.TabIndex = 1;
            label3.Text = "Doktor Düzenleme Paneli";
            // 
            // DoktorDüzenle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.LightBlue;
            ClientSize = new Size(592, 508);
            Controls.Add(button1);
            Controls.Add(cmbBrans);
            Controls.Add(txtSifre);
            Controls.Add(mskTC);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "DoktorDüzenle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Doktor Düzenle";
            Load += DoktorDüzenle_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ComboBox cmbBrans;
        private TextBox txtSifre;
        private MaskedTextBox mskTC;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Label label3;
    }
}