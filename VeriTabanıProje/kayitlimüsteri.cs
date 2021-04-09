using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeriTabanıProje
{
    public partial class kayitlimüsteri : Form
    {
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
    }
}
