namespace FinalProject_ManagingEmployees.UI
{
    partial class FormBank
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
            this.LabelTitle = new System.Windows.Forms.Label();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.TextBoxBank = new System.Windows.Forms.TextBox();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ListBoxBank = new System.Windows.Forms.ListBox();
            this.LabelIncome = new System.Windows.Forms.Label();
            this.LabelIDText = new System.Windows.Forms.Label();
            this.LabelID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LabelTitle.Location = new System.Drawing.Point(326, 9);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(129, 37);
            this.LabelTitle.TabIndex = 138;
            this.LabelTitle.Text = "טופס בנק";
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(238)))), ((int)(((byte)(247)))));
            this.ButtonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ButtonDelete.Location = new System.Drawing.Point(155, 496);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(152, 73);
            this.ButtonDelete.TabIndex = 137;
            this.ButtonDelete.Text = "מחיקה";
            this.ButtonDelete.UseVisualStyleBackColor = false;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // TextBoxBank
            // 
            this.TextBoxBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TextBoxBank.Location = new System.Drawing.Point(514, 163);
            this.TextBoxBank.Name = "TextBoxBank";
            this.TextBoxBank.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextBoxBank.Size = new System.Drawing.Size(119, 39);
            this.TextBoxBank.TabIndex = 136;
            this.TextBoxBank.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxIsDigit_KeyPress);
            // 
            // ButtonClear
            // 
            this.ButtonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(104)))), ((int)(((byte)(230)))));
            this.ButtonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ButtonClear.Location = new System.Drawing.Point(313, 496);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(152, 73);
            this.ButtonClear.TabIndex = 135;
            this.ButtonClear.Text = "נקה";
            this.ButtonClear.UseVisualStyleBackColor = false;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.ButtonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ButtonSave.Location = new System.Drawing.Point(471, 496);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(152, 73);
            this.ButtonSave.TabIndex = 134;
            this.ButtonSave.Text = "שמירה";
            this.ButtonSave.UseVisualStyleBackColor = false;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ListBoxBank
            // 
            this.ListBoxBank.BackColor = System.Drawing.Color.GhostWhite;
            this.ListBoxBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxBank.FormattingEnabled = true;
            this.ListBoxBank.ItemHeight = 29;
            this.ListBoxBank.Location = new System.Drawing.Point(12, 92);
            this.ListBoxBank.Name = "ListBoxBank";
            this.ListBoxBank.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ListBoxBank.Size = new System.Drawing.Size(184, 352);
            this.ListBoxBank.TabIndex = 133;
            this.ListBoxBank.DoubleClick += new System.EventHandler(this.ListBoxBanks_DoubleClick);
            // 
            // LabelIncome
            // 
            this.LabelIncome.AutoSize = true;
            this.LabelIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LabelIncome.Location = new System.Drawing.Point(654, 163);
            this.LabelIncome.Name = "LabelIncome";
            this.LabelIncome.Size = new System.Drawing.Size(135, 32);
            this.LabelIncome.TabIndex = 132;
            this.LabelIncome.Text = "מספר בנק";
            // 
            // LabelIDText
            // 
            this.LabelIDText.AutoSize = true;
            this.LabelIDText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LabelIDText.Location = new System.Drawing.Point(608, 99);
            this.LabelIDText.Name = "LabelIDText";
            this.LabelIDText.Size = new System.Drawing.Size(31, 32);
            this.LabelIDText.TabIndex = 131;
            this.LabelIDText.Text = "0";
            // 
            // LabelID
            // 
            this.LabelID.AutoSize = true;
            this.LabelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LabelID.Location = new System.Drawing.Point(654, 99);
            this.LabelID.Name = "LabelID";
            this.LabelID.Size = new System.Drawing.Size(133, 32);
            this.LabelID.TabIndex = 130;
            this.LabelID.Text = "מזהה בנק";
            // 
            // FormBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(801, 581);
            this.Controls.Add(this.LabelTitle);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.TextBoxBank);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ListBoxBank);
            this.Controls.Add(this.LabelIncome);
            this.Controls.Add(this.LabelIDText);
            this.Controls.Add(this.LabelID);
            this.Name = "FormBank";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "טופס בנק";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.TextBox TextBoxBank;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.ListBox ListBoxBank;
        private System.Windows.Forms.Label LabelIncome;
        private System.Windows.Forms.Label LabelIDText;
        private System.Windows.Forms.Label LabelID;
    }
}