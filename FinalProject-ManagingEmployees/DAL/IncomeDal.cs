using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_ManagingEmployees.DAL
{
    class IncomeDal
    {
        public static bool Insert(string name, double defaultPayment)
        {

            //מוסיפה את ההכנסה למסד הנתונים
            //בניית הוראת ה-SQL

            string str = "INSERT INTO TableIncome"
            + "("
            + "[Name],[DefaultPayment]"
            + ")"
            + " VALUES "
            + "("
            + $"N'{name}',{defaultPayment}"
            + ")";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static bool Update(int id, string name, double defaultPayment)
        {

            //מעדכנת את ההכנסה במסד הנתונים

            string str = "UPDATE TableIncome SET"
            + $" [Name] = N'{name}'"
            + $" [DefaultPayment] = {defaultPayment}"
            + $" WHERE ID = {id}";

            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה

            return Dal.ExecuteSql(str);
        }

        public static bool Delete(int id)
        {

            //מוחקת את ההכנסה ממסד הנתונים

            string str = $"DELETE FROM TableIncome WHERE ID = {id}";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataSet = new DataSet();
            FillDataSet(dataSet);
            dataTable = dataSet.Tables["TableIncome"];
            return dataTable;
        }

        public static void FillDataSet(DataSet dataSet)
        {
            //ממלאת את אוסף הטבלאות בטבלה הנוכחית - בתנאי שהטבלה לא נמצאת כבר באוסף
            if (!dataSet.Tables.Contains("TableIncome"))
            {
                Dal.FillDataSet(dataSet, "TableIncome", "[Name]");
            }
        }
    }
}
