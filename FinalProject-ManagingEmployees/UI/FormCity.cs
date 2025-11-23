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
    public partial class FormCity : Form
    {
        public City SelectedCity { get => ListBoxCitys.SelectedItem as City; }
        string m_userName;

        public FormCity(string userName, City city = null)
        {
            InitializeComponent();
            m_userName = userName;
            //אם נשלח ישוב שאינו ישוב אמיתי - לאפס אותו

            if (city != null && city.Id <= 0)
                city = null;

            CityArrToForm(city);
            CityToForm(city);
            FormCity_InputLanguageChanged(null, null);
        }

        private void CityArrToForm(City curCity = null)
        {

            //ממירה את הטנ "מ אוסף יישובים לטופס

            CityArr cityArr = new CityArr();
            cityArr.Fill();
            ListBoxCitys.DataSource = cityArr;
            ListBoxCitys.ValueMember = "Id";
            ListBoxCitys.DisplayMember = "Name";

            //אם נשלח לפעולה ישוב ,הצבתו בתיבת הבחירה של ישובים בטופס

            if (curCity != null)
                ListBoxCitys.SelectedValue = curCity.Id;
        }

        private City FormToCity()
        {
            City city = new City();

            city.Id = int.Parse(LabelIDText.Text);
            city.Name = TextBoxCity.Text;

            return city;
        }

        private void CityToForm(City city)
        {
            if (city != null)
            {
                LabelIDText.Text = city.Id.ToString();
                TextBoxCity.Text = city.Name;
            }
            else
            {
                LabelIDText.Text = "0";
                TextBoxCity.Text = "";
                FormCity_InputLanguageChanged(null, null);
            }
        }

        private bool IsHebLetter(char c)
        {

            // פעולת עזר – האם האות היא אות בעברית

            return (c >= 'א' && c <= 'ת');
        }

        private void FormCity_InputLanguageChanged(object sender, InputLanguageChangedEventArgs e)
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

            if (TextBoxCity.Text.Length < 2)
            {
                flag = false;
                TextBoxCity.BackColor = Color.Red;
            }
            else
                TextBoxCity.BackColor = Color.White;

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
                City city = FormToCity();
                CityArr oldCityArr = new CityArr();
                oldCityArr.Fill();
                if (city.Id == 0)
                {                 
                    if (!oldCityArr.IsContain(city.Name))
                    {
                        if (city.Insert())
                        {
                            MessageBox.Show("היישוב נוסף בהצלחה", "מידע", MessageBoxButtons.OK,
                                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                            CityArrToForm();
                        }
                        else
                            MessageBox.Show("הטופס לא התמלא בהצלחה, נסה בשנית", "שגיאה", MessageBoxButtons.OK,
                                MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                    }
                    else
                        MessageBox.Show("שם הישוב שהזנת קיים", "מידע", MessageBoxButtons.OK,
                                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                }
                else
                {
                    if (m_userName == "מנהל מערכת")
                    {
                        if (!oldCityArr.IsContain(city.Name))
                        {
                            if (city.Update())
                                MessageBox.Show("המידע עודכן בהצלחה", "מידע", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                                    MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                            else
                                MessageBox.Show("הטופס לא עודכן בהצלחה, נסה בשנית", "שגיאה", MessageBoxButtons.OK,
                                        MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                                        MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                        }
                        else
                            MessageBox.Show("שם הישוב שהזנת קיים", "מידע", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                                    MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                    }
                    else
                        MessageBox.Show("אינך רשאי לעדכן ישובים", "מידע", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                                    MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                }
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            CityToForm(null);
            ListBoxCitys.SelectedIndex = -1;
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (m_userName == "מנהל מערכת")
            {
                City city = FormToCity();
                if (city.Id <= 0)
                    MessageBox.Show("לא נבחר יישוב למחיקה", "מידע", MessageBoxButtons.OK,
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

                        if (businessArr.DoesExist(city))
                            MessageBox.Show("אתה לא יכול למחוק יישוב שנבחר לעסק", "מידע", MessageBoxButtons.OK,
                            MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                        else
                        {
                            if (city.Delete())
                            {
                                MessageBox.Show("נמחק בהצלחה", "מידע", MessageBoxButtons.OK,
                                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                                CityToForm(null);
                                CityArrToForm();
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
                MessageBox.Show("אינך רשאי למחוק ישובים", "מידע", MessageBoxButtons.OK,
                                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
        }

        private void ListBoxCitys_DoubleClick(object sender, EventArgs e)
        {
            CityToForm(ListBoxCitys.SelectedItem as City);
        }
    }
}
