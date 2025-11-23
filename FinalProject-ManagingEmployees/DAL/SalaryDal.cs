using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_ManagingEmployees.DAL
{
    class SalaryDal
    {
        public static bool Insert(string month, int year, int worker,
            double amountHours100, double amountHours125, double amountHours150, 
            double incomeTax, double nationalInsurance, double healthInsurance,
            double pensionPayment, double advancedStudyFund,
            double sumGross, double sumNet, int isPaid)
        {

            //מוסיפה את התלוש משכורת למסד הנתונים
            //בניית הוראת ה-SQL

            string str = "INSERT INTO TableSalary"
            + "("
            + "[Month],[Year],[Worker],[AmountHours100],[AmountHours125],[AmountHours150]," +
            "[IncomeTax],[NationalInsurance],[HealthInsurance],[PensionPayment]," +
            "[AdvancedStudyFund],[SumGross],[SumNet],[IsPaid]"
            + ")"
            + " VALUES "
            + "("
            + $"N'{month}',{year},{worker},{amountHours100},{amountHours125},{amountHours150}," +
            $"{incomeTax},{nationalInsurance},{healthInsurance},{pensionPayment}," +
            $"{advancedStudyFund},{sumGross},{sumNet},{isPaid}"
            + ")";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static bool Update(int id, string month, int year, int worker,
            double amountHours100, double amountHours125, double amountHours150, 
            double incomeTax, double nationalInsurance, double healthInsurance,
            double pensionPayment, double advancedStudyFund,
            double sumGross, double sumNet, int isPaid)
        {

            //מעדכנת את התלוש משכורת במסד הנתונים

            string str = "UPDATE TableSalary SET"
            + $" [Month] = N'{month}'"
            + $",[Year] = {year}"
            + $",[Worker] = {worker}"
            + $",[AmountHours100] = {amountHours100}"
            + $",[AmountHours125] = {amountHours125}"
            + $",[AmountHours150] = {amountHours150}"
            + $",[IncomeTax] = {incomeTax}"
            + $",[NationalInsurance] = {nationalInsurance}"
            + $",[HealthInsurance] = {healthInsurance}"
            + $",[PensionPayment] = {pensionPayment}"
            + $",[AdvancedStudyFund] = {advancedStudyFund}"
            + $",[SumGross] = {sumGross}"
            + $",[SumNet] = {sumNet}"
            + $",[IsPaid] = {isPaid}"
            + $" WHERE ID = {id}";

            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה

            return Dal.ExecuteSql(str);
        }

        public static bool Delete(int id)
        {

            //מוחקת את התלוש משכורת ממסד הנתונים

            string str = $"DELETE FROM TableSalary WHERE ID = {id}";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataSet = new DataSet();
            FillDataSet(dataSet);
            dataTable = dataSet.Tables["TableSalary"];
            return dataTable;
        }

        public static void FillDataSet(DataSet dataSet)
        {
            //ממלאת את אוסף הטבלאות בטבלת הלקוחות
            Dal.FillDataSet(dataSet, "TableSalary");

            WorkerDal.FillDataSet(dataSet);

            DataRelation dataRelation = null;
            dataRelation = new DataRelation(

            //שם קשר הגומלין

            "SalaryWorker"

            //(עמודת הקשר בטבלת האב (המפתח הראשי של טבלת האב

            , dataSet.Tables["TableWorker"].Columns["ID"]

            //עמודת הקשר בטבלת הבן (המפתח הזר של בטבלת הבן)

            , dataSet.Tables["TableSalary"].Columns["Worker"]);

            //הוספת קשר הגומלין לאוסף הטבלאות

            dataSet.Relations.Add(dataRelation);
        }
    }
}
