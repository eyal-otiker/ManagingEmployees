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
    public class BankArr : ArrayList
    {
        public void Fill()
        {

            //להביא מה-DAL טבלה מלאה בכל ההכנסות

            DataTable dataTable = BankDal.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף ההכנסות
            //להעביר כל שורה בטבלה להכנסה

            DataRow dataRow;
            Bank curBank;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                curBank = new Bank(dataRow);
                this.Add(curBank);
            }
        }

        public bool IsContain(int bankNumber)
        {
            int curBankNumber;
            for (int i = 0; i < this.Count; i++)
            {
                curBankNumber = (this[i] as Bank).Number;

                if (curBankNumber == bankNumber)
                    return true;

            }
            return false;
        }
    }
}
