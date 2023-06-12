using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ERC.Form1;

namespace ERC
{
    internal class CalculationStandart
    {

        //расчет ХВС по нормативу
        public double Сalculation_Coldwhater_standard(TextBox textbox)
        {            
            double P_coldwhater = 0.0;
            double V_coldwhater = double.Parse(textbox.Text) * 4.85;
            P_coldwhater = Math.Round((V_coldwhater * 35.78), 2);
            return P_coldwhater;
        }
        //расчет ГВС Теплоноситель по нормативу
        public double Сalculation_Hotwhater_standard(TextBox textbox)
        {
            
            double P_hotwhater = 0.0;
            double V_hotwhater = double.Parse(textbox.Text) * 4.01;
            P_hotwhater = Math.Round((V_hotwhater * 35.78), 2);
            return P_hotwhater;
        }
        //расчет ГВС Тепловая энергия по нормативу        
        public double Calculation_Thermalenergy_standart(TextBox textbox)
        {
            Form1 f1 = new Form1();
            double P_termal_energy = 0.0;
            double V_termal_energy = (double.Parse(textbox.Text) * 4.01) * 0.05349;
            P_termal_energy = Math.Round((V_termal_energy * 998.69), 2);
            return P_termal_energy;
        }
        //Расчет Электроэнергии по нормативу
       public double Calculation_electricity_standart(TextBox textbox)
        {           
            double P_electricity = 0.0;
            double V_electricit = double.Parse(textbox.Text) * 164;
            P_electricity = Math.Round((V_electricit * 4.28), 2);
            return P_electricity;

        }
    }
}
