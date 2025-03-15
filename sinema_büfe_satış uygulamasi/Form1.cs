using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinema_büfe_satış_uygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        int kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, bilet, su, çay, toplam;

            misir = Convert.ToUInt16(txtmisir.Text);
            bilet = Convert.ToInt16(txtbilet.Text);
            su = Convert.ToInt16(txtsu.Text);
            çay = Convert.ToInt16(txtcay.Text);

            toplam = misir * 50 + bilet * 100 + su * 15 + çay * 30;
            lbltoplam.Text = toplam.ToString() + "tl";
            kasatutar = kasatutar + toplam;
            lblkasa.Text = kasatutar.ToString() + "tl";


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtbilet.Text = "";
            txtcay.Text = "";
            txtmisir.Text = "";
            txtsu.Text = "";
            txtmisir.Focus();

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
