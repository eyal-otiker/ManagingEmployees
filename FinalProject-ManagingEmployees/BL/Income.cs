using FinalProject_ManagingEmployees.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_ManagingEmployees.BL
{
    public class Income
    {
        private int m_id;
        private string m_name;
        private double m_defaultPayment;

        public int Id { get => m_id; set => m_id = value; }
        public string Name { get => m_name; set => m_name = value; }
        public double DefaultPayment { get => m_defaultPayment; set => m_defaultPayment = value; }

        public Income() { }

        public Income(DataRow dataRow)
        {
            //מייצרת הכנסה מתוך שורת הכנסה

            this.Id = (int)dataRow["ID"];
            m_name = dataRow["Name"].ToString();
            this.m_defaultPayment = (double)dataRow["DefaultPayment"];
        }

        public override string ToString()
        { return $"{m_name}"; }

        public bool Insert()
        {
            return IncomeDal.Insert(m_name, m_defaultPayment);
        }

        public bool Update()
        {
            return IncomeDal.Update(m_id, m_name, m_defaultPayment);
        }

        public bool Delete()
        {
            return IncomeDal.Delete(m_id);
        }
    }
}
