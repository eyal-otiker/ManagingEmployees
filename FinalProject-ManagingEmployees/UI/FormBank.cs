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
    public partial class FormBank : Form
    {
        public Bank SelectedBank { get => ListBoxBank.SelectedItem as Bank; }
        string m_userName;

        public FormBank(string userName, Bank bank = null)
        {
            InitializeComponent();
            m_userName = userName;
            //אם נשלח בנק שאינו בנק אמיתי - לאפס אותו

            if (bank != null && bank.Id <= 0)
                bank = null;

            //טעינת אוסף ההכנסות לרשימה בטופס
            BankArrToForm(bank);
            BankToForm(bank);
            FormBank_InputLanguageChanged(null, null);
        }

        private void BankArrToForm(Bank curBank = null)
        {

            //ממירה את הטנ "מ אוסף בנקים לטופס

            BankArr bankArr = new BankArr();
            bankArr.Fill();
            ListBoxBank.DataSource = bankArr;
            ListBoxBank.ValueMember = "Id";
            ListBoxBank.DisplayMember = "Number";

            //אם נשלח לפעולה בנק ,הצבתו בתיבת הבחירה של בנקים בטופס

            if (curBank != null)
                ListBoxBank.SelectedValue = curBank.Id;
        }

        private Bank FormToBank()
        {
            Bank bank = new Bank();

            bank.Id = int.Parse(LabelIDText.Text);
            bank.Number = int.Parse(TextBoxBank.Text);

            return bank;
        }

        private void BankToForm(Bank bank)
        {
            if (bank != null)
            {
                LabelIDText.Text = bank.Id.ToString();
                TextBoxBank.Text = bank.Number.ToString();
            }
            else
            {
                LabelIDText.Text = "0";
                TextBoxBank.Text = "";
                FormBank_InputLanguageChanged(null, null);
            }
        }

        private void TextBoxIsDigit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.KeyChar = char.MinValue;
        }

        private void FormBank_InputLanguageChanged(object sender, InputLanguageChangedEventArgs e)
        {
            InputLanguage myCurrentLang = InputLanguage.CurrentInputLanguage;
            if (myCurrentLang.Culture.Name.ToLower() != "he-il")
                MessageBox.Show("אתה לא מקליד בעברית", "מידע", MessageBoxButtons.OK,
                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
        }

        public bool CheckForm()
        {
            bool flag = true;

            if (TextBoxBank.Text.Length < 1)
            {
                flag = false;
                TextBoxBank.BackColor = Color.Red;
            }
            else
                TextBoxBank.BackColor = Color.White;

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
                Bank bank = FormToBank();
                BankArr oldBankArr = new BankArr();
                oldBankArr.Fill();
                if (bank.Id == 0)
                {
                    if (!oldBankArr.IsContain(bank.Number))
                    {
                        if (bank.Insert())
                        {
                            MessageBox.Show("בנק נוסף בהצלחה", "מידע", MessageBoxButtons.OK,
                                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                            BankArrToForm();
                        }
                        else
                            MessageBox.Show("הטופס לא התמלא בהצלחה, נסה בשנית", "שגיאה", MessageBoxButtons.OK,
                                MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                    }
                    else
                        MessageBox.Show("מספר הבנק שהזנת קיים", "מידע", MessageBoxButtons.OK,
                                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                }
                else
                {
                    if (m_userName == "מנהל מערכת")
                    {
                        if (!oldBankArr.IsContain(bank.Number))
                        {
                            if (bank.Update())
                                MessageBox.Show("המידע עודכן בהצלחה", "מידע", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                                    MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                            else
                                MessageBox.Show("הטופס לא עודכן בהצלחה, נסה בשנית", "שגיאה", MessageBoxButtons.OK,
                                        MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                                        MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                        }
                        else
                            MessageBox.Show("מספר הבנק שהזנת קיים", "מידע", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                                    MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                    }
                    else
                        MessageBox.Show("אינך רשאי לעדכן מספרי בנקים", "מידע", MessageBoxButtons.OK,
                            MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                }
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            BankToForm(null);
            ListBoxBank.SelectedIndex = -1;
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (m_userName == "מנהל מערכת")
            {
                Bank bank = FormToBank();
                if (bank.Id <= 0)
                    MessageBox.Show("לא נבחר בנק למחיקה", "מידע", MessageBoxButtons.OK,
                        MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                else
                {
                    if (MessageBox.Show("אתה בטוח שברצונך למחוק?", "אזהרה", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2,
                        MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading) ==
                        System.Windows.Forms.DialogResult.Yes)
                    {
                        // לפני המחיקה- בדיקה שהבק לא נמצאת באחד מהעובדים
                        // בדיקה עבור עובדים

                        WorkerArr workerArr = new WorkerArr();
                        workerArr.Fill();

                        if (workerArr.DoesExist(bank))
                            MessageBox.Show("אתה לא יכול למחוק בנק שנבחר לעובד", "מידע", MessageBoxButtons.OK,
                            MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                        else
                        {
                            if (bank.Delete())
                            {
                                MessageBox.Show("נמחק בהצלחה", "מידע", MessageBoxButtons.OK,
                                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                                BankToForm(null);
                                BankArrToForm();
                            }
                            else
                                MessageBox.Show("יש שגיאה במחיקה", "שגיאה", MessageBoxButtons.OK,
                                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                        }
                    }
                }
            }
            else
                MessageBox.Show("אינך רשאי למחוק בנקים", "מידע", MessageBoxButtons.OK,
                            MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
        }

        private void ListBoxBanks_DoubleClick(object sender, EventArgs e)
        {
            BankToForm(ListBoxBank.SelectedItem as Bank);
        }
    }
}
