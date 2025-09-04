namespace ToplantıRandevuSistemi
{
    partial class Form4
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
            dgvEkle = new DataGridView();
            btnSil = new Button();
            btnEkle = new Button();
            lblAdSoyad = new Label();
            cmbAdSoyad = new ComboBox();
            lblKapasite = new Label();
            btnOlustur = new Button();
            label1 = new Label();
            btnForm3Geri = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEkle).BeginInit();
            SuspendLayout();
            // 
            // dgvEkle
            // 
            dgvEkle.BackgroundColor = SystemColors.ControlLightLight;
            dgvEkle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEkle.Location = new Point(116, 125);
            dgvEkle.Name = "dgvEkle";
            dgvEkle.RowHeadersWidth = 51;
            dgvEkle.RowTemplate.Height = 29;
            dgvEkle.Size = new Size(554, 223);
            dgvEkle.TabIndex = 45;
            dgvEkle.CellContentClick += dgvEkle_CellContentClick;
            // 
            // btnSil
            // 
            btnSil.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSil.ForeColor = Color.DarkOliveGreen;
            btnSil.Location = new Point(568, 78);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(102, 31);
            btnSil.TabIndex = 42;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnEkle
            // 
            btnEkle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEkle.ForeColor = Color.DarkOliveGreen;
            btnEkle.Location = new Point(460, 78);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(102, 31);
            btnEkle.TabIndex = 41;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.AutoSize = true;
            lblAdSoyad.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblAdSoyad.ForeColor = Color.DarkOliveGreen;
            lblAdSoyad.Location = new Point(116, 83);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(75, 20);
            lblAdSoyad.TabIndex = 43;
            lblAdSoyad.Text = "Ad Soyad";
            // 
            // cmbAdSoyad
            // 
            cmbAdSoyad.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cmbAdSoyad.FormattingEnabled = true;
            cmbAdSoyad.Location = new Point(211, 80);
            cmbAdSoyad.Name = "cmbAdSoyad";
            cmbAdSoyad.Size = new Size(237, 28);
            cmbAdSoyad.TabIndex = 44;
            cmbAdSoyad.SelectedIndexChanged += cmbAdSoyad_SelectedIndexChanged;
            // 
            // lblKapasite
            // 
            lblKapasite.AutoSize = true;
            lblKapasite.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblKapasite.ForeColor = Color.DarkOliveGreen;
            lblKapasite.Location = new Point(117, 361);
            lblKapasite.Name = "lblKapasite";
            lblKapasite.Size = new Size(69, 20);
            lblKapasite.TabIndex = 46;
            lblKapasite.Text = "Kapasite";
            // 
            // btnOlustur
            // 
            btnOlustur.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnOlustur.ForeColor = Color.DarkOliveGreen;
            btnOlustur.Location = new Point(519, 354);
            btnOlustur.Name = "btnOlustur";
            btnOlustur.Size = new Size(151, 39);
            btnOlustur.TabIndex = 48;
            btnOlustur.Text = "Toplantyı oluştur";
            btnOlustur.UseVisualStyleBackColor = true;
            btnOlustur.Click += btnOlustur_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(192, 361);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 49;
            label1.Text = "label1";
            // 
            // btnForm3Geri
            // 
            btnForm3Geri.BackColor = Color.Beige;
            btnForm3Geri.Image = Properties.Resources.arrow_back_16dp_48752C_FILL0_wght400_GRAD0_opsz20;
            btnForm3Geri.Location = new Point(12, 12);
            btnForm3Geri.Name = "btnForm3Geri";
            btnForm3Geri.Size = new Size(48, 27);
            btnForm3Geri.TabIndex = 51;
            btnForm3Geri.UseVisualStyleBackColor = false;
            btnForm3Geri.Click += btnForm3Geri_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(814, 450);
            Controls.Add(btnForm3Geri);
            Controls.Add(label1);
            Controls.Add(btnOlustur);
            Controls.Add(lblKapasite);
            Controls.Add(dgvEkle);
            Controls.Add(cmbAdSoyad);
            Controls.Add(lblAdSoyad);
            Controls.Add(btnEkle);
            Controls.Add(btnSil);
            Name = "Form4";
            Text = "Katılımcı Ekleme Ekranı";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEkle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DataGridView dgvEkle;
        public Button btnSil;
        public Button btnEkle;
        public Label lblAdSoyad;
        public ComboBox cmbAdSoyad;
        public Label lblKapasite;
        public Button btnOlustur;
        private Label label1;
        private Button btnForm3Geri;
    }
}