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
    class LoginArr : ArrayList
    {
        public void Fill()
        {

            //להביא מה-DAL טבלה מלאה בכל ההכנסות

            DataTable dataTable = LoginDal.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף ההכנסות
            //להעביר כל שורה בטבלה להכנסה

            DataRow dataRow;
            Login curLogin;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                curLogin = new Login(dataRow);
                this.Add(curLogin);
            }
        }

        public bool IsContainRegisterUserName(string userName)
        {
            string curUserName; 
            for (int i = 0; i < this.Count; i++)
            {
                curUserName = (this[i] as Login).UserName;

                if (curUserName == userName)
                    return true;

            }
            return false;
        }

        public bool IsContainRegisterPassword(string password)
        {
            string curPassword;
            for (int i = 0; i < this.Count; i++)
            {
                curPassword = (this[i] as Login).Password;

                if (curPassword == password)
                    return true;

            }
            return false;
        }

        public bool IsContainLogin(string userName, string password)
        {
            string curUserName;
            string curPassword;
            for (int i = 0; i < this.Count; i++)
            {
                curUserName = (this[i] as Login).UserName;
                curPassword = (this[i] as Login).Password;

                if (curUserName == userName && curPassword == password)
                    return true;

            }
            return false;
        }

        public Login SearchLogin(string userName, string password)
        {
            string curUserName;
            string curPassword;
            for (int i = 0; i < this.Count; i++)
            {
                curUserName = (this[i] as Login).UserName;
                curPassword = (this[i] as Login).Password;

                if (curUserName == userName && curPassword == password)
                    return this[i] as Login;
            }
            return null;
        }

        public Login SearchLogin(string userName)
        {
            string curUserName;
            Login curLogin;
            for (int i = 0; i < this.Count; i++)
            {
                curLogin = this[i] as Login;
                curUserName = curLogin.UserName;

                if (curUserName == userName)
                    return curLogin;
            }
            return null;
        }
    }
}
