
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Office.Word;


namespace ToplantıRandevuSistemi
{
    public partial class formGirisEkrani : Form
    {
        int loginAttempts = 0;
        SqlConnection baglanti = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=toplantıRandevuSistemi;
                                                     Integrated Security=True;Trust Server Certificate=True");

        public formGirisEkrani()
        {
            InitializeComponent();

        }
        private void formGirisEkrani_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGirsYap.PerformClick();
                e.SuppressKeyPress = true;

            }

            if (e.KeyCode == Keys.Up)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }

            if (e.KeyCode == Keys.Down)
            {
                SendKeys.Send("{TAB}");
            }

        }



        private void cbGoster_CheckedChanged(object sender, EventArgs e)
        {
            

            if (cbGoster.CheckState == CheckState.Checked)
            {
                txtSifre.UseSystemPasswordChar = false;
                // cbGoster.Text = "Göster";
            }
            else if (cbGoster.CheckState == CheckState.Unchecked)
            {
                txtSifre.UseSystemPasswordChar = true;
                //cbGoster.Text = "Gizle";
            }
        }

        private void btnGirsYap_Click(object sender, EventArgs e)
        {
            string KullaniciAd = txtKullanıci.Text;
            string sifre = txtSifre.Text;
            Form5 form5 = new Form5(KullaniciAd, sifre);



            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT COUNT(*) FROM kullanıcı WHERE kullanıci_İsmi = @kullanıci_İsmi AND Şifre = @Şifre", baglanti);
                komut.Parameters.AddWithValue("@kullanıci_ismi", KullaniciAd);
                komut.Parameters.AddWithValue("@Şifre", sifre);

                int count = (int)komut.ExecuteScalar();

                if (count == 1)
                {
                    Form2 form2 = new Form2(KullaniciAd, sifre);
                    form2.Show();
                    this.Hide();
                }
                else
                {
                    loginAttempts++;
                    if (loginAttempts >= 3)
                    {
                        MessageBox.Show("Robot musun?");
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı veya şifre yanlış.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
                txtSifre.UseSystemPasswordChar = true;

        }

        private void txtKullanıci_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void formGirisEkrani_Load(object sender, EventArgs e)
        {

        }

        private void lblKullanıcıAdi_Click(object sender, EventArgs e)
        {

        }
    }
}





