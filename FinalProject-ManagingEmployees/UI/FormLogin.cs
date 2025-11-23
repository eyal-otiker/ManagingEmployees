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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            GroupBoxRegister.Hide();
            GroupBoxLogin.Show();
        }

        private Login FormToLogin()
        {
            Login login = new Login();

            login.Id = int.Parse(LabelIDText.Text);
            login.UserName = TextBoxUserNameRegister.Text;
            login.Password = TextBoxPasswordRegister.Text;

            return login;
        }

        private bool IsHebLetter(char c)
        {

            // פעולת עזר – האם האות היא אות בעברית

            return (c >= 'א' && c <= 'ת');
        }

        private void TextBoxIsFix_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!IsHebLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ' &&
                !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.KeyChar = char.MinValue;
        }

        public bool CheckForm()
        {
            bool flag = true;

            if (TextBoxUserNameRegister.Text.Length < 2)
            {
                flag = false;
                TextBoxUserNameRegister.BackColor = Color.Red;
            }
            else
                TextBoxUserNameRegister.BackColor = Color.White;

            if (TextBoxPasswordRegister.Text.Length < 2)
            {
                flag = false;
                TextBoxPasswordRegister.BackColor = Color.Red;
            }
            else
                TextBoxPasswordRegister.BackColor = Color.White;

            if (TextBoxPasswordRegister.Text != TextBoxRepeatPassword.Text)
            {
                flag = false;
                TextBoxPasswordRegister.BackColor = Color.Red;
                TextBoxRepeatPassword.BackColor = Color.Red;
            }
            else
                TextBoxPasswordRegister.BackColor = Color.White;
                TextBoxRepeatPassword.BackColor = Color.White;

            return flag;
        }

        private void ButtonRegisterLogin_Click(object sender, EventArgs e)
        {
            GroupBoxLogin.Hide();
            this.Text = "טופס רישום";
            GroupBoxRegister.Show();
        }

        private void ButtonLoginLogin_Click(object sender, EventArgs e)
        {
            LoginArr oldLoginArr = new LoginArr();
            oldLoginArr.Fill();
            Login login;
            
            if (TextBoxUserNameLogin.Text.Length == 0 || TextBoxPasswordLogin.Text.Length == 0)
                MessageBox.Show("לא הזנת פרטים", "שגיאה", MessageBoxButtons.OK,
                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);

            else if (!oldLoginArr.IsContainLogin(TextBoxUserNameLogin.Text, TextBoxPasswordLogin.Text))
                MessageBox.Show("הפרטים שההזנת אינם קיימים במערכת", "שגיאה", MessageBoxButtons.OK,
                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                    
            else
            {
                login = oldLoginArr.SearchLogin(TextBoxUserNameLogin.Text, TextBoxPasswordLogin.Text);
                this.Hide();
                FormBeginning formBeginning = new FormBeginning(login.UserName);
                formBeginning.ShowDialog();
            }              
        }

        private void ButtonRegisterRegister_Click(object sender, EventArgs e)
        {
            if (!CheckForm())
            {
                MessageBox.Show("הטופס לא מולא בהצלחה, תקן את השגיאות המסומנות באדום", "שגיאה", MessageBoxButtons.OK,
                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
            }
            else
            {
                Login login = FormToLogin();
                LoginArr oldLoginArr = new LoginArr();
                oldLoginArr.Fill();

                if (oldLoginArr.IsContainRegisterUserName(login.UserName))
                    MessageBox.Show("שם המשתמש שהזנת קיים", "מידע", MessageBoxButtons.OK,
                            MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);

                if (oldLoginArr.IsContainRegisterPassword(login.Password))
                    MessageBox.Show("הסיסמה שהזנת קיימת", "מידע", MessageBoxButtons.OK,
                            MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);

                if (!oldLoginArr.IsContainRegisterUserName(login.UserName) &&
                    !oldLoginArr.IsContainRegisterPassword(login.Password))
                {
                    if (login.Insert())
                    {
                        MessageBox.Show("שם המשתמש נוסף בהצלחה", "מידע", MessageBoxButtons.OK,
                            MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                        this.Hide();
                        FormBeginning formBeginning = new FormBeginning(login.UserName);
                        formBeginning.ShowDialog();
                    }
                    else
                        MessageBox.Show("הטופס לא התמלא בהצלחה, נסה בשנית", "שגיאה", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                                    MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                }               
            }
        }

        private void ButtonLoginRegister_Click(object sender, EventArgs e)
        {
            this.Text = "טופס התחברות";
            GroupBoxLogin.Show();
            GroupBoxRegister.Hide();
        }

        private void ShowPassword(TextBox textBox)
        {
            if (textBox.UseSystemPasswordChar == true)
                textBox.UseSystemPasswordChar = false;
            else
                textBox.UseSystemPasswordChar = true;
        }

        private void ButtonShowPasswordLogin_Click(object sender, EventArgs e)
        {
            ShowPassword(TextBoxPasswordLogin);
        }

        private void ButtonShowPasswordRegister_Click(object sender, EventArgs e)
        {
            ShowPassword(TextBoxPasswordRegister);
        }

        private void ButtonShowRepeatPasswordRegister_Click(object sender, EventArgs e)
        {
            ShowPassword(TextBoxRepeatPassword);
        }
    }
}
