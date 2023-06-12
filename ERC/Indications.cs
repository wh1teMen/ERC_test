using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERC
{
    internal class Indications
    {
        private double cold_whater;
        private double hot_whater;
        private double day_electro;
        private double night_electro;

        public double Cold_whater { get => cold_whater;  set => cold_whater = value;}
        public double Hot_whater { get => hot_whater; set => hot_whater = value; }
        public double Day_electro { get => day_electro; set => day_electro=value;}  
        public double Night_electro { get => night_electro;set => night_electro=value;}


    }
}
