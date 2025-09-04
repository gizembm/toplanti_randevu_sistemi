namespace ToplantıRandevuSistemi
{
    partial class Form6
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
            btnKaydet = new Button();
            btnSil = new Button();
            labelMeetingRoom = new Label();
            labelMeetingDate = new Label();
            labelStartTime = new Label();
            labelEndTime = new Label();
            btnForm3Geri = new Button();
            DateTimePicker1 = new DateTimePicker();
            cmbBaslangıc = new ComboBox();
            cmbBitis = new ComboBox();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // btnKaydet
            // 
            btnKaydet.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnKaydet.ForeColor = Color.DarkOliveGreen;
            btnKaydet.Location = new Point(338, 291);
            btnKaydet.Margin = new Padding(3, 4, 3, 4);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(90, 38);
            btnKaydet.TabIndex = 4;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnSil
            // 
            btnSil.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSil.ForeColor = Color.DarkOliveGreen;
            btnSil.Location = new Point(448, 291);
            btnSil.Margin = new Padding(3, 4, 3, 4);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(90, 38);
            btnSil.TabIndex = 5;
            btnSil.Text = "İptal";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // labelMeetingRoom
            // 
            labelMeetingRoom.AutoSize = true;
            labelMeetingRoom.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelMeetingRoom.ForeColor = Color.DarkOliveGreen;
            labelMeetingRoom.Location = new Point(218, 91);
            labelMeetingRoom.Name = "labelMeetingRoom";
            labelMeetingRoom.Size = new Size(86, 20);
            labelMeetingRoom.TabIndex = 6;
            labelMeetingRoom.Text = "Toplantı ID";
            // 
            // labelMeetingDate
            // 
            labelMeetingDate.AutoSize = true;
            labelMeetingDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelMeetingDate.ForeColor = Color.DarkOliveGreen;
            labelMeetingDate.Location = new Point(218, 141);
            labelMeetingDate.Name = "labelMeetingDate";
            labelMeetingDate.Size = new Size(48, 20);
            labelMeetingDate.TabIndex = 7;
            labelMeetingDate.Text = "Tarih:";
            // 
            // labelStartTime
            // 
            labelStartTime.AutoSize = true;
            labelStartTime.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelStartTime.ForeColor = Color.DarkOliveGreen;
            labelStartTime.Location = new Point(218, 191);
            labelStartTime.Name = "labelStartTime";
            labelStartTime.Size = new Size(117, 20);
            labelStartTime.TabIndex = 8;
            labelStartTime.Text = "Başlangıç Saati:";
            // 
            // labelEndTime
            // 
            labelEndTime.AutoSize = true;
            labelEndTime.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelEndTime.ForeColor = Color.DarkOliveGreen;
            labelEndTime.Location = new Point(218, 241);
            labelEndTime.Name = "labelEndTime";
            labelEndTime.Size = new Size(82, 20);
            labelEndTime.TabIndex = 9;
            labelEndTime.Text = "Bitiş Saati:";
            // 
            // btnForm3Geri
            // 
            btnForm3Geri.BackColor = Color.Beige;
            btnForm3Geri.Image = Properties.Resources.arrow_back_16dp_48752C_FILL0_wght400_GRAD0_opsz20;
            btnForm3Geri.Location = new Point(25, 12);
            btnForm3Geri.Name = "btnForm3Geri";
            btnForm3Geri.Size = new Size(48, 27);
            btnForm3Geri.TabIndex = 51;
            btnForm3Geri.UseVisualStyleBackColor = false;
            btnForm3Geri.Click += btnForm3Geri_Click;
            // 
            // DateTimePicker1
            // 
            DateTimePicker1.Location = new Point(338, 136);
            DateTimePicker1.Name = "DateTimePicker1";
            DateTimePicker1.Size = new Size(224, 27);
            DateTimePicker1.TabIndex = 52;
            // 
            // cmbBaslangıc
            // 
            cmbBaslangıc.FormattingEnabled = true;
            cmbBaslangıc.Items.AddRange(new object[] { "08:00:00", "08:30:00", "09:00.00", "09:30:00", "10:00:00", "10:30:00", "11:00:00", "11:30:00", "12:00:00", "12:30:00", "13:00:00", "13:30:00", "14:00:00", "14:30:00", "15:00:00", "15:30:00", "16:00:00", "16:30:00", "17:00:00" });
            cmbBaslangıc.Location = new Point(338, 191);
            cmbBaslangıc.Name = "cmbBaslangıc";
            cmbBaslangıc.Size = new Size(224, 28);
            cmbBaslangıc.TabIndex = 53;
            // 
            // cmbBitis
            // 
            cmbBitis.FormattingEnabled = true;
            cmbBitis.Items.AddRange(new object[] { "08:30:00", "09:00.00", "09:30:00", "10:00:00", "10:30:00", "11:00:00", "11:30:00", "12:00:00", "12:30:00", "13:00:00", "13:30:00", "14:00:00", "14:30:00", "15:00:00", "15:30:00", "16:00:00", "16:30:00", "17:00:00", "17:30:00" });
            cmbBitis.Location = new Point(338, 241);
            cmbBitis.Name = "cmbBitis";
            cmbBitis.Size = new Size(224, 28);
            cmbBitis.TabIndex = 53;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(338, 91);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(224, 28);
            comboBox1.TabIndex = 54;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(816, 436);
            Controls.Add(comboBox1);
            Controls.Add(cmbBitis);
            Controls.Add(cmbBaslangıc);
            Controls.Add(DateTimePicker1);
            Controls.Add(btnForm3Geri);
            Controls.Add(labelEndTime);
            Controls.Add(labelStartTime);
            Controls.Add(labelMeetingDate);
            Controls.Add(labelMeetingRoom);
            Controls.Add(btnSil);
            Controls.Add(btnKaydet);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form6";
            Text = "Toplantı Bilgilerini Düzenle";
            Load += Form6_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label labelMeetingRoom;
        private System.Windows.Forms.Label labelMeetingDate;
        private System.Windows.Forms.Label labelStartTime;
        private System.Windows.Forms.Label labelEndTime;
        private Button btnForm3Geri;
        private DateTimePicker DateTimePicker1;
        private ComboBox cmbBaslangıc;
        private ComboBox cmbBitis;
        private ComboBox comboBox1;
    }
}
