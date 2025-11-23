namespace FinalProject_ManagingEmployees.UI
{
    partial class FormWorker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.TabControlWorker = new System.Windows.Forms.TabControl();
            this.TabPageWorker = new System.Windows.Forms.TabPage();
            this.LabelBusienssText = new System.Windows.Forms.Label();
            this.LabelBusiness = new System.Windows.Forms.Label();
            this.TextBoxEmail = new System.Windows.Forms.TextBox();
            this.GroupBoxFilter = new System.Windows.Forms.GroupBox();
            this.TextBoxEmailFilter = new System.Windows.Forms.TextBox();
            this.TextBoxIdentityNumberFilter = new System.Windows.Forms.TextBox();
            this.LabelEmailFilter = new System.Windows.Forms.Label();
            this.LabelIdNumberFilter = new System.Windows.Forms.Label();
            this.TextBoxPhoneNumberFilter = new System.Windows.Forms.TextBox();
            this.LabelPhoneNumberFilter = new System.Windows.Forms.Label();
            this.TextBoxLastNameFilter = new System.Windows.Forms.TextBox();
            this.LabelLastNameFilter = new System.Windows.Forms.Label();
            this.TextBoxFilterID = new System.Windows.Forms.TextBox();
            this.LabelIDFilter = new System.Windows.Forms.Label();
            this.LabelEmail = new System.Windows.Forms.Label();
            this.ListBoxWorker = new System.Windows.Forms.ListBox();
            this.LabelComboPhone = new System.Windows.Forms.Label();
            this.ComboBoxPhone = new System.Windows.Forms.ComboBox();
            this.TextBoxIdentityNumber = new System.Windows.Forms.TextBox();
            this.TextBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.TextBoxLastName = new System.Windows.Forms.TextBox();
            this.LabelIDText = new System.Windows.Forms.Label();
            this.LabelFirstName = new System.Windows.Forms.Label();
            this.LabelLastName = new System.Windows.Forms.Label();
            this.LabelBirhdayDate = new System.Windows.Forms.Label();
            this.LabelIdNumber = new System.Windows.Forms.Label();
            this.LabelPhoneNumber = new System.Windows.Forms.Label();
            this.DateTimeBirthday = new System.Windows.Forms.DateTimePicker();
            this.TextBoxFirstName = new System.Windows.Forms.TextBox();
            this.LabelID = new System.Windows.Forms.Label();
            this.TabPageBankAccount = new System.Windows.Forms.TabPage();
            this.ButtonBank = new System.Windows.Forms.Button();
            this.ComboBoxBank = new System.Windows.Forms.ComboBox();
            this.TextBoxAccountNumber = new System.Windows.Forms.TextBox();
            this.LabelBank = new System.Windows.Forms.Label();
            this.LabelAccountNum = new System.Windows.Forms.Label();
            this.LabelBranch = new System.Windows.Forms.Label();
            this.LabelTitleSection2 = new System.Windows.Forms.Label();
            this.TabPageDetailPayment = new System.Windows.Forms.TabPage();
            this.LabelMoney = new System.Windows.Forms.Label();
            this.TextBoxPayment = new System.Windows.Forms.TextBox();
            this.RadionButtonHourlyPayment = new System.Windows.Forms.RadioButton();
            this.RadionButtonMonthlyPayment = new System.Windows.Forms.RadioButton();
            this.LabelTitleSection3 = new System.Windows.Forms.Label();
            this.ButtonBeginning = new System.Windows.Forms.Button();
            this.TextBoxBranch = new System.Windows.Forms.TextBox();
            this.TabControlWorker.SuspendLayout();
            this.TabPageWorker.SuspendLayout();
            this.GroupBoxFilter.SuspendLayout();
            this.TabPageBankAccount.SuspendLayout();
            this.TabPageDetailPayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(30)))), ((int)(((byte)(14)))));
            this.ButtonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ButtonDelete.Location = new System.Drawing.Point(600, 766);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(180, 83);
            this.ButtonDelete.TabIndex = 70;
            this.ButtonDelete.Text = "מחיקה";
            this.ButtonDelete.UseVisualStyleBackColor = false;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonClear
            // 
            this.ButtonClear.BackColor = System.Drawing.Color.Yellow;
            this.ButtonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ButtonClear.Location = new System.Drawing.Point(795, 766);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(180, 83);
            this.ButtonClear.TabIndex = 69;
            this.ButtonClear.Text = "נקה";
            this.ButtonClear.UseVisualStyleBackColor = false;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LabelTitle.Location = new System.Drawing.Point(623, 22);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(213, 37);
            this.LabelTitle.TabIndex = 61;
            this.LabelTitle.Text = "טופס פרטי עובד";
            // 
            // ButtonSave
            // 
            this.ButtonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(222)))), ((int)(((byte)(115)))));
            this.ButtonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ButtonSave.Location = new System.Drawing.Point(990, 766);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(180, 83);
            this.ButtonSave.TabIndex = 60;
            this.ButtonSave.Text = "שמירה";
            this.ButtonSave.UseVisualStyleBackColor = false;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // TabControlWorker
            // 
            this.TabControlWorker.Controls.Add(this.TabPageWorker);
            this.TabControlWorker.Controls.Add(this.TabPageBankAccount);
            this.TabControlWorker.Controls.Add(this.TabPageDetailPayment);
            this.TabControlWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TabControlWorker.Location = new System.Drawing.Point(49, 12);
            this.TabControlWorker.Name = "TabControlWorker";
            this.TabControlWorker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TabControlWorker.RightToLeftLayout = true;
            this.TabControlWorker.SelectedIndex = 0;
            this.TabControlWorker.Size = new System.Drawing.Size(1461, 735);
            this.TabControlWorker.TabIndex = 78;
            // 
            // TabPageWorker
            // 
            this.TabPageWorker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(222)))), ((int)(((byte)(115)))));
            this.TabPageWorker.Controls.Add(this.LabelBusienssText);
            this.TabPageWorker.Controls.Add(this.LabelBusiness);
            this.TabPageWorker.Controls.Add(this.TextBoxEmail);
            this.TabPageWorker.Controls.Add(this.GroupBoxFilter);
            this.TabPageWorker.Controls.Add(this.LabelEmail);
            this.TabPageWorker.Controls.Add(this.ListBoxWorker);
            this.TabPageWorker.Controls.Add(this.LabelComboPhone);
            this.TabPageWorker.Controls.Add(this.ComboBoxPhone);
            this.TabPageWorker.Controls.Add(this.TextBoxIdentityNumber);
            this.TabPageWorker.Controls.Add(this.LabelTitle);
            this.TabPageWorker.Controls.Add(this.TextBoxPhoneNumber);
            this.TabPageWorker.Controls.Add(this.TextBoxLastName);
            this.TabPageWorker.Controls.Add(this.LabelIDText);
            this.TabPageWorker.Controls.Add(this.LabelFirstName);
            this.TabPageWorker.Controls.Add(this.LabelLastName);
            this.TabPageWorker.Controls.Add(this.LabelBirhdayDate);
            this.TabPageWorker.Controls.Add(this.LabelIdNumber);
            this.TabPageWorker.Controls.Add(this.LabelPhoneNumber);
            this.TabPageWorker.Controls.Add(this.DateTimeBirthday);
            this.TabPageWorker.Controls.Add(this.TextBoxFirstName);
            this.TabPageWorker.Controls.Add(this.LabelID);
            this.TabPageWorker.Location = new System.Drawing.Point(4, 38);
            this.TabPageWorker.Name = "TabPageWorker";
            this.TabPageWorker.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageWorker.Size = new System.Drawing.Size(1453, 693);
            this.TabPageWorker.TabIndex = 0;
            this.TabPageWorker.Text = "פרטי עובד";
            // 
            // LabelBusienssText
            // 
            this.LabelBusienssText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LabelBusienssText.Location = new System.Drawing.Point(129, 157);
            this.LabelBusienssText.Name = "LabelBusienssText";
            this.LabelBusienssText.Size = new System.Drawing.Size(259, 37);
            this.LabelBusienssText.TabIndex = 95;
            this.LabelBusienssText.Text = "0";
            // 
            // LabelBusiness
            // 
            this.LabelBusiness.AutoSize = true;
            this.LabelBusiness.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LabelBusiness.Location = new System.Drawing.Point(451, 157);
            this.LabelBusiness.Name = "LabelBusiness";
            this.LabelBusiness.Size = new System.Drawing.Size(114, 32);
            this.LabelBusiness.TabIndex = 94;
            this.LabelBusiness.Text = "שם עסק";
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TextBoxEmail.Location = new System.Drawing.Point(11, 579);
            this.TextBoxEmail.MaxLength = 50;
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextBoxEmail.Size = new System.Drawing.Size(370, 39);
            this.TextBoxEmail.TabIndex = 92;
            // 
            // GroupBoxFilter
            // 
            this.GroupBoxFilter.BackColor = System.Drawing.Color.LightYellow;
            this.GroupBoxFilter.Controls.Add(this.TextBoxEmailFilter);
            this.GroupBoxFilter.Controls.Add(this.TextBoxIdentityNumberFilter);
            this.GroupBoxFilter.Controls.Add(this.LabelEmailFilter);
            this.GroupBoxFilter.Controls.Add(this.LabelIdNumberFilter);
            this.GroupBoxFilter.Controls.Add(this.TextBoxPhoneNumberFilter);
            this.GroupBoxFilter.Controls.Add(this.LabelPhoneNumberFilter);
            this.GroupBoxFilter.Controls.Add(this.TextBoxLastNameFilter);
            this.GroupBoxFilter.Controls.Add(this.LabelLastNameFilter);
            this.GroupBoxFilter.Controls.Add(this.TextBoxFilterID);
            this.GroupBoxFilter.Controls.Add(this.LabelIDFilter);
            this.GroupBoxFilter.Location = new System.Drawing.Point(1021, 22);
            this.GroupBoxFilter.Name = "GroupBoxFilter";
            this.GroupBoxFilter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GroupBoxFilter.Size = new System.Drawing.Size(417, 363);
            this.GroupBoxFilter.TabIndex = 72;
            this.GroupBoxFilter.TabStop = false;
            this.GroupBoxFilter.Text = "סינון";
            // 
            // TextBoxEmailFilter
            // 
            this.TextBoxEmailFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TextBoxEmailFilter.Location = new System.Drawing.Point(30, 297);
            this.TextBoxEmailFilter.MaxLength = 9;
            this.TextBoxEmailFilter.Name = "TextBoxEmailFilter";
            this.TextBoxEmailFilter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextBoxEmailFilter.Size = new System.Drawing.Size(175, 39);
            this.TextBoxEmailFilter.TabIndex = 78;
            this.TextBoxEmailFilter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxFilter_KeyUp);
            // 
            // TextBoxIdentityNumberFilter
            // 
            this.TextBoxIdentityNumberFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TextBoxIdentityNumberFilter.Location = new System.Drawing.Point(30, 158);
            this.TextBoxIdentityNumberFilter.Name = "TextBoxIdentityNumberFilter";
            this.TextBoxIdentityNumberFilter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextBoxIdentityNumberFilter.Size = new System.Drawing.Size(175, 39);
            this.TextBoxIdentityNumberFilter.TabIndex = 50;
            this.TextBoxIdentityNumberFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxIsDigit_KeyPress);
            this.TextBoxIdentityNumberFilter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxFilter_KeyUp);
            // 
            // LabelEmailFilter
            // 
            this.LabelEmailFilter.AutoSize = true;
            this.LabelEmailFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LabelEmailFilter.Location = new System.Drawing.Point(302, 305);
            this.LabelEmailFilter.Name = "LabelEmailFilter";
            this.LabelEmailFilter.Size = new System.Drawing.Size(97, 32);
            this.LabelEmailFilter.TabIndex = 79;
            this.LabelEmailFilter.Text = "אימייל";
            // 
            // LabelIdNumberFilter
            // 
            this.LabelIdNumberFilter.AutoSize = true;
            this.LabelIdNumberFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LabelIdNumberFilter.Location = new System.Drawing.Point(236, 165);
            this.LabelIdNumberFilter.Name = "LabelIdNumberFilter";
            this.LabelIdNumberFilter.Size = new System.Drawing.Size(160, 32);
            this.LabelIdNumberFilter.TabIndex = 53;
            this.LabelIdNumberFilter.Text = "תעודת זהות";
            // 
            // TextBoxPhoneNumberFilter
            // 
            this.TextBoxPhoneNumberFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxPhoneNumberFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TextBoxPhoneNumberFilter.Location = new System.Drawing.Point(30, 228);
            this.TextBoxPhoneNumberFilter.Name = "TextBoxPhoneNumberFilter";
            this.TextBoxPhoneNumberFilter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextBoxPhoneNumberFilter.Size = new System.Drawing.Size(175, 39);
            this.TextBoxPhoneNumberFilter.TabIndex = 51;
            this.TextBoxPhoneNumberFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxIsDigit_KeyPress);
            this.TextBoxPhoneNumberFilter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxFilter_KeyUp);
            // 
            // LabelPhoneNumberFilter
            // 
            this.LabelPhoneNumberFilter.AutoSize = true;
            this.LabelPhoneNumberFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LabelPhoneNumberFilter.Location = new System.Drawing.Point(237, 235);
            this.LabelPhoneNumberFilter.Name = "LabelPhoneNumberFilter";
            this.LabelPhoneNumberFilter.Size = new System.Drawing.Size(161, 32);
            this.LabelPhoneNumberFilter.TabIndex = 50;
            this.LabelPhoneNumberFilter.Text = "מספר טלפון";
            // 
            // TextBoxLastNameFilter
            // 
            this.TextBoxLastNameFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxLastNameFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TextBoxLastNameFilter.Location = new System.Drawing.Point(30, 89);
            this.TextBoxLastNameFilter.Name = "TextBoxLastNameFilter";
            this.TextBoxLastNameFilter.Size = new System.Drawing.Size(175, 39);
            this.TextBoxLastNameFilter.TabIndex = 49;
            this.TextBoxLastNameFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxIsHebrewLetter_KeyPress);
            this.TextBoxLastNameFilter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxFilter_KeyUp);
            // 
            // LabelLastNameFilter
            // 
            this.LabelLastNameFilter.AutoSize = true;
            this.LabelLastNameFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LabelLastNameFilter.Location = new System.Drawing.Point(245, 96);
            this.LabelLastNameFilter.Name = "LabelLastNameFilter";
            this.LabelLastNameFilter.Size = new System.Drawing.Size(151, 32);
            this.LabelLastNameFilter.TabIndex = 49;
            this.LabelLastNameFilter.Text = "שם משפחה";
            // 
            // TextBoxFilterID
            // 
            this.TextBoxFilterID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxFilterID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TextBoxFilterID.Location = new System.Drawing.Point(30, 27);
            this.TextBoxFilterID.Name = "TextBoxFilterID";
            this.TextBoxFilterID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextBoxFilterID.Size = new System.Drawing.Size(175, 39);
            this.TextBoxFilterID.TabIndex = 48;
            this.TextBoxFilterID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxIsDigit_KeyPress);
            this.TextBoxFilterID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxFilter_KeyUp);
            // 
            // LabelIDFilter
            // 
            this.LabelIDFilter.AutoSize = true;
            this.LabelIDFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LabelIDFilter.Location = new System.Drawing.Point(317, 29);
            this.LabelIDFilter.Name = "LabelIDFilter";
            this.LabelIDFilter.Size = new System.Drawing.Size(80, 32);
            this.LabelIDFilter.TabIndex = 1;
            this.LabelIDFilter.Text = "מזהה";
            // 
            // LabelEmail
            // 
            this.LabelEmail.AutoSize = true;
            this.LabelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LabelEmail.Location = new System.Drawing.Point(471, 583);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.Size = new System.Drawing.Size(97, 32);
            this.LabelEmail.TabIndex = 93;
            this.LabelEmail.Text = "אימייל";
            // 
            // ListBoxWorker
            // 
            this.ListBoxWorker.BackColor = System.Drawing.Color.White;
            this.ListBoxWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ListBoxWorker.FormattingEnabled = true;
            this.ListBoxWorker.ItemHeight = 29;
            this.ListBoxWorker.Location = new System.Drawing.Point(623, 71);
            this.ListBoxWorker.Name = "ListBoxWorker";
            this.ListBoxWorker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ListBoxWorker.Size = new System.Drawing.Size(361, 584);
            this.ListBoxWorker.TabIndex = 68;
            this.ListBoxWorker.DoubleClick += new System.EventHandler(this.ListBoxWorkers_DoubleClick);
            // 
            // LabelComboPhone
            // 
            this.LabelComboPhone.AutoSize = true;
            this.LabelComboPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LabelComboPhone.Location = new System.Drawing.Point(129, 513);
            this.LabelComboPhone.Name = "LabelComboPhone";
            this.LabelComboPhone.Size = new System.Drawing.Size(24, 32);
            this.LabelComboPhone.TabIndex = 91;
            this.LabelComboPhone.Text = "-";
            // 
            // ComboBoxPhone
            // 
            this.ComboBoxPhone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ComboBoxPhone.FormattingEnabled = true;
            this.ComboBoxPhone.Items.AddRange(new object[] {
            "050",
            "052",
            "053",
            "054",
            "055",
            "058"});
            this.ComboBoxPhone.Location = new System.Drawing.Point(11, 509);
            this.ComboBoxPhone.Name = "ComboBoxPhone";
            this.ComboBoxPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ComboBoxPhone.Size = new System.Drawing.Size(112, 40);
            this.ComboBoxPhone.TabIndex = 83;
            // 
            // TextBoxIdentityNumber
            // 
            this.TextBoxIdentityNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TextBoxIdentityNumber.Location = new System.Drawing.Point(129, 364);
            this.TextBoxIdentityNumber.MaxLength = 9;
            this.TextBoxIdentityNumber.Name = "TextBoxIdentityNumber";
            this.TextBoxIdentityNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextBoxIdentityNumber.Size = new System.Drawing.Size(252, 39);
            this.TextBoxIdentityNumber.TabIndex = 81;
            this.TextBoxIdentityNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxIsDigit_KeyPress);
            // 
            // TextBoxPhoneNumber
            // 
            this.TextBoxPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TextBoxPhoneNumber.Location = new System.Drawing.Point(163, 506);
            this.TextBoxPhoneNumber.MaxLength = 7;
            this.TextBoxPhoneNumber.Name = "TextBoxPhoneNumber";
            this.TextBoxPhoneNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextBoxPhoneNumber.Size = new System.Drawing.Size(218, 39);
            this.TextBoxPhoneNumber.TabIndex = 84;
            this.TextBoxPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxIsDigit_KeyPress);
            // 
            // TextBoxLastName
            // 
            this.TextBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TextBoxLastName.Location = new System.Drawing.Point(129, 291);
            this.TextBoxLastName.Name = "TextBoxLastName";
            this.TextBoxLastName.Size = new System.Drawing.Size(252, 39);
            this.TextBoxLastName.TabIndex = 80;
            this.TextBoxLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxIsHebrewLetter_KeyPress);
            // 
            // LabelIDText
            // 
            this.LabelIDText.AutoSize = true;
            this.LabelIDText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LabelIDText.Location = new System.Drawing.Point(352, 86);
            this.LabelIDText.Name = "LabelIDText";
            this.LabelIDText.Size = new System.Drawing.Size(31, 32);
            this.LabelIDText.TabIndex = 90;
            this.LabelIDText.Text = "0";
            // 
            // LabelFirstName
            // 
            this.LabelFirstName.AutoSize = true;
            this.LabelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LabelFirstName.Location = new System.Drawing.Point(445, 228);
            this.LabelFirstName.Name = "LabelFirstName";
            this.LabelFirstName.Size = new System.Drawing.Size(120, 32);
            this.LabelFirstName.TabIndex = 89;
            this.LabelFirstName.Text = "שם פרטי";
            // 
            // LabelLastName
            // 
            this.LabelLastName.AutoSize = true;
            this.LabelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LabelLastName.Location = new System.Drawing.Point(414, 299);
            this.LabelLastName.Name = "LabelLastName";
            this.LabelLastName.Size = new System.Drawing.Size(151, 32);
            this.LabelLastName.TabIndex = 88;
            this.LabelLastName.Text = "שם משפחה";
            // 
            // LabelBirhdayDate
            // 
            this.LabelBirhdayDate.AutoSize = true;
            this.LabelBirhdayDate.BackColor = System.Drawing.Color.Transparent;
            this.LabelBirhdayDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LabelBirhdayDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelBirhdayDate.Location = new System.Drawing.Point(404, 441);
            this.LabelBirhdayDate.Name = "LabelBirhdayDate";
            this.LabelBirhdayDate.Size = new System.Drawing.Size(160, 32);
            this.LabelBirhdayDate.TabIndex = 87;
            this.LabelBirhdayDate.Text = "תאריך לידה";
            this.LabelBirhdayDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LabelIdNumber
            // 
            this.LabelIdNumber.AutoSize = true;
            this.LabelIdNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LabelIdNumber.Location = new System.Drawing.Point(400, 370);
            this.LabelIdNumber.Name = "LabelIdNumber";
            this.LabelIdNumber.Size = new System.Drawing.Size(160, 32);
            this.LabelIdNumber.TabIndex = 86;
            this.LabelIdNumber.Text = "תעודת זהות";
            // 
            // LabelPhoneNumber
            // 
            this.LabelPhoneNumber.AutoSize = true;
            this.LabelPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LabelPhoneNumber.Location = new System.Drawing.Point(406, 512);
            this.LabelPhoneNumber.Name = "LabelPhoneNumber";
            this.LabelPhoneNumber.Size = new System.Drawing.Size(161, 32);
            this.LabelPhoneNumber.TabIndex = 85;
            this.LabelPhoneNumber.Text = "מספר טלפון";
            // 
            // DateTimeBirthday
            // 
            this.DateTimeBirthday.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DateTimeBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.DateTimeBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimeBirthday.Location = new System.Drawing.Point(129, 437);
            this.DateTimeBirthday.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DateTimeBirthday.Name = "DateTimeBirthday";
            this.DateTimeBirthday.Size = new System.Drawing.Size(252, 39);
            this.DateTimeBirthday.TabIndex = 82;
            this.DateTimeBirthday.Value = new System.DateTime(2021, 3, 18, 0, 0, 0, 0);
            // 
            // TextBoxFirstName
            // 
            this.TextBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TextBoxFirstName.Location = new System.Drawing.Point(129, 218);
            this.TextBoxFirstName.Name = "TextBoxFirstName";
            this.TextBoxFirstName.Size = new System.Drawing.Size(252, 39);
            this.TextBoxFirstName.TabIndex = 79;
            this.TextBoxFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxIsHebrewLetter_KeyPress);
            // 
            // LabelID
            // 
            this.LabelID.AutoSize = true;
            this.LabelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LabelID.Location = new System.Drawing.Point(415, 86);
            this.LabelID.Name = "LabelID";
            this.LabelID.Size = new System.Drawing.Size(149, 32);
            this.LabelID.TabIndex = 78;
            this.LabelID.Text = "מזהה עובד";
            // 
            // TabPageBankAccount
            // 
            this.TabPageBankAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(222)))), ((int)(((byte)(115)))));
            this.TabPageBankAccount.Controls.Add(this.TextBoxBranch);
            this.TabPageBankAccount.Controls.Add(this.ButtonBank);
            this.TabPageBankAccount.Controls.Add(this.ComboBoxBank);
            this.TabPageBankAccount.Controls.Add(this.TextBoxAccountNumber);
            this.TabPageBankAccount.Controls.Add(this.LabelBank);
            this.TabPageBankAccount.Controls.Add(this.LabelAccountNum);
            this.TabPageBankAccount.Controls.Add(this.LabelBranch);
            this.TabPageBankAccount.Controls.Add(this.LabelTitleSection2);
            this.TabPageBankAccount.Location = new System.Drawing.Point(4, 38);
            this.TabPageBankAccount.Name = "TabPageBankAccount";
            this.TabPageBankAccount.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageBankAccount.Size = new System.Drawing.Size(1453, 693);
            this.TabPageBankAccount.TabIndex = 1;
            this.TabPageBankAccount.Text = "חשבון בנק";
            // 
            // ButtonBank
            // 
            this.ButtonBank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(15)))));
            this.ButtonBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ButtonBank.Location = new System.Drawing.Point(922, 245);
            this.ButtonBank.Name = "ButtonBank";
            this.ButtonBank.Size = new System.Drawing.Size(51, 49);
            this.ButtonBank.TabIndex = 126;
            this.ButtonBank.Text = "+";
            this.ButtonBank.UseVisualStyleBackColor = false;
            this.ButtonBank.Click += new System.EventHandler(this.ButtonBank_Click);
            // 
            // ComboBoxBank
            // 
            this.ComboBoxBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ComboBoxBank.FormattingEnabled = true;
            this.ComboBoxBank.Location = new System.Drawing.Point(992, 245);
            this.ComboBoxBank.Name = "ComboBoxBank";
            this.ComboBoxBank.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ComboBoxBank.Size = new System.Drawing.Size(252, 40);
            this.ComboBoxBank.TabIndex = 124;
            // 
            // TextBoxAccountNumber
            // 
            this.TextBoxAccountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TextBoxAccountNumber.Location = new System.Drawing.Point(992, 104);
            this.TextBoxAccountNumber.MaxLength = 7;
            this.TextBoxAccountNumber.Name = "TextBoxAccountNumber";
            this.TextBoxAccountNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextBoxAccountNumber.Size = new System.Drawing.Size(252, 39);
            this.TextBoxAccountNumber.TabIndex = 96;
            this.TextBoxAccountNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxIsDigit_KeyPress);
            // 
            // LabelBank
            // 
            this.LabelBank.AutoSize = true;
            this.LabelBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LabelBank.Location = new System.Drawing.Point(1381, 248);
            this.LabelBank.Name = "LabelBank";
            this.LabelBank.Size = new System.Drawing.Size(60, 32);
            this.LabelBank.TabIndex = 92;
            this.LabelBank.Text = "בנק";
            // 
            // LabelAccountNum
            // 
            this.LabelAccountNum.AutoSize = true;
            this.LabelAccountNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LabelAccountNum.Location = new System.Drawing.Point(1274, 104);
            this.LabelAccountNum.Name = "LabelAccountNum";
            this.LabelAccountNum.Size = new System.Drawing.Size(166, 32);
            this.LabelAccountNum.TabIndex = 94;
            this.LabelAccountNum.Text = "מספר חשבון";
            // 
            // LabelBranch
            // 
            this.LabelBranch.AutoSize = true;
            this.LabelBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LabelBranch.Location = new System.Drawing.Point(1370, 175);
            this.LabelBranch.Name = "LabelBranch";
            this.LabelBranch.Size = new System.Drawing.Size(72, 32);
            this.LabelBranch.TabIndex = 93;
            this.LabelBranch.Text = "סניף";
            // 
            // LabelTitleSection2
            // 
            this.LabelTitleSection2.AutoSize = true;
            this.LabelTitleSection2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LabelTitleSection2.Location = new System.Drawing.Point(596, 17);
            this.LabelTitleSection2.Name = "LabelTitleSection2";
            this.LabelTitleSection2.Size = new System.Drawing.Size(215, 37);
            this.LabelTitleSection2.TabIndex = 90;
            this.LabelTitleSection2.Text = "טופס חשבון בנק";
            // 
            // TabPageDetailPayment
            // 
            this.TabPageDetailPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(222)))), ((int)(((byte)(115)))));
            this.TabPageDetailPayment.Controls.Add(this.LabelMoney);
            this.TabPageDetailPayment.Controls.Add(this.TextBoxPayment);
            this.TabPageDetailPayment.Controls.Add(this.RadionButtonHourlyPayment);
            this.TabPageDetailPayment.Controls.Add(this.RadionButtonMonthlyPayment);
            this.TabPageDetailPayment.Controls.Add(this.LabelTitleSection3);
            this.TabPageDetailPayment.Location = new System.Drawing.Point(4, 38);
            this.TabPageDetailPayment.Name = "TabPageDetailPayment";
            this.TabPageDetailPayment.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageDetailPayment.Size = new System.Drawing.Size(1453, 693);
            this.TabPageDetailPayment.TabIndex = 2;
            this.TabPageDetailPayment.Text = "אופן תשלום משכורת";
            // 
            // LabelMoney
            // 
            this.LabelMoney.AutoSize = true;
            this.LabelMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LabelMoney.Location = new System.Drawing.Point(1303, 131);
            this.LabelMoney.Name = "LabelMoney";
            this.LabelMoney.Size = new System.Drawing.Size(35, 32);
            this.LabelMoney.TabIndex = 127;
            this.LabelMoney.Text = "₪";
            // 
            // TextBoxPayment
            // 
            this.TextBoxPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TextBoxPayment.Location = new System.Drawing.Point(1139, 128);
            this.TextBoxPayment.MaxLength = 7;
            this.TextBoxPayment.Name = "TextBoxPayment";
            this.TextBoxPayment.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextBoxPayment.Size = new System.Drawing.Size(158, 39);
            this.TextBoxPayment.TabIndex = 126;
            // 
            // RadionButtonHourlyPayment
            // 
            this.RadionButtonHourlyPayment.AutoSize = true;
            this.RadionButtonHourlyPayment.Location = new System.Drawing.Point(994, 71);
            this.RadionButtonHourlyPayment.Name = "RadionButtonHourlyPayment";
            this.RadionButtonHourlyPayment.Size = new System.Drawing.Size(198, 33);
            this.RadionButtonHourlyPayment.TabIndex = 125;
            this.RadionButtonHourlyPayment.Text = "משכורת שעתית";
            this.RadionButtonHourlyPayment.UseVisualStyleBackColor = true;
            // 
            // RadionButtonMonthlyPayment
            // 
            this.RadionButtonMonthlyPayment.AutoSize = true;
            this.RadionButtonMonthlyPayment.Checked = true;
            this.RadionButtonMonthlyPayment.Location = new System.Drawing.Point(1231, 71);
            this.RadionButtonMonthlyPayment.Name = "RadionButtonMonthlyPayment";
            this.RadionButtonMonthlyPayment.Size = new System.Drawing.Size(203, 33);
            this.RadionButtonMonthlyPayment.TabIndex = 125;
            this.RadionButtonMonthlyPayment.TabStop = true;
            this.RadionButtonMonthlyPayment.Text = "משכורת חודשית";
            this.RadionButtonMonthlyPayment.UseVisualStyleBackColor = true;
            // 
            // LabelTitleSection3
            // 
            this.LabelTitleSection3.AutoSize = true;
            this.LabelTitleSection3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LabelTitleSection3.Location = new System.Drawing.Point(493, 11);
            this.LabelTitleSection3.Name = "LabelTitleSection3";
            this.LabelTitleSection3.Size = new System.Drawing.Size(336, 37);
            this.LabelTitleSection3.TabIndex = 123;
            this.LabelTitleSection3.Text = "טופס אופן תשלום משכורת";
            // 
            // ButtonBeginning
            // 
            this.ButtonBeginning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(15)))));
            this.ButtonBeginning.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ButtonBeginning.Location = new System.Drawing.Point(402, 766);
            this.ButtonBeginning.Name = "ButtonBeginning";
            this.ButtonBeginning.Size = new System.Drawing.Size(180, 83);
            this.ButtonBeginning.TabIndex = 79;
            this.ButtonBeginning.Text = "חזרה לעמוד הקודם";
            this.ButtonBeginning.UseVisualStyleBackColor = false;
            this.ButtonBeginning.Click += new System.EventHandler(this.ButtonBeginning_Click);
            // 
            // TextBoxBranch
            // 
            this.TextBoxBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TextBoxBranch.Location = new System.Drawing.Point(992, 175);
            this.TextBoxBranch.MaxLength = 7;
            this.TextBoxBranch.Name = "TextBoxBranch";
            this.TextBoxBranch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextBoxBranch.Size = new System.Drawing.Size(252, 39);
            this.TextBoxBranch.TabIndex = 127;
            // 
            // FormWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(1522, 861);
            this.Controls.Add(this.ButtonBeginning);
            this.Controls.Add(this.TabControlWorker);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.ButtonSave);
            this.Name = "FormWorker";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "FormClient";
            this.TabControlWorker.ResumeLayout(false);
            this.TabPageWorker.ResumeLayout(false);
            this.TabPageWorker.PerformLayout();
            this.GroupBoxFilter.ResumeLayout(false);
            this.GroupBoxFilter.PerformLayout();
            this.TabPageBankAccount.ResumeLayout(false);
            this.TabPageBankAccount.PerformLayout();
            this.TabPageDetailPayment.ResumeLayout(false);
            this.TabPageDetailPayment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.TabControl TabControlWorker;
        private System.Windows.Forms.TabPage TabPageWorker;
        private System.Windows.Forms.TextBox TextBoxEmail;
        private System.Windows.Forms.GroupBox GroupBoxFilter;
        private System.Windows.Forms.TextBox TextBoxEmailFilter;
        private System.Windows.Forms.TextBox TextBoxIdentityNumberFilter;
        private System.Windows.Forms.Label LabelEmailFilter;
        private System.Windows.Forms.Label LabelIdNumberFilter;
        private System.Windows.Forms.TextBox TextBoxPhoneNumberFilter;
        private System.Windows.Forms.Label LabelPhoneNumberFilter;
        private System.Windows.Forms.TextBox TextBoxLastNameFilter;
        private System.Windows.Forms.Label LabelLastNameFilter;
        private System.Windows.Forms.TextBox TextBoxFilterID;
        private System.Windows.Forms.Label LabelIDFilter;
        private System.Windows.Forms.Label LabelEmail;
        private System.Windows.Forms.Label LabelComboPhone;
        private System.Windows.Forms.ComboBox ComboBoxPhone;
        private System.Windows.Forms.TextBox TextBoxIdentityNumber;
        private System.Windows.Forms.TextBox TextBoxPhoneNumber;
        private System.Windows.Forms.TextBox TextBoxLastName;
        private System.Windows.Forms.Label LabelIDText;
        private System.Windows.Forms.Label LabelFirstName;
        private System.Windows.Forms.Label LabelLastName;
        private System.Windows.Forms.Label LabelBirhdayDate;
        private System.Windows.Forms.Label LabelIdNumber;
        private System.Windows.Forms.Label LabelPhoneNumber;
        private System.Windows.Forms.DateTimePicker DateTimeBirthday;
        private System.Windows.Forms.TextBox TextBoxFirstName;
        private System.Windows.Forms.Label LabelID;
        private System.Windows.Forms.TabPage TabPageBankAccount;
        private System.Windows.Forms.ListBox ListBoxWorker;
        private System.Windows.Forms.TextBox TextBoxAccountNumber;
        private System.Windows.Forms.Label LabelBank;
        private System.Windows.Forms.Label LabelAccountNum;
        private System.Windows.Forms.Label LabelBranch;
        private System.Windows.Forms.Label LabelTitleSection2;
        private System.Windows.Forms.Button ButtonBeginning;
        private System.Windows.Forms.Label LabelBusienssText;
        private System.Windows.Forms.Label LabelBusiness;
        private System.Windows.Forms.TabPage TabPageDetailPayment;
        private System.Windows.Forms.Label LabelTitleSection3;
        private System.Windows.Forms.RadioButton RadionButtonHourlyPayment;
        private System.Windows.Forms.RadioButton RadionButtonMonthlyPayment;
        private System.Windows.Forms.ComboBox ComboBoxBank;
        private System.Windows.Forms.Button ButtonBank;
        private System.Windows.Forms.TextBox TextBoxPayment;
        private System.Windows.Forms.Label LabelMoney;
        private System.Windows.Forms.TextBox TextBoxBranch;
    }
}