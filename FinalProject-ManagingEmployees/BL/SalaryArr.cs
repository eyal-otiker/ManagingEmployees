using FinalProject_ManagingEmployees.DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_ManagingEmployees.BL
{
    public class SalaryArr : ArrayList
    {
        public void Fill()
        {

            //להביא מה-DAL טבלה מלאה בכל התלושי משכורת

            DataTable dataTable = SalaryDal.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף התלושי משכורת
            //להעביר כל שורה בטבלה לתלוש משכורת

            DataRow dataRow;
            Salary curSalary;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                curSalary = new Salary(dataRow);
                this.Add(curSalary);
            }
        }

        public SalaryArr Filter(int countSalary, int idSalary, string month, int year,
            int idWorker, string lastName, string cellNumber, string business, int isPaid, int isEntered)
        {
            SalaryArr salaryArr = new SalaryArr();
            Salary salary;
            for (int i = 0; i < countSalary; i++)
            {
                //הצבת התלוש משכורת הנוכחי במשתנה עזר - תלוש משכורת

                salary = (this[i] as Salary);

                if
                (

                // מזהה 0 – כלומר, לא נבחר מזהה בסינון

                (idSalary == 0 || salary.Id == idSalary)
                && (month == null || salary.Month == month)
                && (year == 0 || salary.Year == year)
                && (idWorker == 0 || salary.Worker.Id == -1 || salary.Worker.Id == idWorker)
                && (salary.Worker.LastName.StartsWith(lastName))
                && ((salary.Worker.PhoneAreaCode + salary.Worker.PhoneNumber).Contains(cellNumber))
                && (business == "" || salary.Worker.Business.Name == business)
                && (isPaid == 2 || salary.IsPaid == isPaid)
                && (isEntered == 2 || (isEntered == 1 && (salary.IsPaid == 0 || salary.IsPaid == 1)) || 
                (isEntered == 0 && salary.IsPaid == 2))
                )

                    //התלוש משכורת ענה לדרישות הסינון - הוספת התלוש משכורת לאוסף התלושי משכורת המוחזר

                    salaryArr.Add(salary);
            }
            return salaryArr;
        }

        public SalaryArr Filter(WorkerArr workerArr, int[] year)
        {
            SalaryArr salaryArr = new SalaryArr();
            Salary newSalary;
            Salary salaryFilter;
            Worker worker;
            int NumYear;
            string NumMonth;

            for (int i = 0; i < workerArr.Count; i++)
            {
                worker = (workerArr[i] as Worker);
                for (int k = 0; k < year.Length; k++)
                {
                    NumYear = year[k];
                    for (int h = 0; h < 12; h++)
                    {
                        newSalary = new Salary();
                        NumMonth = (h + 1).ToString() + "," + 
                            CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(h + 1); 
                        salaryFilter = Filter(NumYear, NumMonth, worker);
                        if (salaryFilter != null)
                            salaryArr.Add(salaryFilter);
                        else
                        {
                            newSalary.Month = NumMonth;
                            newSalary.Year = NumYear;
                            newSalary.Worker = worker;
                            newSalary.IsPaid = 2;
                            salaryArr.Add(newSalary);
                        }
                    }
                }
            }
            
            return salaryArr;
        }

        public Salary Filter(int year, string month, Worker worker)
        {
            Salary curSalary;

            for (int i = 0; i < this.Count; i++)
            {
                curSalary = this[i] as Salary;
                if (curSalary.Month == month && curSalary.Year == year && curSalary.Worker.Id == worker.Id)
                    return curSalary;
            }
            return null;
        }

        public SalaryArr FilterAmountOfWorkers(int year, string month, string name)
        {

            //מחזירה את אוסף התלושי משכורת מאותה שנה ואותו חודש ומהעסק הנבחר

            SalaryArr returnArr = new SalaryArr();
            foreach (Salary item in this)
                if (item.Year == year && item.Month == month && item.Worker.Business.Name == name)
                    returnArr.Add(item);
            return returnArr;
        }

        public double FilterSumSalaryOfWorkers(int year, string month, string name)
        {
            //מחזירה את אוסף התלושי משכורת מאותה שנה ואותו חודש ומהעסק הנבחר

            double sum = 0;
            foreach (Salary item in this)
                if (item.Year == year && item.Month == month && item.Worker.Business.Name == name)
                    sum += item.SumGross;

            sum = Math.Round((10.0 * sum) / 10.0);
            return sum;
        }

        public double FilterAverageSalaryOfWorkers(int year, string month, string name)
        {
            //מחזירה את אוסף התלושי משכורת מאותה שנה ואותו חודש ומהעסק הנבחר

            int count = 0;
            double sum = 0, avg;
            foreach (Salary item in this)
                if (item.Year == year && item.Month == month && item.Worker.Business.Name == name)
                {
                    sum += item.SumGross;
                    count++;
                }

            if (count != 0)
            {
                avg = (double)(sum / count);
                avg = Math.Round((10.0 * avg) / 10.0);
            }
            else
                avg = 0;

            return avg;
        }

        public double FilterSalaryWorker(int year, string month, string business, string worker)
        {
            //מחזירה את אוסף התלושי משכורת מאותה שנה ואותו חודש ומהעסק הנבחר

            double sum = 0;
            foreach (Salary item in this)
                if (item.Year == year && item.Month == month && item.Worker.Business.Name == business &&
                    item.Worker.ToString() == worker)
                {
                    sum = item.SumGross;
                    return sum;
                }

            sum = Math.Round((10.0 * sum) / 10.0);
            return sum;
        }

        public double FilterAmountHoursWorker(int year, string month, string business, string worker)
        {
            //מחזירה את אוסף התלושי משכורת מאותה שנה ואותו חודש ומהעסק הנבחר

            double amountHours = 0;
            foreach (Salary item in this)
                if (item.Year == year && item.Month == month && item.Worker.Business.Name == business &&
                    item.Worker.ToString() == worker)
                {
                    if (item.AmountHours100 != 0)
                        amountHours += item.AmountHours100;

                    if (item.AmountHours125 != 0)
                        amountHours += item.AmountHours125;

                    if (item.AmountHours150 != 0)
                        amountHours += item.AmountHours150;
                }

            amountHours = Math.Round((10.0 * amountHours) / 10.0);
            return amountHours;
        }

        public bool IsContain(Salary salary)
        {
            string curSalaryMonth;
            int curSalaryYear;
            string curSalaryWorker;

            for (int i = 0; i < this.Count; i++)
            {
                curSalaryMonth = (this[i] as Salary).Month;
                curSalaryYear = (this[i] as Salary).Year;
                curSalaryWorker = (this[i] as Salary).Worker.FirstName + (this[i] as Salary).Worker.LastName;

                if (curSalaryMonth == salary.Month && curSalaryYear == salary.Year &&
                    curSalaryWorker == salary.Worker.FirstName + salary.Worker.LastName)
                        return true;
            }
            return false;
        }

        public bool DoesExist(Worker curWorker)
        {

            //מחזירה האם לפחות לאחד מתלושי המשכורת יש את העובד

            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Salary).Worker.Id == curWorker.Id)
                    return true;

            return false;
        }

        public Dictionary<string, int> GetDictionaryAmountOfWorkers(int year, string name)
        {

            //מחזירה משתנה מסוג מילון הכולל עבור כל חודש בשנה מסוימת, כמות העובדים בעסק

            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            for (int i = 1; i <= 12; i++)
            {

                //אם רוצים את שם החודש בהתאם לשפת מערכת ההפעלה
                string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i);
                dictionary.Add(monthName, this.FilterAmountOfWorkers(year, i + "," + monthName, name).Count);
            }
            return dictionary;
        }

        public Dictionary<string, double> GetDictionarySumSalaryOfWorkers(int year, string name)
        {

            //מחזירה משתנה מסוג מילון הכולל עבור כל חודש בשנה מסוימת, כמות העובדים בעסק

            Dictionary<string, double> dictionary = new Dictionary<string, double>();
            for (int i = 1; i <= 12; i++)
            {

                //אם רוצים את שם החודש בהתאם לשפת מערכת ההפעלה
                string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i);
                dictionary.Add(monthName, FilterSumSalaryOfWorkers(year, i + "," + monthName, name));
            }
            return dictionary;
        }

        public Dictionary<string, double> GetDictionaryAverageSalaryOfWorkers(int year, string name)
        {

            //מחזירה משתנה מסוג מילון הכולל עבור כל חודש בשנה מסוימת, כמות העובדים בעסק

            Dictionary<string, double> dictionary = new Dictionary<string, double>();
            for (int i = 1; i <= 12; i++)
            {

                //אם רוצים את שם החודש בהתאם לשפת מערכת ההפעלה
                string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i);
                dictionary.Add(monthName, FilterAverageSalaryOfWorkers(year, i + "," + monthName, name));
            }
            return dictionary;
        }

        public Dictionary<string, double> GetDictionarySalaryWorker(int year, string business, string worker)
        {

            //מחזירה משתנה מסוג מילון הכולל עבור כל חודש בשנה מסוימת, כמות העובדים בעסק

            Dictionary<string, double> dictionary = new Dictionary<string, double>();
            for (int i = 1; i <= 12; i++)
            {

                //אם רוצים את שם החודש בהתאם לשפת מערכת ההפעלה
                string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i);
                dictionary.Add(monthName, FilterSalaryWorker(year, i + "," + monthName, business, worker));
            }
            return dictionary;
        }

        public Dictionary<string, double> GetDictionaryAmountHoursWorker(int year, string business, string worker)
        {

            //מחזירה משתנה מסוג מילון הכולל עבור כל חודש בשנה מסוימת, כמות העובדים בעסק

            Dictionary<string, double> dictionary = new Dictionary<string, double>();
            for (int i = 1; i <= 12; i++)
            {

                //אם רוצים את שם החודש בהתאם לשפת מערכת ההפעלה
                string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i);
                dictionary.Add(monthName, FilterAmountHoursWorker(year, i + "," + monthName, business, worker));
            }
            return dictionary;
        }

        public Salary GetSalaryWithMaxId()
        {

            //מחזירה את התלוש משכורת עם המזהה הגבוה ביותר

            Salary maxSalary = new Salary();
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as Salary).Id > maxSalary.Id)
                    maxSalary = (this[i] as Salary);

            }
            return maxSalary;
        }

    }
}
