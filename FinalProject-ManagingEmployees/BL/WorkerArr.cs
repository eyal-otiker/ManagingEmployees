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
    public class WorkerArr : ArrayList
    {
        public void Fill()
        {

            //להביא מה-DAL טבלה מלאה בכל העובדים

            DataTable dataTable = WorkerDal.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף העובדים
            //להעביר כל שורה בטבלה לעובד

            DataRow dataRow;
            Worker curWorker;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                curWorker = new Worker(dataRow);
                this.Add(curWorker);
            }
        }

        public WorkerArr Filter(int id, string businessName, string lastName, 
            string idNumber, string cellNumber, string email)
        {
            WorkerArr workerArr = new WorkerArr();
            Worker worker;
            for (int i = 0; i < this.Count; i++)
            {

                //הצבת העובד הנוכחי במשתנה עזר - עובד

                worker = (this[i] as Worker);
                if
                (

                // מזהה 0 – כלומר, לא נבחר מזהה בסינון

                (id == 0 || worker.Id == id)
                && (worker.Business.Name == businessName)
                && (lastName == null || worker.LastName.StartsWith(lastName))
                && (idNumber == null || worker.IdNumber.StartsWith(idNumber))
                && (cellNumber == null || (worker.PhoneAreaCode + worker.PhoneNumber).Contains(cellNumber))
                && (email == null || worker.Email.StartsWith(email))
                )

                    //העובד ענה לדרישות הסינון - הוספת העובד לאוסף העובדים המוחזר

                    workerArr.Add(worker);
            }
            return workerArr;
        }

        public Worker FilterWorker(string fullName)
        {
            Worker worker;
            for (int i = 0; i < this.Count; i++)
            {
                worker = this[i] as Worker;
                if (fullName == worker.LastName + " " + worker.FirstName)
                    return worker;
            }

            return null;
        }

        public WorkerArr Filter(string businessName)
        {
            WorkerArr workerArr = new WorkerArr();
            Worker worker;
            for (int i = 0; i < this.Count; i++)
            {

                //הצבת העובד הנוכחי במשתנה עזר - לקוח

                worker = (this[i] as Worker);

                if (worker.Id == -1)
                {
                    //הלקוח ענה לדרישות הסינון - הוספת הלקוח לאוסף הלקוחות המוחזר
                    workerArr.Add(worker);
                }

                else if (worker.Business.Name == businessName)
                {
                    //הלקוח ענה לדרישות הסינון - הוספת הלקוח לאוסף הלקוחות המוחזר
                    workerArr.Add(worker);
                }

            }
            return workerArr;
        }

        public bool DoesExist(string userName)
        {
            Worker curWorker;
            for (int i = 0; i < this.Count; i++)
            {
                curWorker = this[i] as Worker;
                if (curWorker.Business.UserName.UserName == userName)
                    return true;
            }

            return false;
        }

        public bool DoesExist(Bank bank)
        {
            Worker curWorker;
            for (int i = 0; i < this.Count; i++)
            {
                curWorker = this[i] as Worker;
                if (curWorker.Bank.Number == bank.Number)
                    return true;
            }

            return false;
        }
    }
}
