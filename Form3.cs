using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace ToplantıRandevuSistemi
{
    public partial class Form3 : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=toplantıRandevuSistemi;Integrated Security=True;Trust Server Certificate=True");
        public static string metin;
        private string kullanıcıAd2;
        private string sifre2;
        public Form3(string kullanıcıAd2, string sifre2)
        {
            InitializeComponent();
            this.kullanıcıAd2 = kullanıcıAd2;
            this.sifre2 = sifre2;
        }

        private void toplantıyaKatılacakKişiEkranı_Load(object sender, EventArgs e)
        {
            baglanti.Open();

            // Toplantı salonlarını yükle
            SqlCommand komut2 = new SqlCommand("SELECT * FROM Salon", baglanti);
            SqlDataReader dr = komut2.ExecuteReader();
            while (dr.Read())
            {
                cmbToplantıSolonu.Items.Add(dr["toplantıSolonuAdı"]);
            }
            dr.Close();

            // Başlangıç saatlerini yükle
            SqlCommand komut3 = new SqlCommand("SELECT * FROM saatAralıgı", baglanti);
            SqlDataReader dr2 = komut3.ExecuteReader();
            while (dr2.Read())
            {
                cbxBaslangic.Items.Add(dr2["baslangıçSaati"]);
            }
            dr2.Close();

            // Bitiş saatlerini yükle
            SqlCommand komut4 = new SqlCommand("SELECT * FROM saatAralıgı", baglanti);
            SqlDataReader dr3 = komut4.ExecuteReader();
            while (dr3.Read())
            {
                cbxBitis.Items.Add(dr3["bitisSaati"]);
            }
            dr3.Close();

            baglanti.Close();

            rbntYuzYuze.Checked = true;
            lblURL.Visible = false;
            txtToplantıLinki.Hide();
        }

        private void rbntOnline_CheckedChanged(object sender, EventArgs e)
        {
            if (rbntOnline.Checked)
            {
                lblURL.Visible = true;
                txtToplantıLinki.Visible = true;
                cmbToplantıSolonu.Visible = false;
                lblToplantiSolonu.Visible = false;
                txtKapasite.Visible = false;
                lblKapasite.Visible = false;
            }
            else
            {
                lblURL.Visible = false;
                txtToplantıLinki.Visible = false;
                cmbToplantıSolonu.Visible = true;
                lblToplantiSolonu.Visible = true;
                txtKapasite.Visible = true;
                lblKapasite.Visible = true;
            }
        }

        private void cmbToplantıSolonu_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }

                SqlCommand komut = new SqlCommand("SELECT * FROM Salon WHERE toplantıSolonuAdı = @toplantıSolonuAdı", baglanti);
                komut.Parameters.AddWithValue("@toplantıSolonuAdı", cmbToplantıSolonu.SelectedItem.ToString());
                SqlDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    txtKapasite.Text = oku["kapasite"].ToString();
                }
                oku.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
        }

        public bool IsMeetingTimeAvailable(string selectedRoom, DateTime selectedDate, TimeSpan startTime, TimeSpan endTime)
        {
            // Define the base SQL query
            string sqlQuery = "SELECT COUNT(*) FROM Toplantılar WHERE ToplantıTarihi = @Tarih " +
                "AND ((ToplantıBaslangıcSaati < @BitisSaati AND ToplantıBitisSaati > @BaslangıcSaati))";

            // Modify the query if the meeting is face-to-face
            if (rbntYuzYuze.Checked)
            {
                sqlQuery += " AND ToplantıOdasıAdı = @ToplantıOdasıAdı";
            }

            // Create the SQL command
            using (SqlCommand komut = new SqlCommand(sqlQuery, baglanti))
            {
                // Add common parameters
                komut.Parameters.AddWithValue("@Tarih", selectedDate.Date);
                komut.Parameters.AddWithValue("@BaslangıcSaati", startTime);
                komut.Parameters.AddWithValue("@BitisSaati", endTime);

                // Add room parameter if applicable
                if (rbntYuzYuze.Checked)
                {
                    komut.Parameters.AddWithValue("@ToplantıOdasıAdı", selectedRoom);
                }

                // Open the connection if it is closed
                if (baglanti.State == System.Data.ConnectionState.Closed)
                {
                    baglanti.Open();
                }

                // Execute the command and get the count
                int count = (int)komut.ExecuteScalar();

                // Close the connection
                baglanti.Close();

                // Return true if no meetings conflict, otherwise false
                return count == 0;
            }
        }

        

        private void btnSec_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbxBaslangic.Text))
            {
                MessageBox.Show("Lütfen bir başlangıç saati seçiniz!");
                return;
            }

            if (string.IsNullOrEmpty(cbxBitis.Text))
            {
                MessageBox.Show("Lütfen bir bitiş saati giriniz!");
                return;
            }

            if (string.IsNullOrEmpty(txtToplantıKonusu.Text))
            {
                MessageBox.Show("Lütfen toplantı konusu giriniz!");
                return;
            }

            if (rbntOnline.Checked && string.IsNullOrEmpty(txtToplantıLinki.Text))
            {
                MessageBox.Show("Lütfen toplantı linki giriniz!");
                return;
            }

            string selectedRoom = rbntYuzYuze.Checked ? cmbToplantıSolonu.SelectedItem?.ToString() : null;
            DateTime selectedDate = dateTimePicker1.Value;
            TimeSpan startTime = TimeSpan.Parse(cbxBaslangic.Text.Substring(0, 5));
            TimeSpan endTime = TimeSpan.Parse(cbxBitis.Text.Substring(0, 5));

            DateTime selectedStartDateTime = selectedDate.Add(startTime);
            DateTime selectedEndDateTime = selectedDate.Add(endTime);

            DateTime now = DateTime.Now;
            DateTime nowDate = new DateTime(now.Year, now.Month, now.Day, now.Hour, now.Minute, 0);

            

            if (selectedStartDateTime < nowDate || selectedEndDateTime < nowDate)
            {
                MessageBox.Show("Geçmiş tarih ve saat seçemezsiniz. Lütfen gelecekte bir zaman seçin.");
                return;
            }

            // Hafta sonu kontrolü
            if (selectedDate.DayOfWeek == DayOfWeek.Saturday || selectedDate.DayOfWeek == DayOfWeek.Sunday)
            {
                MessageBox.Show("Hafta sonları toplantı oluşturamazsınız. Lütfen hafta içi bir gün seçin.");
                return;
            }

            if (startTime >= endTime)
            {
                MessageBox.Show("Başlangıç saati bitiş saatinden önce olmalıdır.");
                return;
            }

            if (!IsMeetingTimeAvailable(selectedRoom, selectedDate, startTime, endTime))
            {
                MessageBox.Show("Seçilen tarih ve saat aralığında zaten bir toplantı bulunmaktadır. Lütfen başka bir zaman seçin.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=toplantıRandevuSistemi;Integrated Security=True;Trust Server Certificate=True"))
            {
                connection.Open();

                string query = "SELECT COUNT(1) FROM Toplantılar WHERE ToplantıTarihi=@date AND ((ToplantıBaslangıcSaati BETWEEN @start AND @end) OR (ToplantıBitisSaati BETWEEN @start AND @end))";
                if (rbntYuzYuze.Checked)
                {
                    query += " AND ToplantıOdasıAdı=@room";
                }

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@date", selectedDate);
                cmd.Parameters.AddWithValue("@start", startTime);
                cmd.Parameters.AddWithValue("@end", endTime);

                if (rbntYuzYuze.Checked)
                {
                    cmd.Parameters.AddWithValue("@room", selectedRoom);
                }

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count == 0)
                {
                    string meetingLink = rbntOnline.Checked ? txtToplantıLinki.Text : null;

                    // Toplantı oluşturma işlemi
                    string kapasite = txtKapasite.Text;
                    string konu = txtToplantıKonusu.Text;
                    string kisiId = "select kisilerId from Kisiler";

                    // Form4'ü aç
                    Form4 form4 = new Form4(selectedRoom, selectedDate, startTime, endTime, rbntOnline.Checked, meetingLink, kapasite, rbntOnline.Checked, rbntYuzYuze.Checked, konu, kisiId,kullanıcıAd2,sifre2);
                    form4.Show();
                    this.Hide();

                    Form5 form5 = new Form5(kullanıcıAd2,sifre2);
                }
                else
                {
                    MessageBox.Show("Bu toplantı odasında seçilen saatlerde başka bir toplantı bulunmaktadır.");
                }
            }
        }


        private void btnForm3Geri_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(kullanıcıAd2,sifre2);
            form2.Show();
            this.Hide();
        }
    }
}
