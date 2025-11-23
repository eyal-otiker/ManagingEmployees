using FinalProject_ManagingEmployees.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_ManagingEmployees.BL
{
    public class SalaryIncome
    {
        private int m_id;
        private Salary m_salary;
        private Income m_income;
        private double m_price;

        public int Id { get => m_id; set => m_id = value; }
        public Salary Salary { get => m_salary; set => m_salary = value; }
        internal Income Income { get => m_income; set => m_income = value; }
        public double Price { get => m_price; set => m_price = value; }

        public SalaryIncome() { }

        public SalaryIncome(DataRow dataRow)
        {
            //מייצרת הכנסה בתלוש משכורת מתוך שורת הכנסה בתלוש משכורת

            this.Id = (int)dataRow["ID"];
            this.m_salary = new Salary(dataRow.GetParentRow("SalaryIncomeSalary"));
            this.m_income = new Income(dataRow.GetParentRow("SalaryIncomeIncome"));
            this.m_price = (double)dataRow["Price"];
        }

        public override string ToString()
        { return $"{m_id} - {m_income.Name}"; }

        public bool Insert()
        {
            return SalaryIncomeDal.Insert(m_salary.Id, m_income.Id, m_price);
        }

        public bool Update()
        {
            return SalaryIncomeDal.Update(Id, m_salary.Id, m_income.Id, m_price);
        }

        public bool Delete()
        {
            return SalaryIncomeDal.Delete(m_id);
        }
    }
}
