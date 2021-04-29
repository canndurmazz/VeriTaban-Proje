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
    public partial class müsterisifre : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=CANPC\\SQLEXPRESS;Initial Catalog=fabrikadb;Integrated Security=True");
        public müsterisifre()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Open)
            {
                baglanti.Close();
            }
            baglanti.Open();
            if (string.IsNullOrEmpty(müsad.Text) == true || string.IsNullOrEmpty(müssif.Text) == true)
            {
                MessageBox.Show("Bu Alanlar Boş Bırakılamaz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    SqlCommand al = new SqlCommand("select * from musteriler where ad=@AD and sifre=@SİFRE", baglanti);
                    al.Parameters.Add("@AD", SqlDbType.VarChar, 50).Value = müsad.Text;
                    al.Parameters.Add("@SİFRE", SqlDbType.VarChar, 50).Value = müssif.Text;

                    SqlDataReader oku = al.ExecuteReader();
                    if (!oku.HasRows)
                    {

                        MessageBox.Show("Böyle Bir Kullanıcı Yok.", "GİRİŞ BAŞARISIZ !", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        while (oku.Read())
                        {
                            string ad = (oku["AD"].ToString());
                            string sifre = (oku["SİFRE"].ToString());
                            if (ad == müsad.Text || sifre == müssif.Text)
                            {
                             kayitlimüsteri kayitlimüsteri = new kayitlimüsteri();
                             kayitlimüsteri.Show();
                             this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Hatalı Kullanıcı Adı Veya Şifre", "GİRİŞ BAŞARISIZ !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message);
                }
                finally
                {
                    baglanti.Close();
                }
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
