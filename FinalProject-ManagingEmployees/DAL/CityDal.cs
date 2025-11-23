using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_ManagingEmployees.DAL
{
    class CityDal
    {
        public static bool Insert(string name)
        {

            //מוסיפה את היישוב למסד הנתונים
            //בניית הוראת ה-SQL

            string str = "INSERT INTO TableCity"
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

            //מעדכנת את היישוב במסד הנתונים

            string str = "UPDATE TableCity SET"
            + $" [Name] = N'{name}'"
            + $" WHERE ID = {id}";

            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה

            return Dal.ExecuteSql(str);
        }

        public static bool Delete(int id)
        {

            //מוחקת את היישוב ממסד הנתונים

            string str = $"DELETE FROM TableCity WHERE ID = {id}";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataSet = new DataSet();
            FillDataSet(dataSet);
            dataTable = dataSet.Tables["TableCity"];
            return dataTable;
        }

        public static void FillDataSet(DataSet dataSet)
        {
            //ממלאת את אוסף הטבלאות בטבלה הנוכחית - בתנאי שהטבלה לא נמצאת כבר באוסף
            if (!dataSet.Tables.Contains("TableCity"))
            {
                Dal.FillDataSet(dataSet, "TableCity", "[Name]");
            }
        }
    }
}
