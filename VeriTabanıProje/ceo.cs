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

        private void button8_Click(object sender, EventArgs e)
        {
            button8.BackColor = Color.Silver;
            üstpanel.BackColor = Color.Silver;
         }

        private void button17_Click(object sender, EventArgs e)
        {
            button17.BackColor = Color.Gray;
            üstpanel.BackColor = Color.Gray;
        }

      
      

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.LightGray;
            üstpanel.BackColor = Color.LightGray;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            button19.BackColor = Color.DarkGray;
            üstpanel.BackColor = Color.DarkGray;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            button20.BackColor = Color.LightGray;
            üstpanel.BackColor = Color.LightGray;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            button21.BackColor = Color.Gray;
            üstpanel.BackColor = Color.Gray;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            button22.BackColor = Color.DarkGray;
            üstpanel.BackColor = Color.DarkGray;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            button23.BackColor = Color.Gray;
            üstpanel.BackColor = Color.Gray;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            button24.BackColor = Color.LightGray; 
            üstpanel.BackColor = Color.LightGray; 
        }

        private void button25_Click(object sender, EventArgs e)
        {
            button25.BackColor = Color.DimGray;
            üstpanel.BackColor = Color.DimGray;
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.LightGray;
            üstpanel.BackColor = Color.LightGray;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.Gray;
            üstpanel.BackColor = Color.Gray;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
