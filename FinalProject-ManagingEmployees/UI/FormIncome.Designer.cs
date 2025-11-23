namespace FinalProject_ManagingEmployees.UI
{
    partial class FormIncome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIncome));
            this.LabelTitle = new System.Windows.Forms.Label();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.TextBoxIncome = new System.Windows.Forms.TextBox();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.ListBoxIncome = new System.Windows.Forms.ListBox();
            this.LabelIncome = new System.Windows.Forms.Label();
            this.LabelIDText = new System.Windows.Forms.Label();
            this.LabelID = new System.Windows.Forms.Label();
            this.PictureBoxIncome = new System.Windows.Forms.PictureBox();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.TextBoxDefaultPayment = new System.Windows.Forms.TextBox();
            this.LabelDefaultPayment = new System.Windows.Forms.Label();
            this.LabelMoney = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxIncome)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.LabelTitle.Location = new System.Drawing.Point(377, 9);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(266, 37);
            this.LabelTitle.TabIndex = 66;
            this.LabelTitle.Text = "טופס הכנסות נוספות";
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.ButtonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ButtonDelete.Location = new System.Drawing.Point(230, 688);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(180, 83);
            this.ButtonDelete.TabIndex = 65;
            this.ButtonDelete.Text = "מחיקה";
            this.ButtonDelete.UseVisualStyleBackColor = false;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // TextBoxIncome
            // 
            this.TextBoxIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TextBoxIncome.Location = new System.Drawing.Point(644, 165);
            this.TextBoxIncome.Name = "TextBoxIncome";
            this.TextBoxIncome.Size = new System.Drawing.Size(199, 39);
            this.TextBoxIncome.TabIndex = 64;
            this.TextBoxIncome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxIsHebrewLetter_KeyPress);
            // 
            // ButtonClear
            // 
            this.ButtonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(175)))), ((int)(((byte)(132)))));
            this.ButtonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ButtonClear.Location = new System.Drawing.Point(416, 688);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(180, 83);
            this.ButtonClear.TabIndex = 63;
            this.ButtonClear.Text = "נקה";
            this.ButtonClear.UseVisualStyleBackColor = false;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // ListBoxIncome
            // 
            this.ListBoxIncome.BackColor = System.Drawing.Color.GhostWhite;
            this.ListBoxIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxIncome.FormattingEnabled = true;
            this.ListBoxIncome.ItemHeight = 29;
            this.ListBoxIncome.Location = new System.Drawing.Point(12, 81);
            this.ListBoxIncome.Name = "ListBoxIncome";
            this.ListBoxIncome.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ListBoxIncome.Size = new System.Drawing.Size(276, 555);
            this.ListBoxIncome.TabIndex = 61;
            this.ListBoxIncome.DoubleClick += new System.EventHandler(this.ListBoxIncomes_DoubleClick);
            // 
            // LabelIncome
            // 
            this.LabelIncome.AutoSize = true;
            this.LabelIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LabelIncome.Location = new System.Drawing.Point(858, 165);
            this.LabelIncome.Name = "LabelIncome";
            this.LabelIncome.Size = new System.Drawing.Size(142, 32);
            this.LabelIncome.TabIndex = 60;
            this.LabelIncome.Text = "שם הכנסה";
            // 
            // LabelIDText
            // 
            this.LabelIDText.AutoSize = true;
            this.LabelIDText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LabelIDText.Location = new System.Drawing.Point(794, 102);
            this.LabelIDText.Name = "LabelIDText";
            this.LabelIDText.Size = new System.Drawing.Size(31, 32);
            this.LabelIDText.TabIndex = 59;
            this.LabelIDText.Text = "0";
            // 
            // LabelID
            // 
            this.LabelID.AutoSize = true;
            this.LabelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LabelID.Location = new System.Drawing.Point(831, 102);
            this.LabelID.Name = "LabelID";
            this.LabelID.Size = new System.Drawing.Size(169, 32);
            this.LabelID.TabIndex = 58;
            this.LabelID.Text = "מזהה הכנסה";
            // 
            // PictureBoxIncome
            // 
            this.PictureBoxIncome.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxIncome.Image")));
            this.PictureBoxIncome.InitialImage = null;
            this.PictureBoxIncome.Location = new System.Drawing.Point(489, 311);
            this.PictureBoxIncome.Name = "PictureBoxIncome";
            this.PictureBoxIncome.Size = new System.Drawing.Size(496, 291);
            this.PictureBoxIncome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxIncome.TabIndex = 129;
            this.PictureBoxIncome.TabStop = false;
            // 
            // ButtonSave
            // 
            this.ButtonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(108)))), ((int)(((byte)(59)))));
            this.ButtonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ButtonSave.Location = new System.Drawing.Point(602, 688);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(180, 83);
            this.ButtonSave.TabIndex = 62;
            this.ButtonSave.Text = "שמירה";
            this.ButtonSave.UseVisualStyleBackColor = false;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // TextBoxDefaultPayment
            // 
            this.TextBoxDefaultPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TextBoxDefaultPayment.Location = new System.Drawing.Point(621, 234);
            this.TextBoxDefaultPayment.Name = "TextBoxDefaultPayment";
            this.TextBoxDefaultPayment.Size = new System.Drawing.Size(114, 39);
            this.TextBoxDefaultPayment.TabIndex = 131;
            this.TextBoxDefaultPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TextBoxDefaultPayment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxIsDigit_KeyPress);
            // 
            // LabelDefaultPayment
            // 
            this.LabelDefaultPayment.AutoSize = true;
            this.LabelDefaultPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LabelDefaultPayment.Location = new System.Drawing.Point(744, 234);
            this.LabelDefaultPayment.Name = "LabelDefaultPayment";
            this.LabelDefaultPayment.Size = new System.Drawing.Size(256, 32);
            this.LabelDefaultPayment.TabIndex = 130;
            this.LabelDefaultPayment.Text = "תשלום ברירת מחדל";
            // 
            // LabelMoney
            // 
            this.LabelMoney.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelMoney.AutoSize = true;
            this.LabelMoney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(199)))), ((int)(((byte)(51)))));
            this.LabelMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LabelMoney.Location = new System.Drawing.Point(581, 237);
            this.LabelMoney.Margin = new System.Windows.Forms.Padding(3);
            this.LabelMoney.Name = "LabelMoney";
            this.LabelMoney.Size = new System.Drawing.Size(34, 32);
            this.LabelMoney.TabIndex = 169;
            this.LabelMoney.Text = "₪";
            // 
            // FormIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(199)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1028, 783);
            this.Controls.Add(this.LabelMoney);
            this.Controls.Add(this.TextBoxDefaultPayment);
            this.Controls.Add(this.LabelDefaultPayment);
            this.Controls.Add(this.PictureBoxIncome);
            this.Controls.Add(this.LabelTitle);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.TextBoxIncome);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ListBoxIncome);
            this.Controls.Add(this.LabelIncome);
            this.Controls.Add(this.LabelIDText);
            this.Controls.Add(this.LabelID);
            this.Name = "FormIncome";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "טופס הכנסות נוספות";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxIncome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.TextBox TextBoxIncome;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.ListBox ListBoxIncome;
        private System.Windows.Forms.Label LabelIncome;
        private System.Windows.Forms.Label LabelIDText;
        private System.Windows.Forms.Label LabelID;
        private System.Windows.Forms.PictureBox PictureBoxIncome;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.TextBox TextBoxDefaultPayment;
        private System.Windows.Forms.Label LabelDefaultPayment;
        private System.Windows.Forms.Label LabelMoney;
    }
}