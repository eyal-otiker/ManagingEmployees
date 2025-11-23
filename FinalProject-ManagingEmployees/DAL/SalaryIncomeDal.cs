using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_ManagingEmployees.DAL
{
    class SalaryIncomeDal
    {
        public static bool Insert(int salary, int income, double price)
        {

            //מוסיפה את ההכנסה בתלוש משכורת למסד הנתונים
            //בניית הוראת ה-SQL

            string str = "INSERT INTO TableSalaryIncome"
            + "("
            + "[Salary],[Income],[Price]"
            + ")"
            + " VALUES "
            + "("
            + $"{salary},{income},{price}"
            + ")";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static bool Update(int id, int salary, int income, double price)
        {

            //מעדכנת את ההכנסה בתלוש משכורת במסד הנתונים

            string str = "UPDATE TableSalaryIncome SET"
            + $",[Salary] = {salary}"
            + $",[Income] = {income}"
            + $",[Price]  = {price}"
            + $" WHERE ID = {id}";

            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה

            return Dal.ExecuteSql(str);
        }

        public static bool Delete(int id)
        {

            //מוחקת את ההכנסה בתלוש משכורת ממסד הנתונים

            string str = $"DELETE FROM TableSalaryIncome WHERE ID = {id}";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataSet = new DataSet();
            FillDataSet(dataSet);
            dataTable = dataSet.Tables["TableSalaryIncome"];
            return dataTable;
        }

        public static void FillDataSet(DataSet dataSet)
        {
            //ממלאת את אוסף הטבלאות בטבלת ההכנסות בתלוש משכורת
            Dal.FillDataSet(dataSet, "TableSalaryIncome");

            SalaryDal.FillDataSet(dataSet);

            DataRelation dataRelation = null;
            dataRelation = new DataRelation(

            //שם קשר הגומלין

            "SalaryIncomeSalary"

            //(עמודת הקשר בטבלת האב (המפתח הראשי של טבלת האב

            , dataSet.Tables["TableSalary"].Columns["ID"]

            //עמודת הקשר בטבלת הבן (המפתח הזר של בטבלת הבן)

            , dataSet.Tables["TableSalaryIncome"].Columns["Salary"]);

            //הוספת קשר הגומלין לאוסף הטבלאות

            dataSet.Relations.Add(dataRelation);

            IncomeDal.FillDataSet(dataSet);

            dataRelation = new DataRelation(

            //שם קשר הגומלין

            "SalaryIncomeIncome"

            //(עמודת הקשר בטבלת האב (המפתח הראשי של טבלת האב

            , dataSet.Tables["TableIncome"].Columns["ID"]

            //עמודת הקשר בטבלת הבן (המפתח הזר של בטבלת הבן)

            , dataSet.Tables["TableSalaryIncome"].Columns["Income"]);

            //הוספת קשר הגומלין לאוסף הטבלאות

            dataSet.Relations.Add(dataRelation);
        }
    }
}
