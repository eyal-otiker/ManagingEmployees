using FinalProject_ManagingEmployees.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_ManagingEmployees.BL
{
    public class Salary
    {
        private int m_id;
        private string m_month;
        private int m_year;
        private Worker m_worker;
        private double m_amountHours100;
        private double m_amountHours125;
        private double m_amountHours150;
        private double m_incomeTax;
        private double m_nationalInsurance;
        private double m_healthInsurance;
        private double m_pensionPayment;
        private double m_advancedStudyFund;
        private double m_sumGross;
        private double m_sumNet;
        private int m_isPaid;

        public int Id { get => m_id; set => m_id = value; }
        public string Month { get => m_month; set => m_month = value; }
        public int Year { get => m_year; set => m_year = value; }
        public Worker Worker { get => m_worker; set => m_worker = value; }
        public double AmountHours100 { get => m_amountHours100; set => m_amountHours100 = value; }
        public double AmountHours125 { get => m_amountHours125; set => m_amountHours125 = value; }
        public double AmountHours150 { get => m_amountHours150; set => m_amountHours150 = value; }
        public double IncomeTax { get => m_incomeTax; set => m_incomeTax = value; }
        public double NationalInsurance { get => m_nationalInsurance; set => m_nationalInsurance = value; }
        public double HealthInsurance { get => m_healthInsurance; set => m_healthInsurance = value; }
        public double PensionPayment { get => m_pensionPayment; set => m_pensionPayment = value; }
        public double AdvancedStudyFund { get => m_advancedStudyFund; set => m_advancedStudyFund = value; }
        public double SumGross { get => m_sumGross; set => m_sumGross = value; }
        public double SumNet { get => m_sumNet; set => m_sumNet = value; }
        public int IsPaid { get => m_isPaid; set => m_isPaid = value; }

        public Salary() { }

        public Salary(DataRow dataRow)
        {

            //מייצרת תלוש משכורת מתוך שורת תלוש משכורת

            this.m_id = (int)dataRow["ID"];
            this.m_month = dataRow["Month"].ToString();
            this.m_year = (int)dataRow["Year"];
            this.m_worker = new Worker(dataRow.GetParentRow("SalaryWorker"));
            if (dataRow["AmountHours100"] != null)
                this.m_amountHours100 = (double)dataRow["AmountHours100"];
            if (dataRow["AmountHours125"] != null)
                this.m_amountHours125 = (double)dataRow["AmountHours125"];
            if (dataRow["AmountHours150"] != null)
                this.m_amountHours150 = (double)dataRow["AmountHours150"];
            this.m_incomeTax = (double)dataRow["IncomeTax"];
            this.m_nationalInsurance = (double)dataRow["NationalInsurance"];
            this.m_healthInsurance = (double)dataRow["HealthInsurance"];
            this.m_pensionPayment = (double)dataRow["PensionPayment"];
            this.m_advancedStudyFund = (double)dataRow["AdvancedStudyFund"];
            this.m_sumGross = (double)dataRow["SumGross"];
            this.m_sumNet = (double)dataRow["SumNet"];
            this.m_isPaid = (int)dataRow["IsPaid"];
        }

        public override string ToString()
        {
            string isPaid;
            if (m_isPaid == 0)
                isPaid = "לא שולם";
            else if (m_isPaid == 1)
                isPaid = "שולם";
            else
                isPaid = "טרם הוזן";

            return $"{m_worker.LastName} {m_worker.FirstName},{m_month},{m_year} - {isPaid}";
        }

        public bool Insert()
        {
            return SalaryDal.Insert(m_month, m_year, m_worker.Id, m_amountHours100, 
                m_amountHours125, m_amountHours150,m_incomeTax, m_nationalInsurance, 
                m_healthInsurance, m_pensionPayment, m_advancedStudyFund, 
                m_sumGross, m_sumNet, m_isPaid);
        }

        public bool Update()
        {
            return SalaryDal.Update(m_id, m_month, m_year, m_worker.Id, m_amountHours100, 
                m_amountHours125, m_amountHours150, m_incomeTax, m_nationalInsurance, 
                m_healthInsurance, m_pensionPayment, m_advancedStudyFund, 
                m_sumGross, m_sumNet, m_isPaid);
        }

        public bool Delete()
        {
            return SalaryDal.Delete(m_id);
        }
    }
}
