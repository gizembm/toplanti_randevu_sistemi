using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace ToplantıRandevuSistemi
{
    public partial class Form6 : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=toplantıRandevuSistemi;Integrated Security=True;Trust Server Certificate=True");
        private string kullanıcıAd2;
        private string sifre2;

        public Form6(string kullanıcıAd2, string sifre2)
        {
            InitializeComponent();
            this.sifre2 = sifre2;
            this.kullanıcıAd2 = kullanıcıAd2;
            LoadMeetingDetails();
        }

        private void LoadMeetingDetails()
        {
            using (SqlConnection baglanti = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=toplantıRandevuSistemi;Integrated Security=True;Trust Server Certificate=True"))
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT ToplantılarID  FROM Toplantılar", baglanti);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBox1.ValueMember = "ToplantılarID";
                comboBox1.DataSource = dt;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnForm3Geri_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(kullanıcıAd2, sifre2);
            form2.Show();
            this.Hide();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

            LoadToplantilar();

        }
        private void LoadToplantilar()
        {
            using (SqlConnection baglanti = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=toplantıRandevuSistemi;Integrated Security=True;Trust Server Certificate=True"))
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT ToplantılarID FROM Toplantılar", baglanti);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBox1.ValueMember = "ToplantılarID";
                comboBox1.DataSource = dt;
            }
        }

        private void LoadMeetingDetails(int toplantilarID)
        {
            using (SqlConnection baglanti = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=toplantıRandevuSistemi;Integrated Security=True;Trust Server Certificate=True"))
            {
                baglanti.Open();
                SqlCommand komut5 = new SqlCommand("SELECT * FROM Toplantılar WHERE ToplantılarID = @toplantilarID", baglanti);
                komut5.Parameters.AddWithValue("@toplantilarID", toplantilarID);

                SqlDataReader dr4 = komut5.ExecuteReader();
                if (dr4.Read())
                {
                    cmbBaslangıc.Text = dr4["ToplantıBaslangıcSaati"].ToString();
                    cmbBitis.Text = dr4["ToplantıBitisSaati"].ToString();
                    DateTimePicker1.Value = DateTime.Parse(dr4["ToplantıTarihi"].ToString());
                }
                dr4.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue != null)
            {
                int toplantilarID = (int)comboBox1.SelectedValue;
                LoadMeetingDetails(toplantilarID);
            }

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = DateTimePicker1.Value;
            TimeSpan startTime = TimeSpan.Parse(cmbBaslangıc.Text.Substring(0, 5));
            TimeSpan endTime = TimeSpan.Parse(cmbBitis.Text.Substring(0, 5));

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



            // ComboBox'tan seçili toplantı ID'sini alın
            int toplantilarID = (int)comboBox1.SelectedValue;

            // TextBox ve diğer kontrollerden güncellenmiş değerleri alın
            string yeniBaslangicSaati = cmbBaslangıc.Text;
            string yeniBitisSaati = cmbBitis.Text;
            DateTime yeniTarih = DateTimePicker1.Value;

            // Veritabanında güncelleme yap
            using (SqlConnection baglanti = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=toplantıRandevuSistemi;Integrated Security=True;Trust Server Certificate=True"))
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("UPDATE Toplantılar SET ToplantıBaslangıcSaati = @baslangicSaati, ToplantıBitisSaati = @bitisSaati, ToplantıTarihi = @tarih WHERE ToplantılarID = @toplantilarID", baglanti);
                komut.Parameters.AddWithValue("@baslangicSaati", yeniBaslangicSaati);
                komut.Parameters.AddWithValue("@bitisSaati", yeniBitisSaati);
                komut.Parameters.AddWithValue("@tarih", yeniTarih);
                komut.Parameters.AddWithValue("@toplantilarID", toplantilarID);

                int rowsAffected = komut.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Toplantı başarıyla güncellendi.");
                }
                else
                {
                    MessageBox.Show("Toplantı güncellemesi başarısız.");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            // ComboBox'tan seçili toplantı ID'sini alın
            int toplantilarID = (int)comboBox1.SelectedValue;

            // Veritabanında silme işlemi yap
            using (SqlConnection baglanti = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=toplantıRandevuSistemi;Integrated Security=True;Trust Server Certificate=True"))
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM Toplantılar WHERE ToplantılarID = @toplantilarID", baglanti);
                komut.Parameters.AddWithValue("@toplantilarID", toplantilarID);

                int rowsAffected = komut.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Toplantı başarıyla silindi.");
                    // Toplantı silindikten sonra ComboBox'ı güncelle
                    LoadToplantilar();
                }
                else
                {
                    MessageBox.Show("Toplantı silme işlemi başarısız.");
                }
            }
        }
    }
}


