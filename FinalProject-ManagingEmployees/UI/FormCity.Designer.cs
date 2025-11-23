namespace FinalProject_ManagingEmployees.UI
{
    partial class FormCity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCity));
            this.LabelTitle = new System.Windows.Forms.Label();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.TextBoxCity = new System.Windows.Forms.TextBox();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ListBoxCitys = new System.Windows.Forms.ListBox();
            this.LabelCity = new System.Windows.Forms.Label();
            this.LabelIDText = new System.Windows.Forms.Label();
            this.LabelID = new System.Windows.Forms.Label();
            this.PictureBoxCity = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCity)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LabelTitle.Location = new System.Drawing.Point(351, 9);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(142, 37);
            this.LabelTitle.TabIndex = 75;
            this.LabelTitle.Text = "טופס ישוב";
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.BackColor = System.Drawing.Color.Tomato;
            this.ButtonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ButtonDelete.Location = new System.Drawing.Point(144, 688);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(180, 83);
            this.ButtonDelete.TabIndex = 74;
            this.ButtonDelete.Text = "מחיקה";
            this.ButtonDelete.UseVisualStyleBackColor = false;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // TextBoxCity
            // 
            this.TextBoxCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TextBoxCity.Location = new System.Drawing.Point(565, 175);
            this.TextBoxCity.Name = "TextBoxCity";
            this.TextBoxCity.Size = new System.Drawing.Size(156, 39);
            this.TextBoxCity.TabIndex = 73;
            this.TextBoxCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxIsHebrewLetter_KeyPress);
            // 
            // ButtonClear
            // 
            this.ButtonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(202)))), ((int)(((byte)(156)))));
            this.ButtonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ButtonClear.Location = new System.Drawing.Point(344, 688);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(180, 83);
            this.ButtonClear.TabIndex = 72;
            this.ButtonClear.Text = "נקה";
            this.ButtonClear.UseVisualStyleBackColor = false;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(189)))));
            this.ButtonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ButtonSave.Location = new System.Drawing.Point(541, 688);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(180, 83);
            this.ButtonSave.TabIndex = 71;
            this.ButtonSave.Text = "שמירה";
            this.ButtonSave.UseVisualStyleBackColor = false;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ListBoxCitys
            // 
            this.ListBoxCitys.BackColor = System.Drawing.Color.White;
            this.ListBoxCitys.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ListBoxCitys.FormattingEnabled = true;
            this.ListBoxCitys.ItemHeight = 29;
            this.ListBoxCitys.Location = new System.Drawing.Point(12, 80);
            this.ListBoxCitys.Name = "ListBoxCitys";
            this.ListBoxCitys.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ListBoxCitys.Size = new System.Drawing.Size(251, 584);
            this.ListBoxCitys.TabIndex = 70;
            this.ListBoxCitys.DoubleClick += new System.EventHandler(this.ListBoxCitys_DoubleClick);
            // 
            // LabelCity
            // 
            this.LabelCity.AutoSize = true;
            this.LabelCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LabelCity.Location = new System.Drawing.Point(755, 175);
            this.LabelCity.Name = "LabelCity";
            this.LabelCity.Size = new System.Drawing.Size(118, 32);
            this.LabelCity.TabIndex = 69;
            this.LabelCity.Text = "שם ישוב";
            // 
            // LabelIDText
            // 
            this.LabelIDText.AutoSize = true;
            this.LabelIDText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LabelIDText.Location = new System.Drawing.Point(670, 104);
            this.LabelIDText.Name = "LabelIDText";
            this.LabelIDText.Size = new System.Drawing.Size(31, 32);
            this.LabelIDText.TabIndex = 68;
            this.LabelIDText.Text = "0";
            // 
            // LabelID
            // 
            this.LabelID.AutoSize = true;
            this.LabelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LabelID.Location = new System.Drawing.Point(728, 104);
            this.LabelID.Name = "LabelID";
            this.LabelID.Size = new System.Drawing.Size(145, 32);
            this.LabelID.TabIndex = 67;
            this.LabelID.Text = "מזהה ישוב";
            // 
            // PictureBoxCity
            // 
            this.PictureBoxCity.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxCity.Image")));
            this.PictureBoxCity.Location = new System.Drawing.Point(0, -3);
            this.PictureBoxCity.Name = "PictureBoxCity";
            this.PictureBoxCity.Size = new System.Drawing.Size(888, 798);
            this.PictureBoxCity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxCity.TabIndex = 76;
            this.PictureBoxCity.TabStop = false;
            // 
            // FormCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(885, 783);
            this.Controls.Add(this.LabelTitle);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.TextBoxCity);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ListBoxCitys);
            this.Controls.Add(this.LabelCity);
            this.Controls.Add(this.LabelIDText);
            this.Controls.Add(this.LabelID);
            this.Controls.Add(this.PictureBoxCity);
            this.Name = "FormCity";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "טופס ישוב";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.TextBox TextBoxCity;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.ListBox ListBoxCitys;
        private System.Windows.Forms.Label LabelCity;
        private System.Windows.Forms.Label LabelIDText;
        private System.Windows.Forms.Label LabelID;
        private System.Windows.Forms.PictureBox PictureBoxCity;
    }
}