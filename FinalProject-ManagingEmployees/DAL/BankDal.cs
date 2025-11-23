using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_ManagingEmployees.DAL
{
    class BankDal
    {
        public static bool Insert(int number)
        {

            //מוסיפה את ההכנסה למסד הנתונים
            //בניית הוראת ה-SQL

            string str = "INSERT INTO TableBank"
            + "("
            + "[Number]"
            + ")"
            + " VALUES "
            + "("
            + $"{number}"
            + ")";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static bool Update(int id, int number)
        {

            //מעדכנת את ההכנסה במסד הנתונים

            string str = "UPDATE TableBank SET"
            + $" [Number] = {number}"
            + $" WHERE ID = {id}";

            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה

            return Dal.ExecuteSql(str);
        }

        public static bool Delete(int id)
        {

            //מוחקת את ההכנסה ממסד הנתונים

            string str = $"DELETE FROM TableBank WHERE ID = {id}";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataSet = new DataSet();
            FillDataSet(dataSet);
            dataTable = dataSet.Tables["TableBank"];
            return dataTable;
        }

        public static void FillDataSet(DataSet dataSet)
        {
            //ממלאת את אוסף הטבלאות בטבלה הנוכחית - בתנאי שהטבלה לא נמצאת כבר באוסף
            if (!dataSet.Tables.Contains("TableBank"))
            {
                Dal.FillDataSet(dataSet, "TableBank", "[Number]");
            }
        }
    }
}
