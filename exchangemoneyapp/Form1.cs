using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exchangemoneyapp
{
    public partial class Form1 : Form
    {
        double bath;
        double dollar = 36.5176;
        double pond = 46.0846;
        double euro = 38.8960;
        double xaun = 4.9790;
        double rupe = 0.4090;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            bath = Convert.ToDouble(textBox1.Text);
            double exchange = bath / dollar;
            LDL.Text = exchange.ToString("#.####");
            
           // LDL.Text = Convert.ToString(bath / dollar);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void picus_MouseLeave(object sender, EventArgs e)
        {
            LDL.Text = "....................";
        }

        private void picus_MouseHover(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                bath = Convert.ToDouble(textBox1.Text);
                double exchange = bath / dollar;
                LDL.Text = exchange.ToString("#.####");
            }
        }

        private void piceng_Click(object sender, EventArgs e)
        {
            bath = Convert.ToDouble(textBox1.Text);
            double exchange = bath / pond;
            LUS.Text = exchange.ToString("#.####");
        }

        private void piceng_MouseHover(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                bath = Convert.ToDouble(textBox1.Text);
                double exchange = bath / pond;
                LUS.Text = exchange.ToString("#.####");
            }
        }

        private void piceng_MouseLeave(object sender, EventArgs e)
        {
            LUS.Text = "....................";
        }

        private void piceuro_Click(object sender, EventArgs e)
        {
            bath = Convert.ToDouble(textBox1.Text);
            double exchange = bath / euro;
            LER.Text = exchange.ToString("#.####");
        }

        private void piceuro_MouseHover(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                bath = Convert.ToDouble(textBox1.Text);
                double exchange = bath / euro;
                LER.Text = exchange.ToString("#.####");
            }
        }

        private void piceuro_MouseLeave(object sender, EventArgs e)
        {
            LER.Text = "....................";
        }

        private void picND_MouseHover(object sender, EventArgs e)
        {
            if (textBox1.Text != "") {
            bath = Convert.ToDouble(textBox1.Text);
            double exchange = bath / rupe;
            LND.Text = exchange.ToString("#.####");
            }
        }

        private void picND_MouseLeave(object sender, EventArgs e)
        {
            LND.Text = "....................";
        }

        private void picND_Click(object sender, EventArgs e)
        {
            bath = Convert.ToDouble(textBox1.Text);
            double exchange = bath / rupe;
            LND.Text = exchange.ToString("#.####");
        }

        private void LCN_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void picCN_Click(object sender, EventArgs e)
        {
            bath = Convert.ToDouble(textBox1.Text);
            double exchange = bath / xaun;
            LCN.Text = exchange.ToString("#.####");
        }

        private void LCN_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void picCN_MouseHover(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                bath = Convert.ToDouble(textBox1.Text);
                double exchange = bath / xaun;
                LCN.Text = exchange.ToString("#.####");
            }
        }

        private void picCN_MouseLeave(object sender, EventArgs e)
        {
            LCN.Text = "....................";
        }

        private void LUS_Click(object sender, EventArgs e)
        {

        }
    }
}

