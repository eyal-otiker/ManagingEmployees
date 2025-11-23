using FinalProject_ManagingEmployees.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_ManagingEmployees.BL
{
    public class Business
    {
        private int m_id;
        private Login m_userName;
        private string m_name;
        private Street m_street;
        private int m_numberStreet;
        private City m_city;
        private string m_phoneAreaCode;
        private string m_phoneNumber;
        private string m_picture;

        public int Id { get => m_id; set => m_id = value; }
        internal Login UserName { get => m_userName; set => m_userName = value; }
        public string Name { get => m_name; set => m_name = value; }
        public Street Street { get => m_street; set => m_street = value; }
        public int NumberStreet { get => m_numberStreet; set => m_numberStreet = value; }
        public City City { get => m_city; set => m_city = value; }
        public string PhoneAreaCode { get => m_phoneAreaCode; set => m_phoneAreaCode = value; }
        public string PhoneNumber { get => m_phoneNumber; set => m_phoneNumber = value; }
        public string Picture { get => m_picture; set => m_picture = value; }

        public Business() { }

        public Business(DataRow dataRow)
        {
            //מייצרת עסק מתוך שורת עסק

            this.m_id = (int)dataRow["ID"];
            m_userName = new Login(dataRow.GetParentRow("BusinessLogin"));
            m_name = dataRow["Name"].ToString();
            if (dataRow.GetParentRow("BusinessStreet") != null)
                m_street = new Street(dataRow.GetParentRow("BusinessStreet"));
            if (dataRow["NumberStreet"] != null)
                m_numberStreet = (int)dataRow["NumberStreet"];
            if (dataRow.GetParentRow("BusinessCity") != null)
                m_city = new City(dataRow.GetParentRow("BusinessCity"));
            if (dataRow["PhoneAreaCode"] != null)
                m_phoneAreaCode = dataRow["PhoneAreaCode"].ToString();
            if (dataRow["PhoneNumber"] != null)
                m_phoneNumber = dataRow["PhoneNumber"].ToString();
            if (dataRow["Picture"] != null)
                m_picture = dataRow["Picture"].ToString();
        }

        public override string ToString()
        { return $"{m_name}"; }

        public bool Insert()
        {
            return BusinessDal.Insert(m_userName.Id, m_name, m_street.Id, 
                m_numberStreet, m_city.Id, m_phoneAreaCode, m_phoneNumber, m_picture);
        }

        public bool Update()
        {
            return BusinessDal.Update(m_id, m_userName.Id, m_name, m_street.Id,
                m_numberStreet, m_city.Id, m_phoneAreaCode, m_phoneNumber, m_picture);
        }
    }

}
