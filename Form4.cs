using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using DocumentFormat.OpenXml.Drawing.Wordprocessing;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Office.Word;
using DocumentFormat.OpenXml.Spreadsheet;


namespace ToplantıRandevuSistemi
{

    public partial class Form4 : Form
    {
        private string selectedRoom1;
        private DateTime selectedDate1;
        private TimeSpan startTime1;
        private TimeSpan endTime1;
        private bool isOnline1;
        private string meetingLink1;
        private string kapasite2;
        private string katılımcılar;
        private bool online;
        private bool yuzyuze;
        private string konu;
        private string kullanıcıAd3;
        private string sifre3;




        SqlConnection baglanti = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=toplantıRandevuSistemi;Integrated Security=True;Trust Server Certificate=True");
        DataTable tablo = new();
        DataGridView dataGridView1 = new DataGridView();

        public Form4(string selectedRoom1, DateTime selectedDate1, TimeSpan startTime1, TimeSpan endTime1, bool isOnline1,
                     string meetingLink1, string kapasite2, bool online, bool yuzyuze, string konu,string kisiId,string kullanıcıAd3,string sifre3)
        {
            InitializeComponent();

            this.selectedRoom1 = selectedRoom1;
            this.selectedDate1 = selectedDate1;
            this.startTime1 = startTime1;
            this.endTime1 = endTime1;
            this.isOnline1 = isOnline1;
            this.meetingLink1 = meetingLink1;
            this.kapasite2 = kapasite2;
            this.online = online;
            this.yuzyuze = yuzyuze;
            this.konu = konu;
            this.kullanıcıAd3 = kullanıcıAd3;
            this.sifre3=sifre3;


        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //label1.Text = Form3.metin;
           

            label1.Text = kapasite2;


            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM Kisiler", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cmbAdSoyad.Items.Add(oku["Ad"]);
            }
            oku.Close();

            dgvEkle.Columns.Add("ID", "ID");
            dgvEkle.Columns.Add("Ad", "Ad");
            dgvEkle.Columns.Add("Birim", "Birim");
            dgvEkle.Columns.Add("Mail", "Mail");
            dgvEkle.Columns.Add("Telefon", "Telefon");

        }


        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvEkle.SelectedRows.Count > 0)
            {

                foreach (DataGridViewRow row in dgvEkle.SelectedRows)
                {

                    dgvEkle.Rows.Remove(row);
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir satır seçin.");
            }
        }

 
        private void btnEkle_Click(object sender, EventArgs e)
        {
            string selectedAd = cmbAdSoyad.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedAd))
            {
                MessageBox.Show("Lütfen bir ad seçin.");
                return;
            }

            if (yuzyuze)
            {
                int maxKapasite = Convert.ToInt32(label1.Text);
                if (dgvEkle.Rows.Count >= maxKapasite)
                {
                    MessageBox.Show("Kapasite doldu, daha fazla kişi ekleyemezsiniz.");
                    return;
                }
            }

            foreach (DataGridViewRow row in dgvEkle.Rows)
            {
                if (row.Cells["Ad"].Value?.ToString() == selectedAd)
                {
                    MessageBox.Show("Bu kişi zaten eklenmiş.");
                    return;
                }
            }

            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }

                SqlCommand komut = new SqlCommand("SELECT Birim, postaAdresi, Telefon, kisilerId FROM Kisiler WHERE Ad = @Ad", baglanti);
                komut.Parameters.AddWithValue("@Ad", selectedAd);
                SqlDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {
                    string ID = oku["kisilerId"].ToString();
                    string birim = oku["Birim"].ToString();
                    string postaAdresi = oku["postaAdresi"].ToString();
                    string telefon = oku["Telefon"].ToString();

                    dgvEkle.Rows.Add(ID, selectedAd, birim, postaAdresi, telefon);
                }

                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı işlemi sırasında bir hata oluştu: " + ex.Message);
            }
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }

                dgvEkle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                List<int> katilimciIDList = new List<int>();
                for (int i = 0; i < dgvEkle.Rows.Count; i++) // 0. indeksten başlıyor
                {
                    DataGridViewRow row = dgvEkle.Rows[i];
                    if (!row.IsNewRow) // yeni ekleme satırını atla
                    {
                        int kisiID = Convert.ToInt32(row.Cells["ID"].Value);
                        katilimciIDList.Add(kisiID);
                    }
                }

                string katilimcilar = string.Join(",", katilimciIDList);

                // Toplantı ekleme sorgusu
                string query = "INSERT INTO Toplantılar (ToplantıTarihi, ToplantıBaslangıcSaati, ToplantıBitisSaati, Online, Katılımcılar,toplantıKonusu";

                if (yuzyuze)
                {
                    query += ", ToplantıOdasıAdı";
                }

                query += ") VALUES (@date, @start, @end, @online, @katilimcilar,@toplantıKonusu";

                if (yuzyuze)
                {
                    query += ", @room";
                }

                query += ")";

                SqlCommand cmd = new SqlCommand(query, baglanti);

                if (yuzyuze)
                {
                    cmd.Parameters.AddWithValue("@room", selectedRoom1);
                }

                cmd.Parameters.AddWithValue("@date", selectedDate1);
                cmd.Parameters.AddWithValue("@start", startTime1);
                cmd.Parameters.AddWithValue("@end", endTime1);
                cmd.Parameters.AddWithValue("@online", isOnline1);
                cmd.Parameters.AddWithValue("@katilimcilar", katilimcilar);
                cmd.Parameters.AddWithValue("@toplantıKonusu", konu);


                cmd.ExecuteNonQuery();

                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }

                MessageBox.Show("Toplantı başarıyla oluşturuldu.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }

            // Katılımcılara e-posta gönderme
            List<(string Email, string Name)> emailAddresses = new List<(string Email, string Name)>();
            foreach (DataGridViewRow row in dgvEkle.Rows)
            {
                if (row.Cells["Mail"].Value != null)
                {
                    string email = row.Cells["Mail"].Value.ToString();
                    string name = row.Cells["Ad"].Value.ToString();
                    if (!emailAddresses.Any(e => e.Email == email))
                    {
                        emailAddresses.Add((email, name));
                    }
                }
            }

            try
            {
                using (SmtpClient client = new SmtpClient("smtp.office365.com"))
                {
                    client.Port = 587;
                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential("meetingbilgilendirme@outlook.com", "your-app-password");
                    client.EnableSsl = true;

                    foreach (var (email, name) in emailAddresses)
                    {
                        using (MailMessage mailMessage = new MailMessage())
                        {
                            mailMessage.From = new MailAddress("meetingbilgilendirme@outlook.com");
                            mailMessage.To.Add(email);
                            mailMessage.Subject = "Toplantı Daveti";

                            mailMessage.Body = $"Merhaba {name},\n\n" +
                                               $"Toplantı Bilgileri:\n" +
                                               $"Tarih: {selectedDate1}\n" +
                                               $"Saat: {startTime1} - {endTime1}\n" +
                                               (yuzyuze ? $"Yer: {selectedRoom1}\n" : "") +
                                               $"Toplantı Konusu: {konu}\n\n" +
                                               (isOnline1 ? $"Toplantı Linki: {meetingLink1}\n\n" : "") +
                                               $"Katılımınızı bekliyoruz.\n\n" +
                                               $"Saygılarımızla,\n";

                            client.Send(mailMessage);
                        }
                    }
                }

                MessageBox.Show("Toplantı oluşturuldu ve e-posta gönderildi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("E-posta gönderimi sırasında bir hata oluştu: " + ex.Message);
            }
        }







        private void txtKapasite_TextChanged(object sender, EventArgs e)
        {

            try
            {

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void cmbAdSoyad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnForm3Geri_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(kullanıcıAd3, sifre3);
            form2.Show();
            this.Hide();
        }

        private void dgvEkle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public static implicit operator int(Form4 v)
        {
            throw new NotImplementedException();
        }
        //MessageBox.Show("Toplantı başarıyla oluşturuldu.");
    }
}

