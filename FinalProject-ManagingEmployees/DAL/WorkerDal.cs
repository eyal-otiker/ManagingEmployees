using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_ManagingEmployees.DAL
{
    class WorkerDal
    {
        public static bool Insert(int business, string firstName, string lastName,
            string idNumber, DateTime bday, string phoneAreaCode, string phoneNumber,
            string email, int accountNumber, int branchNumber, int bankNumber,
            double monthlyPayment, double hourlyPayment)
        {

            //מוסיפה את העסק למסד הנתונים
            //בניית הוראת ה-SQL

            string str = "INSERT INTO TableWorker"
            + "("
            + "[Business],[FirstName],[LastName],[IdNumber],[Bday],[PhoneAreaCode],[PhoneNumber]," +
            "[Email],[AccountNumber],[BranchNumber],[BankNumber],[MonthlyPayment],[HourlyPayment]"
            + ")"
            + " VALUES "
            + "("
            + $"{business},N'{firstName}',N'{lastName}','{idNumber}','{bday.ToString("MM-dd-yyyy")}'," +
            $"'{phoneAreaCode}','{phoneNumber}','{email}',{accountNumber},{branchNumber},{bankNumber}," +
            $"{monthlyPayment},{hourlyPayment}"
            + ")";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static bool Update(int id, int business, string firstName, string lastName, 
            string idNumber, DateTime bday, string phoneAreaCode, string phoneNumber, 
            string email, int accountNumber, int branchNumber, int bankNumber,
            double monthlyPayment, double hourlyPayment)
        {

            //מעדכנת את הלקוח במסד הנתונים

            string str = "UPDATE TableWorker SET"
            + $" [Business] = {business}"
            + $",[FirstName] = N'{firstName}'"
            + $",[LastName] = N'{lastName}'"
            + $",[IdNumber] = '{idNumber}'"
            + $",[Bday] = '{bday.ToString("MM-dd-yyyy")}'"
            + $",[PhoneAreaCode] = '{phoneAreaCode}'"
            + $",[PhoneNumber] = '{phoneNumber}'"
            + $",[Email] = '{email}'"
            + $",[AccountNumber] = {accountNumber}"
            + $",[BranchNumber] = {branchNumber}"
            + $",[BankNumber] = {bankNumber}"
            + $",[MonthlyPayment] = {monthlyPayment}"
            + $",[HourlyRate] = {hourlyPayment}"
            + $" WHERE ID = {id}";

            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה

            return Dal.ExecuteSql(str);
        }

        public static bool Delete(int id)
        {

            //מוחקת את הלקוח ממסד הנתונים

            string str = $"DELETE FROM TableWorker WHERE ID = {id}";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataSet = new DataSet();
            FillDataSet(dataSet);
            dataTable = dataSet.Tables["TableWorker"];
            return dataTable;
        }

        public static void FillDataSet(DataSet dataSet)
        {
            //ממלאת את אוסף הטבלאות בטבלת הלקוחות
            Dal.FillDataSet(dataSet, "TableWorker");

            BusinessDal.FillDataSet(dataSet);

            DataRelation dataRelation = null;
            dataRelation = new DataRelation(

            //שם קשר הגומלין

            "WorkerBusiness"

            //(עמודת הקשר בטבלת האב (המפתח הראשי של טבלת האב

            , dataSet.Tables["TableBusiness"].Columns["ID"]

            //עמודת הקשר בטבלת הבן (המפתח הזר של בטבלת הבן)

            , dataSet.Tables["TableWorker"].Columns["Business"]);

            //הוספת קשר הגומלין לאוסף הטבלאות

            dataSet.Relations.Add(dataRelation);

            BankDal.FillDataSet(dataSet);

            dataRelation = new DataRelation(

            //שם קשר הגומלין

            "WorkerBank"

            //(עמודת הקשר בטבלת האב (המפתח הראשי של טבלת האב

            , dataSet.Tables["TableBank"].Columns["ID"]

            //עמודת הקשר בטבלת הבן (המפתח הזר של בטבלת הבן)

            , dataSet.Tables["TableWorker"].Columns["Bank"]);

            //הוספת קשר הגומלין לאוסף הטבלאות

            dataSet.Relations.Add(dataRelation);
        }
    }
}
