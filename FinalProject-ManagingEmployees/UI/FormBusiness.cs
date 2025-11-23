using FinalProject_ManagingEmployees.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_ManagingEmployees.UI
{
    public partial class FormBusiness : Form
    {
        const string DefaultPic = "DefaultPic.jpg";

        public FormBusiness(string userName)
        {
            InitializeComponent();
            FormBusiness_InputLanguageChanged(null, null);
            StreetArrToForm(ComboBoxStreet, true);
            CityArrToForm(ComboBoxCity, true);
            LabelUserNameText.Text = userName;
            ShowBusiness(userName);
            if (TextBoxName.Text != "")
                this.Text = TextBoxName.Text + " " + "-" + " " + "טופס פרטי עסק";
            else
                this.Text = "טופס פרטי עסק";

        }

        public void ShowBusiness(string userName)
        {
            Business business;
            BusinessArr businessArr = new BusinessArr();
            businessArr.Fill();
            business = businessArr.SearchBusinessByUserName(userName);
            if (business != null)
                BusinessToForm(business);
        }

        private Login FindFullUserName(string userName)
        {
            Login login;
            LoginArr loginArr = new LoginArr();
            loginArr.Fill();
            login = loginArr.SearchLogin(userName);
            return login;
        }

        private string FindPicturePath()
        {

            //מציאת הנתיב ממנו רץ היישום

            string path = Application.StartupPath;

            //מעבר לתיקייה בה שמורה התמונה

            path = path.Replace(@"bin\Debug", "");
            path = path.Replace(@"bin\Release", "");
            path = path + @"\Pictures\";
            return path;
        }

        private string GetPicfileName()
        {

            //מחזירה את שם הקובץ של התמונה - ללא התיקיה

            int k = PictureBoxBusiness.ImageLocation.LastIndexOf(@"\") + 1;
            return PictureBoxBusiness.ImageLocation.Substring(k);
        }

        public void StreetArrToForm(ComboBox comboBox, bool isMustChoose, Street curStreet = null)
        {
            StreetArr streetArr = new StreetArr();

            //הוספת רחוב ברירת מחדל - בחר רחוב/כל הרחובות

            Street streetDefault = new Street();
            streetDefault.Id = -1;
            if (isMustChoose)
                streetDefault.Name = "בחר רחוב";
            else
                streetDefault.Name = "כל הרחובות";
            streetArr.Add(streetDefault);
            streetArr.Fill();
            comboBox.DataSource = streetArr;
            comboBox.ValueMember = "Id";
            comboBox.DisplayMember = "Name";

            //אם נשלח לפעולה טיפוס, הצבתו בתיבת הבחירה של הטיפוס בטופס

            if (curStreet != null)
                comboBox.SelectedValue = curStreet.Id;
        }

        public void CityArrToForm(ComboBox comboBox, bool isMustChoose, City curCity = null)
        {
            CityArr cityArr = new CityArr();

            //הוספת רחוב ברירת מחדל - בחר ישובים/כל הישובים

            City cityDefault = new City();
            cityDefault.Id = -1;
            if (isMustChoose)
                cityDefault.Name = "בחר ישוב";
            else
                cityDefault.Name = "כל הישובים";
            cityArr.Add(cityDefault);
            cityArr.Fill();
            comboBox.DataSource = cityArr;
            comboBox.ValueMember = "Id";
            comboBox.DisplayMember = "Name";

            //אם נשלח לפעולה טיפוס, הצבתו בתיבת הבחירה של הטיפוס בטופס

            if (curCity != null)
                comboBox.SelectedValue = curCity.Id;
        }

        private Business FormToBusiness()
        {
            Business business = new Business();

            business.Id = int.Parse(LabelIDText.Text);
            business.UserName = FindFullUserName(LabelUserNameText.Text);
            business.Name = TextBoxName.Text;
            if (ComboBoxStreet.SelectedItem != null)
                business.Street = (ComboBoxStreet.SelectedItem as Street);
            if (TextBoxNumberInStreet.Text != "")
                business.NumberStreet = int.Parse(TextBoxNumberInStreet.Text);
            if (ComboBoxCity.SelectedItem != null)
                business.City = (ComboBoxCity.SelectedItem as City);
            if (ComboBoxPhone.SelectedItem != null)
                business.PhoneAreaCode = ComboBoxPhone.Text;
            if (TextBoxPhoneNumber.Text != "")
                business.PhoneNumber = TextBoxPhoneNumber.Text;
            business.Picture = GetPicfileName();

            return business;
        }

        private void BusinessToForm(Business business)
        {
            if (business != null)
            {
                LabelIDText.Text = business.Id.ToString();
                LabelUserNameText.Text = business.UserName.UserName;
                TextBoxName.Text = business.Name;
                if (business.Street != null)
                    ComboBoxStreet.SelectedValue = business.Street.Id;
                if (business.NumberStreet != 0)
                    TextBoxNumberInStreet.Text = business.NumberStreet.ToString();
                if (business.City != null)
                    ComboBoxCity.SelectedValue = business.City.Id;
                if (business.PhoneAreaCode != null)
                    ComboBoxPhone.Text = business.PhoneAreaCode;
                if (business.PhoneNumber != null)
                    TextBoxPhoneNumber.Text = business.PhoneNumber;
                if (string.IsNullOrEmpty(business.Picture))
                    PictureBoxBusiness.ImageLocation = FindPicturePath() + DefaultPic;
                else
                    PictureBoxBusiness.ImageLocation = FindPicturePath() + business.Picture;
            }
            else
            {
                LabelIDText.Text = "0";
                LabelUserNameText.Text = "0";
                TextBoxName.Text = "";
                ComboBoxStreet.SelectedItem = null;
                TextBoxNumberInStreet.Text = "";
                ComboBoxCity.SelectedItem = null;
                ComboBoxPhone.SelectedItem = null;
                TextBoxPhoneNumber.Text = "";
                PictureBoxBusiness.ImageLocation = FindPicturePath() + DefaultPic;
                FormBusiness_InputLanguageChanged(null, null);
            }
        }

        private bool IsHebLetter(char c)
        {

            // פעולת עזר – האם האות היא אות בעברית

            return (c >= 'א' && c <= 'ת');
        }

        private void FormBusiness_InputLanguageChanged(object sender, InputLanguageChangedEventArgs e)
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
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.KeyChar = char.MinValue;
        }

        private void TextBoxFullAdress_KeyUp(object sender, KeyEventArgs e)
        {
            FullAdress();
        }

        private void ComboBoxFullAdress_TextChanged(object sender, EventArgs e)
        {
            FullAdress();
        }

        private void FullAdress()
        {
            if (ComboBoxStreet.SelectedItem != null && TextBoxNumberInStreet.Text != ""
                && ComboBoxCity.SelectedItem != null)
                LabelFullAdressText.Text = ComboBoxStreet.SelectedItem.ToString() + " " +
                TextBoxNumberInStreet.Text + ", " + ComboBoxCity.SelectedItem.ToString();
        }

        private bool CheckForm()
        {
            bool flag = true;

            if (TextBoxName.Text.Length < 2)
            {
                flag = false;
                TextBoxName.BackColor = Color.Red;
            }
            else
                TextBoxName.BackColor = Color.White;

            if (!(ComboBoxPhone.Text == "02" || ComboBoxPhone.Text == "03"
                || ComboBoxPhone.Text == "04" || ComboBoxPhone.Text == "08"
                || ComboBoxPhone.Text == "09" || ComboBoxPhone.Text == ""))
            {
                flag = false;
                ComboBoxPhone.BackColor = Color.Red;
            }
            else
                ComboBoxPhone.BackColor = Color.White;

            if (TextBoxPhoneNumber.Text.Length != 0 && TextBoxPhoneNumber.Text.Length != 7)
            {
                flag = false;
                TextBoxPhoneNumber.BackColor = Color.Red;
            }
            else
                TextBoxPhoneNumber.BackColor = Color.White;

            return flag;
        }

        public bool SaveFile(string fileName, string prevFileName = "")
        {
            //מעתיק את קובץ התמונה למקום
            //ואם זהו קובץ זהה למקור (עבור עדכון) או קובץ שזהה לברירת המחדל -הקובץ לא יועתק
            if (fileName == DefaultPic || fileName == prevFileName)
                return true;
            if (!File.Exists(FindPicturePath() + fileName))
                File.Copy(openFileDialogPicture.FileName, FindPicturePath() + fileName);
            else
            {

                //התמונה כבר קיימת - נאפשר למשתמש להחליט האם הוא רוצה לבחור תמונה אחרת או להמשיך
                if (MessageBox.Show("התמונה כבר קיימת, האם אתה רוצה לבחור תמונה אחרת?",
                "אזהרה", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    return true;
                else
                    return false;
            }
            return true;
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
                Business business = FormToBusiness();

                BusinessArr oldBusinessArr = new BusinessArr();
                oldBusinessArr.Fill();
                if (business.Id == 0)
                {                   
                    if (!oldBusinessArr.IsContain(business.Name) && !oldBusinessArr.DoesExist(LabelUserNameText.Text))
                    {
                        //העתקת קובץ התמונה - אם לא תקינה הפסקת הפעולה ואי ביצוע השמירה
                        if (!SaveFile(GetPicfileName()))
                            return;

                        if (business.Insert())
                        {
                            BusinessArr businessArr = new BusinessArr();
                            businessArr.Fill();
                            business = businessArr.GetBusinessWithMaxId();

                            MessageBox.Show("העסק נוסף בהצלחה", "מידע", MessageBoxButtons.OK,
                                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                        }
                        else
                            MessageBox.Show("העסק לא נוסף בהצלחה, נסה בשנית", "שגיאה", MessageBoxButtons.OK,
                                MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                    }
                    else
                        MessageBox.Show("שם העסק שכתבת קיים", "מידע", MessageBoxButtons.OK,
                                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                }
                else
                {
                    //עדכון עסק קיים
                    if (oldBusinessArr.IsContain(business.Name))
                    {
                        //העתקת קובץ התמונה - אם לא תקינה הפסקת הפעולה ואי ביצוע השמירה
                        if (!SaveFile(GetPicfileName(), business.Picture))
                            return;

                        if (business.Update())
                        {                            
                            MessageBox.Show("המידע עודכן בהצלחה", "מידע", MessageBoxButtons.OK,
                                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                        }
                        else
                            MessageBox.Show("המידע לא עודכן בהצלחה, נסה בשנית", "שגיאה", MessageBoxButtons.OK,
                                MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                    }
                    else
                        MessageBox.Show("שם העסק שכתבת קיים", "מידע", MessageBoxButtons.OK,
                                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                }
            }
        }

        private void ButtonStreet_Click(object sender, EventArgs e)
        {
            FormStreet formStreet = new FormStreet(LabelUserNameText.Text, ComboBoxStreet.SelectedItem as Street);
            formStreet.ShowDialog();
            StreetArrToForm(ComboBoxStreet, true, formStreet.SelectedStreet);
        }

        private void PictureBoxBusiness_Click(object sender, EventArgs e)
        {
            //פתיחת תיבת דו-שיח לבחירת קובץ התמונה - לקבצים מסוג תמונה בלבד - והצגת התמונה
            openFileDialogPicture.Filter = "pics (*.png)|*.png|pics (*.jpg)|*.jpg|All files (*.*)|*.*";
            openFileDialogPicture.ShowDialog();
            PictureBoxBusiness.ImageLocation = openFileDialogPicture.FileName;
        }

        private void ButtonCity_Click(object sender, EventArgs e)
        {
            FormCity formCity = new FormCity(LabelUserNameText.Text, ComboBoxCity.SelectedItem as City);
            formCity.ShowDialog();
            CityArrToForm(ComboBoxCity, true, formCity.SelectedCity);
        }

        private void ButtonBeginning_Click(object sender, EventArgs e)
        {
            string userName;
            userName = LabelUserNameText.Text;
            this.Hide();
            FormBeginning formBeginning = new FormBeginning(userName);
            formBeginning.ShowDialog();
        }
    }
}
