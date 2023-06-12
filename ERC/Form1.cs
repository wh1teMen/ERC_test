using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Data.SQLite;
using System.Windows.Forms.VisualStyles;
using System.Diagnostics;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using System.Drawing.Drawing2D;

namespace ERC
{
    public partial class Form1 : Form
    {
        DataBase dataBase=new DataBase();
        CalculationStandart calculationStandart = new CalculationStandart();
        Calculation_Indication calculation_Indication = new Calculation_Indication();
       
        public Form1()
        {
            InitializeComponent();
        
        }
        //показания за пердыдущий месяц
        Indications FirstData = new Indications();
        //показания за текущий месяц
        Indications LastData = new Indications();
        private void Form1_Load(object sender, EventArgs e)
        {
            size();
            chekHotWhater();
            chekColdWhater();
            chekElectricity();
            resident();
            dataBase.CreateBD();
            FirstData = dataBase.Firstindications();
            offButton();
            
        }
       

        //фиксация размера окна
        private void size()
        {
            int x = this.Width = 325;
            int y = this.Height = 460;
            var CBSize = new Size(x, y);
            this.MinimumSize = this.MaximumSize = this.Size = CBSize;
        }

        //обработка полей ввода           

        private async void  chekColdWhater()
        {
            try
            {
                while (true)
                {
                    if (checkBox_ColdWhater.Checked)
                    {                        
                        maskedTextBox_ColdWhater.Enabled = true;
                        textBox_residents.Enabled = false;
                        maskedTextBox_ColdWhater.BackColor=Color.White;
                      


                    }
                    else
                    {
                        maskedTextBox_ColdWhater.Enabled=false;
                        maskedTextBox_ColdWhater.Text = string.Empty;
                        maskedTextBox_ColdWhater.BackColor = Color.Gray;



                    }
                    await Task.Delay(100);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            
        }
        private async void chekHotWhater()
        {
            try
            {
                while (true)
                {
                   
                    if (checkBox_HotWhater.Checked)
                    {
                        maskedTextBox_HotWhater.Enabled = true;
                        textBox_residents.Enabled = false;
                        textBox_residents.MaxLength = 2;
                        maskedTextBox_HotWhater.BackColor = Color.White;


                    }
                    else
                    {
                        maskedTextBox_HotWhater.Enabled = false;
                        maskedTextBox_HotWhater.Text = string.Empty;
                        maskedTextBox_HotWhater.BackColor = Color.Gray;

                    }                
                    await Task.Delay(100);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }
        private async void chekElectricity()
        {
            try
            {
               
                while (true)
                {

                    if (checkBox_Electricity.Checked)
                    {
                        maskedTextBox_DayElectro.Enabled = true;
                        maskedTextBox_NightElectro.Enabled=true;
                        textBox_residents.Enabled=false;
                        textBox_residents.MaxLength = 2;
                        maskedTextBox_DayElectro.BackColor = Color.White;
                        maskedTextBox_NightElectro.BackColor = Color.White;


                    }
                    else
                    {
                       maskedTextBox_DayElectro.Enabled = false;
                       maskedTextBox_DayElectro.Text = string.Empty;
                       maskedTextBox_NightElectro.Enabled = false;
                       maskedTextBox_NightElectro.Text=string.Empty;
                        maskedTextBox_DayElectro.BackColor = Color.Gray;
                        maskedTextBox_NightElectro.BackColor = Color.Gray;


                    }
                    await Task.Delay(100);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }
        private async void resident()
        {
            try
            {
                textBox_residents.MaxLength = 2;
                while (true)
                {
                    if(checkBox_ColdWhater.Checked==false
                     && checkBox_HotWhater.Checked==false
                     &&checkBox_Electricity.Checked==false)
                    {
                        textBox_residents.Enabled = true;
                        textBox_residents.BackColor = Color.White;
                    }
                    else { textBox_residents.BackColor = Color.Gray; }
                   
                    
                    await Task.Delay(100);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }
        
        private void textBox_residents_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number)&&number!=8)
            {
                e.Handled = true;
            }

        }

        //получение вводных данных      
        private void button_Сalculate_MouseClick(object sender, MouseEventArgs e)
        {
            
            try
            {
                if (textBox_residents.Enabled == true)
                {
                    outStandart();
                    button_transfer.Enabled = false;                   
                }
                if (textBox_residents.Enabled == false)
                {
                    outIndication();                   
                }                  
            }
            catch (Exception ) { MessageBox.Show("Введите количесвто проживающих","Предупреждение",MessageBoxButtons.OK,MessageBoxIcon.Warning); }                              
           
        }
        //отключение кнопки "Передача показханий"
        private async void offButton()
        {
            try
            {               
                while (true)
                {
                    if (textBox_residents.Enabled == true)
                    {                        
                        button_transfer.Enabled = false;
                    }
                    if (textBox_residents.Enabled == false)
                    {
                        button_transfer.Enabled =true;
                        textBox_residents.Text = "";
                    }
                    await Task.Delay(100);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void outStandart()
        {
           

            label_ColdWhater.Text= "ХВС: " + (calculationStandart.Сalculation_Coldwhater_standard(textBox_residents)).ToString() + " руб." + "\r\n";
            label8_HotWhater.Text = "ГВС(теплоноситель): " + (calculationStandart.Сalculation_Hotwhater_standard(textBox_residents)).ToString() +" руб."+ "\r\n";
            label_HotEnergy.Text= "ГВС(теплоэнергия): " + (calculationStandart.Calculation_Thermalenergy_standart(textBox_residents)).ToString() + " руб." + "\r\n";
            label10_Electro_day_and_all.Text= "Электроэнергия: " + (calculationStandart.Calculation_electricity_standart(textBox_residents)).ToString() + " руб." + "\r\n";
            label7_ElectroNight.Text = "";
           label_Total.Text = "Сумма к оплате: " + (calculationStandart.Сalculation_Coldwhater_standard(textBox_residents)
                + calculationStandart.Сalculation_Hotwhater_standard(textBox_residents)
                + calculationStandart.Calculation_Thermalenergy_standart(textBox_residents)
                + calculationStandart.Calculation_electricity_standart(textBox_residents)).ToString()+ " руб." ;
           

        }

        private void outIndication()
        {
            label_ColdWhater.Text = "ХВС: " + calculation_Indication.Calculation_ColdWhater(maskedTextBox_ColdWhater, FirstData).ToString() +" руб."+"\r\n";
            label8_HotWhater.Text = "ГВС(теплоноситель): " + calculation_Indication.Сalculation_Hotwhater(maskedTextBox_HotWhater, FirstData).ToString() + " руб." + "\r\n";
            label_HotEnergy.Text = "ГВС(теплоэнергия): " + calculation_Indication.Calculation_Thermalenergy(maskedTextBox_HotWhater, FirstData).ToString() + " руб." + "\r\n";
            label10_Electro_day_and_all.Text = "Электроэнергия День: " + calculation_Indication.Calculation_electricity_Day(maskedTextBox_DayElectro, FirstData).ToString() + " руб." + "\r\n";
            label7_ElectroNight.Text= "Электроэнергия Ночь: " + calculation_Indication. Calculation_electricity_Night(maskedTextBox_NightElectro, FirstData).ToString() + " руб." + "\r\n";
            label_Total.Text = "Сумма к оплате: " + (calculation_Indication.Calculation_ColdWhater(maskedTextBox_ColdWhater, FirstData)
                + calculation_Indication.Сalculation_Hotwhater(maskedTextBox_HotWhater, FirstData)
                + calculation_Indication.Calculation_Thermalenergy(maskedTextBox_HotWhater, FirstData)
                + calculation_Indication.Calculation_electricity_Day(maskedTextBox_DayElectro, FirstData)
                + calculation_Indication.Calculation_electricity_Night(maskedTextBox_NightElectro, FirstData)).ToString() + " руб."; 

        }
       
        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataBase.CountID() < 1)
            {
                dataBase.AddIndications(maskedTextBox_ColdWhater.Text, maskedTextBox_HotWhater.Text, maskedTextBox_DayElectro.Text, maskedTextBox_NightElectro.Text);
                LastData = dataBase.Lastindications();
                MessageBox.Show("Показания успешно переданы!!!","Оповещение",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else{ MessageBox.Show("Показания в этом месяце уже переданы!!","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Warning); }
        }

        
    }
}
