namespace Hastane
{
    partial class frmHastaGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHastaGiris));
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            mskTc = new MaskedTextBox();
            label2 = new Label();
            txtSifre = new TextBox();
            button1 = new Button();
            panel1 = new Panel();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(59, 139);
            label1.Name = "label1";
            label1.Size = new Size(194, 35);
            label1.TabIndex = 0;
            label1.Text = "TC Kimlik No :";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            linkLabel1.Location = new Point(446, 202);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(83, 24);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Kayıt Ol";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // mskTc
            // 
            mskTc.Font = new Font("Constantia", 13.8F);
            mskTc.Location = new Point(259, 140);
            mskTc.Mask = "00000000000";
            mskTc.Name = "mskTc";
            mskTc.Size = new Size(181, 36);
            mskTc.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(170, 191);
            label2.Name = "label2";
            label2.Size = new Size(83, 35);
            label2.TabIndex = 4;
            label2.Text = "Şifre :";
            // 
            // txtSifre
            // 
            txtSifre.Font = new Font("Constantia", 13.8F);
            txtSifre.Location = new Point(259, 192);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(181, 36);
            txtSifre.TabIndex = 5;
            txtSifre.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.Font = new Font("Constantia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.Location = new Point(298, 241);
            button1.Name = "button1";
            button1.Size = new Size(142, 47);
            button1.TabIndex = 6;
            button1.Text = "Giriş Yap";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label3);
            panel1.Location = new Point(-7, -7);
            panel1.Name = "panel1";
            panel1.Size = new Size(593, 114);
            panel1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Constantia", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.FromArgb(5, 69, 99);
            label3.Location = new Point(85, 28);
            label3.Name = "label3";
            label3.Size = new Size(422, 58);
            label3.TabIndex = 0;
            label3.Text = "Hasta Giriş Paneli";
            // 
            // frmHastaGiris
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.LightBlue;
            ClientSize = new Size(580, 320);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(txtSifre);
            Controls.Add(label2);
            Controls.Add(mskTc);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmHastaGiris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hasta Giriş";
            FormClosed += frmHastaGiris_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private LinkLabel linkLabel1;
        private MaskedTextBox mskTc;
        private Label label2;
        private TextBox txtSifre;
        private Button button1;
        private Panel panel1;
        private Label label3;
    }
}