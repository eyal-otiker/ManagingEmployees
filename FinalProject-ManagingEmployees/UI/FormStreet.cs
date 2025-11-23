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
    public partial class FormStreet : Form
    {
        public Street SelectedStreet { get => ListBoxStreets.SelectedItem as Street; }
        string m_userName;

        public FormStreet(string userName, Street street = null)
        {
            InitializeComponent();
            m_userName = userName;
            //אם נשלח רחוב שאינו אמיתי - לאפס אותו

            if (street != null && street.Id <= 0)
                street = null;

            StreetArrToForm(street);
            StreetToForm(street);
            FormStreet_InputLanguageChanged(null, null);
        }

        private void StreetArrToForm(Street curStreet = null)
        {

            //ממירה את הטנ "מ אוסף רחובות לטופס

            StreetArr streetArr = new StreetArr();
            streetArr.Fill();
            ListBoxStreets.DataSource = streetArr;
            ListBoxStreets.ValueMember = "Id";
            ListBoxStreets.DisplayMember = "Name";

            //אם נשלח לפעולה רחוב ,הצבתו בתיבת הבחירה של רחובות בטופס

            if (curStreet != null)
                ListBoxStreets.SelectedValue = curStreet.Id;
        }

        private Street FormToStreet()
        {
            Street street = new Street();

            street.Id = int.Parse(LabelIDText.Text);
            street.Name = TextBoxStreet.Text;

            return street;
        }

        private void StreetToForm(Street street)
        {
            if (street != null)
            {
                LabelIDText.Text = street.Id.ToString();
                TextBoxStreet.Text = street.Name;
            }
            else
            {
                LabelIDText.Text = "0";
                TextBoxStreet.Text = "";
                FormStreet_InputLanguageChanged(null, null);
            }
        }

        private bool IsHebLetter(char c)
        {

            // פעולת עזר – האם האות היא אות בעברית

            return (c >= 'א' && c <= 'ת');
        }

        private void FormStreet_InputLanguageChanged(object sender, InputLanguageChangedEventArgs e)
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

        public bool CheckForm()
        {
            bool flag = true;

            if (TextBoxStreet.Text.Length < 2)
            {
                flag = false;
                TextBoxStreet.BackColor = Color.Red;
            }
            else
                TextBoxStreet.BackColor = Color.White;

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
                Street street = FormToStreet();
                StreetArr oldStreetArr = new StreetArr();
                oldStreetArr.Fill();
                if (street.Id == 0)
                {                  
                    if (!oldStreetArr.IsContain(street.Name))
                    {
                        if (street.Insert())
                        {
                            MessageBox.Show("הרחוב נוסף בהצלחה", "מידע", MessageBoxButtons.OK,
                                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                            StreetArrToForm();
                        }
                        else
                            MessageBox.Show("הטופס לא התמלא בהצלחה, נסה בשנית", "שגיאה", MessageBoxButtons.OK,
                                MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                    }
                    else
                        MessageBox.Show("הרחוב קיים", "מידע", MessageBoxButtons.OK,
                                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                }
                else
                {
                    if (m_userName == "מנהל מערכת")
                    {
                        if (!oldStreetArr.IsContain(street.Name))
                        {
                            if (street.Update())
                                MessageBox.Show("המידע עודכן בהצלחה", "מידע", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                                    MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                            else
                                MessageBox.Show("הטופס לא עודכן בהצלחה, נסה בשנית", "שגיאה", MessageBoxButtons.OK,
                                        MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                                        MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                        }
                        else
                            MessageBox.Show("הרחוב קיים", "מידע", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                                    MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                    }
                    else
                        MessageBox.Show("אינך רשאי לעדכן רחובות", "מידע", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                                    MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                }
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            StreetToForm(null);
            ListBoxStreets.SelectedIndex = -1;
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (m_userName == "מנהל מערכת")
            {
                Street street = FormToStreet();
                if (street.Id <= 0)
                    MessageBox.Show("לא נבחר רחוב למחיקה", "מידע", MessageBoxButtons.OK,
                        MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                else
                {
                    if (MessageBox.Show("אתה בטוח שברצונך למחוק?", "אזהרה", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2,
                        MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading) ==
                        System.Windows.Forms.DialogResult.Yes)
                    {
                        //לפני המחיקה - בדיקה שהרחוב לא בשימוש בישויות אחרות
                        //בדיקה עבור עסקים

                        BusinessArr businessArr = new BusinessArr();
                        businessArr.Fill();

                        if (businessArr.DoesExist(street))
                            MessageBox.Show("אתה לא יכול לבחור רחוב שנבחר עבור עסק", "מידע", MessageBoxButtons.OK,
                            MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                        else
                        {
                            if (street.Delete())
                            {
                                MessageBox.Show("נמחק בהצלחה", "מידע", MessageBoxButtons.OK,
                                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                                StreetToForm(null);
                                StreetArrToForm();
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
                MessageBox.Show("אינך רשאי למחוק רחובות", "מידע", MessageBoxButtons.OK,
                                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
        }

        private void ListBoxStreets_DoubleClick(object sender, EventArgs e)
        {
            StreetToForm(ListBoxStreets.SelectedItem as Street);
        }

    }
}