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

namespace ToplantıRandevuSistemi
{
    public partial class Form2 : Form
    {
        private string kullanıcıAd1;
        private string sifre1;
        public Form2(string kullanıcıAd1, string sifre1)
        {
            InitializeComponent();
            this.kullanıcıAd1 = kullanıcıAd1;
            this.sifre1 = sifre1;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }


        private void btnYeniToplantıOlustur_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(kullanıcıAd1,sifre1);
            form3.Show();
            this.Hide();
        }

        private void btnToplantılarıGor_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(kullanıcıAd1, sifre1);
            form5.Show();
            this.Hide();
        }

        private void btnToplantıllarıDuzenle_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6(kullanıcıAd1, sifre1);
            form6.Show();
            this.Hide();
        }

        private void btnHesapAyarları_Click(object sender, EventArgs e)
        {

        }

        private void btnform2Kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
    }
}



