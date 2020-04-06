namespace _01_Eva
{
    partial class frm_start
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbx_стоимость = new System.Windows.Forms.ComboBox();
            this.rb_юл = new System.Windows.Forms.RadioButton();
            this.rb_фл = new System.Windows.Forms.RadioButton();
            this.cbx_оценщик = new System.Windows.Forms.ComboBox();
            this.txb_цель = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.date_договора = new System.Windows.Forms.DateTimePicker();
            this.date_составления = new System.Windows.Forms.DateTimePicker();
            this.date_оценки = new System.Windows.Forms.DateTimePicker();
            this.txb_номер_договора = new System.Windows.Forms.TextBox();
            this.txb_номер_отчета = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbx_стоимость
            // 
            this.cbx_стоимость.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_стоимость.FormattingEnabled = true;
            this.cbx_стоимость.Items.AddRange(new object[] {
            "Рыночная стоимость",
            "Инвестиционная стоимость",
            "Ликвидационная стоимость",
            "Кадастровая стоимость"});
            this.cbx_стоимость.Location = new System.Drawing.Point(341, 150);
            this.cbx_стоимость.Name = "cbx_стоимость";
            this.cbx_стоимость.Size = new System.Drawing.Size(172, 21);
            this.cbx_стоимость.TabIndex = 44;
            // 
            // rb_юл
            // 
            this.rb_юл.AutoSize = true;
            this.rb_юл.Location = new System.Drawing.Point(230, 209);
            this.rb_юл.Name = "rb_юл";
            this.rb_юл.Size = new System.Drawing.Size(120, 17);
            this.rb_юл.TabIndex = 41;
            this.rb_юл.Text = "Юридическое лицо";
            this.rb_юл.UseVisualStyleBackColor = true;
            // 
            // rb_фл
            // 
            this.rb_фл.AutoSize = true;
            this.rb_фл.Checked = true;
            this.rb_фл.Location = new System.Drawing.Point(108, 209);
            this.rb_фл.Name = "rb_фл";
            this.rb_фл.Size = new System.Drawing.Size(116, 17);
            this.rb_фл.TabIndex = 40;
            this.rb_фл.TabStop = true;
            this.rb_фл.Text = "Физическое лицо";
            this.rb_фл.UseVisualStyleBackColor = true;
            // 
            // cbx_оценщик
            // 
            this.cbx_оценщик.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_оценщик.FormattingEnabled = true;
            this.cbx_оценщик.Items.AddRange(new object[] {
            "Дельвиг Антон Денисович",
            "Рошка Андрей Ильевич",
            "Шестаков Денис Александрович"});
            this.cbx_оценщик.Location = new System.Drawing.Point(152, 178);
            this.cbx_оценщик.Name = "cbx_оценщик";
            this.cbx_оценщик.Size = new System.Drawing.Size(361, 21);
            this.cbx_оценщик.TabIndex = 39;
            // 
            // txb_цель
            // 
            this.txb_цель.Location = new System.Drawing.Point(98, 150);
            this.txb_цель.Name = "txb_цель";
            this.txb_цель.Size = new System.Drawing.Size(138, 20);
            this.txb_цель.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 211);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "Тип заказчика";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Оценщик/Исполнитель";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(252, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Вид стоимости";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Цель оценки";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.date_договора);
            this.groupBox1.Controls.Add(this.date_составления);
            this.groupBox1.Controls.Add(this.date_оценки);
            this.groupBox1.Controls.Add(this.txb_номер_договора);
            this.groupBox1.Controls.Add(this.txb_номер_отчета);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(525, 132);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информацмя отчета об оценке";
            // 
            // date_договора
            // 
            this.date_договора.Location = new System.Drawing.Point(361, 60);
            this.date_договора.Name = "date_договора";
            this.date_договора.Size = new System.Drawing.Size(138, 20);
            this.date_договора.TabIndex = 19;
            // 
            // date_составления
            // 
            this.date_составления.Location = new System.Drawing.Point(113, 86);
            this.date_составления.Name = "date_составления";
            this.date_составления.Size = new System.Drawing.Size(138, 20);
            this.date_составления.TabIndex = 18;
            // 
            // date_оценки
            // 
            this.date_оценки.Location = new System.Drawing.Point(113, 60);
            this.date_оценки.Name = "date_оценки";
            this.date_оценки.Size = new System.Drawing.Size(138, 20);
            this.date_оценки.TabIndex = 17;
            // 
            // txb_номер_договора
            // 
            this.txb_номер_договора.Location = new System.Drawing.Point(361, 34);
            this.txb_номер_договора.Name = "txb_номер_договора";
            this.txb_номер_договора.Size = new System.Drawing.Size(138, 20);
            this.txb_номер_договора.TabIndex = 16;
            // 
            // txb_номер_отчета
            // 
            this.txb_номер_отчета.Location = new System.Drawing.Point(113, 34);
            this.txb_номер_отчета.Name = "txb_номер_отчета";
            this.txb_номер_отчета.Size = new System.Drawing.Size(138, 20);
            this.txb_номер_отчета.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(272, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Дата договора";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Номер договора";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Дата составления";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Дата оценки";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Номер отчета";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(356, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 45;
            this.button1.Text = "Далее >>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 250);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbx_стоимость);
            this.Controls.Add(this.rb_юл);
            this.Controls.Add(this.rb_фл);
            this.Controls.Add(this.cbx_оценщик);
            this.Controls.Add(this.txb_цель);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyEva";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbx_стоимость;
        private System.Windows.Forms.RadioButton rb_юл;
        private System.Windows.Forms.RadioButton rb_фл;
        private System.Windows.Forms.ComboBox cbx_оценщик;
        private System.Windows.Forms.TextBox txb_цель;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker date_договора;
        private System.Windows.Forms.DateTimePicker date_составления;
        private System.Windows.Forms.DateTimePicker date_оценки;
        private System.Windows.Forms.TextBox txb_номер_договора;
        private System.Windows.Forms.TextBox txb_номер_отчета;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

