namespace FinalProject_ManagingEmployees.UI
{
    partial class FormBusiness
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
            this.openFileDialogPicture = new System.Windows.Forms.OpenFileDialog();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonBeginning = new System.Windows.Forms.Button();
            this.LabelID = new System.Windows.Forms.Label();
            this.LabelStreet = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelIDText = new System.Windows.Forms.Label();
            this.LabelPhoneNumber = new System.Windows.Forms.Label();
            this.TextBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.ComboBoxPhone = new System.Windows.Forms.ComboBox();
            this.LabelComboPhone = new System.Windows.Forms.Label();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.ComboBoxStreet = new System.Windows.Forms.ComboBox();
            this.ButtonStreet = new System.Windows.Forms.Button();
            this.LabelNumberStreet = new System.Windows.Forms.Label();
            this.TextBoxNumberInStreet = new System.Windows.Forms.TextBox();
            this.LabelCity = new System.Windows.Forms.Label();
            this.ComboBoxCity = new System.Windows.Forms.ComboBox();
            this.ButtonCity = new System.Windows.Forms.Button();
            this.LabelUserName = new System.Windows.Forms.Label();
            this.LabelUserNameText = new System.Windows.Forms.Label();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.PictureBoxBusiness = new System.Windows.Forms.PictureBox();
            this.LabelFullAdress = new System.Windows.Forms.Label();
            this.LabelFullAdressText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxBusiness)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialogPicture
            // 
            this.openFileDialogPicture.FileName = "openFileDialog1";
            // 
            // ButtonSave
            // 
            this.ButtonSave.BackColor = System.Drawing.Color.LightGreen;
            this.ButtonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ButtonSave.Location = new System.Drawing.Point(598, 717);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(180, 83);
            this.ButtonSave.TabIndex = 90;
            this.ButtonSave.Text = "שמירה";
            this.ButtonSave.UseVisualStyleBackColor = false;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonBeginning
            // 
            this.ButtonBeginning.BackColor = System.Drawing.Color.Cyan;
            this.ButtonBeginning.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ButtonBeginning.Location = new System.Drawing.Point(402, 717);
            this.ButtonBeginning.Name = "ButtonBeginning";
            this.ButtonBeginning.Size = new System.Drawing.Size(180, 83);
            this.ButtonBeginning.TabIndex = 111;
            this.ButtonBeginning.Text = "חזרה לעמוד הקודם";
            this.ButtonBeginning.UseVisualStyleBackColor = false;
            this.ButtonBeginning.Click += new System.EventHandler(this.ButtonBeginning_Click);
            // 
            // LabelID
            // 
            this.LabelID.AutoSize = true;
            this.LabelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LabelID.Location = new System.Drawing.Point(1007, 117);
            this.LabelID.Name = "LabelID";
            this.LabelID.Size = new System.Drawing.Size(141, 32);
            this.LabelID.TabIndex = 113;
            this.LabelID.Text = "מזהה עסק";
            // 
            // LabelStreet
            // 
            this.LabelStreet.AutoSize = true;
            this.LabelStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LabelStreet.Location = new System.Drawing.Point(1072, 342);
            this.LabelStreet.Name = "LabelStreet";
            this.LabelStreet.Size = new System.Drawing.Size(75, 32);
            this.LabelStreet.TabIndex = 117;
            this.LabelStreet.Text = "רחוב";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LabelName.Location = new System.Drawing.Point(968, 267);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(180, 32);
            this.LabelName.TabIndex = 118;
            this.LabelName.Text = "שם עסק/סניף";
            // 
            // LabelIDText
            // 
            this.LabelIDText.AutoSize = true;
            this.LabelIDText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LabelIDText.Location = new System.Drawing.Point(962, 117);
            this.LabelIDText.Name = "LabelIDText";
            this.LabelIDText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelIDText.Size = new System.Drawing.Size(31, 32);
            this.LabelIDText.TabIndex = 119;
            this.LabelIDText.Text = "0";
            // 
            // LabelPhoneNumber
            // 
            this.LabelPhoneNumber.AutoSize = true;
            this.LabelPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LabelPhoneNumber.Location = new System.Drawing.Point(993, 642);
            this.LabelPhoneNumber.Name = "LabelPhoneNumber";
            this.LabelPhoneNumber.Size = new System.Drawing.Size(147, 32);
            this.LabelPhoneNumber.TabIndex = 116;
            this.LabelPhoneNumber.Text = "טלפון עסק";
            // 
            // TextBoxPhoneNumber
            // 
            this.TextBoxPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TextBoxPhoneNumber.Location = new System.Drawing.Point(752, 642);
            this.TextBoxPhoneNumber.MaxLength = 7;
            this.TextBoxPhoneNumber.Name = "TextBoxPhoneNumber";
            this.TextBoxPhoneNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextBoxPhoneNumber.Size = new System.Drawing.Size(218, 39);
            this.TextBoxPhoneNumber.TabIndex = 115;
            this.TextBoxPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxIsDigit_KeyPress);
            // 
            // ComboBoxPhone
            // 
            this.ComboBoxPhone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ComboBoxPhone.FormattingEnabled = true;
            this.ComboBoxPhone.Items.AddRange(new object[] {
            "02",
            "03",
            "04",
            "08",
            "09"});
            this.ComboBoxPhone.Location = new System.Drawing.Point(603, 641);
            this.ComboBoxPhone.Name = "ComboBoxPhone";
            this.ComboBoxPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ComboBoxPhone.Size = new System.Drawing.Size(112, 40);
            this.ComboBoxPhone.TabIndex = 114;
            // 
            // LabelComboPhone
            // 
            this.LabelComboPhone.AutoSize = true;
            this.LabelComboPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LabelComboPhone.Location = new System.Drawing.Point(721, 645);
            this.LabelComboPhone.Name = "LabelComboPhone";
            this.LabelComboPhone.Size = new System.Drawing.Size(25, 32);
            this.LabelComboPhone.TabIndex = 120;
            this.LabelComboPhone.Text = "-";
            // 
            // TextBoxName
            // 
            this.TextBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TextBoxName.Location = new System.Drawing.Point(591, 267);
            this.TextBoxName.MaxLength = 50;
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TextBoxName.Size = new System.Drawing.Size(364, 39);
            this.TextBoxName.TabIndex = 121;
            this.TextBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxIsHebrewLetter_KeyPress);
            // 
            // ComboBoxStreet
            // 
            this.ComboBoxStreet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ComboBoxStreet.FormattingEnabled = true;
            this.ComboBoxStreet.Location = new System.Drawing.Point(803, 342);
            this.ComboBoxStreet.Name = "ComboBoxStreet";
            this.ComboBoxStreet.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComboBoxStreet.Size = new System.Drawing.Size(252, 40);
            this.ComboBoxStreet.TabIndex = 122;
            this.ComboBoxStreet.TextChanged += new System.EventHandler(this.ComboBoxFullAdress_TextChanged);
            // 
            // ButtonStreet
            // 
            this.ButtonStreet.BackColor = System.Drawing.Color.Chocolate;
            this.ButtonStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ButtonStreet.Location = new System.Drawing.Point(735, 342);
            this.ButtonStreet.Name = "ButtonStreet";
            this.ButtonStreet.Size = new System.Drawing.Size(51, 49);
            this.ButtonStreet.TabIndex = 123;
            this.ButtonStreet.Text = "+";
            this.ButtonStreet.UseVisualStyleBackColor = false;
            this.ButtonStreet.Click += new System.EventHandler(this.ButtonStreet_Click);
            // 
            // LabelNumberStreet
            // 
            this.LabelNumberStreet.AutoSize = true;
            this.LabelNumberStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LabelNumberStreet.Location = new System.Drawing.Point(1066, 417);
            this.LabelNumberStreet.Name = "LabelNumberStreet";
            this.LabelNumberStreet.Size = new System.Drawing.Size(82, 32);
            this.LabelNumberStreet.TabIndex = 124;
            this.LabelNumberStreet.Text = "מספר";
            // 
            // TextBoxNumberInStreet
            // 
            this.TextBoxNumberInStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TextBoxNumberInStreet.Location = new System.Drawing.Point(803, 417);
            this.TextBoxNumberInStreet.MaxLength = 3;
            this.TextBoxNumberInStreet.Name = "TextBoxNumberInStreet";
            this.TextBoxNumberInStreet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextBoxNumberInStreet.Size = new System.Drawing.Size(252, 39);
            this.TextBoxNumberInStreet.TabIndex = 125;
            this.TextBoxNumberInStreet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxIsDigit_KeyPress);
            this.TextBoxNumberInStreet.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxFullAdress_KeyUp);
            // 
            // LabelCity
            // 
            this.LabelCity.AutoSize = true;
            this.LabelCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LabelCity.Location = new System.Drawing.Point(1065, 492);
            this.LabelCity.Name = "LabelCity";
            this.LabelCity.Size = new System.Drawing.Size(82, 32);
            this.LabelCity.TabIndex = 126;
            this.LabelCity.Text = "יישוב";
            // 
            // ComboBoxCity
            // 
            this.ComboBoxCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ComboBoxCity.FormattingEnabled = true;
            this.ComboBoxCity.Location = new System.Drawing.Point(803, 496);
            this.ComboBoxCity.Name = "ComboBoxCity";
            this.ComboBoxCity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComboBoxCity.Size = new System.Drawing.Size(252, 40);
            this.ComboBoxCity.TabIndex = 127;
            this.ComboBoxCity.TextChanged += new System.EventHandler(this.ComboBoxFullAdress_TextChanged);
            // 
            // ButtonCity
            // 
            this.ButtonCity.BackColor = System.Drawing.Color.Chocolate;
            this.ButtonCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ButtonCity.Location = new System.Drawing.Point(735, 496);
            this.ButtonCity.Name = "ButtonCity";
            this.ButtonCity.Size = new System.Drawing.Size(51, 52);
            this.ButtonCity.TabIndex = 128;
            this.ButtonCity.Text = "+";
            this.ButtonCity.UseVisualStyleBackColor = false;
            this.ButtonCity.Click += new System.EventHandler(this.ButtonCity_Click);
            // 
            // LabelUserName
            // 
            this.LabelUserName.AutoSize = true;
            this.LabelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LabelUserName.Location = new System.Drawing.Point(993, 192);
            this.LabelUserName.Name = "LabelUserName";
            this.LabelUserName.Size = new System.Drawing.Size(155, 32);
            this.LabelUserName.TabIndex = 131;
            this.LabelUserName.Text = "שם משתמש";
            // 
            // LabelUserNameText
            // 
            this.LabelUserNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LabelUserNameText.Location = new System.Drawing.Point(581, 192);
            this.LabelUserNameText.Name = "LabelUserNameText";
            this.LabelUserNameText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelUserNameText.Size = new System.Drawing.Size(395, 37);
            this.LabelUserNameText.TabIndex = 132;
            this.LabelUserNameText.Text = "0";
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LabelTitle.Location = new System.Drawing.Point(505, 9);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(202, 37);
            this.LabelTitle.TabIndex = 133;
            this.LabelTitle.Text = "טופס פרטי עסק";
            // 
            // PictureBoxBusiness
            // 
            this.PictureBoxBusiness.Location = new System.Drawing.Point(37, 117);
            this.PictureBoxBusiness.Name = "PictureBoxBusiness";
            this.PictureBoxBusiness.Size = new System.Drawing.Size(443, 263);
            this.PictureBoxBusiness.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxBusiness.TabIndex = 134;
            this.PictureBoxBusiness.TabStop = false;
            this.PictureBoxBusiness.Click += new System.EventHandler(this.PictureBoxBusiness_Click);
            // 
            // LabelFullAdress
            // 
            this.LabelFullAdress.AutoSize = true;
            this.LabelFullAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LabelFullAdress.Location = new System.Drawing.Point(976, 567);
            this.LabelFullAdress.Name = "LabelFullAdress";
            this.LabelFullAdress.Size = new System.Drawing.Size(172, 32);
            this.LabelFullAdress.TabIndex = 135;
            this.LabelFullAdress.Text = "כתובת מלאה";
            // 
            // LabelFullAdressText
            // 
            this.LabelFullAdressText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LabelFullAdressText.Location = new System.Drawing.Point(549, 567);
            this.LabelFullAdressText.Name = "LabelFullAdressText";
            this.LabelFullAdressText.Size = new System.Drawing.Size(412, 32);
            this.LabelFullAdressText.TabIndex = 136;
            this.LabelFullAdressText.Text = "כתובת מלאה";
            // 
            // FormBusiness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(1181, 812);
            this.Controls.Add(this.LabelFullAdressText);
            this.Controls.Add(this.LabelFullAdress);
            this.Controls.Add(this.PictureBoxBusiness);
            this.Controls.Add(this.LabelTitle);
            this.Controls.Add(this.LabelUserNameText);
            this.Controls.Add(this.LabelUserName);
            this.Controls.Add(this.ButtonCity);
            this.Controls.Add(this.ComboBoxCity);
            this.Controls.Add(this.LabelCity);
            this.Controls.Add(this.TextBoxNumberInStreet);
            this.Controls.Add(this.LabelNumberStreet);
            this.Controls.Add(this.ButtonStreet);
            this.Controls.Add(this.ComboBoxStreet);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.LabelComboPhone);
            this.Controls.Add(this.ComboBoxPhone);
            this.Controls.Add(this.TextBoxPhoneNumber);
            this.Controls.Add(this.LabelPhoneNumber);
            this.Controls.Add(this.LabelIDText);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.LabelStreet);
            this.Controls.Add(this.LabelID);
            this.Controls.Add(this.ButtonBeginning);
            this.Controls.Add(this.ButtonSave);
            this.Name = "FormBusiness";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Business Form";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxBusiness)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialogPicture;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonBeginning;
        private System.Windows.Forms.Label LabelID;
        private System.Windows.Forms.Label LabelStreet;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelIDText;
        private System.Windows.Forms.Label LabelPhoneNumber;
        private System.Windows.Forms.TextBox TextBoxPhoneNumber;
        private System.Windows.Forms.ComboBox ComboBoxPhone;
        private System.Windows.Forms.Label LabelComboPhone;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.ComboBox ComboBoxStreet;
        private System.Windows.Forms.Button ButtonStreet;
        private System.Windows.Forms.Label LabelNumberStreet;
        private System.Windows.Forms.TextBox TextBoxNumberInStreet;
        private System.Windows.Forms.Label LabelCity;
        private System.Windows.Forms.ComboBox ComboBoxCity;
        private System.Windows.Forms.Button ButtonCity;
        private System.Windows.Forms.Label LabelUserName;
        private System.Windows.Forms.Label LabelUserNameText;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.PictureBox PictureBoxBusiness;
        private System.Windows.Forms.Label LabelFullAdress;
        private System.Windows.Forms.Label LabelFullAdressText;
    }
}