namespace Hastane
{
    partial class HastaDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastaDetay));
            groupBox2 = new GroupBox();
            txtİd = new TextBox();
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            label7 = new Label();
            rchSikayet = new RichTextBox();
            label6 = new Label();
            cmbDoktor = new ComboBox();
            cmbBrans = new ComboBox();
            label5 = new Label();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox4 = new GroupBox();
            dataGridView2 = new DataGridView();
            label4 = new Label();
            label1 = new Label();
            lblTc = new Label();
            groupBox1 = new GroupBox();
            LblAdSoyad = new Label();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtİd);
            groupBox2.Controls.Add(linkLabel1);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(rchSikayet);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(cmbDoktor);
            groupBox2.Controls.Add(cmbBrans);
            groupBox2.Controls.Add(label5);
            groupBox2.Font = new Font("Constantia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox2.ForeColor = Color.DodgerBlue;
            groupBox2.Location = new Point(0, 213);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(425, 483);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Randevu Paneli";
            // 
            // txtİd
            // 
            txtİd.Location = new Point(171, 35);
            txtİd.Name = "txtİd";
            txtİd.Size = new Size(203, 36);
            txtİd.TabIndex = 22;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(10, 443);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(206, 28);
            linkLabel1.TabIndex = 21;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Bilgilerimi Düzenle";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(171, 390);
            button1.Name = "button1";
            button1.Size = new Size(203, 50);
            button1.TabIndex = 20;
            button1.Text = "Randevu Al";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(53, 214);
            label7.Name = "label7";
            label7.Size = new Size(112, 35);
            label7.TabIndex = 19;
            label7.Text = "Şikayet :";
            // 
            // rchSikayet
            // 
            rchSikayet.Location = new Point(171, 214);
            rchSikayet.Name = "rchSikayet";
            rchSikayet.Size = new Size(203, 153);
            rchSikayet.TabIndex = 18;
            rchSikayet.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(50, 153);
            label6.Name = "label6";
            label6.Size = new Size(115, 35);
            label6.TabIndex = 17;
            label6.Text = "Doktor :";
            // 
            // cmbDoktor
            // 
            cmbDoktor.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cmbDoktor.FormattingEnabled = true;
            cmbDoktor.Location = new Point(171, 153);
            cmbDoktor.Name = "cmbDoktor";
            cmbDoktor.Size = new Size(203, 39);
            cmbDoktor.TabIndex = 16;
            cmbDoktor.SelectedIndexChanged += cmbDoktor_SelectedIndexChanged;
            // 
            // cmbBrans
            // 
            cmbBrans.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cmbBrans.FormattingEnabled = true;
            cmbBrans.Location = new Point(171, 91);
            cmbBrans.Name = "cmbBrans";
            cmbBrans.Size = new Size(203, 39);
            cmbBrans.TabIndex = 15;
            cmbBrans.SelectedIndexChanged += cmbBrans_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(69, 93);
            label5.Name = "label5";
            label5.Size = new Size(96, 35);
            label5.TabIndex = 13;
            label5.Text = "Branş :";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Font = new Font("Constantia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox3.ForeColor = Color.DodgerBlue;
            groupBox3.Location = new Point(431, 1);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(877, 353);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Randevu Geçmişi";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(871, 318);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView2);
            groupBox4.Font = new Font("Constantia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox4.ForeColor = Color.DodgerBlue;
            groupBox4.Location = new Point(434, 360);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(871, 336);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Aktif Randevular";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(3, 32);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(865, 301);
            dataGridView2.TabIndex = 0;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Constantia", 16.2F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(16, 73);
            label4.Name = "label4";
            label4.Size = new Size(194, 35);
            label4.TabIndex = 12;
            label4.Text = "TC Kimlik No :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 16.2F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(68, 127);
            label1.Name = "label1";
            label1.Size = new Size(142, 35);
            label1.TabIndex = 14;
            label1.Text = "Ad Soyad :";
            // 
            // lblTc
            // 
            lblTc.AutoSize = true;
            lblTc.Font = new Font("Dubai", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTc.ForeColor = Color.Black;
            lblTc.Location = new Point(216, 73);
            lblTc.Name = "lblTc";
            lblTc.Size = new Size(149, 39);
            lblTc.TabIndex = 15;
            lblTc.Text = "00000000000";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(LblAdSoyad);
            groupBox1.Controls.Add(lblTc);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label4);
            groupBox1.Font = new Font("Constantia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox1.ForeColor = Color.DodgerBlue;
            groupBox1.Location = new Point(0, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(425, 206);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kişi Bilgi";
            // 
            // LblAdSoyad
            // 
            LblAdSoyad.AutoSize = true;
            LblAdSoyad.Font = new Font("Constantia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            LblAdSoyad.ForeColor = Color.Black;
            LblAdSoyad.Location = new Point(216, 134);
            LblAdSoyad.Name = "LblAdSoyad";
            LblAdSoyad.Size = new Size(102, 28);
            LblAdSoyad.TabIndex = 16;
            LblAdSoyad.Text = "Null Null";
            // 
            // HastaDetay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1320, 708);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "HastaDetay";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hasta Detay";
            FormClosed += HastaDetay_FormClosed;
            Load += HastaDetay_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private DataGridView dataGridView1;
        private GroupBox groupBox4;
        private DataGridView dataGridView2;
        private Label label4;
        private Label label1;
        private Label lblTc;
        private GroupBox groupBox1;
        private Label LblAdSoyad;
        private ComboBox cmbBrans;
        private Button button1;
        private Label label7;
        private RichTextBox rchSikayet;
        private Label label6;
        private ComboBox cmbDoktor;
        private Label label5;
        private LinkLabel linkLabel1;
        private TextBox txtİd;
    }
}