namespace FinalProject_ManagingEmployees.UI
{
    partial class FormLogin
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
            this.GroupBoxLogin = new System.Windows.Forms.GroupBox();
            this.ButtonShowPasswordLogin = new System.Windows.Forms.Button();
            this.ButtonRegisterLogin = new System.Windows.Forms.Button();
            this.ButtonLoginLogin = new System.Windows.Forms.Button();
            this.TextBoxPasswordLogin = new System.Windows.Forms.TextBox();
            this.LabelPasswordLogin = new System.Windows.Forms.Label();
            this.LabelTitleLogin = new System.Windows.Forms.Label();
            this.LabelUserNameLogin = new System.Windows.Forms.Label();
            this.TextBoxUserNameLogin = new System.Windows.Forms.TextBox();
            this.GroupBoxRegister = new System.Windows.Forms.GroupBox();
            this.ButtonShowRepeatPasswordRegister = new System.Windows.Forms.Button();
            this.ButtonShowPasswordRegister = new System.Windows.Forms.Button();
            this.LabelIDText = new System.Windows.Forms.Label();
            this.LabelID = new System.Windows.Forms.Label();
            this.TextBoxRepeatPassword = new System.Windows.Forms.TextBox();
            this.LabelRepeatPassword = new System.Windows.Forms.Label();
            this.ButtonRegisterRegister = new System.Windows.Forms.Button();
            this.ButtonLoginRegister = new System.Windows.Forms.Button();
            this.TextBoxPasswordRegister = new System.Windows.Forms.TextBox();
            this.LabelPasswordRegister = new System.Windows.Forms.Label();
            this.LabelTitleRegister = new System.Windows.Forms.Label();
            this.LabelUserNameRegister = new System.Windows.Forms.Label();
            this.TextBoxUserNameRegister = new System.Windows.Forms.TextBox();
            this.GroupBoxLogin.SuspendLayout();
            this.GroupBoxRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxLogin
            // 
            this.GroupBoxLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBoxLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(222)))), ((int)(((byte)(115)))));
            this.GroupBoxLogin.Controls.Add(this.ButtonShowPasswordLogin);
            this.GroupBoxLogin.Controls.Add(this.ButtonRegisterLogin);
            this.GroupBoxLogin.Controls.Add(this.ButtonLoginLogin);
            this.GroupBoxLogin.Controls.Add(this.TextBoxPasswordLogin);
            this.GroupBoxLogin.Controls.Add(this.LabelPasswordLogin);
            this.GroupBoxLogin.Controls.Add(this.LabelTitleLogin);
            this.GroupBoxLogin.Controls.Add(this.LabelUserNameLogin);
            this.GroupBoxLogin.Controls.Add(this.TextBoxUserNameLogin);
            this.GroupBoxLogin.Location = new System.Drawing.Point(17, 12);
            this.GroupBoxLogin.Name = "GroupBoxLogin";
            this.GroupBoxLogin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GroupBoxLogin.Size = new System.Drawing.Size(566, 412);
            this.GroupBoxLogin.TabIndex = 182;
            this.GroupBoxLogin.TabStop = false;
            this.GroupBoxLogin.Text = "התחברות";
            // 
            // ButtonShowPasswordLogin
            // 
            this.ButtonShowPasswordLogin.BackColor = System.Drawing.Color.SeaShell;
            this.ButtonShowPasswordLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ButtonShowPasswordLogin.Location = new System.Drawing.Point(150, 245);
            this.ButtonShowPasswordLogin.Name = "ButtonShowPasswordLogin";
            this.ButtonShowPasswordLogin.Size = new System.Drawing.Size(145, 39);
            this.ButtonShowPasswordLogin.TabIndex = 224;
            this.ButtonShowPasswordLogin.Text = "הצג סיסמה";
            this.ButtonShowPasswordLogin.UseVisualStyleBackColor = false;
            this.ButtonShowPasswordLogin.Click += new System.EventHandler(this.ButtonShowPasswordLogin_Click);
            // 
            // ButtonRegisterLogin
            // 
            this.ButtonRegisterLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(137)))), ((int)(((byte)(0)))));
            this.ButtonRegisterLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ButtonRegisterLogin.Location = new System.Drawing.Point(123, 331);
            this.ButtonRegisterLogin.Name = "ButtonRegisterLogin";
            this.ButtonRegisterLogin.Size = new System.Drawing.Size(133, 66);
            this.ButtonRegisterLogin.TabIndex = 223;
            this.ButtonRegisterLogin.Text = "הירשם";
            this.ButtonRegisterLogin.UseVisualStyleBackColor = false;
            this.ButtonRegisterLogin.Click += new System.EventHandler(this.ButtonRegisterLogin_Click);
            // 
            // ButtonLoginLogin
            // 
            this.ButtonLoginLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(234)))), ((int)(((byte)(0)))));
            this.ButtonLoginLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ButtonLoginLogin.Location = new System.Drawing.Point(271, 331);
            this.ButtonLoginLogin.Name = "ButtonLoginLogin";
            this.ButtonLoginLogin.Size = new System.Drawing.Size(133, 66);
            this.ButtonLoginLogin.TabIndex = 222;
            this.ButtonLoginLogin.Text = "התחבר";
            this.ButtonLoginLogin.UseVisualStyleBackColor = false;
            this.ButtonLoginLogin.Click += new System.EventHandler(this.ButtonLoginLogin_Click);
            // 
            // TextBoxPasswordLogin
            // 
            this.TextBoxPasswordLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPasswordLogin.Location = new System.Drawing.Point(150, 200);
            this.TextBoxPasswordLogin.MaxLength = 20;
            this.TextBoxPasswordLogin.Name = "TextBoxPasswordLogin";
            this.TextBoxPasswordLogin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TextBoxPasswordLogin.Size = new System.Drawing.Size(264, 39);
            this.TextBoxPasswordLogin.TabIndex = 178;
            this.TextBoxPasswordLogin.UseSystemPasswordChar = true;
            this.TextBoxPasswordLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxIsFix_KeyPress);
            // 
            // LabelPasswordLogin
            // 
            this.LabelPasswordLogin.AutoSize = true;
            this.LabelPasswordLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LabelPasswordLogin.Location = new System.Drawing.Point(452, 207);
            this.LabelPasswordLogin.Name = "LabelPasswordLogin";
            this.LabelPasswordLogin.Size = new System.Drawing.Size(97, 32);
            this.LabelPasswordLogin.TabIndex = 177;
            this.LabelPasswordLogin.Text = "סיסמה";
            // 
            // LabelTitleLogin
            // 
            this.LabelTitleLogin.AutoSize = true;
            this.LabelTitleLogin.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LabelTitleLogin.Location = new System.Drawing.Point(200, 22);
            this.LabelTitleLogin.Name = "LabelTitleLogin";
            this.LabelTitleLogin.Size = new System.Drawing.Size(144, 37);
            this.LabelTitleLogin.TabIndex = 175;
            this.LabelTitleLogin.Text = "התחברות";
            // 
            // LabelUserNameLogin
            // 
            this.LabelUserNameLogin.AutoSize = true;
            this.LabelUserNameLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LabelUserNameLogin.Location = new System.Drawing.Point(391, 126);
            this.LabelUserNameLogin.Name = "LabelUserNameLogin";
            this.LabelUserNameLogin.Size = new System.Drawing.Size(155, 32);
            this.LabelUserNameLogin.TabIndex = 84;
            this.LabelUserNameLogin.Text = "שם משתמש";
            // 
            // TextBoxUserNameLogin
            // 
            this.TextBoxUserNameLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxUserNameLogin.Location = new System.Drawing.Point(92, 126);
            this.TextBoxUserNameLogin.MaxLength = 20;
            this.TextBoxUserNameLogin.Name = "TextBoxUserNameLogin";
            this.TextBoxUserNameLogin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TextBoxUserNameLogin.Size = new System.Drawing.Size(264, 39);
            this.TextBoxUserNameLogin.TabIndex = 170;
            this.TextBoxUserNameLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxIsFix_KeyPress);
            // 
            // GroupBoxRegister
            // 
            this.GroupBoxRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBoxRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(222)))), ((int)(((byte)(115)))));
            this.GroupBoxRegister.Controls.Add(this.ButtonShowRepeatPasswordRegister);
            this.GroupBoxRegister.Controls.Add(this.ButtonShowPasswordRegister);
            this.GroupBoxRegister.Controls.Add(this.LabelIDText);
            this.GroupBoxRegister.Controls.Add(this.LabelID);
            this.GroupBoxRegister.Controls.Add(this.TextBoxRepeatPassword);
            this.GroupBoxRegister.Controls.Add(this.LabelRepeatPassword);
            this.GroupBoxRegister.Controls.Add(this.ButtonRegisterRegister);
            this.GroupBoxRegister.Controls.Add(this.ButtonLoginRegister);
            this.GroupBoxRegister.Controls.Add(this.TextBoxPasswordRegister);
            this.GroupBoxRegister.Controls.Add(this.LabelPasswordRegister);
            this.GroupBoxRegister.Controls.Add(this.LabelTitleRegister);
            this.GroupBoxRegister.Controls.Add(this.LabelUserNameRegister);
            this.GroupBoxRegister.Controls.Add(this.TextBoxUserNameRegister);
            this.GroupBoxRegister.Location = new System.Drawing.Point(10, 12);
            this.GroupBoxRegister.Name = "GroupBoxRegister";
            this.GroupBoxRegister.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GroupBoxRegister.Size = new System.Drawing.Size(573, 506);
            this.GroupBoxRegister.TabIndex = 183;
            this.GroupBoxRegister.TabStop = false;
            this.GroupBoxRegister.Text = "רישום";
            // 
            // ButtonShowRepeatPasswordRegister
            // 
            this.ButtonShowRepeatPasswordRegister.BackColor = System.Drawing.Color.SeaShell;
            this.ButtonShowRepeatPasswordRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ButtonShowRepeatPasswordRegister.Location = new System.Drawing.Point(107, 386);
            this.ButtonShowRepeatPasswordRegister.Name = "ButtonShowRepeatPasswordRegister";
            this.ButtonShowRepeatPasswordRegister.Size = new System.Drawing.Size(145, 39);
            this.ButtonShowRepeatPasswordRegister.TabIndex = 228;
            this.ButtonShowRepeatPasswordRegister.Text = "הצג סיסמה";
            this.ButtonShowRepeatPasswordRegister.UseVisualStyleBackColor = false;
            this.ButtonShowRepeatPasswordRegister.Click += new System.EventHandler(this.ButtonShowRepeatPasswordRegister_Click);
            // 
            // ButtonShowPasswordRegister
            // 
            this.ButtonShowPasswordRegister.BackColor = System.Drawing.Color.SeaShell;
            this.ButtonShowPasswordRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ButtonShowPasswordRegister.Location = new System.Drawing.Point(181, 294);
            this.ButtonShowPasswordRegister.Name = "ButtonShowPasswordRegister";
            this.ButtonShowPasswordRegister.Size = new System.Drawing.Size(145, 39);
            this.ButtonShowPasswordRegister.TabIndex = 225;
            this.ButtonShowPasswordRegister.Text = "הצג סיסמה";
            this.ButtonShowPasswordRegister.UseVisualStyleBackColor = false;
            this.ButtonShowPasswordRegister.Click += new System.EventHandler(this.ButtonShowPasswordRegister_Click);
            // 
            // LabelIDText
            // 
            this.LabelIDText.AutoSize = true;
            this.LabelIDText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LabelIDText.Location = new System.Drawing.Point(341, 106);
            this.LabelIDText.Name = "LabelIDText";
            this.LabelIDText.Size = new System.Drawing.Size(31, 32);
            this.LabelIDText.TabIndex = 227;
            this.LabelIDText.Text = "0";
            // 
            // LabelID
            // 
            this.LabelID.AutoSize = true;
            this.LabelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LabelID.Location = new System.Drawing.Point(380, 106);
            this.LabelID.Name = "LabelID";
            this.LabelID.Size = new System.Drawing.Size(182, 32);
            this.LabelID.TabIndex = 226;
            this.LabelID.Text = "מזהה משתמש";
            // 
            // TextBoxRepeatPassword
            // 
            this.TextBoxRepeatPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TextBoxRepeatPassword.Location = new System.Drawing.Point(107, 341);
            this.TextBoxRepeatPassword.MaxLength = 20;
            this.TextBoxRepeatPassword.Name = "TextBoxRepeatPassword";
            this.TextBoxRepeatPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TextBoxRepeatPassword.Size = new System.Drawing.Size(264, 39);
            this.TextBoxRepeatPassword.TabIndex = 225;
            this.TextBoxRepeatPassword.UseSystemPasswordChar = true;
            this.TextBoxRepeatPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxIsFix_KeyPress);
            // 
            // LabelRepeatPassword
            // 
            this.LabelRepeatPassword.AutoSize = true;
            this.LabelRepeatPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LabelRepeatPassword.Location = new System.Drawing.Point(383, 348);
            this.LabelRepeatPassword.Name = "LabelRepeatPassword";
            this.LabelRepeatPassword.Size = new System.Drawing.Size(177, 32);
            this.LabelRepeatPassword.TabIndex = 224;
            this.LabelRepeatPassword.Text = "סיסמה חוזרת";
            // 
            // ButtonRegisterRegister
            // 
            this.ButtonRegisterRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(137)))), ((int)(((byte)(0)))));
            this.ButtonRegisterRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ButtonRegisterRegister.Location = new System.Drawing.Point(137, 434);
            this.ButtonRegisterRegister.Name = "ButtonRegisterRegister";
            this.ButtonRegisterRegister.Size = new System.Drawing.Size(133, 66);
            this.ButtonRegisterRegister.TabIndex = 223;
            this.ButtonRegisterRegister.Text = "הירשם";
            this.ButtonRegisterRegister.UseVisualStyleBackColor = false;
            this.ButtonRegisterRegister.Click += new System.EventHandler(this.ButtonRegisterRegister_Click);
            // 
            // ButtonLoginRegister
            // 
            this.ButtonLoginRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(234)))), ((int)(((byte)(0)))));
            this.ButtonLoginRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ButtonLoginRegister.Location = new System.Drawing.Point(285, 434);
            this.ButtonLoginRegister.Name = "ButtonLoginRegister";
            this.ButtonLoginRegister.Size = new System.Drawing.Size(133, 66);
            this.ButtonLoginRegister.TabIndex = 222;
            this.ButtonLoginRegister.Text = "התחבר";
            this.ButtonLoginRegister.UseVisualStyleBackColor = false;
            this.ButtonLoginRegister.Click += new System.EventHandler(this.ButtonLoginRegister_Click);
            // 
            // TextBoxPasswordRegister
            // 
            this.TextBoxPasswordRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TextBoxPasswordRegister.Location = new System.Drawing.Point(181, 249);
            this.TextBoxPasswordRegister.MaxLength = 20;
            this.TextBoxPasswordRegister.Name = "TextBoxPasswordRegister";
            this.TextBoxPasswordRegister.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TextBoxPasswordRegister.Size = new System.Drawing.Size(264, 39);
            this.TextBoxPasswordRegister.TabIndex = 178;
            this.TextBoxPasswordRegister.UseSystemPasswordChar = true;
            this.TextBoxPasswordRegister.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxIsFix_KeyPress);
            // 
            // LabelPasswordRegister
            // 
            this.LabelPasswordRegister.AutoSize = true;
            this.LabelPasswordRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LabelPasswordRegister.Location = new System.Drawing.Point(466, 256);
            this.LabelPasswordRegister.Name = "LabelPasswordRegister";
            this.LabelPasswordRegister.Size = new System.Drawing.Size(97, 32);
            this.LabelPasswordRegister.TabIndex = 177;
            this.LabelPasswordRegister.Text = "סיסמה";
            // 
            // LabelTitleRegister
            // 
            this.LabelTitleRegister.AutoSize = true;
            this.LabelTitleRegister.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LabelTitleRegister.Location = new System.Drawing.Point(229, 22);
            this.LabelTitleRegister.Name = "LabelTitleRegister";
            this.LabelTitleRegister.Size = new System.Drawing.Size(92, 37);
            this.LabelTitleRegister.TabIndex = 175;
            this.LabelTitleRegister.Text = "רישום";
            // 
            // LabelUserNameRegister
            // 
            this.LabelUserNameRegister.AutoSize = true;
            this.LabelUserNameRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LabelUserNameRegister.Location = new System.Drawing.Point(405, 177);
            this.LabelUserNameRegister.Name = "LabelUserNameRegister";
            this.LabelUserNameRegister.Size = new System.Drawing.Size(155, 32);
            this.LabelUserNameRegister.TabIndex = 84;
            this.LabelUserNameRegister.Text = "שם משתמש";
            // 
            // TextBoxUserNameRegister
            // 
            this.TextBoxUserNameRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TextBoxUserNameRegister.Location = new System.Drawing.Point(123, 170);
            this.TextBoxUserNameRegister.MaxLength = 20;
            this.TextBoxUserNameRegister.Name = "TextBoxUserNameRegister";
            this.TextBoxUserNameRegister.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TextBoxUserNameRegister.Size = new System.Drawing.Size(264, 39);
            this.TextBoxUserNameRegister.TabIndex = 170;
            this.TextBoxUserNameRegister.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxIsFix_KeyPress);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(595, 530);
            this.Controls.Add(this.GroupBoxRegister);
            this.Controls.Add(this.GroupBoxLogin);
            this.Name = "FormLogin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "טופס התחברות";
            this.GroupBoxLogin.ResumeLayout(false);
            this.GroupBoxLogin.PerformLayout();
            this.GroupBoxRegister.ResumeLayout(false);
            this.GroupBoxRegister.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxLogin;
        private System.Windows.Forms.Label LabelPasswordLogin;
        private System.Windows.Forms.Label LabelTitleLogin;
        private System.Windows.Forms.Label LabelUserNameLogin;
        private System.Windows.Forms.TextBox TextBoxUserNameLogin;
        private System.Windows.Forms.TextBox TextBoxPasswordLogin;
        private System.Windows.Forms.Button ButtonLoginLogin;
        private System.Windows.Forms.Button ButtonRegisterLogin;
        private System.Windows.Forms.GroupBox GroupBoxRegister;
        private System.Windows.Forms.Button ButtonRegisterRegister;
        private System.Windows.Forms.Button ButtonLoginRegister;
        private System.Windows.Forms.TextBox TextBoxPasswordRegister;
        private System.Windows.Forms.Label LabelPasswordRegister;
        private System.Windows.Forms.Label LabelTitleRegister;
        private System.Windows.Forms.Label LabelUserNameRegister;
        private System.Windows.Forms.TextBox TextBoxUserNameRegister;
        private System.Windows.Forms.TextBox TextBoxRepeatPassword;
        private System.Windows.Forms.Label LabelRepeatPassword;
        private System.Windows.Forms.Label LabelID;
        private System.Windows.Forms.Label LabelIDText;
        private System.Windows.Forms.Button ButtonShowPasswordLogin;
        private System.Windows.Forms.Button ButtonShowRepeatPasswordRegister;
        private System.Windows.Forms.Button ButtonShowPasswordRegister;
    }
}