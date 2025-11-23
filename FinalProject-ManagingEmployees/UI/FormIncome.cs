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
    public partial class FormIncome : Form
    {
        string m_userName;

        public FormIncome(string userName)
        {
            InitializeComponent();
            m_userName = userName;

            //טעינת אוסף ההכנסות לרשימה בטופס

            IncomeArrToForm();
            IncomeToForm(null);
            FormIncome_InputLanguageChanged(null, null);
            ListBoxIncome.SelectedIndex = -1;
        }

        private void IncomeArrToForm()
        {

            //ממירה את הטנ "מ אוסף הכנסות לטופס

            IncomeArr incomeArr = new IncomeArr();
            incomeArr.Fill();
            ListBoxIncome.DataSource = incomeArr;
        }

        private Income FormToIncome()
        {
            Income income = new Income();

            income.Id = int.Parse(LabelIDText.Text);
            income.Name = TextBoxIncome.Text;
            income.DefaultPayment = double.Parse(TextBoxDefaultPayment.Text);

            return income;
        }

        private void IncomeToForm(Income income)
        {
            if (income != null)
            {
                LabelIDText.Text = income.Id.ToString();
                TextBoxIncome.Text = income.Name;
                TextBoxDefaultPayment.Text = income.DefaultPayment.ToString();
            }
            else
            {
                LabelIDText.Text = "0";
                TextBoxIncome.Text = "";
                TextBoxDefaultPayment.Text = "";
                FormIncome_InputLanguageChanged(null, null);
            }
        }

        private bool IsHebLetter(char c)
        {

            // פעולת עזר – האם האות היא אות בעברית

            return (c >= 'א' && c <= 'ת');
        }

        private void FormIncome_InputLanguageChanged(object sender, InputLanguageChangedEventArgs e)
        {
            InputLanguage myCurrentLang = InputLanguage.CurrentInputLanguage;
            if (myCurrentLang.Culture.Name.ToLower() != "he-il")
                MessageBox.Show("אתה לא מקליד בעברית", "מידע", MessageBoxButtons.OK,
                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
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

        public bool CheckForm()
        {
            bool flag = true;

            if (TextBoxIncome.Text.Length < 2)
            {
                flag = false;
                TextBoxIncome.BackColor = Color.Red;
            }
            else
                TextBoxIncome.BackColor = Color.White;

            if (double.Parse(TextBoxDefaultPayment.Text) > 0)
            {
                flag = false;
                TextBoxDefaultPayment.BackColor = Color.Red;
            }
            else
                TextBoxDefaultPayment.BackColor = Color.White;

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
                Income income = FormToIncome();
                IncomeArr oldIncomeArr = new IncomeArr();
                oldIncomeArr.Fill();
                if (income.Id == 0)
                {                   
                    if (!oldIncomeArr.IsContain(income.Name))
                    {
                        if (income.Insert())
                        {
                            MessageBox.Show("ההכנסה נוספה בהצלחה", "מידע", MessageBoxButtons.OK,
                                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                            IncomeArrToForm();
                        }
                        else
                            MessageBox.Show("הטופס לא התמלא בהצלחה, נסה בשנית", "שגיאה", MessageBoxButtons.OK,
                                MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                    }
                    else
                        MessageBox.Show("שם ההכנסה שהזנת קיים", "מידע", MessageBoxButtons.OK,
                                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                }                
                else
                {
                    if (m_userName == "מנהל מערכת")
                    {
                        if (!oldIncomeArr.IsContain(income.Name))
                        {
                            if (income.Update())
                                MessageBox.Show("המידע עודכן בהצלחה", "מידע", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                                    MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                            else
                                MessageBox.Show("הטופס לא עודכן בהצלחה, נסה בשנית", "שגיאה", MessageBoxButtons.OK,
                                        MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                                        MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                        }
                        else
                            MessageBox.Show("שם ההכנסה שהזנת קיים", "מידע", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                                    MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                    }
                    else
                        MessageBox.Show("אינך רשאי לעדכן הכנסות", "מידע", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                                    MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                }
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            IncomeToForm(null);
            ListBoxIncome.SelectedIndex = -1;
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (m_userName == "מנהל מערכת")
            {
                Income income = FormToIncome();
                if (income.Id <= 0)
                    MessageBox.Show("לא נבחרה הכנסה למחיקה", "מידע", MessageBoxButtons.OK,
                        MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                else
                {
                    if (MessageBox.Show("אתה בטוח שברצונך למחוק?", "אזהרה", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2,
                        MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading) ==
                        System.Windows.Forms.DialogResult.Yes)
                    {
                        // לפני המחיקה- בדיקה שההכנסה לא נמצאת באחד מתלושי המשכורת
                        // בדיקה עבור תלושי משכורות

                        SalaryIncomeArr salaryIncomeArr = new SalaryIncomeArr();
                        salaryIncomeArr.Fill();

                        if (salaryIncomeArr.DoesExist(income))
                            MessageBox.Show("אתה לא יכול למחוק הכנסה שנבחרה לתלוש משכורת", "מידע", MessageBoxButtons.OK,
                            MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                        else
                        {
                            if (income.Delete())
                            {
                                MessageBox.Show("נמחק בהצלחה", "מידע", MessageBoxButtons.OK,
                                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                                IncomeToForm(null);
                                IncomeArrToForm();
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
                MessageBox.Show("אינך רשאי למחוק הכנסות", "מידע", MessageBoxButtons.OK,
                                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
        }

        private void ListBoxIncomes_DoubleClick(object sender, EventArgs e)
        {
            IncomeToForm(ListBoxIncome.SelectedItem as Income);
        }
    }
}
