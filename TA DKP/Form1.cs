using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TA_DKP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pilihan;//variable
            int harga = 0;
            int total = 0;
            int paket;
            pilihan = comboBox1.SelectedIndex;
            if (comboBox1.SelectedIndex == 0)
            {
                // harga = 50000;
                paket = comboBox2.SelectedIndex + 1;
                //total = harga*paket;
                
                paket one = new TA_DKP.paket(50000);
                harga = one.harga;
                total = paket * harga;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                //harga = 100000;
                paket = comboBox2.SelectedIndex + 1;
                paket one = new TA_DKP.paket(100000);
                harga = one.harga;
                total = harga*paket;

            }
            else if (comboBox1.SelectedIndex == 2)
            {
                //harga = 100000;
                paket = comboBox2.SelectedIndex + 1;
                paket one = new TA_DKP.paket(150000);
                harga = one.harga;
                total = harga * paket;

            }


            textBox2.Text = "Terima kasih  sudah membeli followers dari kami. Total harga : " + total;

        }
    }
}
