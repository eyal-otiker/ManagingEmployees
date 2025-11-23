using FinalProject_ManagingEmployees.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_ManagingEmployees.UI
{
    public partial class FormBeginning : Form
    {
        string userName;

        public FormBeginning(string userName)
        {
            InitializeComponent();
            LabelUserNameText.Text = userName;
            this.Text = userName + " " + "-" + " " + "טופס פתיחה";
        }

        private void PictureBoxBusiness_Click(object sender, EventArgs e)
        {
            userName = LabelUserNameText.Text;
            this.Hide();
            FormBusiness formBusiness = new FormBusiness(userName);
            formBusiness.ShowDialog();           
        }

        private void PictureBoxWorker_Click(object sender, EventArgs e)
        {
            userName = LabelUserNameText.Text;
            BusinessArr businessArr = new BusinessArr();
            businessArr.Fill();
            if (businessArr.DoesExist(userName) || userName == "מנהל מערכת")
            {
                this.Hide();
                FormWorker formWorker = new FormWorker(userName);
                formWorker.ShowDialog();
            }
            else
                MessageBox.Show("תוכל לגשת לטופס ניהול עובדים רק אחרי הוספת עסק", "מידע", MessageBoxButtons.OK,
                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
        }

        private void PictureBoxSalary_Click(object sender, EventArgs e)
        {
            userName = LabelUserNameText.Text;
            BusinessArr businessArr = new BusinessArr();
            businessArr.Fill();
            WorkerArr workerArr = new WorkerArr();
            workerArr.Fill();
            if ((businessArr.DoesExist(userName) && workerArr.DoesExist(userName)) || userName == "מנהל מערכת")
            {
                this.Hide();
                FormSalary formSalary = new FormSalary(userName);
                formSalary.ShowDialog();
            }
            else
                MessageBox.Show("תוכל לגשת לטופס ניהול משכורות רק אחרי הוספת עסק ועובד אחד לפחות", "מידע", MessageBoxButtons.OK,
                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
        }

        private void PictureBoxReport_Click(object sender, EventArgs e)
        {
            userName = LabelUserNameText.Text;
            BusinessArr businessArr = new BusinessArr();
            businessArr.Fill();
            WorkerArr workerArr = new WorkerArr();
            workerArr.Fill();
            if ((businessArr.DoesExist(userName) && workerArr.DoesExist(userName)) || userName == "מנהל מערכת")
            {
                this.Hide();
                FormReport formReport = new FormReport(userName);
                formReport.ShowDialog();
            }
            else
                MessageBox.Show("תוכל לגשת לדוחות וגרפים רק אחרי הוספת עסק ועובד אחד לפחות", "מידע", MessageBoxButtons.OK,
                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);           
        }
    }
}
