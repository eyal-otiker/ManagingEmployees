using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_ManagingEmployees.DAL
{
    class StreetDal
    {
        public static bool Insert(string name)
        {

            //מוסיפה את הרחוב למסד הנתונים
            //בניית הוראת ה-SQL

            string str = "INSERT INTO TableStreet"
            + "("
            + "[Name]"
            + ")"
            + " VALUES "
            + "("
            + $"N'{name}'"
            + ")";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static bool Update(int id, string name)
        {

            //מעדכנת את הרחוב במסד הנתונים

            string str = "UPDATE TableStreet SET"
            + $" [Name] = N'{name}'"
            + $" WHERE ID = {id}";

            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה

            return Dal.ExecuteSql(str);
        }

        public static bool Delete(int id)
        {

            //מוחקת את הרחוב ממסד הנתונים

            string str = $"DELETE FROM TableStreet WHERE ID = {id}";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataSet = new DataSet();
            FillDataSet(dataSet);
            dataTable = dataSet.Tables["TableStreet"];
            return dataTable;
        }

        public static void FillDataSet(DataSet dataSet)
        {
            //ממלאת את אוסף הטבלאות בטבלה הנוכחית - בתנאי שהטבלה לא נמצאת כבר באוסף
            if (!dataSet.Tables.Contains("TableStreet"))
            {
                Dal.FillDataSet(dataSet, "TableStreet", "[Name]");
            }
        }
    }
}
