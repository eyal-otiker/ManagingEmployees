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
    public class IncomeArr : ArrayList
    {
        public void Fill()
        {

            //להביא מה-DAL טבלה מלאה בכל ההכנסות

            DataTable dataTable = IncomeDal.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף ההכנסות
            //להעביר כל שורה בטבלה להכנסה

            DataRow dataRow;
            Income curIncome;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                curIncome = new Income(dataRow);
                this.Add(curIncome);
            }
        }

        public IncomeArr Filter(int id, string name)
        {
            IncomeArr incomeArr = new IncomeArr();
            Income income;
            for (int i = 0; i < this.Count; i++)
            {

                //הצבת ההכנסה הנוכחית במשתנה עזר - הכנסה

                income = (this[i] as Income);
                if
                (

                // מזהה 0 – כלומר, לא נבחר מזהה בסינון

                (id == 0 || income.Id == id)
                && income.Name.StartsWith(name)
                )

                    //ההכנסה ענתה לדרישות הסינון - הוספת ההכנסה לאוסף ההכנסות המוחזר

                    incomeArr.Add(income);
            }
            return incomeArr;
        }

        public bool IsContain(string incomeName)
        {

            //בדיקה האם יש הכנסה עם אותו שם
            //הסרת האותיות י', ו' משם ההכנסה לבדיקה - כדיי לשפר מניעת כפילות

            incomeName = incomeName.Replace("י", "");
            incomeName = incomeName.Replace("ו", "");
            string curIncomeName;
            for (int i = 0; i < this.Count; i++)
            {
                curIncomeName = (this[i] as Income).Name;

                //הסרת האותיות י', ו' משם ההכנסה הנוכחית - כדיי לשפר מניעת כפילות

                curIncomeName = curIncomeName.Replace("י", "");
                curIncomeName = curIncomeName.Replace("ו", "");
                if (curIncomeName == incomeName)
                    return true;

            }
            return false;
        }

        public void Remove(IncomeArr incomeArr)
        {

            //מסירה מהאוסף הנוכחי את האוסף המתקבל

            for (int i = 0; i < incomeArr.Count; i++)
                this.Remove(incomeArr[i] as Income);
        }

        public void Remove(Income income)
        {

            //מסירה מהאוסף הנוכחי את הפריט המתקבל

            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Income).Id == income.Id)
                { this.RemoveAt(i); return; }
        }

    }
}
