using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_ManagingEmployees.DAL
{
    class BusinessDal
    {
        public static bool Insert(int userName, string name, int street, int numberStreet, 
            int city, string phoneAreaCode, string phoneNumber, string picture)
        {

            //מוסיפה את העסק למסד הנתונים
            //בניית הוראת ה-SQL

            string str = "INSERT INTO TableBusiness"
            + "("
            + "[UserName],[Name],[Street],[NumberStreet],[City],[PhoneAreaCode],[PhoneNumber],[Picture]"
            + ")"
            + " VALUES "
            + "("
            + $"{userName},N'{name}',{street},{numberStreet},{city},'{phoneAreaCode}','{phoneNumber}',N'{picture}'"
            + ")";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static bool Update(int id, int userName, string name, int street, int numberStreet, int city, 
            string phoneAreaCode, string phoneNumber, string picture)
        {

            //מעדכנת את העסק במסד הנתונים

            string str = "UPDATE TableBusiness SET"
            + $" [UserName] = {userName}"
            + $",[Name] = N'{name}'"
            + $",[Street] = {street}"
            + $",[NumberStreet] = {numberStreet}"
            + $",[City] = {city}"
            + $",[PhoneAreaCode] = '{phoneAreaCode}'"
            + $",[PhoneNumber] = '{phoneNumber}'"
            + $",[Picture] = N'{picture}'"
            + $" WHERE ID = {id}";

            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה

            return Dal.ExecuteSql(str);
        }

        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataSet = new DataSet();
            FillDataSet(dataSet);
            dataTable = dataSet.Tables["TableBusiness"];
            return dataTable;
        }

        public static void FillDataSet(DataSet dataSet)
        {
            //ממלאת את אוסף הטבלאות בטבלת הלקוחות
            Dal.FillDataSet(dataSet, "TableBusiness");

            LoginDal.FillDataSet(dataSet);

            DataRelation dataRelation = null;
            dataRelation = new DataRelation(

            //שם קשר הגומלין

            "BusinessLogin"

            //(עמודת הקשר בטבלת האב (המפתח הראשי של טבלת האב

            , dataSet.Tables["TableLogin"].Columns["ID"]

            //עמודת הקשר בטבלת הבן (המפתח הזר של בטבלת הבן)

            , dataSet.Tables["TableBusiness"].Columns["UserName"]);

            //הוספת קשר הגומלין לאוסף הטבלאות

            dataSet.Relations.Add(dataRelation);

            StreetDal.FillDataSet(dataSet);
            dataRelation = new DataRelation(

            //שם קשר הגומלין

            "BusinessStreet"

            //(עמודת הקשר בטבלת האב (המפתח הראשי של טבלת האב

            , dataSet.Tables["TableStreet"].Columns["ID"]

            //עמודת הקשר בטבלת הבן (המפתח הזר של בטבלת הבן)

            , dataSet.Tables["TableBusiness"].Columns["Street"], false);

            //הוספת קשר הגומלין לאוסף הטבלאות

            dataSet.Relations.Add(dataRelation);

            CityDal.FillDataSet(dataSet);

            dataRelation = new DataRelation(

            //שם קשר הגומלין

            "BusinessCity"

            //(עמודת הקשר בטבלת האב (המפתח הראשי של טבלת האב

            , dataSet.Tables["TableCity"].Columns["ID"]

            //עמודת הקשר בטבלת הבן (המפתח הזר של בטבלת הבן)

            , dataSet.Tables["TableBusiness"].Columns["City"], false);

            //הוספת קשר הגומלין לאוסף הטבלאות

            dataSet.Relations.Add(dataRelation);
        }
    }
}
