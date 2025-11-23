using FinalProject_ManagingEmployees.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_ManagingEmployees.BL
{
    class Login
    {
        private int m_id;
        private string m_userName;
        private string m_password;

        public int Id { get => m_id; set => m_id = value; }
        public string UserName { get => m_userName; set => m_userName = value; }
        public string Password { get => m_password; set => m_password = value; }
       

        public Login() { }

        public Login(DataRow dataRow)
        {
            //מייצרת משתמש מתוך שורת משתמש

            this.m_id = (int)dataRow["ID"];
            m_userName = dataRow["UserName"].ToString();
            m_password = dataRow["Password"].ToString();
        }

        public override string ToString()
        { return $"{m_userName}"; }

        public bool Insert()
        {
            return LoginDal.Insert(m_userName, m_password);
        }
    }
}
