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
    public class SalaryIncomeArr : ArrayList
    {
        public void Fill()
        {

            //להביא מה-DAL טבלה מלאה בכל ההכנסות בתלושי המשכורת

            DataTable dataTable = SalaryIncomeDal.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף ההכנסות בתלושי המשכורת
            //להעביר כל שורה בטבלה להכנסות בתלושי המשכורת

            DataRow dataRow;
            SalaryIncome curSalaryIncome;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                curSalaryIncome = new SalaryIncome(dataRow);
                this.Add(curSalaryIncome);
            }
        }

        public SalaryIncomeArr FilterSalary(Salary salary)
        {
            SalaryIncomeArr salaryIncomeArr = new SalaryIncomeArr();
            SalaryIncome salaryIncome;
            for (int i = 0; i < this.Count; i++)
            {

                //הצבת ההכנסות בתלוש המשכורת הנוכחי במשתנה עזר - הכנסה בתלוש משכורת

                salaryIncome = (this[i] as SalaryIncome);
                if (salaryIncome.Salary.Id == salary.Id)
                {
                    //ההכנסה בתלוש המשכורת ענתה לדרישות הסינון - הוספת ההכנסה בתלוש המשכורת לאוסף ההכנסות בתלוש המשכורת המוחזר
                    salaryIncomeArr.Add(salaryIncome);
                }

            }
            return salaryIncomeArr;
        }

        public SalaryIncomeArr FilterIncome(Income income)
        {
            SalaryIncomeArr SalaryIncomeArr = new SalaryIncomeArr();
            SalaryIncome SalaryIncome;
            for (int i = 0; i < this.Count; i++)
            {

                //הצבת ההכנסה בתלוש המשכורת הנוכחי במשתנה עזר - הכנסה בתלוש המשכורת

                SalaryIncome = (this[i] as SalaryIncome);
                if (SalaryIncome.Income.Id == income.Id)
                {
                    //ההכנסה בתלוש המשכורת ענתה לדרישות הסינון - הוספת ההכנסה בתלוש המשכורת לאוסף ההכנסות בתלוש המשכורת המוחזר
                    SalaryIncomeArr.Add(SalaryIncome);
                }

            }
            return SalaryIncomeArr;
        }

        public bool DoesExist(Income curIncome)
        {

            //מחזירה האם לפחות לאחד מתלושי המשכורת יש את ההכנסה

            for (int i = 0; i < this.Count; i++)
                if ((this[i] as SalaryIncome).Income.Id == curIncome.Id)
                    return true;

            return false;
        }

        public IncomeArr GetIncomeArr()
        {

            //מחזירה את אוסף הפריטים מתוך אוסף הזוגות פריט-הזמנה

            IncomeArr incometArr = new IncomeArr();
            for (int i = 0; i < this.Count; i++)
                incometArr.Add((this[i] as SalaryIncome).Income);
            return incometArr;
        }

        public bool Insert()
        {

            //מוסיפה את אוסף ההכנסות לתלוש משכורת למסד הנתונים

            SalaryIncome SalaryIncome = null;
            for (int i = 0; i < this.Count; i++)
            {
                SalaryIncome = (this[i] as SalaryIncome);
                if (!SalaryIncome.Insert())
                    return false;
            }
            return true;
        }

        public bool Delete()
        {

            //מוחקת את אוסף ההכנסות לתלוש משכורת ממסד הנתונים

            SalaryIncome SalaryIncome = null;
            for (int i = 0; i < this.Count; i++)
            {
                SalaryIncome = (this[i] as SalaryIncome);
                if (!SalaryIncome.Delete())
                    return false;

            }
            return true;
        }
    }
}
