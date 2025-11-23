using FinalProject_ManagingEmployees.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_ManagingEmployees.BL
{
    public class Worker
    {
        private int m_id;
        private Business m_business;
        private string m_firstName;
        private string m_lastName;
        private string m_idNumber;
        private DateTime m_bday;
        private string m_phoneAreaCode;
        private string m_phoneNumber;
        private string m_email;
        private int m_accountNumber;
        private int m_branch;
        private Bank m_bank;
        private double m_monthlyPayment;
        private double m_hourlyPayment;

        public int Id { get => m_id; set => m_id = value; }
        public Business Business { get => m_business; set => m_business = value; }
        public string FirstName { get => m_firstName; set => m_firstName = value; }
        public string LastName { get => m_lastName; set => m_lastName = value; }
        public string IdNumber { get => m_idNumber; set => m_idNumber = value; }
        public DateTime Bday { get => m_bday; set => m_bday = value; }
        public string PhoneAreaCode { get => m_phoneAreaCode; set => m_phoneAreaCode = value; }
        public string PhoneNumber { get => m_phoneNumber; set => m_phoneNumber = value; }
        public string Email { get => m_email; set => m_email = value; }
        public int AccountNumber { get => m_accountNumber; set => m_accountNumber = value; }
        internal int Branch { get => m_branch; set => m_branch = value; }
        internal Bank Bank { get => m_bank; set => m_bank = value; }
        public double MonthlyPayment { get => m_monthlyPayment; set => m_monthlyPayment = value; }
        public double HourlyPayment { get => m_hourlyPayment; set => m_hourlyPayment = value; }

        public Worker() { }

        public Worker(DataRow dataRow)
        {

            //מייצרת עובד מתוך שורת עובד

            this.m_id = (int)dataRow["ID"];
            this.m_business = new Business(dataRow.GetParentRow("WorkerBusiness"));
            m_firstName = dataRow["FirstName"].ToString();
            m_lastName = dataRow["LastName"].ToString();
            m_idNumber = dataRow["IdNumber"].ToString();
            m_bday = (DateTime)dataRow["Bday"];
            m_phoneAreaCode = dataRow["PhoneAreaCode"].ToString();
            m_phoneNumber = dataRow["PhoneNumber"].ToString();
            if (dataRow["Email"] != null)
                m_email = dataRow["Email"].ToString();
            this.m_accountNumber = (int)dataRow["AccountNumber"];
            this.m_branch = (int)dataRow["Branch"];
            this.m_bank = new Bank(dataRow.GetParentRow("WorkerBank"));
            if (dataRow["MonthlyPayment"] != null)
                this.m_monthlyPayment = (double)dataRow["MonthlyPayment"];
            if (dataRow["HourlyPayment"] != null)
                this.m_hourlyPayment = (double)dataRow["HourlyPayment"];
        }

        public override string ToString()
        { return $"{m_lastName} {m_firstName}"; }

        public bool Insert()
        {
            return WorkerDal.Insert(m_business.Id, m_firstName, m_lastName, m_idNumber, 
            m_bday, m_phoneAreaCode, m_phoneNumber, m_email, m_accountNumber, 
            m_branch, m_bank.Id, m_monthlyPayment, m_hourlyPayment);
        }

        public bool Update()
        {
            return WorkerDal.Update(m_id, m_business.Id, m_firstName, m_lastName, 
                m_idNumber, m_bday, m_phoneAreaCode, m_phoneNumber, m_email,
                m_accountNumber, m_branch, m_bank.Id, 
                m_monthlyPayment, m_hourlyPayment);
        }

        public bool Delete()
        {
            return WorkerDal.Delete(m_id);
        }
    }
}
