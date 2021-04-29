using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Collections;

namespace VeriTabanıProje
{
    public partial class yenimüsteri : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=CANPC\\SQLEXPRESS;Initial Catalog=fabrikadb;Integrated Security=True");
        public yenimüsteri()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            kmc kmc = new kmc();
            kmc.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(adiniz.Text) == true || string.IsNullOrEmpty(soyadiniz.Text) == true || string.IsNullOrEmpty(teliniz.Text) == true
                || string.IsNullOrEmpty(emailiniz.Text) == true || string.IsNullOrEmpty(ad.Text) == true || string.IsNullOrEmpty(sifre.Text) == true
                || string.IsNullOrEmpty(sifret.Text) == true)
            {
                MessageBox.Show("Bu Alanlar Boş Bırakılamaz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();
                    string kayit = "insert into musteriler(adınız,soyadınız,telefonunuz,emailiniz,ad,sifre) values (@adınız,@soyadınız,@telefonunuz,@emailiniz,@ad,@sifre)";
                    SqlCommand komut = new SqlCommand(kayit, baglanti);
                    komut.Parameters.AddWithValue("@adınız", adiniz.Text);
                    komut.Parameters.AddWithValue("@soyadınız", soyadiniz.Text);
                    komut.Parameters.AddWithValue("@telefonunuz", teliniz.Text);
                    komut.Parameters.AddWithValue("@emailiniz", emailiniz.Text);
                    komut.Parameters.AddWithValue("@ad", ad.Text);
                    if (sifre.Text == sifret.Text)
                    {
                        komut.Parameters.AddWithValue("@sifre", sifre.Text);
                    }
                    else
                    {
                        MessageBox.Show("Şifreleriniz Uyuşmuyor", "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Müşteri Kaydı Başarılı !");
                }
                catch (Exception hata)
                {
                   //  MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }
    }
}
