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
using System.Windows.Forms.DataVisualization.Charting;

namespace FinalProject_ManagingEmployees.UI
{
    public partial class FormReport : Form
    {
        Bitmap m_bitmap;
        private int m_LastColumnSortBy = -1;
        private SortOrder m_LastSortOrder = SortOrder.Ascending;
        int countTimerLabel = 0;
        int countTimerPictureBox = 0;

        public FormReport(string userName)
        {
            InitializeComponent();
            LabelUserNameText.Text = userName;
            SerachBusiness(userName);
            this.Text = LabelBusinessNameBusiness.Text + " " + "-" + " " + "דוחות וגרפים";
            WorkerArrToForm(LabelBusinessNameBusiness.Text);
            GroupBox();
            ButtonPrint();
            FillListViewWorkerDetail(userName);
            FillListViewPaymentSalary(userName);
        }

        public void SerachBusiness(string userName)
        {
            string business;
            BusinessArr businessArr = new BusinessArr();
            businessArr.Fill();
            business = businessArr.SearchBusinessName(userName);
            if (business != null)
            {
                LabelBusinessNameBusiness.Text = business;
                LabelBusinessNameWorker.Text = business;
            }       
        }

        private void WorkerArrToForm(string businessName)
        {
            //ממירה את הטנ "מ אוסף הלקוחות לטופס

            WorkerArr workerArr = new WorkerArr();
            WorkerArr workerArrFilter;

            //הוספת לקוח ברירת מחדל - בחר לקוח
            //יצירת מופע חדש של לקוח עם מזהה מינוס 1 ושם מתאים
            Worker workerDefault = new Worker();
            workerDefault.Id = -1;
            workerDefault.LastName = "בחר עובד";

            //הוספת העסק לאוסף לקוחות - אותו נציב במקור הנתונים של תיבת הבחירה
            workerArr.Add(workerDefault);

            workerArr.Fill();
            workerArrFilter = workerArr.Filter(businessName);

            ComboBoxWorkerWorker.DataSource = workerArrFilter;
            ComboBoxWorkerWorker.ValueMember = "Id";
            ComboBoxWorkerWorker.DisplayMember = "";
        }

        private void GroupBox(GroupBox groupBox = null)
        {
            if (groupBox != GroupBoxAmountOfWorkers)
                GroupBoxAmountOfWorkers.Hide();
            if (groupBox != GroupBoxSumSalaryOfWorkers)
                GroupBoxSumSalaryOfWorkers.Hide();
            if (groupBox != GroupBoxAverageSalaryOfWorkers)
                GroupBoxAverageSalaryOfWorkers.Hide();
            if (groupBox != GroupBoxSalaryWorker)
                GroupBoxSalaryWorker.Hide();
            if (groupBox != GroupBoxAmountHoursWorker)
                GroupBoxAmountHoursWorker.Hide();
            if (groupBox != GroupBoxWorkerDetail)
                GroupBoxWorkerDetail.Hide();
            if (groupBox != GroupBoxPaymentSalary)
                GroupBoxPaymentSalary.Hide();
            if (groupBox != null)
                groupBox.Show();
        }

        private void ButtonPrint(Button button = null)
        {
            if (button != ButtonPrintAmountOfWorkers)
                ButtonPrintAmountOfWorkers.Hide();
            if (button != ButtonPrintSumSalaryOfWorkers)
                ButtonPrintSumSalaryOfWorkers.Hide();
            if (button != ButtonPrintAverageSalaryOfWorkers)
                ButtonPrintAverageSalaryOfWorkers.Hide();
            if (button != ButtonPrintSalaryWorker)
                ButtonPrintSalaryWorker.Hide();
            if (button != ButtonPrintAmountHoursWorker)
                ButtonPrintAmountHoursWorker.Hide();
            if (button != ButtonPrintWorkerDetail)
                ButtonPrintWorkerDetail.Hide();
            if (button != ButtonPrintPaymentSalary)
                ButtonPrintPaymentSalary.Hide();
            if (button != null)
                button.Show();
        }

        private void Clear(ListView listview)
        {
            ListViewItem listViewItemRemove;
            for (int i = 0; i < listview.Items.Count;)
            {
                listViewItemRemove = listview.Items[i];
                listview.Items.Remove(listViewItemRemove);
            }
        }

        private void ButtonAmountOfWorkers_Click(object sender, EventArgs e)
        {
            GroupBox(GroupBoxAmountOfWorkers);
            ButtonPrint(ButtonPrintAmountOfWorkers);
            if (!CheckForm(LabelYearBusiness, ComboBoxYearBusiness))
            {
                MessageBox.Show("לא ניתן לייצר דוח, השגיאות מסומנות באדום", "שגיאה", MessageBoxButtons.OK,
                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
            }
            else
            {
                Clear(ListViewAmountOfWorkers);
                FillListViewAmountOfWorkers();
                DataToChartAmountOfWorkers();
            }
        }

        private void ButtonSumSalaryOfWorkers_Click(object sender, EventArgs e)
        {
            GroupBox(GroupBoxSumSalaryOfWorkers);
            ButtonPrint(ButtonPrintSumSalaryOfWorkers);
            if (!CheckForm(LabelYearBusiness, ComboBoxYearBusiness))
            {
                MessageBox.Show("לא ניתן לייצר דוח, השגיאות מסומנות באדום", "שגיאה", MessageBoxButtons.OK,
                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
            }
            else
            {
                Clear(ListViewSumSalaryOfWorkers);
                FillListViewSumSalaryOfWorkers();
                DataToChartSumSalaryOfWorkers();
            }
        }

        private void ButtonAverageSalaryOfWorkers_Click(object sender, EventArgs e)
        {
            GroupBox(GroupBoxAverageSalaryOfWorkers);
            ButtonPrint(ButtonPrintAverageSalaryOfWorkers);
            if (!CheckForm(LabelYearBusiness, ComboBoxYearBusiness))
            {
                MessageBox.Show("לא ניתן לייצר דוח, השגיאות מסומנות באדום", "שגיאה", MessageBoxButtons.OK,
                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
            }
            else
            {
                Clear(ListViewAverageSalaryOfWorkers);
                FillListViewAverageSalaryOfWorkers();
                DataToChartAverageSalaryOfWorkers();
            }
        }

        private void ButtonSalaryWorker_Click(object sender, EventArgs e)
        {
            GroupBox(GroupBoxSalaryWorker);
            ButtonPrint(ButtonPrintSalaryWorker);
            if (!CheckForm(LabelYearWorker, ComboBoxYearWorker, LabelWorkerWorker, ComboBoxWorkerWorker))
            {
                MessageBox.Show("לא ניתן לייצר דוח, השגיאות מסומנות באדום", "שגיאה", MessageBoxButtons.OK,
                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
            }
            else
            {
                Clear(ListViewSalaryWorker);
                FillListViewSalaryWorker();
                DataToChartSalaryWorker();
            }
        }

        private void ButtonAmountHoursWorker_Click(object sender, EventArgs e)
        {
            GroupBox(GroupBoxAmountHoursWorker);
            ButtonPrint(ButtonPrintAmountHoursWorker); 
            if (!CheckForm(LabelYearWorker, ComboBoxYearWorker, LabelWorkerWorker, ComboBoxWorkerWorker))
            {
                MessageBox.Show("לא ניתן לייצר דוח, השגיאות מסומנות באדום", "שגיאה", MessageBoxButtons.OK,
                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
            }
            else
            {
                Clear(ListViewAmountHoursWorker);
                FillListViewAmountHoursWorker();
                DataToChartAmountHoursWorker();
            }
        }

        private void ButtonWorkerDetail_Click(object sender, EventArgs e)
        {
            GroupBox(GroupBoxWorkerDetail);
            ButtonPrint(ButtonPrintWorkerDetail);
        }

        private void ButtonPaymentSalary_Click(object sender, EventArgs e)
        {
            GroupBox(GroupBoxPaymentSalary);
            ButtonPrint(ButtonPrintPaymentSalary);
        }

        private bool CheckForm(Label labelYear, ComboBox comboBoxYear, 
            Label labelWorker = null, ComboBox comboBoxWorker = null)
        {
            bool flag = true;

            if (comboBoxYear.SelectedItem == null)
            {
                flag = false;
                labelYear.ForeColor = Color.Red;
            }
            else
                labelYear.ForeColor = Color.Black;

            if (comboBoxWorker != null)
            {
                if ((int)comboBoxWorker.SelectedValue <= 0)
                {
                    flag = false;
                    labelWorker.ForeColor = Color.Red;
                }
                else
                    labelWorker.ForeColor = Color.Black;
            }         

            return flag;
        }

        private void FillListViewAmountOfWorkers()
        {
            //מוסיף נתונים לפקד תיבת התצוגה
            //יצירת מקור הנתונים

            SalaryArr salaryArr = new SalaryArr();
            salaryArr.Fill();
            Dictionary<string, int> dictionary = salaryArr.GetDictionaryAmountOfWorkers
                (int.Parse(ComboBoxYearBusiness.Text), LabelBusinessNameBusiness.Text);
            ListViewItem listViewItem;

            //מעבר על כל הפריטים במקור הנתונים והוספה שלהם לתיבת התצוגה

            foreach (KeyValuePair<string, int> item in dictionary)
            {

                //יצירת פריט-תיבת-תצוגה
                listViewItem = new ListViewItem(new[] {item.Key, item.Value.ToString()});
                //הוספת פריט-תיבת-תצוגה לתיבת תצוגה

                ListViewAmountOfWorkers.Items.Add(listViewItem);
            }
        }

        private void FillListViewSumSalaryOfWorkers()
        {
            //מוסיף נתונים לפקד תיבת התצוגה
            //יצירת מקור הנתונים

            SalaryArr salaryArr = new SalaryArr();
            salaryArr.Fill();
            Dictionary<string, double> dictionary = salaryArr.GetDictionarySumSalaryOfWorkers
                (int.Parse(ComboBoxYearBusiness.Text), LabelBusinessNameBusiness.Text);
            ListViewItem listViewItem;

            //מעבר על כל הפריטים במקור הנתונים והוספה שלהם לתיבת התצוגה

            foreach (KeyValuePair<string, double> item in dictionary)
            {

                //יצירת פריט-תיבת-תצוגה
                listViewItem = new ListViewItem(new[] { item.Key, item.Value.ToString() });
                //הוספת פריט-תיבת-תצוגה לתיבת תצוגה

                ListViewSumSalaryOfWorkers.Items.Add(listViewItem);
            }
        }

        private void FillListViewAverageSalaryOfWorkers()
        {
            //מוסיף נתונים לפקד תיבת התצוגה
            //יצירת מקור הנתונים

            SalaryArr salaryArr = new SalaryArr();
            salaryArr.Fill();
            Dictionary<string, double> dictionary = salaryArr.GetDictionaryAverageSalaryOfWorkers
                (int.Parse(ComboBoxYearBusiness.Text), LabelBusinessNameBusiness.Text);
            ListViewItem listViewItem;

            //מעבר על כל הפריטים במקור הנתונים והוספה שלהם לתיבת התצוגה

            foreach (KeyValuePair<string, double> item in dictionary)
            {

                //יצירת פריט-תיבת-תצוגה
                listViewItem = new ListViewItem(new[] { item.Key, item.Value.ToString() });
                //הוספת פריט-תיבת-תצוגה לתיבת תצוגה

                ListViewAverageSalaryOfWorkers.Items.Add(listViewItem);
            }
        }

        private void FillListViewSalaryWorker()
        {
            //מוסיף נתונים לפקד תיבת התצוגה
            //יצירת מקור הנתונים

            SalaryArr salaryArr = new SalaryArr();
            salaryArr.Fill();
            Dictionary<string, double> dictionary = salaryArr.GetDictionarySalaryWorker
                (int.Parse(ComboBoxYearWorker.Text), LabelBusinessNameWorker.Text, ComboBoxWorkerWorker.SelectedItem.ToString());
            ListViewItem listViewItem;

            //מעבר על כל הפריטים במקור הנתונים והוספה שלהם לתיבת התצוגה

            foreach (KeyValuePair<string, double> item in dictionary)
            {

                //יצירת פריט-תיבת-תצוגה
                listViewItem = new ListViewItem(new[] { item.Key, item.Value.ToString() });
                //הוספת פריט-תיבת-תצוגה לתיבת תצוגה

                ListViewSalaryWorker.Items.Add(listViewItem);
            }
        }

        private void FillListViewAmountHoursWorker()
        {
            //מוסיף נתונים לפקד תיבת התצוגה
            //יצירת מקור הנתונים

            SalaryArr salaryArr = new SalaryArr();
            salaryArr.Fill();
            Dictionary<string, double> dictionary = salaryArr.GetDictionaryAmountHoursWorker
                (int.Parse(ComboBoxYearWorker.Text), LabelBusinessNameWorker.Text, ComboBoxWorkerWorker.SelectedItem.ToString());
            ListViewItem listViewItem;

            //מעבר על כל הפריטים במקור הנתונים והוספה שלהם לתיבת התצוגה

            foreach (KeyValuePair<string, double> item in dictionary)
            {

                //יצירת פריט-תיבת-תצוגה
                listViewItem = new ListViewItem(new[] { item.Key, item.Value.ToString() });
                //הוספת פריט-תיבת-תצוגה לתיבת תצוגה

                ListViewAmountHoursWorker.Items.Add(listViewItem);
            }
        }

        private void FillListViewWorkerDetail(string userName)
        {

            //מוסיף נתונים לפקד תיבת התצוגה
            //יצירת מקור הנתונים

            WorkerArr workerArr = new WorkerArr();
            workerArr.Fill();
            Worker worker;
            ListViewItem listViewItem;

            //מעבר על כל הפריטים במקור הנתונים והוספה שלהם לתיבת התצוגה

            for (int i = 0; i < workerArr.Count; i++)
            {
                worker = workerArr[i] as Worker;

                if (worker.Business.UserName.UserName == userName)
                {
                    //יצירת פריט-תיבת-תצוגה
                    listViewItem = new ListViewItem(new[] { worker.FirstName, worker.LastName, worker.IdNumber,
                    worker.Bday.ToShortDateString(), worker.PhoneAreaCode + worker.PhoneNumber, worker.Email,
                    worker.AccountNumber.ToString(), worker.Branch.ToString(), worker.Bank.Number.ToString()});

                    //הוספת פריט-תיבת-תצוגה לתיבת תצוגה
                    ListViewWorkerDetail.Items.Add(listViewItem);
                }            
            }
        }

        private void FillListViewPaymentSalary(string userName)
        {

            //מוסיף נתונים לפקד תיבת התצוגה
            //יצירת מקור הנתונים

            WorkerArr workerArr = new WorkerArr();
            workerArr.Fill();
            Worker worker;
            ListViewItem listViewItem;
            string replace0 = "";

            //מעבר על כל הפריטים במקור הנתונים והוספה שלהם לתיבת התצוגה

            for (int i = 0; i < workerArr.Count; i++)
            {
                worker = workerArr[i] as Worker;

                if (worker.Business.UserName.UserName == userName)
                {
                    if (worker.MonthlyPayment == 0)
                        //יצירת פריט-תיבת-תצוגה
                        listViewItem = new ListViewItem(new[] { worker.FirstName + " " + worker.LastName,
                        replace0, worker.HourlyPayment.ToString()});
                    else
                        //יצירת פריט-תיבת-תצוגה
                        listViewItem = new ListViewItem(new[] { worker.FirstName + " " + worker.LastName,
                        worker.MonthlyPayment.ToString(), replace0});

                    //הוספת פריט-תיבת-תצוגה לתיבת תצוגה
                    ListViewPaymentSalary.Items.Add(listViewItem);
                }
            }
        }

        public void DataToChartAmountOfWorkers()
        {
           // (פלטת הצבעים -אפשר גם להגדיר מראש במאפיינים (לא בקוד
           ChartAmountOfWorkers.Palette = ChartColorPalette.SeaGreen;

           // מחייב הצגת כל הערכים בציר האיקס, אם רוצים שיוצגו לסירוגין רושמים 2
            ChartAmountOfWorkers.ChartAreas[0].AxisX.LabelStyle.Interval = 1;

            // כותרת הגרף -1
            ChartAmountOfWorkers.Titles.Clear();
            ChartAmountOfWorkers.Titles.Add("כמות עובדים בכל חודש לעסק " + 
                LabelBusinessNameBusiness.Text + " בשנת " + ComboBoxYearBusiness.Text);

            // הוספת הערכים למשתנה מסוג מילון ממוין
            SalaryArr curSalaryArr = new SalaryArr();
            curSalaryArr.Fill();
            Dictionary<string, int> dictionary = curSalaryArr.GetDictionaryAmountOfWorkers
                (int.Parse(ComboBoxYearBusiness.Text), LabelBusinessNameBusiness.Text);

            //הגדרת סדרה וערכיה - שם הסדרה מועבר למקרא - 2

            Series series = new Series("כמות עובדים בכל חודש");

            //סוג הגרף

            series.ChartType = SeriesChartType.Column;

            //המידע שיוצג לכל רכיב ערך בגרף - 3

            //שם - VALX# 
            //הערך - VAL#
            // אחוז עם אפס אחרי הנקודה- #Precent{P0}
            //series.Label = "#VALX [#VAL = #PERCENT{P0}]";

            //הוספת הערכים מתוך משתנה המילון לסדרה
            series.Points.DataBindXY(dictionary.Keys, dictionary.Values);

            //מחיקת סדרות קיימות - אם יש ולא בכוונה
            ChartAmountOfWorkers.Series.Clear();

            //הוספת הסדרה לפקד הגרף
            ChartAmountOfWorkers.Series.Add(series);
        }

        public void DataToChartSumSalaryOfWorkers()
        {
            // (פלטת הצבעים -אפשר גם להגדיר מראש במאפיינים (לא בקוד
            ChartSumSalaryOfWorkers.Palette = ChartColorPalette.SeaGreen;

            // מחייב הצגת כל הערכים בציר האיקס, אם רוצים שיוצגו לסירוגין רושמים 2
            ChartSumSalaryOfWorkers.ChartAreas[0].AxisX.LabelStyle.Interval = 1;

            // כותרת הגרף -1
            ChartSumSalaryOfWorkers.Titles.Clear();
            ChartSumSalaryOfWorkers.Titles.Add("כמות הוצאות בגין משכורות בכל חודש לעסק " +
                LabelBusinessNameBusiness.Text + " בשנת " + ComboBoxYearBusiness.Text);

            // הוספת הערכים למשתנה מסוג מילון ממוין
            SalaryArr curSalaryArr = new SalaryArr();
            curSalaryArr.Fill();
            Dictionary<string, double> dictionary = curSalaryArr.GetDictionarySumSalaryOfWorkers
                (int.Parse(ComboBoxYearBusiness.Text), LabelBusinessNameBusiness.Text);

            //הגדרת סדרה וערכיה - שם הסדרה מועבר למקרא - 2

            Series series = new Series("כמות עובדים בכל חודש");

            //סוג הגרף

            series.ChartType = SeriesChartType.Column;

            //המידע שיוצג לכל רכיב ערך בגרף - 3

            //שם - VALX# 
            //הערך - VAL#
            // אחוז עם אפס אחרי הנקודה- #Precent{P0}
            //series.Label = "#VALX [#VAL = #PERCENT{P0}]";

            //הוספת הערכים מתוך משתנה המילון לסדרה
            series.Points.DataBindXY(dictionary.Keys, dictionary.Values);

            //מחיקת סדרות קיימות - אם יש ולא בכוונה
            ChartSumSalaryOfWorkers.Series.Clear();

            //הוספת הסדרה לפקד הגרף
            ChartSumSalaryOfWorkers.Series.Add(series);
        }

        public void DataToChartAverageSalaryOfWorkers()
        {
            // (פלטת הצבעים -אפשר גם להגדיר מראש במאפיינים (לא בקוד
            ChartAverageSalaryOfWorkers.Palette = ChartColorPalette.SeaGreen;

            // מחייב הצגת כל הערכים בציר האיקס, אם רוצים שיוצגו לסירוגין רושמים 2
            ChartAverageSalaryOfWorkers.ChartAreas[0].AxisX.LabelStyle.Interval = 1;

            // כותרת הגרף -1
            ChartAverageSalaryOfWorkers.Titles.Clear();
            ChartAverageSalaryOfWorkers.Titles.Add("ממוצע משכורות בכל חודש לעסק " +
                LabelBusinessNameBusiness.Text + " בשנת " + ComboBoxYearBusiness.Text);

            // הוספת הערכים למשתנה מסוג מילון ממוין
            SalaryArr curSalaryArr = new SalaryArr();
            curSalaryArr.Fill();
            Dictionary<string, double> dictionary = curSalaryArr.GetDictionaryAverageSalaryOfWorkers
                (int.Parse(ComboBoxYearBusiness.Text), LabelBusinessNameBusiness.Text);

            //הגדרת סדרה וערכיה - שם הסדרה מועבר למקרא - 2

            Series series = new Series("כמות עובדים בכל חודש");

            //סוג הגרף

            series.ChartType = SeriesChartType.Column;

            //המידע שיוצג לכל רכיב ערך בגרף - 3

            //שם - VALX# 
            //הערך - VAL#
            // אחוז עם אפס אחרי הנקודה- #Precent{P0}
            //series.Label = "#VALX [#VAL = #PERCENT{P0}]";

            //הוספת הערכים מתוך משתנה המילון לסדרה
            series.Points.DataBindXY(dictionary.Keys, dictionary.Values);

            //מחיקת סדרות קיימות - אם יש ולא בכוונה
            ChartAverageSalaryOfWorkers.Series.Clear();

            //הוספת הסדרה לפקד הגרף
            ChartAverageSalaryOfWorkers.Series.Add(series);
        }

        public void DataToChartSalaryWorker()
        {
            // (פלטת הצבעים -אפשר גם להגדיר מראש במאפיינים (לא בקוד
            ChartSalaryWorker.Palette = ChartColorPalette.SeaGreen;

            // מחייב הצגת כל הערכים בציר האיקס, אם רוצים שיוצגו לסירוגין רושמים 2
            ChartSalaryWorker.ChartAreas[0].AxisX.LabelStyle.Interval = 1;

            // כותרת הגרף -1
            ChartSalaryWorker.Titles.Clear();
            ChartSalaryWorker.Titles.Add("משכורת של עובד/ת " + ComboBoxYearWorker.SelectedItem + " בעסק " +
                LabelBusinessNameWorker.Text + " בשנת " + ComboBoxYearWorker.Text);

            // הוספת הערכים למשתנה מסוג מילון ממוין
            SalaryArr curSalaryArr = new SalaryArr();
            curSalaryArr.Fill();
            Dictionary<string, double> dictionary = curSalaryArr.GetDictionarySalaryWorker
                (int.Parse(ComboBoxYearWorker.Text), LabelBusinessNameWorker.Text, ComboBoxWorkerWorker.SelectedItem.ToString());

            //הגדרת סדרה וערכיה - שם הסדרה מועבר למקרא - 2

            Series series = new Series("משכורת של עובד");

            //סוג הגרף

            series.ChartType = SeriesChartType.Column;

            //המידע שיוצג לכל רכיב ערך בגרף - 3

            //שם - VALX# 
            //הערך - VAL#
            // אחוז עם אפס אחרי הנקודה- #Precent{P0}
            //series.Label = "#VALX [#VAL = #PERCENT{P0}]";

            //הוספת הערכים מתוך משתנה המילון לסדרה
            series.Points.DataBindXY(dictionary.Keys, dictionary.Values);

            //מחיקת סדרות קיימות - אם יש ולא בכוונה
            ChartSalaryWorker.Series.Clear();

            //הוספת הסדרה לפקד הגרף
            ChartSalaryWorker.Series.Add(series);
        }

        public void DataToChartAmountHoursWorker()
        {
            // (פלטת הצבעים -אפשר גם להגדיר מראש במאפיינים (לא בקוד
            ChartAmountHoursWorker.Palette = ChartColorPalette.SeaGreen;

            // מחייב הצגת כל הערכים בציר האיקס, אם רוצים שיוצגו לסירוגין רושמים 2
            ChartAmountHoursWorker.ChartAreas[0].AxisX.LabelStyle.Interval = 1;

            // כותרת הגרף -1
            ChartAmountHoursWorker.Titles.Clear();
            ChartAmountHoursWorker.Titles.Add("כמות שעות העבודה של העובד " +
                ComboBoxWorkerWorker.SelectedItem + " בעסק " + LabelBusinessNameWorker.Text + " בשנת " +
                ComboBoxYearWorker.Text);

            // הוספת הערכים למשתנה מסוג מילון ממוין
            SalaryArr curSalaryArr = new SalaryArr();
            curSalaryArr.Fill();
            Dictionary<string, double> dictionary = curSalaryArr.GetDictionaryAmountHoursWorker
                (int.Parse(ComboBoxYearWorker.Text), LabelBusinessNameWorker.Text, ComboBoxWorkerWorker.SelectedItem.ToString());

            //הגדרת סדרה וערכיה - שם הסדרה מועבר למקרא - 2

            Series series = new Series("כמות עובדים בכל חודש");

            //סוג הגרף

            series.ChartType = SeriesChartType.Column;

            //המידע שיוצג לכל רכיב ערך בגרף - 3

            //שם - VALX# 
            //הערך - VAL#
            // אחוז עם אפס אחרי הנקודה- #Precent{P0}
            //series.Label = "#VALX [#VAL = #PERCENT{P0}]";

            //הוספת הערכים מתוך משתנה המילון לסדרה
            series.Points.DataBindXY(dictionary.Keys, dictionary.Values);

            //מחיקת סדרות קיימות - אם יש ולא בכוונה
            ChartAmountHoursWorker.Series.Clear();

            //הוספת הסדרה לפקד הגרף
            ChartAmountHoursWorker.Series.Add(series);
        }

        private void ListViewColumnClick(ListView listView, ColumnClickEventArgs e)
        {
            ListViewSorter sorter = new ListViewSorter();
            listView.ListViewItemSorter = sorter;

            sorter = listView.ListViewItemSorter as ListViewSorter;
            sorter.ByColumn = e.Column;

            // אם לחצו שוב על אותה עמודה - המיון יהיה בסדר הפוך לקודם

            if (m_LastColumnSortBy == e.Column)
                if (m_LastSortOrder == SortOrder.Ascending)
                    sorter.SortOrder = SortOrder.Descending;
                else
                    sorter.SortOrder = SortOrder.Ascending;

            // אחרת - זוהי עמודה חדשה - המיון יהיה בסדר עולה

            else
                sorter.SortOrder = SortOrder.Ascending;
            listView.Sort();

            // שומרים את העמודה הנוכחית כאחרונה שלפיה היה המיון

            m_LastColumnSortBy = e.Column;

            // שומרים את סדר המיון האחרון

            m_LastSortOrder = sorter.SortOrder;
        }

        private void listViewAmountOfWorkers_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ListViewColumnClick(ListViewAmountOfWorkers, e);
        }                            

        private void listViewSumSalaryOfWorkers_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ListViewColumnClick(ListViewSumSalaryOfWorkers, e);
        }

        private void listViewAverageSalaryOfWorkers_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ListViewColumnClick(ListViewAverageSalaryOfWorkers, e);
        }

        private void listViewSalaryWorker_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ListViewColumnClick(ListViewSalaryWorker, e);
        }

        private void listViewAmountHoursWorker_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ListViewColumnClick(ListViewAmountHoursWorker, e);  
        }

        private void listViewWorkerDetail_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ListViewColumnClick(ListViewWorkerDetail, e);
        }

        private void listViewPaymentSalary_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ListViewColumnClick(ListViewPaymentSalary, e);
        }

        private void printDocumentV1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //מגדיר את העמוד שיודפס - כולל מרחק מהשמאל ומלמעלה

            e.Graphics.DrawImage(m_bitmap, 30, 30);
        }

        private void printDocumentV2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //מגדיר את העמוד שיודפס - כולל מרחק מהשמאל ומלמעלה

            e.Graphics.DrawImage(m_bitmap, 170, 20);
        }

        private void printDocumentV3_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //מגדיר את העמוד שיודפס - כולל מרחק מהשמאל ומלמעלה

            e.Graphics.DrawImage(m_bitmap, 20, 30);
        }

        private void printDocumentV4_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //מגדיר את העמוד שיודפס - כולל מרחק מהשמאל ומלמעלה

            e.Graphics.DrawImage(m_bitmap, 15, 30);
        }

        private void CaptureScreen(GroupBox groupBox)
        {
            //תפיסת החלק של הטופס להדפסה כולל הרשימה והכותרת שמעליה - לתוך תמונת ה 
            int addAboveListView = -50;
            int moveLeft = -20;
            Graphics graphics = groupBox.CreateGraphics();
            Size curSize = groupBox.Size;
            curSize.Height += addAboveListView;
            curSize.Width += moveLeft;
            m_bitmap = new Bitmap(curSize.Width, curSize.Height, graphics);
            graphics = Graphics.FromImage(m_bitmap);
            Point panelLocation = PointToScreen(groupBox.Location);
            graphics.CopyFromScreen(panelLocation.X, panelLocation.Y - addAboveListView,
            moveLeft, 0, curSize);
        }

        private void ButtonPrintAmountOfWorkers_Click(object sender, EventArgs e)
        {
            CaptureScreen(GroupBoxAmountOfWorkers);

            printPreviewDialog1.Document = printDocumentV1;
            printPreviewDialog1.ShowDialog();
        }

        private void ButtonPrintSumSalaryOfWorkers_Click(object sender, EventArgs e)
        {
            CaptureScreen(GroupBoxSumSalaryOfWorkers);

            printPreviewDialog1.Document = printDocumentV1;
            printPreviewDialog1.ShowDialog();
        }

        private void ButtonPrintAverageSalaryOfWorkers_Click(object sender, EventArgs e)
        {
            CaptureScreen(GroupBoxAverageSalaryOfWorkers);

            printPreviewDialog1.Document = printDocumentV3;
            printPreviewDialog1.ShowDialog();
        }

        private void ButtonPrintSalaryWorker_Click(object sender, EventArgs e)
        {
            CaptureScreen(GroupBoxSalaryWorker);

            printPreviewDialog1.Document = printDocumentV1;
            printPreviewDialog1.ShowDialog();
        }

        private void ButtonPrintAmountHoursWorker_Click(object sender, EventArgs e)
        {
            CaptureScreen(GroupBoxAmountHoursWorker);

            printPreviewDialog1.Document = printDocumentV4;
            printPreviewDialog1.ShowDialog();
        }

        private void ButtonPrintWorkerDetail_Click(object sender, EventArgs e)
        {
            CaptureScreen(GroupBoxWorkerDetail);

            printPreviewDialog1.Document = printDocumentV4;
            printPreviewDialog1.ShowDialog();
        }

        private void ButtonPrintPaymentSalary_Click(object sender, EventArgs e)
        {
            CaptureScreen(GroupBoxPaymentSalary);

            printPreviewDialog1.Document = printDocumentV2;
            printPreviewDialog1.ShowDialog();
        }

        private void ButtonBeginning_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormBeginning formBeginning = new FormBeginning(LabelUserNameText.Text);
            formBeginning.ShowDialog();
        }

        private void TimerLabelTitle_Tick(object sender, EventArgs e)
        {
            countTimerLabel++;
            if (countTimerLabel <= 5)
            {
                Random rnd = new Random();
                switch (rnd.Next(1, 6))
                {
                    case 1:
                        LabelTitle.ForeColor = Color.Gray;
                        break;
                    case 2:
                        LabelTitle.ForeColor = Color.LightSlateGray;
                        break;
                    case 3:
                        LabelTitle.ForeColor = Color.Chocolate;
                        break;
                    case 4:
                        LabelTitle.ForeColor = Color.Honeydew;
                        break;
                    case 5:
                        LabelTitle.ForeColor = Color.Sienna;
                        break;
                }
            }                  
        }

        private void TimerPictureBox_Tick(object sender, EventArgs e)
        {
            countTimerPictureBox++;
            if (countTimerPictureBox <= 5)
            {
                if (PictureBoxBackground.Size.Height < 512)
                {
                    PictureBoxBackground.Height += 20;
                }
                else if (PictureBoxBackground.Size.Height == 512)
                {
                    PictureBoxBackground.Height = 412;
                }
            }           
        }
    }
}
