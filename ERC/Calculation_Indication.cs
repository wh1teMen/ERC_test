using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERC
{
    internal class Calculation_Indication
    {
        DataBase dataBase = new DataBase();
      
        //Расчет холодной воды по показаниям
       public double Calculation_ColdWhater(MaskedTextBox maskedText, Indications FirstData)
        {
            
            double P_coldwhater = 0.0;
            double V_coldwhater = double.Parse(maskedText.Text) - FirstData.Cold_whater;
            P_coldwhater = Math.Round((V_coldwhater * 35.78), 2);
            return P_coldwhater;
        }
        //расчет ГВС Теплоноситель 
        public double Сalculation_Hotwhater(MaskedTextBox maskedText, Indications FirstData)
        {
            double P_hotwhater = 0.0;

            double V_hotwhater = double.Parse(maskedText.Text) - FirstData.Hot_whater;
            P_hotwhater = Math.Round((V_hotwhater * 35.78), 2);

            return P_hotwhater;
        }
        //расчет ГВС Тепловая энергия        
       public double Calculation_Thermalenergy(MaskedTextBox maskedText, Indications FirstData)
        {
            double P_termal_energy = 0.0;
            double V_termal_energy = (double.Parse(maskedText.Text) - FirstData.Hot_whater)*0.05349;
            P_termal_energy = Math.Round((V_termal_energy * 998.69), 2);
            return P_termal_energy;
        }
        //Расчет Электроэнергии День
       public double Calculation_electricity_Day(MaskedTextBox maskedText, Indications FirstData)
        {
            double P_electricity = 0.0;

            double V_electricit = double.Parse(maskedText.Text) - FirstData.Day_electro;
            P_electricity = Math.Round((V_electricit * 4.9), 2);
            return P_electricity;

        }
        //Расчет Электроэнергии Ночь
        public double Calculation_electricity_Night(MaskedTextBox maskedText, Indications FirstData)
        {
            double P_electricity = 0.0;
            double V_electricit = double.Parse(maskedText.Text) - FirstData.Night_electro;
            P_electricity = Math.Round((V_electricit * 2.31), 2);
            return P_electricity;
        }

    }
}
