using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_ManagingEmployees.DAL
{
    class LoginDal
    {
        public static bool Insert(string userName, string password)
        {

            //מוסיפה את העסק למסד הנתונים
            //בניית הוראת ה-SQL

            string str = "INSERT INTO TableLogin"
            + "("
            + "[UserName],[Password]"
            + ")"
            + " VALUES "
            + "("
            + $"N'{userName}',N'{password}'"
            + ")";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataSet = new DataSet();
            FillDataSet(dataSet);
            dataTable = dataSet.Tables["TableLogin"];
            return dataTable;
        }

        public static void FillDataSet(DataSet dataSet)
        {
            //ממלאת את אוסף הטבלאות בטבלת הלקוחות
            Dal.FillDataSet(dataSet, "TableLogin");
        }
    }
}
