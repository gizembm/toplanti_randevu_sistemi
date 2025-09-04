
namespace ToplantıRandevuSistemi
{
    partial class formGirisEkrani
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            cbGoster = new CheckBox();
            lblToplantiRandevuSistemi = new Label();
            lblKullanici = new Label();
            lblSifre = new Label();
            txtKullanıci = new TextBox();
            txtSifre = new TextBox();
            btnGirsYap = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.Ekran_görüntüsü_2024_07_30_124445;
            pictureBox2.Location = new Point(2, 107);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(333, 231);
            pictureBox2.TabIndex = 28;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DarkOliveGreen;
            pictureBox1.Location = new Point(2, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(333, 476);
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // cbGoster
            // 
            cbGoster.AutoSize = true;
            cbGoster.ForeColor = Color.DarkOliveGreen;
            cbGoster.Location = new Point(734, 246);
            cbGoster.Name = "cbGoster";
            cbGoster.Size = new Size(126, 24);
            cbGoster.TabIndex = 26;
            cbGoster.Text = "Şifreyi Göster";
            cbGoster.UseVisualStyleBackColor = true;
            cbGoster.CheckedChanged += cbGoster_CheckedChanged;
            // 
            // lblToplantiRandevuSistemi
            // 
            lblToplantiRandevuSistemi.AutoSize = true;
            lblToplantiRandevuSistemi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblToplantiRandevuSistemi.ForeColor = Color.DarkOliveGreen;
            lblToplantiRandevuSistemi.Location = new Point(354, 148);
            lblToplantiRandevuSistemi.Name = "lblToplantiRandevuSistemi";
            lblToplantiRandevuSistemi.Size = new Size(399, 28);
            lblToplantiRandevuSistemi.TabIndex = 25;
            lblToplantiRandevuSistemi.Text = "Toplantı Randevu Sistemine Hoşgeldiniz!\r\n";
            // 
            // lblKullanici
            // 
            lblKullanici.AutoSize = true;
            lblKullanici.ForeColor = Color.DarkOliveGreen;
            lblKullanici.Location = new Point(354, 207);
            lblKullanici.Name = "lblKullanici";
            lblKullanici.Size = new Size(96, 20);
            lblKullanici.TabIndex = 23;
            lblKullanici.Text = "Kullanıcı Adı";
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.ForeColor = Color.DarkOliveGreen;
            lblSifre.Location = new Point(385, 251);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(41, 20);
            lblSifre.TabIndex = 24;
            lblSifre.Text = "Şifre";
            // 
            // txtKullanıci
            // 
            txtKullanıci.ForeColor = SystemColors.ControlText;
            txtKullanıci.Location = new Point(490, 204);
            txtKullanıci.Name = "txtKullanıci";
            txtKullanıci.Size = new Size(226, 27);
            txtKullanıci.TabIndex = 21;
            txtKullanıci.TextChanged += txtKullanıci_TextChanged;
            // 
            // txtSifre
            // 
            txtSifre.ForeColor = SystemColors.ControlText;
            txtSifre.Location = new Point(490, 244);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(226, 27);
            txtSifre.TabIndex = 22;
            txtSifre.TextChanged += txtSifre_TextChanged;
            // 
            // btnGirsYap
            // 
            btnGirsYap.ForeColor = Color.DarkOliveGreen;
            btnGirsYap.Location = new Point(592, 277);
            btnGirsYap.Name = "btnGirsYap";
            btnGirsYap.Size = new Size(124, 29);
            btnGirsYap.TabIndex = 20;
            btnGirsYap.Text = "Giriş Yap";
            btnGirsYap.UseVisualStyleBackColor = true;
            btnGirsYap.Click += btnGirsYap_Click;
            // 
            // formGirisEkrani
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(863, 477);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(cbGoster);
            Controls.Add(lblToplantiRandevuSistemi);
            Controls.Add(lblKullanici);
            Controls.Add(lblSifre);
            Controls.Add(txtKullanıci);
            Controls.Add(txtSifre);
            Controls.Add(btnGirsYap);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            KeyPreview = true;
            Name = "formGirisEkrani";
            Text = "Giriş Ekranı";
            Load += formGirisEkrani_Load;
            KeyDown += formGirisEkrani_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            txtSifre.UseSystemPasswordChar = true;
            //ss
            //throw new NotImplementedException();
        }

        private void lblSifre_Click(object sender, EventArgs e)
        {
            // throw new NotImplementedException();
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private CheckBox cbGoster;
        private Label lblToplantiRandevuSistemi;
        private Label lblKullanici;
        private Label lblSifre;
        private TextBox txtKullanıci;
        private TextBox txtSifre;
        private Button btnGirsYap;
    }
}
