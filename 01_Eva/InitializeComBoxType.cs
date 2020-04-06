using System.Drawing;
using System.Windows.Forms;

namespace _01_Eva
{
    class InitializeComBoxType : ComboBox
    {
        public void CreatComBoxType(ref ComboBox cbx, Form frm, string str, int x, int y, int w)
        {
            cbx.Text = str;
            cbx.Location = new Point(x, y);
            cbx.Size = new Size(w, 21);
            frm.Controls.Add(cbx);
        }
    }
}
