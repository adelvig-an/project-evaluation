using System;
using System.Drawing;
using System.Windows.Forms;

namespace _01_Eva
{
    class MyButton : Button
    {
        public void CreatButton(Button btn, Form frm, string str, int x, int y, int w, int h, EventHandler evh)
        {
            btn = new Button();
            btn.Text = str;
            btn.Location = new Point(x, y);
            btn.Size = new Size(w, h);
            btn.Click += evh;
            frm.Controls.Add(btn);
        }
    }
}
