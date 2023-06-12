namespace ERC
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.checkBox_ColdWhater = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox_HotWhater = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox_Electricity = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_Сalculate = new System.Windows.Forms.Button();
            this.label_Total = new System.Windows.Forms.Label();
            this.maskedTextBox_ColdWhater = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_HotWhater = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_DayElectro = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_NightElectro = new System.Windows.Forms.MaskedTextBox();
            this.textBox_residents = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_transfer = new System.Windows.Forms.Button();
            this.label_ColdWhater = new System.Windows.Forms.Label();
            this.label8_HotWhater = new System.Windows.Forms.Label();
            this.label_HotEnergy = new System.Windows.Forms.Label();
            this.label10_Electro_day_and_all = new System.Windows.Forms.Label();
            this.label7_ElectroNight = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBox_ColdWhater
            // 
            this.checkBox_ColdWhater.AutoSize = true;
            this.checkBox_ColdWhater.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_ColdWhater.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_ColdWhater.ForeColor = System.Drawing.Color.Transparent;
            this.checkBox_ColdWhater.Location = new System.Drawing.Point(153, 38);
            this.checkBox_ColdWhater.Name = "checkBox_ColdWhater";
            this.checkBox_ColdWhater.Size = new System.Drawing.Size(130, 20);
            this.checkBox_ColdWhater.TabIndex = 0;
            this.checkBox_ColdWhater.Text = "Прибор учета";
            this.checkBox_ColdWhater.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(4, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "ХВС";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(5, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "ГВС";
            // 
            // checkBox_HotWhater
            // 
            this.checkBox_HotWhater.AutoSize = true;
            this.checkBox_HotWhater.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_HotWhater.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_HotWhater.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox_HotWhater.Location = new System.Drawing.Point(153, 73);
            this.checkBox_HotWhater.Name = "checkBox_HotWhater";
            this.checkBox_HotWhater.Size = new System.Drawing.Size(134, 20);
            this.checkBox_HotWhater.TabIndex = 7;
            this.checkBox_HotWhater.Text = "Прибор  учета";
            this.checkBox_HotWhater.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(5, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Электричесвто";
            // 
            // checkBox_Electricity
            // 
            this.checkBox_Electricity.AutoSize = true;
            this.checkBox_Electricity.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_Electricity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_Electricity.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox_Electricity.Location = new System.Drawing.Point(153, 107);
            this.checkBox_Electricity.Name = "checkBox_Electricity";
            this.checkBox_Electricity.Size = new System.Drawing.Size(134, 20);
            this.checkBox_Electricity.TabIndex = 11;
            this.checkBox_Electricity.Text = "Прибор  учета";
            this.checkBox_Electricity.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(4, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "День";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(4, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ночь";
            // 
            // button_Сalculate
            // 
            this.button_Сalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Сalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Сalculate.Location = new System.Drawing.Point(7, 218);
            this.button_Сalculate.Name = "button_Сalculate";
            this.button_Сalculate.Size = new System.Drawing.Size(105, 33);
            this.button_Сalculate.TabIndex = 14;
            this.button_Сalculate.Text = "Расчитать";
            this.button_Сalculate.UseVisualStyleBackColor = true;
            this.button_Сalculate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_Сalculate_MouseClick);
            // 
            // label_Total
            // 
            this.label_Total.AutoSize = true;
            this.label_Total.BackColor = System.Drawing.Color.Transparent;
            this.label_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Total.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_Total.Location = new System.Drawing.Point(3, 372);
            this.label_Total.Name = "label_Total";
            this.label_Total.Size = new System.Drawing.Size(170, 24);
            this.label_Total.TabIndex = 15;
            this.label_Total.Text = "Сумма к оплате:";
            // 
            // maskedTextBox_ColdWhater
            // 
            this.maskedTextBox_ColdWhater.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskedTextBox_ColdWhater.BackColor = System.Drawing.SystemColors.Window;
            this.maskedTextBox_ColdWhater.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBox_ColdWhater.Cursor = System.Windows.Forms.Cursors.Default;
            this.maskedTextBox_ColdWhater.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox_ColdWhater.ForeColor = System.Drawing.Color.Black;
            this.maskedTextBox_ColdWhater.Location = new System.Drawing.Point(45, 38);
            this.maskedTextBox_ColdWhater.Mask = "00000.000";
            this.maskedTextBox_ColdWhater.Name = "maskedTextBox_ColdWhater";
            this.maskedTextBox_ColdWhater.Size = new System.Drawing.Size(82, 17);
            this.maskedTextBox_ColdWhater.TabIndex = 16;
            // 
            // maskedTextBox_HotWhater
            // 
            this.maskedTextBox_HotWhater.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBox_HotWhater.Cursor = System.Windows.Forms.Cursors.Default;
            this.maskedTextBox_HotWhater.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox_HotWhater.Location = new System.Drawing.Point(46, 73);
            this.maskedTextBox_HotWhater.Mask = "00000.000";
            this.maskedTextBox_HotWhater.Name = "maskedTextBox_HotWhater";
            this.maskedTextBox_HotWhater.Size = new System.Drawing.Size(82, 17);
            this.maskedTextBox_HotWhater.TabIndex = 17;
            // 
            // maskedTextBox_DayElectro
            // 
            this.maskedTextBox_DayElectro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBox_DayElectro.Cursor = System.Windows.Forms.Cursors.Default;
            this.maskedTextBox_DayElectro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox_DayElectro.Location = new System.Drawing.Point(46, 137);
            this.maskedTextBox_DayElectro.Mask = "00000.000";
            this.maskedTextBox_DayElectro.Name = "maskedTextBox_DayElectro";
            this.maskedTextBox_DayElectro.Size = new System.Drawing.Size(82, 17);
            this.maskedTextBox_DayElectro.TabIndex = 18;
            // 
            // maskedTextBox_NightElectro
            // 
            this.maskedTextBox_NightElectro.BackColor = System.Drawing.SystemColors.Window;
            this.maskedTextBox_NightElectro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBox_NightElectro.Cursor = System.Windows.Forms.Cursors.Default;
            this.maskedTextBox_NightElectro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox_NightElectro.Location = new System.Drawing.Point(46, 179);
            this.maskedTextBox_NightElectro.Mask = "00000.000";
            this.maskedTextBox_NightElectro.Name = "maskedTextBox_NightElectro";
            this.maskedTextBox_NightElectro.Size = new System.Drawing.Size(82, 17);
            this.maskedTextBox_NightElectro.TabIndex = 19;
            // 
            // textBox_residents
            // 
            this.textBox_residents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_residents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_residents.Location = new System.Drawing.Point(168, 6);
            this.textBox_residents.Name = "textBox_residents";
            this.textBox_residents.Size = new System.Drawing.Size(36, 19);
            this.textBox_residents.TabIndex = 20;
            this.textBox_residents.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_residents_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(0, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Кол-во проживающих";
            // 
            // button_transfer
            // 
            this.button_transfer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_transfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_transfer.Location = new System.Drawing.Point(127, 218);
            this.button_transfer.Name = "button_transfer";
            this.button_transfer.Size = new System.Drawing.Size(179, 33);
            this.button_transfer.TabIndex = 23;
            this.button_transfer.Text = "передать показания";
            this.button_transfer.UseVisualStyleBackColor = true;
            this.button_transfer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // label_ColdWhater
            // 
            this.label_ColdWhater.AutoSize = true;
            this.label_ColdWhater.BackColor = System.Drawing.Color.Transparent;
            this.label_ColdWhater.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_ColdWhater.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_ColdWhater.Location = new System.Drawing.Point(12, 275);
            this.label_ColdWhater.Name = "label_ColdWhater";
            this.label_ColdWhater.Size = new System.Drawing.Size(47, 18);
            this.label_ColdWhater.TabIndex = 24;
            this.label_ColdWhater.Text = "ХВС:";
            // 
            // label8_HotWhater
            // 
            this.label8_HotWhater.AutoSize = true;
            this.label8_HotWhater.BackColor = System.Drawing.Color.Transparent;
            this.label8_HotWhater.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8_HotWhater.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8_HotWhater.Location = new System.Drawing.Point(11, 293);
            this.label8_HotWhater.Name = "label8_HotWhater";
            this.label8_HotWhater.Size = new System.Drawing.Size(182, 18);
            this.label8_HotWhater.TabIndex = 25;
            this.label8_HotWhater.Text = "ГВС (теплоноситель):";
            // 
            // label_HotEnergy
            // 
            this.label_HotEnergy.AutoSize = true;
            this.label_HotEnergy.BackColor = System.Drawing.Color.Transparent;
            this.label_HotEnergy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_HotEnergy.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_HotEnergy.Location = new System.Drawing.Point(11, 311);
            this.label_HotEnergy.Name = "label_HotEnergy";
            this.label_HotEnergy.Size = new System.Drawing.Size(165, 18);
            this.label_HotEnergy.TabIndex = 26;
            this.label_HotEnergy.Text = "ГВС(теплоэнергия):";
            // 
            // label10_Electro_day_and_all
            // 
            this.label10_Electro_day_and_all.AutoSize = true;
            this.label10_Electro_day_and_all.BackColor = System.Drawing.Color.Transparent;
            this.label10_Electro_day_and_all.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10_Electro_day_and_all.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10_Electro_day_and_all.Location = new System.Drawing.Point(11, 329);
            this.label10_Electro_day_and_all.Name = "label10_Electro_day_and_all";
            this.label10_Electro_day_and_all.Size = new System.Drawing.Size(141, 18);
            this.label10_Electro_day_and_all.TabIndex = 27;
            this.label10_Electro_day_and_all.Text = "Электроэнергия:";
            // 
            // label7_ElectroNight
            // 
            this.label7_ElectroNight.AutoSize = true;
            this.label7_ElectroNight.BackColor = System.Drawing.Color.Transparent;
            this.label7_ElectroNight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7_ElectroNight.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7_ElectroNight.Location = new System.Drawing.Point(11, 347);
            this.label7_ElectroNight.Name = "label7_ElectroNight";
            this.label7_ElectroNight.Size = new System.Drawing.Size(0, 18);
            this.label7_ElectroNight.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(309, 421);
            this.Controls.Add(this.label7_ElectroNight);
            this.Controls.Add(this.label10_Electro_day_and_all);
            this.Controls.Add(this.label_HotEnergy);
            this.Controls.Add(this.label8_HotWhater);
            this.Controls.Add(this.label_ColdWhater);
            this.Controls.Add(this.button_transfer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_residents);
            this.Controls.Add(this.maskedTextBox_NightElectro);
            this.Controls.Add(this.maskedTextBox_DayElectro);
            this.Controls.Add(this.maskedTextBox_HotWhater);
            this.Controls.Add(this.maskedTextBox_ColdWhater);
            this.Controls.Add(this.label_Total);
            this.Controls.Add(this.button_Сalculate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBox_Electricity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox_HotWhater);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox_ColdWhater);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ЕРЦ-Расчет платы за КУ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_ColdWhater;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox_HotWhater;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox_Electricity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_Сalculate;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_ColdWhater;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_HotWhater;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_DayElectro;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_NightElectro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_transfer;
        private System.Windows.Forms.Label label_ColdWhater;
        private System.Windows.Forms.Label label8_HotWhater;
        private System.Windows.Forms.Label label_HotEnergy;
        private System.Windows.Forms.Label label10_Electro_day_and_all;
        private System.Windows.Forms.Label label7_ElectroNight;
        private System.Windows.Forms.Label label_Total;
        private System.Windows.Forms.TextBox textBox_residents;
    }
}

