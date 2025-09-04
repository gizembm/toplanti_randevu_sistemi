namespace ToplantıRandevuSistemi
{
    partial class Form5
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
            dgvMeetings = new DataGridView();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            btnBul = new Button();
            btnform5Kapat = new Button();
            btnForm3Geri = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMeetings).BeginInit();
            SuspendLayout();
            // 
            // dgvMeetings
            // 
            dgvMeetings.BackgroundColor = SystemColors.ControlLightLight;
            dgvMeetings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMeetings.Location = new Point(22, 112);
            dgvMeetings.Name = "dgvMeetings";
            dgvMeetings.RowHeadersWidth = 51;
            dgvMeetings.RowTemplate.Height = 29;
            dgvMeetings.Size = new Size(795, 361);
            dgvMeetings.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkOliveGreen;
            label1.Location = new Point(331, 9);
            label1.Name = "label1";
            label1.Size = new Size(218, 35);
            label1.TabIndex = 1;
            label1.Text = "TOPLANTILARIM";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(118, 61);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 2;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // btnBul
            // 
            btnBul.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBul.ForeColor = Color.DarkOliveGreen;
            btnBul.Location = new Point(374, 61);
            btnBul.Name = "btnBul";
            btnBul.Size = new Size(147, 29);
            btnBul.TabIndex = 3;
            btnBul.Text = "Toplantıları Bul";
            btnBul.UseVisualStyleBackColor = true;
            // 
            // btnform5Kapat
            // 
            btnform5Kapat.BackColor = Color.Beige;
            btnform5Kapat.Image = Properties.Resources.cancel_16dp_48752C_FILL0_wght400_GRAD0_opsz20;
            btnform5Kapat.Location = new Point(785, 9);
            btnform5Kapat.Name = "btnform5Kapat";
            btnform5Kapat.Size = new Size(33, 32);
            btnform5Kapat.TabIndex = 4;
            btnform5Kapat.UseVisualStyleBackColor = false;
            btnform5Kapat.Click += btnform5Kapat_Click;
            // 
            // btnForm3Geri
            // 
            btnForm3Geri.BackColor = Color.Beige;
            btnForm3Geri.Image = Properties.Resources.arrow_back_16dp_48752C_FILL0_wght400_GRAD0_opsz20;
            btnForm3Geri.Location = new Point(22, 14);
            btnForm3Geri.Name = "btnForm3Geri";
            btnForm3Geri.Size = new Size(48, 27);
            btnForm3Geri.TabIndex = 51;
            btnForm3Geri.UseVisualStyleBackColor = false;
            btnForm3Geri.Click += btnForm3Geri_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(829, 496);
            Controls.Add(btnForm3Geri);
            Controls.Add(btnform5Kapat);
            Controls.Add(btnBul);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(dgvMeetings);
            ForeColor = SystemColors.ControlText;
            Name = "Form5";
            Text = "Toplantılarım Ekranı";
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMeetings).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMeetings;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Button btnBul;
        private Button btnform5Kapat;
        private Button btnForm3Geri;
    }
}