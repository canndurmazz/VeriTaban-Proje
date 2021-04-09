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
    public partial class ceo : Form
    {
        public ceo()
        {
            InitializeComponent();
        }

        private void ceo_Load(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            kmc kmc = new kmc();
            kmc.Show();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ceosifre ceosifre = new ceosifre();
            ceosifre.Show();
            this.Hide();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
