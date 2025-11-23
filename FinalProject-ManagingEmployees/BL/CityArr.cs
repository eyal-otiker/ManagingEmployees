using FinalProject_ManagingEmployees.DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_ManagingEmployees.BL
{
    public class CityArr : ArrayList
    {
        public void Fill()
        {

            //להביא מה-DAL טבלה מלאה בכל היישובים

            DataTable dataTable = CityDal.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף היישובים
            //להעביר כל שורה בטבלה ליישוב

            DataRow dataRow;
            City curCity;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                curCity = new City(dataRow);
                this.Add(curCity);
            }
        }

        public bool IsContain(string CityName)
        {

            //בדיקה האם יש ישוב עם אותו שם
            //הסרת האותיות י', ו' משם היישוב לבדיקה - כדיי לשפר מניעת כפילות

            CityName = CityName.Replace("י", "");
            CityName = CityName.Replace("ו", "");
            string curCityName;
            for (int i = 0; i < this.Count; i++)
            {
                curCityName = (this[i] as City).Name;

                //הסרת האותיות י', ו' משם היישוב הנוכחי - כדיי לשפר מניעת כפילות

                curCityName = curCityName.Replace("י", "");
                curCityName = curCityName.Replace("ו", "");
                if (curCityName == CityName)
                    return true;

            }
            return false;
        }
    }
}
