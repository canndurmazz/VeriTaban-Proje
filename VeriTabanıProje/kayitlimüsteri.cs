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

namespace VeriTabanıProje
{
    public partial class kayitlimüsteri : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=CANPC\\SQLEXPRESS;Initial Catalog=fabrikadb;Integrated Security=True");
        public kayitlimüsteri()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            kmc kmc = new kmc();
            kmc.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kayitlimüsteri kayitlimüsteri = new kayitlimüsteri();
            kayitlimüsteri.Show();
            this.Close();
        }

        private void kayitlimüsteri_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
