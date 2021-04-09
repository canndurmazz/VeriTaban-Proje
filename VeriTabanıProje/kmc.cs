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
    public partial class kmc : Form
    {
        public kmc()
        {
            InitializeComponent();
        }

        private void deneme_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            müsterisifre müsterisifre = new müsterisifre();
            müsterisifre.Show();
                this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            yenimüsteri yenimüsteri = new yenimüsteri();
            yenimüsteri.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            yöneticisifre yöneticisifre = new yöneticisifre();
            yöneticisifre.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ceosifre ceosifre = new ceosifre();
            ceosifre.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hakkımızda hakkımızda = new hakkımızda();
            hakkımızda.Show();
            this.Hide();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            destek destek = new destek();
            destek.Show();
            this.Hide();
        }

        private void kmc_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }
    }
}
