using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace _01_Eva
{
    public partial class frm_start : Form
    {

        public frm_start()
        {
            InitializeComponent();

        }

        //Открывает форымы для заполения данных клиента


        private void button1_Click(object sender, EventArgs e)
        {
            if (rb_фл.Checked == true)
            {
                frm_privatePerson frm_фл = new frm_privatePerson();
                frm_фл.Show();
            }
            else
            {
                frm_organization frm_юл = new frm_organization();
                frm_юл.Show();
            }
        }
    }
}
