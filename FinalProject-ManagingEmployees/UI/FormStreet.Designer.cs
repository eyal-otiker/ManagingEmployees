namespace FinalProject_ManagingEmployees.UI
{
    partial class FormStreet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStreet));
            this.LabelTitle = new System.Windows.Forms.Label();
            this.TextBoxStreet = new System.Windows.Forms.TextBox();
            this.ListBoxStreets = new System.Windows.Forms.ListBox();
            this.LabelStreet = new System.Windows.Forms.Label();
            this.LabelIDText = new System.Windows.Forms.Label();
            this.LabelID = new System.Windows.Forms.Label();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.PictureBoxLongestStreet = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLongestStreet)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LabelTitle.Location = new System.Drawing.Point(399, 9);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(148, 37);
            this.LabelTitle.TabIndex = 72;
            this.LabelTitle.Text = "טופס רחוב";
            // 
            // TextBoxStreet
            // 
            this.TextBoxStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TextBoxStreet.Location = new System.Drawing.Point(611, 176);
            this.TextBoxStreet.Name = "TextBoxStreet";
            this.TextBoxStreet.Size = new System.Drawing.Size(165, 39);
            this.TextBoxStreet.TabIndex = 71;
            this.TextBoxStreet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxIsHebrewLetter_KeyPress);
            // 
            // ListBoxStreets
            // 
            this.ListBoxStreets.BackColor = System.Drawing.Color.White;
            this.ListBoxStreets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ListBoxStreets.FormattingEnabled = true;
            this.ListBoxStreets.ItemHeight = 29;
            this.ListBoxStreets.Location = new System.Drawing.Point(12, 79);
            this.ListBoxStreets.Name = "ListBoxStreets";
            this.ListBoxStreets.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ListBoxStreets.Size = new System.Drawing.Size(220, 584);
            this.ListBoxStreets.TabIndex = 70;
            this.ListBoxStreets.DoubleClick += new System.EventHandler(this.ListBoxStreets_DoubleClick);
            // 
            // LabelStreet
            // 
            this.LabelStreet.AutoSize = true;
            this.LabelStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LabelStreet.Location = new System.Drawing.Point(797, 176);
            this.LabelStreet.Name = "LabelStreet";
            this.LabelStreet.Size = new System.Drawing.Size(121, 32);
            this.LabelStreet.TabIndex = 69;
            this.LabelStreet.Text = "שם רחוב";
            // 
            // LabelIDText
            // 
            this.LabelIDText.AutoSize = true;
            this.LabelIDText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LabelIDText.Location = new System.Drawing.Point(713, 102);
            this.LabelIDText.Name = "LabelIDText";
            this.LabelIDText.Size = new System.Drawing.Size(31, 32);
            this.LabelIDText.TabIndex = 68;
            this.LabelIDText.Text = "0";
            // 
            // LabelID
            // 
            this.LabelID.AutoSize = true;
            this.LabelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LabelID.Location = new System.Drawing.Point(770, 102);
            this.LabelID.Name = "LabelID";
            this.LabelID.Size = new System.Drawing.Size(148, 32);
            this.LabelID.TabIndex = 67;
            this.LabelID.Text = "מזהה רחוב";
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ButtonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ButtonDelete.Location = new System.Drawing.Point(164, 688);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(180, 83);
            this.ButtonDelete.TabIndex = 75;
            this.ButtonDelete.Text = "מחיקה";
            this.ButtonDelete.UseVisualStyleBackColor = false;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonClear
            // 
            this.ButtonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ButtonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ButtonClear.Location = new System.Drawing.Point(367, 688);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(180, 83);
            this.ButtonClear.TabIndex = 74;
            this.ButtonClear.Text = "נקה";
            this.ButtonClear.UseVisualStyleBackColor = false;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ButtonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ButtonSave.Location = new System.Drawing.Point(570, 688);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(180, 83);
            this.ButtonSave.TabIndex = 73;
            this.ButtonSave.Text = "שמירה";
            this.ButtonSave.UseVisualStyleBackColor = false;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // PictureBoxLongestStreet
            // 
            this.PictureBoxLongestStreet.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxLongestStreet.Image")));
            this.PictureBoxLongestStreet.Location = new System.Drawing.Point(-4, -3);
            this.PictureBoxLongestStreet.Name = "PictureBoxLongestStreet";
            this.PictureBoxLongestStreet.Size = new System.Drawing.Size(948, 800);
            this.PictureBoxLongestStreet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxLongestStreet.TabIndex = 76;
            this.PictureBoxLongestStreet.TabStop = false;
            // 
            // FormStreet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 783);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.LabelTitle);
            this.Controls.Add(this.TextBoxStreet);
            this.Controls.Add(this.ListBoxStreets);
            this.Controls.Add(this.LabelStreet);
            this.Controls.Add(this.LabelIDText);
            this.Controls.Add(this.LabelID);
            this.Controls.Add(this.PictureBoxLongestStreet);
            this.Name = "FormStreet";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "טופס רחוב";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLongestStreet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.TextBox TextBoxStreet;
        private System.Windows.Forms.ListBox ListBoxStreets;
        private System.Windows.Forms.Label LabelStreet;
        private System.Windows.Forms.Label LabelIDText;
        private System.Windows.Forms.Label LabelID;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.PictureBox PictureBoxLongestStreet;
    }
}