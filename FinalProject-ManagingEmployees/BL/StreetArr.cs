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
    class StreetArr : ArrayList
    {
        public void Fill()
        {

            //להביא מה-DAL טבלה מלאה בכל הרחובות

            DataTable dataTable = StreetDal.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף הרחובות
            //להעביר כל שורה בטבלה לרחוב

            DataRow dataRow;
            Street curStreet;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                curStreet = new Street(dataRow);
                this.Add(curStreet);
            }
        }

        public bool IsContain(string StreetName)
        {

            //בדיקה האם יש ישוב עם אותו שם
            //הסרת האותיות י', ו' משם הרחוב לבדיקה - כדיי לשפר מניעת כפילות

            StreetName = StreetName.Replace("י", "");
            StreetName = StreetName.Replace("ו", "");
            string curStreetName;
            for (int i = 0; i < this.Count; i++)
            {
                curStreetName = (this[i] as Street).Name;

                //הסרת האותיות י', ו' משם הרחוב הנוכחי - כדי לשפר מניעת כפילות

                curStreetName = curStreetName.Replace("י", "");
                curStreetName = curStreetName.Replace("ו", "");
                if (curStreetName == StreetName)
                    return true;

            }
            return false;
        }
    }
}
