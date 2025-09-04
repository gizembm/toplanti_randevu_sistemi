
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ToplantıRandevuSistemi
{
    public partial class Form5 : Form
    {
        private string kullanıcıAd;
        private string sifre;
        SqlConnection baglanti = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=toplantıRandevuSistemi;Integrated Security=True;Trust Server Certificate=True");

        public Form5(string kullanıcıAd, string sifre)
        {
            InitializeComponent();

            this.sifre = sifre;
            this.kullanıcıAd = kullanıcıAd;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            LoadSaatAraliklari();
            LoadToplantiOdaları();

            // 5. satırın 1. sütununa "Online" yaz
            if (dgvMeetings.Rows.Count >= 5)
            {
                dgvMeetings.Rows[4].Cells[1].Value = "Online";
            }
        }

        private void LoadSaatAraliklari()
        {
            List<string> saatAraliklari = new List<string>();
            using (SqlConnection connection = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=toplantıRandevuSistemi;Integrated Security=True;Trust Server Certificate=True"))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT baslangıçSaati, bitisSaati FROM saatAralıgı", connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string baslangicSaati = reader["baslangıçSaati"].ToString();
                    string bitisSaati = reader["bitisSaati"].ToString();
                    saatAraliklari.Add($"{baslangicSaati} - {bitisSaati}");
                }
                reader.Close();
                connection.Close();
            }

            if (saatAraliklari.Count > 0)
            {
                dgvMeetings.Columns.Add("ToplantiKonusu", "Toplantı Konusu");
                dgvMeetings.Columns.Add("ToplantiOdasi", "Toplantı Odası");

                for (int i = 0; i < saatAraliklari.Count; i++)
                {
                    dgvMeetings.Columns.Add($"SaatAraligi{i + 1}", saatAraliklari[i]);
                }
            }
        }

        private void LoadToplantiOdaları()
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=toplantıRandevuSistemi;Integrated Security=True;Trust Server Certificate=True"))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT DISTINCT toplantıSolonuAdı FROM Salon", connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvMeetings);
                    row.Cells[1].Value = reader["toplantıSolonuAdı"].ToString();
                    dgvMeetings.Rows.Add(row);
                }
                reader.Close();
                connection.Close();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            int userID = GetLoggedInUserID(); // Giriş yapan kullanıcının ID'sini alın
            if (userID == -1) // Kullanıcı ID'si geçerli değilse hata mesajı göster
            {
                MessageBox.Show("Geçerli bir kullanıcı ID'si bulunamadı.");
                return;
            }
            DateTime selectedDate = dateTimePicker1.Value.Date;
            dgvMeetings.Rows.Clear();
            LoadToplantiOdaları(); // Toplantı odalarını tekrar yükle
            LoadUserMeetings(userID, selectedDate);
        }

        private void LoadUserMeetings(int userID, DateTime selectedDate)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=toplantıRandevuSistemi;Integrated Security=True;Trust Server Certificate=True"))
            {
                connection.Open();

                string query = @"
                SELECT t.toplantıKonusu, t.ToplantıOdasıAdı, t.ToplantıBaslangıcSaati, t.ToplantıBitisSaati, t.online
                FROM Toplantılar t
                INNER JOIN kullanıcı k ON CHARINDEX(CAST(k.kullanıcıID AS VARCHAR(10)), t.Katılımcılar) > 0
                WHERE k.kullanıcıID = @userID AND t.ToplantıTarihi = @selectedDate";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@userID", userID);
                cmd.Parameters.AddWithValue("@selectedDate", selectedDate);

                SqlDataReader reader = cmd.ExecuteReader();

                if (!reader.HasRows)
                {
                    MessageBox.Show("Yaşasın! Toplantım yok.");
                    reader.Close();
                    connection.Close();
                    return;
                }

                while (reader.Read())
                {
                    string konu = reader["toplantıKonusu"].ToString();
                    string odaAdi = reader["ToplantıOdasıAdı"].ToString();
                    TimeSpan baslangicSaati = TimeSpan.Parse(reader["ToplantıBaslangıcSaati"].ToString());
                    TimeSpan bitisSaati = TimeSpan.Parse(reader["ToplantıBitisSaati"].ToString());
                    bool isOnline = Convert.ToInt32(reader["online"]) == 1;

                    AddMeetingToGrid(konu, odaAdi, baslangicSaati, bitisSaati, isOnline);
                }

                reader.Close();
                connection.Close();
            }
        }

        private void AddMeetingToGrid(string konu, string odaAdi, TimeSpan baslangicSaati, TimeSpan bitisSaati, bool isOnline)
        {
            foreach (DataGridViewRow row in dgvMeetings.Rows)
            {
                if (row.Cells[1].Value?.ToString() == odaAdi || (isOnline && row.Cells[1].Value?.ToString() == "Online"))
                {
                    row.Cells[0].Value = konu; // Toplantı konusunu ekleyin
                    for (int i = 2; i < dgvMeetings.Columns.Count; i++)
                    {
                        string saatAraligi = dgvMeetings.Columns[i].HeaderText;
                        if (saatAraligi != null)
                        {
                            string[] saatler = saatAraligi.Split('-');
                            TimeSpan baslangic = TimeSpan.Parse(saatler[0].Trim());
                            TimeSpan bitis = TimeSpan.Parse(saatler[1].Trim());

                            if (baslangicSaati < bitis && bitisSaati > baslangic)
                            {
                                row.Cells[i].Value = "Toplantım Var!!!";
                            }
                        }
                    }
                    break;
                }
            }
        }

        private int GetLoggedInUserID()
        {
            int userID = -1; // Varsayılan olarak geçersiz bir ID atayın (örneğin -1)

            using (SqlConnection connection = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=toplantıRandevuSistemi;Integrated Security=True;Trust Server Certificate=True"))
            {
                connection.Open();

                // Kullanıcının ID'sini almak için sorgu
                string query = "SELECT kullanıcıID FROM kullanıcı WHERE kullanıci_İsmi = @kullanıcıAd AND şifre = @sifre";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@kullanıcıAd", kullanıcıAd);
                cmd.Parameters.AddWithValue("@sifre", sifre);

                // Kullanıcı ID'sini al
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    userID = Convert.ToInt32(result);
                }
                else
                {
                    // Giriş başarısız, hata mesajı gösterilebilir
                }
            }

            return userID; // Kullanıcı ID'sini döndür
        }

        private void btnForm3Geri_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(kullanıcıAd, sifre);
            form2.Show();
            this.Hide();
        }

        private void btnform5Kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
