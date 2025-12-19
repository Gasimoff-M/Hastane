namespace Hastane
{
    partial class BransPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BransPanel));
            dataGridView1 = new DataGridView();
            txtAd = new TextBox();
            txtİd = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(379, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(419, 226);
            dataGridView1.TabIndex = 58;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // txtAd
            // 
            txtAd.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtAd.Location = new Point(157, 84);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(203, 38);
            txtAd.TabIndex = 57;
            // 
            // txtİd
            // 
            txtİd.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtİd.Location = new Point(157, 30);
            txtİd.Name = "txtİd";
            txtİd.Size = new Size(203, 38);
            txtİd.TabIndex = 56;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(12, 86);
            label2.Name = "label2";
            label2.Size = new Size(139, 35);
            label2.TabIndex = 55;
            label2.Text = "Brasn Ad :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(23, 32);
            label1.Name = "label1";
            label1.Size = new Size(128, 35);
            label1.TabIndex = 54;
            label1.Text = "Brans İd :";
            // 
            // button3
            // 
            button3.BackColor = Color.LightPink;
            button3.Font = new Font("Constantia", 12F);
            button3.Location = new Point(260, 138);
            button3.Name = "button3";
            button3.Size = new Size(100, 47);
            button3.TabIndex = 61;
            button3.Text = "Sil";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SkyBlue;
            button2.Font = new Font("Constantia", 12F);
            button2.Location = new Point(157, 138);
            button2.Name = "button2";
            button2.Size = new Size(100, 47);
            button2.TabIndex = 60;
            button2.Text = "Ekle";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.Font = new Font("Constantia", 12F);
            button1.Location = new Point(157, 191);
            button1.Name = "button1";
            button1.Size = new Size(203, 47);
            button1.TabIndex = 59;
            button1.Text = "Düzenle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // BransPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.LightBlue;
            ClientSize = new Size(800, 258);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(txtAd);
            Controls.Add(txtİd);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "BransPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BransPanel";
            Load += BransPanel_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtAd;
        private TextBox txtİd;
        private Label label2;
        private Label label1;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}