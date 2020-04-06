using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace _01_Eva
{
    class Class1 : ComboBox
    {
        private string[] ArrayObj = { "Жилое помещение", "Нежилое помещение", "Здание", "Здание с земельным участком", "Земельный участок" };

        int n = 1;

        ComboBox myCbx_view = new ComboBox();


        public void InicializationCbx_view ()
        {
            myCbx_view.Name = "myCbx_тип_" + n.ToString();
            myCbx_view.Location = p;
            myCbx_view.Size = new Size(372, 21);
            myCbx_view.Items.AddRange(ArrayObj);
            myCbx_view.DropDownStyle = ComboBoxStyle.DropDownList;

        }

    }
}
