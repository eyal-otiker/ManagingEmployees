using FinalProject_ManagingEmployees.DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_ManagingEmployees.BL
{
    public class BusinessArr : ArrayList
    {
        public void Fill()
        {

            //להביא מה-DAL טבלה מלאה בכל העסקים

            DataTable dataTable = BusinessDal.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף העסקים
            //להעביר כל שורה בטבלה לעסק

            DataRow dataRow;
            Business curBusiness;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                curBusiness = new Business(dataRow);
                this.Add(curBusiness);
            }
        }            

        public bool DoesExist(Street curStreet)
        {

            //מחזירה האם לפחות לאחד מהעסקים יש את הרחוב

            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Business).Street.Id == curStreet.Id)
                    return true;
            
            return false;
        }

        public bool DoesExist(City curCity)
        {

            //מחזירה האם לפחות לאחד מהעסקים יש את היישוב

            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Business).City.Id == curCity.Id)
                    return true;

            return false;
        }

        public bool DoesExist(string userName)
        {
            Business curBusiness;
            for (int i = 0; i < this.Count; i++)
            {
                curBusiness = this[i] as Business;
                if (curBusiness.UserName.UserName == userName)
                    return true;
            }
                
            return false;
        }

        public Business SearchBusiness(string businessName)
        {
            Business curBusiness;
            for (int i = 0; i < this.Count; i++)
            {
                curBusiness = this[i] as Business;
                if (curBusiness.Name == businessName)
                    return curBusiness;
            }
                
            return null;
        }

        public Business SearchBusinessByUserName(string userName)
        {
            Business curBusiness;
            for (int i = 0; i < this.Count; i++)
            {
                curBusiness = this[i] as Business;
                if (curBusiness.UserName.UserName == userName)
                    return curBusiness;
            }

            return null;
        }

        public string SearchBusinessName(string userName)
        {
            Business curBusiness;
            for (int i = 0; i < this.Count; i++)
            {
                curBusiness = this[i] as Business;
                if (curBusiness.UserName.UserName == userName)
                    return curBusiness.Name;
            }

            return null;
        }

        public bool IsContain(string BusinessName)
        {

            //בדיקה האם יש העסק עם אותו שם
            //הסרת האותיות י', ו' משם העסק לבדיקה - כדיי לשפר מניעת כפילות

            BusinessName = BusinessName.Replace("י", "");
            BusinessName = BusinessName.Replace("ו", "");
            string curBusinessName;
            for (int i = 0; i < this.Count; i++)
            {
                curBusinessName = (this[i] as Business).Name;

                //הסרת האותיות י', ו' משם העסק הנוכחי - כדיי לשפר מניעת כפילות

                curBusinessName = curBusinessName.Replace("י", "");
                curBusinessName = curBusinessName.Replace("ו", "");
                if (curBusinessName == BusinessName)
                    return true;

            }
            return false;
        }

        public Business GetBusinessWithMaxId()
        {

            //מחזירה את התלוש משכורת עם המזהה הגבוה ביותר

            Business maxBusiness = new Business();
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as Business).Id > maxBusiness.Id)
                    maxBusiness = (this[i] as Business);

            }
            return maxBusiness;
        }
    }
}
