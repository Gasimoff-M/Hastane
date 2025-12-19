namespace Hastane
{
    partial class DoktorDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoktorDetay));
            groupBox1 = new GroupBox();
            lblAd = new Label();
            lblTC = new Label();
            label1 = new Label();
            label4 = new Label();
            groupBox4 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox2 = new GroupBox();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            button3 = new Button();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblAd);
            groupBox1.Controls.Add(lblTC);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label4);
            groupBox1.Font = new Font("Constantia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox1.ForeColor = Color.DodgerBlue;
            groupBox1.Location = new Point(9, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(425, 234);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Doktor Bilgi";
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Font = new Font("Constantia", 13.8F);
            lblAd.ForeColor = Color.Black;
            lblAd.Location = new Point(215, 131);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(102, 28);
            lblAd.TabIndex = 16;
            lblAd.Text = "Null Null";
            lblAd.Click += label3_Click;
            // 
            // lblTC
            // 
            lblTC.AutoSize = true;
            lblTC.Font = new Font("Constantia", 13.8F);
            lblTC.ForeColor = Color.Black;
            lblTC.Location = new Point(215, 77);
            lblTC.Name = "lblTC";
            lblTC.Size = new Size(144, 28);
            lblTC.TabIndex = 15;
            lblTC.Text = "00000000000";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(67, 127);
            label1.Name = "label1";
            label1.Size = new Size(142, 35);
            label1.TabIndex = 14;
            label1.Text = "Ad Soyad :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(15, 73);
            label4.Name = "label4";
            label4.Size = new Size(194, 35);
            label4.TabIndex = 12;
            label4.Text = "TC Kimlik No :";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView1);
            groupBox4.Font = new Font("Constantia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox4.ForeColor = Color.DodgerBlue;
            groupBox4.Location = new Point(443, 6);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(877, 517);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Randevu Geçmişi";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(871, 482);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(richTextBox1);
            groupBox2.Font = new Font("Constantia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox2.ForeColor = Color.DodgerBlue;
            groupBox2.Location = new Point(9, 246);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(428, 277);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Randevu Detay";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(24, 43);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(380, 213);
            richTextBox1.TabIndex = 18;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(17, 43);
            button1.Name = "button1";
            button1.Size = new Size(194, 50);
            button1.TabIndex = 21;
            button1.Text = "BilgiDüzenle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DeepSkyBlue;
            button3.ForeColor = Color.Black;
            button3.Location = new Point(220, 43);
            button3.Name = "button3";
            button3.Size = new Size(194, 50);
            button3.TabIndex = 23;
            button3.Text = "Duyurular";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(button1);
            groupBox3.Font = new Font("Constantia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox3.ForeColor = Color.DodgerBlue;
            groupBox3.Location = new Point(4, 529);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(430, 116);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Hızlı Erişim";
            // 
            // DoktorDetay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1330, 645);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "DoktorDetay";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Doktor Detay";
            FormClosed += DoktorDetay_FormClosed;
            Load += DoktorDetay_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblAd;
        private Label lblTC;
        private Label label1;
        private Label label4;
        private GroupBox groupBox2;
        private RichTextBox richTextBox1;
        private GroupBox groupBox4;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button3;
        private GroupBox groupBox3;
    }
}