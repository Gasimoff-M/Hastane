namespace Hastane
{
    partial class DoktorPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoktorPaneli));
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            btnEkle = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cmbBrans
            // 
            cmbBrans.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cmbBrans.FormattingEnabled = true;
            cmbBrans.Location = new Point(135, 193);
            cmbBrans.Name = "cmbBrans";
            cmbBrans.Size = new Size(203, 39);
            cmbBrans.TabIndex = 4;
            // 
            // txtSifre
            // 
            txtSifre.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtSifre.Location = new Point(135, 250);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(203, 38);
            txtSifre.TabIndex = 5;
            // 
            // mskTC
            // 
            mskTC.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            mskTC.Location = new Point(135, 139);
            mskTC.Mask = "00000000000";
            mskTC.Name = "mskTC";
            mskTC.Size = new Size(203, 38);
            mskTC.TabIndex = 3;
            // 
            // txtSoyad
            // 
            txtSoyad.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtSoyad.Location = new Point(135, 85);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(203, 38);
            txtSoyad.TabIndex = 2;
            // 
            // txtAd
            // 
            txtAd.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtAd.Location = new Point(135, 31);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(203, 38);
            txtAd.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.Location = new Point(29, 195);
            label7.Name = "label7";
            label7.Size = new Size(96, 35);
            label7.TabIndex = 47;
            label7.Text = "Branş :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.Location = new Point(46, 252);
            label6.Name = "label6";
            label6.Size = new Size(83, 35);
            label6.TabIndex = 46;
            label6.Text = "Şifre :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(23, 141);
            label4.Name = "label4";
            label4.Size = new Size(106, 35);
            label4.TabIndex = 45;
            label4.Text = "TC No :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(29, 87);
            label2.Name = "label2";
            label2.Size = new Size(100, 35);
            label2.TabIndex = 44;
            label2.Text = "Soyad :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(65, 33);
            label1.Name = "label1";
            label1.Size = new Size(64, 35);
            label1.TabIndex = 43;
            label1.Text = "Ad :";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(379, 16);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(799, 387);
            dataGridView1.TabIndex = 53;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.Font = new Font("Constantia", 12F);
            button1.Location = new Point(135, 356);
            button1.Name = "button1";
            button1.Size = new Size(203, 47);
            button1.TabIndex = 54;
            button1.Text = "Düzenle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.SkyBlue;
            btnEkle.Font = new Font("Constantia", 12F);
            btnEkle.Location = new Point(135, 303);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(100, 47);
            btnEkle.TabIndex = 6;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightPink;
            button3.Font = new Font("Constantia", 12F);
            button3.Location = new Point(238, 303);
            button3.Name = "button3";
            button3.Size = new Size(100, 47);
            button3.TabIndex = 56;
            button3.Text = "Sil";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // DoktorPaneli
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1190, 415);
            Controls.Add(button3);
            Controls.Add(btnEkle);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "DoktorPaneli";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Doktor Paneli";
            FormClosed += DoktorPaneli_FormClosed;
            Load += DoktorPaneli_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private DataGridView dataGridView1;
        private Button button1;
        private Button btnEkle;
        private Button button3;
    }
}