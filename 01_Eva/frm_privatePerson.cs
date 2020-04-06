using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Eva
{
    public partial class frm_privatePerson : Form
    {
        public frm_privatePerson()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_ObjectOfEvaluation next_form = new frm_ObjectOfEvaluation();
            next_form.Show();
            this.Close();
        }

        private void chbx_compareAddresses_CheckedChanged(object sender, EventArgs e)
        {
            if(chbx_compareAddresses.Checked)
            {
                txb_addressActually.ReadOnly = true;
            }
            
            
            //txb_addressActually.ReadOnly = chbx_compareAddresses.Checked;
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
