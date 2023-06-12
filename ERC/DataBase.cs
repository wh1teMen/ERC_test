using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Xml;
using System.Diagnostics;

namespace ERC
{
    
    internal class DataBase
    {
        static string BaseName = "Base.db";
        string tableName = (DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString());
        string FirstTableName=(((DateTime.Now.Month)-1).ToString()+ DateTime.Now.Year.ToString());
        SQLiteConnection connects = new SQLiteConnection(string.Format("Data Source={0};", BaseName));       
        
        //Создание таблицы текущего месяца 
        public void CreateBD()
        {
            var SQL_command_create = $"CREATE TABLE IF NOT EXISTS \"{tableName}\" (" +
                $" id INTEGER PRIMARY KEY UNIQUE, " +
                $"ColdWhater double , " +
                $"HotWhater double  , " +                
                $"Electricity_day double , " +
                $"Electricity_night double);";
           
            connects.Open();
            SQLiteCommand command_create = new SQLiteCommand(SQL_command_create, connects);
            command_create.ExecuteNonQuery();
            connects.Close();
        }
        //Добавление показаний по текущему месяцу
        public void AddIndications(string cold_whater, string hot_whater, string day_electro, string night_electro)
        {
            try
            {
                connects.Open();
                var cmd_insert_value = $"insert into  \"{tableName}\"(ColdWhater,HotWhater,Electricity_day,Electricity_night)values(@ColdWhater,@HotWhater,@Electricity_day,@Electricity_night)";
                SQLiteCommand insert = new SQLiteCommand(cmd_insert_value, connects);
                insert.Parameters.Add(new SQLiteParameter("ColdWhater", double.Parse(cold_whater)));
                insert.Parameters.Add(new SQLiteParameter("HotWhater", double.Parse(hot_whater)));              
                insert.Parameters.Add(new SQLiteParameter("Electricity_day", double.Parse(day_electro)));
                insert.Parameters.Add(new SQLiteParameter("Electricity_night", double.Parse(night_electro)));
                insert.ExecuteNonQuery();
                connects.Close();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }

        }
        //Показания за предыдущий месяц
        public Indications Firstindications()
        {
            Indications _IndicationsFirst = new Indications();
            connects.Open();
            var cmd_reder = $"select ColdWhater,HotWhater,Electricity_day,Electricity_night from  \"{FirstTableName}\"";
            SQLiteCommand command_red = new SQLiteCommand(cmd_reder, connects);
            var rider = command_red.ExecuteReader();
            if (rider.HasRows)
            {
                while (rider.Read())
                {
                    _IndicationsFirst.Cold_whater= double.Parse(rider[0].ToString());
                    _IndicationsFirst.Hot_whater = double.Parse(rider[1].ToString());
                    _IndicationsFirst.Day_electro = double.Parse(rider[2].ToString());
                    _IndicationsFirst.Night_electro = double.Parse(rider[3].ToString());
                }
            }
            connects.Close();

            return _IndicationsFirst;
        }
        //показания за текущий месяц
        public Indications Lastindications()
        {
            Indications _IndicationsLast = new Indications();
            connects.Open();
            var cmd_reder = $"select ColdWhater,HotWhater,Electricity_day,Electricity_night from  \"{tableName}\"";
            SQLiteCommand command_red = new SQLiteCommand(cmd_reder, connects);
            var rider = command_red.ExecuteReader();
            if (rider.HasRows)
            {
                while (rider.Read())
                {
                    _IndicationsLast.Cold_whater = double.Parse(rider[0].ToString());
                    _IndicationsLast.Hot_whater = double.Parse(rider[1].ToString());
                    _IndicationsLast.Day_electro = double.Parse(rider[2].ToString());
                    _IndicationsLast.Night_electro = double.Parse(rider[3].ToString());
                }
            }
            connects.Close();

            return _IndicationsLast;
        }
        //Проверка на наличие, переданных показаний в текущем месяце
        public int CountID()
        {
            connects.Open();
            var cmd_reder = $"select count() from  \"{tableName}\"";
            SQLiteCommand command_red = new SQLiteCommand(cmd_reder, connects);
            int count = 0;
            var rider = command_red.ExecuteReader();
            if (rider.HasRows)
            {
                while (rider.Read())
                {
                    count= int.Parse(rider[0].ToString());
                  
                }
            }
            connects.Close();
            return count;


        }


    }
}
