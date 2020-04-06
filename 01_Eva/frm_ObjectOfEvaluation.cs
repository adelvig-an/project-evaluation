using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _01_Eva.Model;

namespace _01_Eva
{
    public partial class frm_ObjectOfEvaluation : Form
    {
        MyButton cl1 = new MyButton();
        InitializeComBoxView comboview = new InitializeComBoxView();
        InitializeComBoxType combotype = new InitializeComBoxType();
        private Basket basket = new Basket();

        public frm_ObjectOfEvaluation()
        {
            InitializeComponent();
        }


        int i = 0;
        int n = 1;

        void InitializeObj()
        {
            i += 60;

            Button btn = new Button();
            ComboBox comboboxView = new ComboBox();
            ComboBox comboboxType = new ComboBox();

            cl1.CreatButton(btn, this, "Кнопка " + n, 385, i, 120, 50, Click_My_Button);
            comboview.CreatComBoxView(ref comboboxView, this, "Список видом объекта " + n, 12, i, 370);
            //comboview.CreatComBoxView(ref comboboxView, "Список видом объекта" + n, 20, i, 250);
            comboboxView.Items.AddRange(basket.Categories.ToArray());
            combotype.CreatComBoxType(ref comboboxType, this, "Список типов объекта " + n, 12, 27 + i, 370);
            comboboxView.SelectedIndexChanged += ComboboxView_SelectedIndexChanged;

            n++;

            void ComboboxView_SelectedIndexChanged(object sender, EventArgs e)
            {
                comboboxType.Items.Clear();
                var item = (Category)comboboxView.SelectedItem;
                comboboxType.Items.AddRange(item.Items.ToArray());
            }

            void Click_My_Button(object sender, EventArgs e)
            {
                if (comboboxView.SelectedItem.ToString() == "Жилое помещение")
                {
                    if (comboboxType.SelectedItem.ToString() == "Квартира")
                    {
                        frm_apartment apartment = new frm_apartment();
                        apartment.Show();
                    }
                }
                else if (comboboxView.SelectedItem.ToString() == "Нежилое помещение")
                {
                    if (comboboxType.SelectedItem.ToString() == "Офисно-торговый объект свободного назначения")
                    {
                        frm_nonpremise nonpremise = new frm_nonpremise();
                        nonpremise.Show();
                    }
                    else if (comboboxType.SelectedItem.ToString() == "Офисы класса А, В")
                    {
                        frm_nonpremise nonpremise = new frm_nonpremise();
                        nonpremise.Show();
                    }
                    else if (comboboxType.SelectedItem.ToString() == "Торговая недвижимость")
                    {
                        frm_nonpremise nonpremise = new frm_nonpremise();
                        nonpremise.Show();
                    }
                    else if (comboboxType.SelectedItem.ToString() == "Производственно-складская недвижимость")
                    {
                        frm_industrialPremise industrialPremise = new frm_industrialPremise();
                        industrialPremise.Show();
                    }
                }
                else if (comboboxView.SelectedItem.ToString() == "Здание")
                {
                    if (comboboxType.SelectedItem.ToString() == "Жилой дом")
                    {
                        MessageBox.Show("Здание! Жилой дом!");
                    }
                    else if (comboboxType.SelectedItem.ToString() == "Офисно-торговый объект свободного назначения")
                    {
                        MessageBox.Show("Здание! Офисно-торговый объект свободного назначения!");
                    }
                    else if (comboboxType.SelectedItem.ToString() == "Офисы класса А, В")
                    {
                        MessageBox.Show("Здание! Офисы класса А, В!");
                    }
                    else if (comboboxType.SelectedItem.ToString() == "Торговая недвижимость")
                    {
                        MessageBox.Show("Здание! Торговая недвижимость!");
                    }
                    else if (comboboxType.SelectedItem.ToString() == "Производственно-складская недвижимость")
                    {
                        MessageBox.Show("Здание! Производственно-складская недвижимость!");
                    }
                }
                else if (comboboxView.SelectedItem.ToString() == "Здание с земельным участком")
                {
                    if (comboboxType.SelectedItem.ToString() == "Жилой дом")
                    {
                        MessageBox.Show("Здание с земельным участком! Жилой дом!");
                    }
                    else if (comboboxType.SelectedItem.ToString() == "Офисно-торговый объект свободного назначения")
                    {
                        MessageBox.Show("Здание с земельным участком! Офисно-торговый объект свободного назначения!");
                    }
                    else if (comboboxType.SelectedItem.ToString() == "Офисы класса А, В")
                    {
                        MessageBox.Show("Здание с земельным участком! Офисы класса А, В!");
                    }
                    else if (comboboxType.SelectedItem.ToString() == "Торговая недвижимость")
                    {
                        MessageBox.Show("Здание с земельным участком! Торговая недвижимость!");
                    }
                    else if (comboboxType.SelectedItem.ToString() == "Производственно-складская недвижимость")
                    {
                        MessageBox.Show("Здание с земельным участком! Производственно-складская недвижимость!");
                    }
                }
                else if (comboboxView.SelectedItem.ToString() == "Земельный участок")
                {
                    if (comboboxType.SelectedItem.ToString() == "Под индустриальную застройку")
                    {
                        MessageBox.Show("Земельный участок! Под индустриальную застройку!");
                    }
                    else if (comboboxType.SelectedItem.ToString() == "Под офисно-торговую застройку")
                    {
                        MessageBox.Show("Земельный участок! Под офисно-торговую застройку!");
                    }
                    else if (comboboxType.SelectedItem.ToString() == "Под многоквартирную жилую застройку")
                    {
                        MessageBox.Show("Земельный участок! Под многоквартирную жилую застройку!");
                    }
                    else if (comboboxType.SelectedItem.ToString() == "Под объекты рекреации")
                    {
                        MessageBox.Show("Земельный участок! Под объекты рекреации!");
                    }
                    else if (comboboxType.SelectedItem.ToString() == "Под объекты придорожного сервиса")
                    {
                        MessageBox.Show("Земельный участок! Под объекты придорожного сервиса!");
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InitializeObj();
        }
    }
}
