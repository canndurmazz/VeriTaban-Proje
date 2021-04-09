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
    public partial class müsteri : Form
    {
        public müsteri()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            müsteri müsteri = new müsteri();
            müsteri.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            yenimüsteri yenimüsteri = new yenimüsteri();
            yenimüsteri.Show();
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            müsterisifre müsterisifre = new müsterisifre();
            müsterisifre.Show();
            this.Hide();
        }
    }
}
