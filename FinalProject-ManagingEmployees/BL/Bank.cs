using FinalProject_ManagingEmployees.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_ManagingEmployees.BL
{
    public class Bank
    {
        private int m_id;
        private int m_number;

        public int Id { get => m_id; set => m_id = value; }
        public int Number { get => m_number; set => m_number = value; }

        public Bank() { }

        public Bank(DataRow dataRow)
        {
            //מייצרת הכנסה מתוך שורת הכנסה

            this.Id = (int)dataRow["ID"];
            this.m_number = (int)dataRow["Number"];
        }

        public override string ToString()
        { return $"{m_number}"; }

        public bool Insert()
        {
            return BankDal.Insert(m_number);
        }

        public bool Update()
        {
            return BankDal.Update(m_id, m_number);
        }

        public bool Delete()
        {
            return BankDal.Delete(m_id);
        }
    }
}
