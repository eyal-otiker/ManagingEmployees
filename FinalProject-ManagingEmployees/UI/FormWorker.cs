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
    public partial class FormWorker : Form
    {
        private Business business;
        string m_userName;
      
        public FormWorker(string userName)
        {
            InitializeComponent();
            BankArrToForm();
            DateTimeBirthday.Text = DateTime.Now.ToString();
            m_userName = userName;
            if (userName != null)
                LabelBusienssText.Text = FindBusinessName(userName);
            this.Text = LabelBusienssText.Text + " " + "-" + " " + "טופס עובדים";
            WorkerArrToForm(LabelBusienssText.Text);
            ListBoxWorker.SelectedIndex = -1;
        }

        private string FindBusinessName(string userName)
        {
            string businessName;
            BusinessArr businessArr = new BusinessArr();
            businessArr.Fill();
            businessName = businessArr.SearchBusinessName(userName);
            return businessName;
        }

        private Business FindFullBusiness(string businessName)
        {
            BusinessArr businessArr = new BusinessArr();
            businessArr.Fill();
            business = businessArr.SearchBusiness(businessName);
            return business;
        }

        private void WorkerArrToForm(string businessName)
        {

            //ממירה את הטנ "מ אוסף עובדים לטופס

            WorkerArr workerArr = new WorkerArr();
            workerArr.Fill();
            WorkerArr workerArrFilter;
            workerArrFilter = workerArr.Filter(businessName);
            ListBoxWorker.DataSource = workerArrFilter;
        }

        private void BankArrToForm(Bank curBank = null)
        {
            BankArr bankArr = new BankArr();

            //הוספת סניף ברירת מחדל

            Bank bankDefault = new Bank();
            bankDefault.Id = -1;
            bankDefault.Number = 0;

            bankArr.Add(bankDefault);
            bankArr.Fill();

            ComboBoxBank.DataSource = bankArr;
            ComboBoxBank.ValueMember = "Id";
            ComboBoxBank.DisplayMember = "Number";

            //אם נשלח לפעולה טיפוס, הצבתו בתיבת הבחירה של הטיפוס בטופס

            if (curBank != null)
                ComboBoxBank.SelectedValue = curBank.Id;
        }

        private Worker FormToWorker()
        {
            Worker worker = new Worker();

            worker.Id = int.Parse(LabelIDText.Text);
            worker.Business = FindFullBusiness(LabelBusienssText.Text);
            worker.FirstName = TextBoxFirstName.Text;
            worker.LastName = TextBoxLastName.Text;
            worker.IdNumber = TextBoxIdentityNumber.Text;
            worker.Bday = DateTime.Parse(DateTimeBirthday.Text);
            worker.PhoneAreaCode = ComboBoxPhone.Text;
            worker.PhoneNumber = TextBoxPhoneNumber.Text;
            if (TextBoxEmail.Text != "")
                worker.Email = TextBoxEmail.Text;
            worker.AccountNumber = int.Parse(TextBoxAccountNumber.Text);
            worker.Branch = int.Parse(TextBoxBranch.Text);
            worker.Bank = ComboBoxBank.SelectedItem as Bank;
            if (RadionButtonMonthlyPayment.Checked == true)
                worker.MonthlyPayment = double.Parse(TextBoxPayment.Text);
            if (RadionButtonHourlyPayment.Checked == true)
                worker.HourlyPayment = double.Parse(TextBoxPayment.Text);
            return worker;
        }

        private void WorkerToForm(Worker worker)
        {
            if (worker != null)
            {
                LabelIDText.Text = worker.Id.ToString();
  
                TextBoxFirstName.Text = worker.FirstName;
                TextBoxLastName.Text = worker.LastName;
                TextBoxIdentityNumber.Text = worker.IdNumber;
                DateTimeBirthday.Text = worker.Bday.ToString();
                ComboBoxPhone.Text  = worker.PhoneAreaCode;
                TextBoxPhoneNumber.Text = worker.PhoneNumber;
                TextBoxEmail.Text = worker.Email;
                TextBoxAccountNumber.Text = worker.AccountNumber.ToString();
                TextBoxBranch.Text = worker.Branch.ToString();
                ComboBoxBank.Text = worker.Bank.ToString();
                if (worker.MonthlyPayment != 0)
                {
                    RadionButtonMonthlyPayment.Checked = true;
                    TextBoxPayment.Text = worker.MonthlyPayment.ToString();                    
                }

                if (worker.HourlyPayment != 0)
                {
                    RadionButtonHourlyPayment.Checked = true;
                    TextBoxPayment.Text = worker.HourlyPayment.ToString();
                }
            }
            else
            {
                LabelIDText.Text = "0";
                TextBoxFirstName.Text = "";
                TextBoxLastName.Text = "";
                TextBoxIdentityNumber.Text = "";
                DateTimeBirthday.Text = DateTime.Now.ToString();
                ComboBoxPhone.SelectedItem = null;
                TextBoxPhoneNumber.Text = "";
                TextBoxEmail.Text = "";
                TextBoxAccountNumber.Text = "";
                TextBoxBranch.Text = "";
                ComboBoxBank.SelectedItem = null;
                RadionButtonMonthlyPayment.Checked = true;
                RadionButtonHourlyPayment.Checked = false;
                TextBoxPayment.Text = "";
            }
        }

        private bool IsHebLetter(char c)
        {

            // פעולת עזר – האם האות היא אות בעברית

            return (c >= 'א' && c <= 'ת');
        }

        private void TextBoxIsHebrewLetter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!IsHebLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
                e.KeyChar = char.MinValue;
        }

        private void TextBoxIsDigit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.KeyChar = char.MinValue;
        }

        private void TextBoxFilter_KeyUp(object sender, KeyEventArgs e)
        {
            int id = 0;

            //אם המשתמש רשם ערך בשדה המזהה

            if (TextBoxFilterID.Text != "")
                id = int.Parse(TextBoxFilterID.Text);

            //מייצרים אוסף של כלל העובדים

            WorkerArr workerArr = new WorkerArr();
            workerArr.Fill();

            //מסננים את אוסף העובדים לפי שדות הסינון שרשם המשתמש

            workerArr = workerArr.Filter(id, LabelBusienssText.Text, TextBoxLastNameFilter.Text,
            TextBoxIdentityNumberFilter.Text, TextBoxPhoneNumberFilter.Text, TextBoxEmailFilter.Text);
            //מציבים בתיבת הרשימה את אוסף העובדים

            ListBoxWorker.DataSource = workerArr;
        }

        private bool CheckForm()
        {
            bool flag = true;

            if (TextBoxFirstName.Text.Length < 2)
            {
                flag = false;
                TextBoxFirstName.BackColor = Color.Red;
            }
            else
                TextBoxFirstName.BackColor = Color.White;

            if (TextBoxLastName.Text.Length < 2)
            {
                flag = false;
                TextBoxLastName.BackColor = Color.Red;
            }
            else
                TextBoxLastName.BackColor = Color.White;

            if (TextBoxIdentityNumber.Text.Length != 9)
            {
                flag = false;
                TextBoxIdentityNumber.BackColor = Color.Red;
            }
            else
                TextBoxIdentityNumber.BackColor = Color.White;

            if (DateTimeBirthday.Value > DateTime.Now)
            {
                flag = false;
                LabelBirhdayDate.BackColor = Color.Red;
            }
            else
                LabelBirhdayDate.ForeColor = Color.Black;


            if (!(ComboBoxPhone.Text == "050" || ComboBoxPhone.Text == "052"
                || ComboBoxPhone.Text == "053" || ComboBoxPhone.Text == "054"
                || ComboBoxPhone.Text == "055" || ComboBoxPhone.Text == "058"))
            {
                flag = false;
                ComboBoxPhone.BackColor = Color.Red;
            }
            else
                ComboBoxPhone.BackColor = Color.White;
                
            if (TextBoxPhoneNumber.Text.Length != 7)
            {
                flag = false;
                TextBoxPhoneNumber.BackColor = Color.Red;
            }
            else
                TextBoxPhoneNumber.BackColor = Color.White;

            if (TextBoxEmail.Text.Length != 0)
            {
                if (!(TextBoxEmail.Text.EndsWith(".co.il") || TextBoxEmail.Text.EndsWith(".com")))               
                {
                    flag = false;
                    TextBoxEmail.BackColor = Color.Red;
                }
                else
                    TextBoxEmail.BackColor = Color.White;

                if (!TextBoxEmail.Text.Contains("@"))
                {
                    flag = false;
                    TextBoxEmail.BackColor = Color.Red;
                }
                else
                    TextBoxEmail.BackColor = Color.White;

                if ((TextBoxEmail.Text.Length > 0 && TextBoxEmail.Text.Length < 10))
                {
                    flag = false;
                    TextBoxEmail.BackColor = Color.Red;
                }
                else
                    TextBoxEmail.BackColor = Color.White;

            }

            if (TextBoxAccountNumber.Text.Length != 7)
            {
                flag = false;
                TextBoxAccountNumber.BackColor = Color.Red;
            }
            else
                TextBoxAccountNumber.BackColor = Color.White;

            if (TextBoxBranch.Text.Length != 3)
            {
                flag = false;
                LabelBranch.ForeColor = Color.Red;
            }
            else
                LabelBranch.ForeColor = Color.Black;

            if (ComboBoxBank.SelectedIndex <= 0)
            {
                flag = false;
                LabelBank.ForeColor = Color.Red;
            }
            else
                LabelBank.ForeColor = Color.Black;

            if (TextBoxPayment.Text.Length == 0)
            {
                flag = false;
                TextBoxPayment.BackColor = Color.Red;
            }
            else
                TextBoxPayment.BackColor = Color.White;

            return flag;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (!CheckForm())
            {
                MessageBox.Show("הטופס לא מולא בהצלחה, תקן את השגיאות המסומנות באדום", "שגיאה", MessageBoxButtons.OK,
                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
            }
            else
            {
                Worker worker = FormToWorker();
                if (worker.Id == 0)
                {
                    if (worker.Insert())
                    {
                        MessageBox.Show("העובד נוסף בהצלחה", "מידע", MessageBoxButtons.OK,
                            MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                        WorkerArrToForm(LabelBusienssText.Text);
                    }                        
                    else
                        MessageBox.Show("העובד לא נוסף בהצלחה, נסה בשנית", "שגיאה", MessageBoxButtons.OK,
                            MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                }
                else
                {
                    if (worker.Update())
                    {
                        MessageBox.Show("המידע עודכן בהצלחה", "מידע", MessageBoxButtons.OK,
                            MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                    }
                    else
                        MessageBox.Show("המידע לא עודכן בהצלחה, נסה בשנית", "שגיאה", MessageBoxButtons.OK,
                            MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                    //עדכון עובד קיים
                    ListBoxWorker.SelectedIndex = -1;
                }
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            WorkerToForm(null);
            ListBoxWorker.SelectedIndex = -1;
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            ListBoxWorker.SelectedIndex = -1;
            Worker worker = FormToWorker();
            if (worker.Id <= 0)
                MessageBox.Show("לא נבחר עובד למחיקה", "מידע", MessageBoxButtons.OK,
                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
            else
            {
                if (MessageBox.Show("אתה בטוח שברצונך למחוק?", "אזהרה", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2,
                    MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading) ==
                    System.Windows.Forms.DialogResult.Yes)
                {
                    //לפני המחיקה - בדיקה שהעובד לא בשימוש בישויות אחרות
                    //בדיקה עבור תלושי משכורת

                    SalaryArr salaryArr = new SalaryArr();
                    salaryArr.Fill();

                    if (salaryArr.DoesExist(worker))
                        MessageBox.Show("אתה לא יכול למחוק עובד שנבחר לתלוש משכורת", "מידע", MessageBoxButtons.OK,
                        MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                    else
                    {
                        if (worker.Delete())
                        {
                            MessageBox.Show("נמחק בהצלחה", "מידע", MessageBoxButtons.OK,
                            MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                            WorkerToForm(null);
                            WorkerArrToForm(LabelBusienssText.Text);
                        }
                        else
                            MessageBox.Show("יש שגיאה במחיקה", "שגיאה", MessageBoxButtons.OK,
                            MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                    }
                }
            }
        }

        private void ButtonBank_Click(object sender, EventArgs e)
        {
            FormBank formBank = new FormBank(m_userName, ComboBoxBank.SelectedItem as Bank);
            formBank.ShowDialog();
            BankArrToForm(formBank.SelectedBank);
        }

        private void ButtonBeginning_Click(object sender, EventArgs e)
        {
            string userName;
            userName = LabelBusienssText.Text;
            this.Hide();
            FormBeginning formBeginning = new FormBeginning(m_userName);
            formBeginning.ShowDialog();
        }

        private void ListBoxWorkers_DoubleClick(object sender, EventArgs e)
        {
            WorkerToForm(ListBoxWorker.SelectedItem as Worker);
        }
    }
}
