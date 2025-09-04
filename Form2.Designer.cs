namespace ToplantıRandevuSistemi
{
    partial class Form2
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
            btnYeniToplantıOlustur = new Button();
            btnToplantılarıGor = new Button();
            btnToplantıllarıDuzenle = new Button();
            btnform2Kapat = new Button();
            SuspendLayout();
            // 
            // btnYeniToplantıOlustur
            // 
            btnYeniToplantıOlustur.BackColor = Color.DarkOliveGreen;
            btnYeniToplantıOlustur.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnYeniToplantıOlustur.ForeColor = Color.Beige;
            btnYeniToplantıOlustur.Location = new Point(68, 123);
            btnYeniToplantıOlustur.Name = "btnYeniToplantıOlustur";
            btnYeniToplantıOlustur.Size = new Size(205, 191);
            btnYeniToplantıOlustur.TabIndex = 1;
            btnYeniToplantıOlustur.Text = "YENİ TOPLANTI OLUŞTUR";
            btnYeniToplantıOlustur.UseVisualStyleBackColor = false;
            btnYeniToplantıOlustur.Click += btnYeniToplantıOlustur_Click;
            // 
            // btnToplantılarıGor
            // 
            btnToplantılarıGor.BackColor = Color.DarkOliveGreen;
            btnToplantılarıGor.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnToplantılarıGor.ForeColor = Color.Beige;
            btnToplantılarıGor.Location = new Point(322, 123);
            btnToplantılarıGor.Name = "btnToplantılarıGor";
            btnToplantılarıGor.Size = new Size(205, 191);
            btnToplantılarıGor.TabIndex = 1;
            btnToplantılarıGor.Text = "TOPLANTILARI GÖR\r\n";
            btnToplantılarıGor.UseVisualStyleBackColor = false;
            btnToplantılarıGor.Click += btnToplantılarıGor_Click;
            // 
            // btnToplantıllarıDuzenle
            // 
            btnToplantıllarıDuzenle.BackColor = Color.DarkOliveGreen;
            btnToplantıllarıDuzenle.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnToplantıllarıDuzenle.ForeColor = Color.Beige;
            btnToplantıllarıDuzenle.Location = new Point(579, 123);
            btnToplantıllarıDuzenle.Name = "btnToplantıllarıDuzenle";
            btnToplantıllarıDuzenle.Size = new Size(205, 191);
            btnToplantıllarıDuzenle.TabIndex = 1;
            btnToplantıllarıDuzenle.Text = "TOPLANTILARI DÜZENLE";
            btnToplantıllarıDuzenle.UseVisualStyleBackColor = false;
            btnToplantıllarıDuzenle.Click += btnToplantıllarıDuzenle_Click;
            // 
            // btnform2Kapat
            // 
            btnform2Kapat.BackColor = Color.Beige;
            btnform2Kapat.Image = Properties.Resources.cancel_16dp_48752C_FILL0_wght400_GRAD0_opsz20;
            btnform2Kapat.Location = new Point(818, 12);
            btnform2Kapat.Name = "btnform2Kapat";
            btnform2Kapat.Size = new Size(33, 32);
            btnform2Kapat.TabIndex = 3;
            btnform2Kapat.UseVisualStyleBackColor = false;
            btnform2Kapat.Click += btnform2Kapat_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(863, 477);
            Controls.Add(btnform2Kapat);
            Controls.Add(btnToplantıllarıDuzenle);
            Controls.Add(btnToplantılarıGor);
            Controls.Add(btnYeniToplantıOlustur);
            Name = "Form2";
            Text = "Ana Menü Ekranı";
            Load += Form2_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnYeniToplantıOlustur;
        private Button btnToplantılarıGor;
        private Button btnToplantıllarıDuzenle;
        private Button btnform2Kapat;
    }
}