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
    public partial class frm_organization : Form
    {
        public frm_organization()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_ObjectOfEvaluation next_form = new frm_ObjectOfEvaluation();
            next_form.Show();
            this.Close();
        }
    }
}
