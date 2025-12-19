namespace Hastane
{
    partial class SekreterGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SekreterGiris));
            panel1 = new Panel();
            label3 = new Label();
            button1 = new Button();
            txtSifre = new TextBox();
            label2 = new Label();
            mskTC = new MaskedTextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label3);
            panel1.Location = new Point(-6, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(593, 114);
            panel1.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Constantia", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.FromArgb(5, 69, 99);
            label3.Location = new Point(59, 28);
            label3.Name = "label3";
            label3.Size = new Size(475, 58);
            label3.TabIndex = 0;
            label3.Text = "Sekreter Giriş Paneli";
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.Location = new Point(299, 247);
            button1.Name = "button1";
            button1.Size = new Size(142, 47);
            button1.TabIndex = 19;
            button1.Text = "Giriş Yap";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtSifre
            // 
            txtSifre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtSifre.Location = new Point(260, 198);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(181, 34);
            txtSifre.TabIndex = 18;
            txtSifre.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(171, 197);
            label2.Name = "label2";
            label2.Size = new Size(83, 35);
            label2.TabIndex = 17;
            label2.Text = "Şifre :";
            // 
            // mskTC
            // 
            mskTC.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            mskTC.Location = new Point(260, 146);
            mskTC.Mask = "00000000000";
            mskTC.Name = "mskTC";
            mskTC.Size = new Size(181, 34);
            mskTC.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(60, 145);
            label1.Name = "label1";
            label1.Size = new Size(194, 35);
            label1.TabIndex = 15;
            label1.Text = "TC Kimlik No :";
            // 
            // SekreterGiris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.LightBlue;
            ClientSize = new Size(580, 320);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(txtSifre);
            Controls.Add(label2);
            Controls.Add(mskTC);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "SekreterGiris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SekreterGiris";
            FormClosed += SekreterGiris_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Button button1;
        private TextBox txtSifre;
        private Label label2;
        private MaskedTextBox mskTC;
        private Label label1;
    }
}