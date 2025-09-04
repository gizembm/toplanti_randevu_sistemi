namespace ToplantıRandevuSistemi
{
    partial class Form3
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
            components = new System.ComponentModel.Container();
            lblAd = new Label();
            toolTip1 = new ToolTip(components);
            toolTip2 = new ToolTip(components);
            bindingSource1 = new BindingSource(components);
            colorDialog1 = new ColorDialog();
            rbntYuzYuze = new RadioButton();
            rbntOnline = new RadioButton();
            cmbToplantıSolonu = new ComboBox();
            lblToplantiSolonu = new Label();
            txtToplantıLinki = new TextBox();
            txtToplantıKonusu = new TextBox();
            lblURL = new Label();
            lblKonu = new Label();
            btnSec = new Button();
            dateTimePicker1 = new DateTimePicker();
            lblSaat = new Label();
            lblTarih = new Label();
            cbxBaslangic = new ComboBox();
            cbxBitis = new ComboBox();
            label1 = new Label();
            txtKapasite = new TextBox();
            lblKapasite = new Label();
            btnForm3Geri = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAd.ForeColor = Color.DarkOliveGreen;
            lblAd.Location = new Point(345, 24);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(254, 56);
            lblAd.TabIndex = 4;
            lblAd.Text = "YENİ TOPLANTI OLUŞTUR\r\n\r\n";
            //lblAd.Click += lblAd_Click;
            // 
            // rbntYuzYuze
            // 
            rbntYuzYuze.AutoSize = true;
            rbntYuzYuze.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rbntYuzYuze.ForeColor = Color.DarkOliveGreen;
            rbntYuzYuze.Location = new Point(530, 143);
            rbntYuzYuze.Name = "rbntYuzYuze";
            rbntYuzYuze.Size = new Size(90, 24);
            rbntYuzYuze.TabIndex = 27;
            rbntYuzYuze.TabStop = true;
            rbntYuzYuze.Text = "Yüz yüze";
            rbntYuzYuze.UseVisualStyleBackColor = true;
            //rbntYuzYuze.CheckedChanged += rbntYuzYuze_CheckedChanged;
            // 
            // rbntOnline
            // 
            rbntOnline.AutoSize = true;
            rbntOnline.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rbntOnline.ForeColor = Color.DarkOliveGreen;
            rbntOnline.Location = new Point(530, 113);
            rbntOnline.Name = "rbntOnline";
            rbntOnline.Size = new Size(75, 24);
            rbntOnline.TabIndex = 26;
            rbntOnline.TabStop = true;
            rbntOnline.Text = "Online";
            rbntOnline.UseVisualStyleBackColor = true;
            rbntOnline.CheckedChanged += rbntOnline_CheckedChanged;
            // 
            // cmbToplantıSolonu
            // 
            cmbToplantıSolonu.BackColor = Color.Cornsilk;
            cmbToplantıSolonu.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbToplantıSolonu.FormattingEnabled = true;
            cmbToplantıSolonu.Location = new Point(287, 136);
            cmbToplantıSolonu.Name = "cmbToplantıSolonu";
            cmbToplantıSolonu.Size = new Size(237, 28);
            cmbToplantıSolonu.TabIndex = 28;
            cmbToplantıSolonu.SelectedIndexChanged += cmbToplantıSolonu_SelectedIndexChanged;
            // 
            // lblToplantiSolonu
            // 
            lblToplantiSolonu.AutoSize = true;
            lblToplantiSolonu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblToplantiSolonu.ForeColor = Color.DarkOliveGreen;
            lblToplantiSolonu.Location = new Point(158, 144);
            lblToplantiSolonu.Name = "lblToplantiSolonu";
            lblToplantiSolonu.Size = new Size(118, 20);
            lblToplantiSolonu.TabIndex = 29;
            lblToplantiSolonu.Text = "Toplantı Solonu";
            // 
            // txtToplantıLinki
            // 
            txtToplantıLinki.Location = new Point(287, 306);
            txtToplantıLinki.Name = "txtToplantıLinki";
            txtToplantıLinki.Size = new Size(415, 27);
            txtToplantıLinki.TabIndex = 36;
            //txtToplantıLinki.TextChanged += txtToplantıLinki_TextChanged;
            // 
            // txtToplantıKonusu
            // 
            txtToplantıKonusu.Location = new Point(287, 260);
            txtToplantıKonusu.Name = "txtToplantıKonusu";
            txtToplantıKonusu.Size = new Size(415, 27);
            txtToplantıKonusu.TabIndex = 37;
            // 
            // lblURL
            // 
            lblURL.AutoSize = true;
            lblURL.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblURL.ForeColor = Color.DarkOliveGreen;
            lblURL.Location = new Point(168, 309);
            lblURL.Name = "lblURL";
            lblURL.Size = new Size(103, 20);
            lblURL.TabIndex = 34;
            lblURL.Text = "Toplantı Linki";
            // 
            // lblKonu
            // 
            lblKonu.AutoSize = true;
            lblKonu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblKonu.ForeColor = Color.DarkOliveGreen;
            lblKonu.Location = new Point(158, 263);
            lblKonu.Name = "lblKonu";
            lblKonu.Size = new Size(123, 20);
            lblKonu.TabIndex = 35;
            lblKonu.Text = "Toplantı Konusu";
            // 
            // btnSec
            // 
            btnSec.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSec.ForeColor = Color.DarkOliveGreen;
            btnSec.Location = new Point(540, 356);
            btnSec.Name = "btnSec";
            btnSec.Size = new Size(162, 31);
            btnSec.TabIndex = 33;
            btnSec.Text = "Katılımcı ekle";
            btnSec.UseVisualStyleBackColor = true;
            btnSec.Click += btnSec_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(287, 179);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(415, 27);
            dateTimePicker1.TabIndex = 32;
            // 
            // lblSaat
            // 
            lblSaat.AutoSize = true;
            lblSaat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSaat.ForeColor = Color.DarkOliveGreen;
            lblSaat.Location = new Point(163, 223);
            lblSaat.Name = "lblSaat";
            lblSaat.Size = new Size(113, 20);
            lblSaat.TabIndex = 30;
            lblSaat.Text = "Başlangıç Saati\r\n";
            //lblSaat.Click += lblSaat_Click;
            // 
            // lblTarih
            // 
            lblTarih.AutoSize = true;
            lblTarih.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTarih.ForeColor = Color.DarkOliveGreen;
            lblTarih.Location = new Point(192, 186);
            lblTarih.Name = "lblTarih";
            lblTarih.Size = new Size(44, 20);
            lblTarih.TabIndex = 31;
            lblTarih.Text = "Tarih";
            // 
            // cbxBaslangic
            // 
            cbxBaslangic.FormattingEnabled = true;
            cbxBaslangic.Location = new Point(287, 220);
            cbxBaslangic.Name = "cbxBaslangic";
            cbxBaslangic.Size = new Size(151, 28);
            cbxBaslangic.TabIndex = 40;
            //cbxBaslangic.SelectedIndexChanged += cbxBaslangic_SelectedIndexChanged;
            // 
            // cbxBitis
            // 
            cbxBitis.FormattingEnabled = true;
            cbxBitis.Location = new Point(551, 220);
            cbxBitis.Name = "cbxBitis";
            cbxBitis.Size = new Size(151, 28);
            cbxBitis.TabIndex = 41;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkOliveGreen;
            label1.Location = new Point(467, 223);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 42;
            label1.Text = "Bitiş Saati";
            // 
            // txtKapasite
            // 
            txtKapasite.Location = new Point(626, 136);
            txtKapasite.Name = "txtKapasite";
            txtKapasite.ReadOnly = true;
            txtKapasite.Size = new Size(76, 27);
            txtKapasite.TabIndex = 48;
            //txtKapasite.TextChanged += txtKapasite_TextChanged_2;
            // 
            // lblKapasite
            // 
            lblKapasite.AutoSize = true;
            lblKapasite.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblKapasite.ForeColor = Color.DarkOliveGreen;
            lblKapasite.Location = new Point(633, 113);
            lblKapasite.Name = "lblKapasite";
            lblKapasite.Size = new Size(69, 20);
            lblKapasite.TabIndex = 49;
            lblKapasite.Text = "Kapasite";
            // 
            // btnForm3Geri
            // 
            btnForm3Geri.BackColor = Color.Beige;
            btnForm3Geri.Image = Properties.Resources.arrow_back_16dp_48752C_FILL0_wght400_GRAD0_opsz20;
            btnForm3Geri.Location = new Point(24, 12);
            btnForm3Geri.Name = "btnForm3Geri";
            btnForm3Geri.Size = new Size(48, 27);
            btnForm3Geri.TabIndex = 50;
            btnForm3Geri.UseVisualStyleBackColor = false;
            btnForm3Geri.Click += btnForm3Geri_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(973, 445);
            Controls.Add(btnForm3Geri);
            Controls.Add(lblKapasite);
            Controls.Add(txtKapasite);
            Controls.Add(label1);
            Controls.Add(cbxBitis);
            Controls.Add(cbxBaslangic);
            Controls.Add(txtToplantıLinki);
            Controls.Add(txtToplantıKonusu);
            Controls.Add(lblURL);
            Controls.Add(lblKonu);
            Controls.Add(btnSec);
            Controls.Add(dateTimePicker1);
            Controls.Add(lblSaat);
            Controls.Add(lblTarih);
            Controls.Add(lblToplantiSolonu);
            Controls.Add(cmbToplantıSolonu);
            Controls.Add(rbntYuzYuze);
            Controls.Add(rbntOnline);
            Controls.Add(lblAd);
            ForeColor = SystemColors.ControlText;
            Name = "Form3";
            Text = "Toplantı Oluşturma Ekranı";
            Load += toplantıyaKatılacakKişiEkranı_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolTip toolTip1;
        private ToolTip toolTip2;
        private BindingSource bindingSource1;
        private ColorDialog colorDialog1;
        public Label lblAd;
        public RadioButton rbntYuzYuze;
        public RadioButton rbntOnline;
        public ComboBox cmbToplantıSolonu;
        public Label lblToplantiSolonu;
        public TextBox txtToplantıLinki;
        public TextBox txtToplantıKonusu;
        public Label lblURL;
        public Label lblKonu;
        public Button btnSec;
        public DateTimePicker dateTimePicker1;
        public Label lblSaat;
        public Label lblTarih;
        public ComboBox cbxBaslangic;
        public ComboBox cbxBitis;
        public Label label1;
        public TextBox txtKapasite;
        public Label lblKapasite;
        private Button btnForm3Geri;
    }
}