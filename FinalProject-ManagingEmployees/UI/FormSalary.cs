using FinalProject_ManagingEmployees.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_ManagingEmployees.UI
{
    public partial class FormSalary : Form
    {
        private Bitmap m_bitmap;

        public FormSalary(string userName)
        {
            InitializeComponent();
            LabelUserNameText.Text = userName;
            LabelBusinessName.Text = FindBusinessName(userName);
            this.Text = LabelBusinessName.Text + " " + "-" + " " + "טופס משכורות";
            SalaryArrToForm(LabelBusinessName.Text);
            ListBoxSalary.SelectedIndex = -1;
            IncomeArrToForm(ListBoxPotentialIncomes);
            FormSalary_InputLanguageChanged(null, null);
            if (DateTime.Today.Day >= 25)
            {
                ComboBoxMonth.Text = (DateTime.Today.Month + 1).ToString() + "," + 
                    CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(DateTime.Today.Month + 1); 
                ComboBoxMonthFilter.Text = (DateTime.Today.Month + 1).ToString() + "," +
                    CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(DateTime.Today.Month + 1);
            }
            else
            {
                ComboBoxMonth.Text = (DateTime.Today.Month).ToString() + "," +
                    CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(DateTime.Today.Month);
                ComboBoxMonthFilter.Text = (DateTime.Today.Month).ToString() + "," +
                    CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(DateTime.Today.Month);
            }

            if (DateTime.Today.Day >= 25 && DateTime.Today.Month == 12)
            {
                ComboBoxYear.Text = (DateTime.Today.Year + 1).ToString();
                ComboBoxYearFilter.Text = (DateTime.Today.Year + 1).ToString();
            }
            else
            {
                ComboBoxYear.Text = (DateTime.Today.Year).ToString();
                ComboBoxYearFilter.Text = (DateTime.Today.Year).ToString();
            }
            RadionButtonPriceTax.Checked = true;
            RadionButtonPricePension.Checked = true;
            RadionButtonNotPaid.Checked = true;
            LabelIncomeTaxPrecent.Hide();
            LabelNationalInsurancePrecent.Hide();
            LabelHealthInsurancePrecent.Hide();
            LabelPensionPaymentPrecent.Hide();
            LabelAdvancedStudyFundPrecent.Hide();
            LabelIsPaidText.Text = "לא שולם";
        }

        private string FindBusinessName(string userName)
        {
            string business;
            BusinessArr businessArr = new BusinessArr();
            businessArr.Fill();
            business = businessArr.SearchBusinessName(userName);
            return business;
        }

        private void SalaryArrToForm(string business)
        {
            // החזרת כל העובדים באותו העסק
            WorkerArr workerArr = new WorkerArr();
            workerArr.Fill();
            WorkerArr workerArrFilter;
            workerArrFilter = workerArr.Filter(business);

            //ממירה את הטנ "מ אוסף תלושי המשכורת לטופס
            SalaryArr salaryArr = new SalaryArr();
            salaryArr.Fill();

            int[] year = new int[ComboBoxYear.Items.Count];
            int NumYear = 2015;
            for (int i = 0; i < ComboBoxYear.Items.Count; i++)
            {
                year[i] = NumYear;
                NumYear++;
            }

            salaryArr = salaryArr.Filter(workerArrFilter, year);
            ListBoxSalary.DataSource = salaryArr;
        }

        private void IncomeArrToForm(ListBox listBox, IncomeArr incomeArr = null)
        {

            //מקבלת אוסף הכנסות נוספות ותיבת רשימה להכנסות נוספות ומציבה את האוסף בתוך התיבה
            //אם האוסף ריק - מייצרת אוסף חדש מלא בכל הערכים מהטבלה

            listBox.DataSource = null;
            if (incomeArr == null)
            {
                incomeArr = new IncomeArr();
                incomeArr.Fill();
            }
            listBox.DataSource = incomeArr;
        }

        private void IncomeArrPriceToForm(SalaryIncomeArr curSalaryIncomeArr)
        {
            ListBoxInSalaryIncomesPrice.Items.Clear();
            if (curSalaryIncomeArr != null)
            {
                double sum = 0;
                for (int i = 0; i < curSalaryIncomeArr.Count; i++)
                {
                    ListBoxInSalaryIncomesPrice.Items.Add(
                    (curSalaryIncomeArr[i] as SalaryIncome).Price);
                    sum += (curSalaryIncomeArr[i] as SalaryIncome).Price;
                }
                LabelNumSumIncome.Text = sum.ToString() + "₪";
                LabelNumIncome.Text = sum.ToString() + "₪";
                CalculateData(sum);
            }

            //כדי לסמן את השורה הראשונה ישר בהתחלה) אם יש כזאת)

            if (ListBoxInSalaryIncomesPrice.Items.Count > 0)
                ListBoxInSalaryIncomesPrice.SelectedIndex = 0;
        }

        private SalaryIncomeArr FormToSalaryIncomeArr(Salary curSalary)
        {

            //יצירת אוסף ההכנסות לתלוש משכורת מהטופס
            //מייצרים זוגות של תלוש משכורת-הכנסה, תלוש המשכורת - תמיד אותו תלוש משכורת (הרי מדובר על תלוש משכורת אחד), ההכנסה - מגיע מרשימת ההכנסות שנבחרו
            SalaryIncomeArr salaryIncomeArr = new SalaryIncomeArr();
            //יצירת אוסף הזוגות תלוש משכורת-הכנסה
            SalaryIncome salaryIncome;

            //סורקים את כל הערכים בתיבת הרשימה של ההכנסות שנבחרו לתלוש משכורת
            for (int i = 0; i < ListBoxInSalaryIncomes.Items.Count; i++)
            {
                salaryIncome = new SalaryIncome();

                //התלוש משכורת הנוכחי הוא התלוש משכורת לכל הזוגות באוסף

                salaryIncome.Salary = curSalary;

                //מוצר נוכחי לזוג תלוש משכורת-הכנסה

                salaryIncome.Income = ListBoxInSalaryIncomes.Items[i] as Income;

                //כמות מוצר נוכחי לזוג תלוש משכורת-הכנסה

                salaryIncome.Price = (double)ListBoxInSalaryIncomesPrice.Items[i];

                //הוספת הזוג תלוש משכורת-הכנסה לאוסף

                salaryIncomeArr.Add(salaryIncome);
            }
            return salaryIncomeArr;
        }

        private Salary FormToSalary()
        {
            Salary salary = new Salary();
            WorkerArr workerArr = new WorkerArr();
            Worker worker;
            workerArr.Fill();
            worker = workerArr.FilterWorker(LabelWorkerName.Text);

            salary.Id = int.Parse(LabelIDTextBasicDetails.Text);
            if (ComboBoxMonth.SelectedItem != null)
                salary.Month = ComboBoxMonth.Text;
            if (ComboBoxYear.SelectedItem != null)
                salary.Year = int.Parse(ComboBoxYear.Text);
            salary.Worker = worker;
            if (TextBoxAmountHours100.Text.Length != 0)
                salary.AmountHours100 = double.Parse(TextBoxAmountHours100.Text);
            if (TextBoxAmountHours125.Text.Length != 0)
                salary.AmountHours125 = double.Parse(TextBoxAmountHours125.Text);
            if (TextBoxAmountHours150.Text.Length != 0)
                salary.AmountHours150 = double.Parse(TextBoxAmountHours150.Text);
            if (RadionButtonPriceTax.Checked == true)
            {
                salary.IncomeTax = double.Parse(TextBoxPriceIncomeTax.Text);
                salary.NationalInsurance = double.Parse(TextBoxPriceNationalInsurance.Text);
                salary.HealthInsurance = double.Parse(TextBoxPriceHealthInsurance.Text);
            }
            else
            {
                salary.IncomeTax = double.Parse(LabelPriceIncomeTaxText.Text.Replace("₪", ""));
                salary.NationalInsurance = double.Parse(LabelPriceNationalInsuranceText.Text.Replace("₪", ""));
                salary.HealthInsurance = double.Parse(LabelPriceHealthInsuranceText.Text.Replace("₪", ""));
            }

            if (RadionButtonPricePension.Checked == true)
            {
                salary.PensionPayment = double.Parse(TextBoxPricePensionPayment.Text);
                salary.AdvancedStudyFund = double.Parse(TextBoxPriceAdvancedStudyFund.Text);
            }
            else
            {
                salary.PensionPayment = double.Parse(LabelPricePensionPaymentText.Text.Replace("₪", ""));
                salary.AdvancedStudyFund = double.Parse(LabelPriceAdvancedStudyFundText.Text.Replace("₪", ""));
            }

            if (LabelIsPaidText.Text == "שולם")
                salary.IsPaid = 1;
            else if (LabelIsPaidText.Text == "לא שולם")
                salary.IsPaid = 0;

            if (LabelNumBruto.Text != "")
                salary.SumGross = double.Parse(LabelNumBruto.Text.Replace("₪", ""));
            if (LabelNumNeto.Text != "")
                salary.SumNet = double.Parse(LabelNumNeto.Text.Replace("₪", ""));

            return salary;
        }

        private void SalaryToForm(Salary salary)
        {
            if (salary != null)
            {
                LabelIDTextBasicDetails.Text = salary.Id.ToString();
                ComboBoxMonth.Text = salary.Month.ToString();
                ComboBoxYear.Text = salary.Year.ToString();
                LabelWorkerName.Text = salary.Worker.LastName + " " + salary.Worker.FirstName;             

                if (salary.AmountHours100 != 0)
                    TextBoxAmountHours100.Text = salary.AmountHours100.ToString();
                else
                {
                    TextBoxAmountHours100.Text = "";
                    LabelSum100.Text = "0";
                }                    

                if (salary.AmountHours125 != 0)
                    TextBoxAmountHours125.Text = salary.AmountHours125.ToString();
                else
                {
                    TextBoxAmountHours125.Text = "";
                    LabelSum125.Text = "0";
                }                   

                if (salary.AmountHours150 != 0)
                    TextBoxAmountHours150.Text = salary.AmountHours150.ToString();
                else
                {
                    TextBoxAmountHours150.Text = "";
                    LabelSum150.Text = "0";
                }

                TextBoxPriceIncomeTax.Text = salary.IncomeTax.ToString();
                TextBoxPriceNationalInsurance.Text = salary.NationalInsurance.ToString();
                TextBoxPriceHealthInsurance.Text = salary.HealthInsurance.ToString();

                LabelPriceIncomeTaxText.Text = salary.IncomeTax.ToString();
                LabelPriceNationalInsuranceText.Text = salary.NationalInsurance.ToString();
                LabelPriceHealthInsuranceText.Text = salary.HealthInsurance.ToString();

                TextBoxPricePensionPayment.Text = salary.PensionPayment.ToString();
                TextBoxPriceAdvancedStudyFund.Text = salary.AdvancedStudyFund.ToString();

                LabelPricePensionPaymentText.Text = salary.PensionPayment.ToString();
                LabelPriceAdvancedStudyFundText.Text = salary.AdvancedStudyFund.ToString();

                if (salary.IsPaid == 0 || salary.IsPaid == 2)
                {
                    RadionButtonNotPaid.Checked = true;
                    LabelIsPaidText.Text = "לא שולם";
                }
                else
                {
                    RadionButtonPaid.Checked = true;
                    LabelIsPaidText.Text = "שולם";
                }
            }
            else
            {
                LabelIDTextBasicDetails.Text = "0";
                if (DateTime.Today.Day >= 25)
                    ComboBoxMonth.SelectedItem = DateTime.Today.Month;
                ComboBoxYear.SelectedItem = DateTime.Today.Year;
                LabelWorkerName.Text = "טרם נבחר";
                LabelMonthlyPaymentText.Text = "";
                LabelHourlyRateText.Text = "";
                RadionButtonNotPaid.Checked = true;
                LabelIsPaidText.Text = "לא שולם";
                TextBoxAmountHours100.Text = "";
                LabelSum100.Text = "0";
                TextBoxAmountHours125.Text = "";
                LabelSum125.Text = "0";
                TextBoxAmountHours150.Text = "";
                LabelSum150.Text = "0";
                LabelNumSumJobPayment.Text = "0";
                LabelSumPaymentsShow.Text = "0";
                TextBoxIncomePrice.Text = "";
                LabelNumSumIncome.Text = "0";
                TextBoxPriceIncomeTax.Text = "";
                TextBoxPriceNationalInsurance.Text = "";
                TextBoxPriceHealthInsurance.Text = "";
                TextBoxPrecentIncomeTax.Text = "";
                TextBoxPrecentNationalInsurance.Text = "";
                TextBoxPrecentHealthInsurance.Text = "";
                LabelPriceIncomeTaxText.Text = "0";
                LabelPriceNationalInsuranceText.Text = "0";
                LabelPriceHealthInsuranceText.Text = "0";
                LabelPrecentIncomeTaxText.Text = "";
                LabelPrecentNationalInsuranceText.Text = "";
                LabelPrecentHealthInsuranceText.Text = "";
                LabelNumSumTax.Text = "0";
                TextBoxPricePensionPayment.Text = "";
                TextBoxPriceAdvancedStudyFund.Text = "";
                TextBoxPrecentPensionPayment.Text = "";
                TextBoxPrecentAdvancedStudyFund.Text = "";
                LabelPricePensionPaymentText.Text = "0";
                LabelPriceAdvancedStudyFundText.Text = "0";
                LabelPrecentPensionPaymentText.Text = "";
                LabelPrecentAdvancedStudyFundText.Text = "";
                LabelNumSumPension.Text = "0";
                LabelNumJobPayment.Text = "0";
                LabelNumIncome.Text = "0";
                LabelNumIncomeTax.Text = "0";
                LabelNumNationalInsurance.Text = "0";
                LabelNumHealthInsurance.Text = "0";
                LabelNumPensionPayment.Text = "0";
                LabelNumAdvancedStudyFund.Text = "0";
                LabelNumBruto.Text = "0";
                LabelNumNeto.Text = "0";
                TextBoxIdSalaryFilter.Text = "";
                if (DateTime.Today.Day >= 25)
                    ComboBoxMonthFilter.SelectedItem = DateTime.Today.Month;
                ComboBoxYearFilter.SelectedItem = DateTime.Today.Year;
                TextBoxIdWorkerFilter.Text = "";
                TextBoxLastNameFilter.Text = "";
                TextBoxPhoneNumberFilter.Text = "";
                FormSalary_InputLanguageChanged(null, null);
            }
        }

        private void WorkerToForm(Worker worker)
        {
            if (worker != null)
            {
                LabelIDWorkerTextShow.Text = worker.Id.ToString();
                LabelBusinessWorkerShow.Text = worker.Business.Name;
                LabelFirstNameText.Text = worker.FirstName;
                LabelLastNameText.Text = worker.LastName;
                LabelIdNumberText.Text = worker.IdNumber;
                LabelBirthdayDateText.Text = worker.Bday.ToString();
                LabelPhoneNumberText.Text = worker.PhoneAreaCode + worker.PhoneNumber;
                if (worker.Email != null)
                    LabelEmailText.Text = worker.Email;
                LabelAccountNumText.Text = worker.AccountNumber.ToString();
                LabelBranchNumText.Text = worker.Branch.ToString();
                LabelBankNumText.Text = worker.Bank.Number.ToString();

                if (worker.MonthlyPayment != 0)
                {
                    LabelMonthlyPaymentText.Text = worker.MonthlyPayment.ToString() + "₪";
                }
                else
                {
                    LabelMonthlyPaymentText.Text = "0";
                }

                if (worker.HourlyPayment != 0)
                {
                    LabelHourlyRateText.Text = worker.HourlyPayment.ToString() + "₪";
                }
                else
                {
                    LabelHourlyRateText.Text = "0";
                }
            }
            else
            {
                LabelIDWorkerTextShow.Text = "0";
                LabelBusinessWorkerShow.Text = "0";
                LabelFirstNameText.Text = "0";
                LabelLastNameText.Text = "0";
                LabelIdNumberText.Text = "0";
                LabelBirthdayDateText.Text = "0";
                LabelPhoneNumberText.Text = "0";
                LabelEmailText.Text = "0";
                LabelAccountNumText.Text = "0";
                LabelBranchNumText.Text = "0";
                LabelBankNumText.Text = "0";
                LabelMonthlyPaymentText.Text = "0";
                LabelHourlyRateText.Text = "0";
            }
        }

        private void DetailSalaryToForm(Salary salary)
        {
            if (salary != null)
            {
                if (GroupBoxDetailSalalryJobPayment.Text != "תלוש משכורת עבור" + " " + salary.Worker.LastName + " " + salary.Worker.FirstName)
                    GroupBoxDetailSalalryJobPayment.Text = "תלוש משכורת עבור" + " " + salary.Worker.LastName + " " + salary.Worker.FirstName;
                LabelWorkerNameJobPaymentShow.Text = salary.Worker.LastName + " " + salary.Worker.FirstName;
                LabelBusinessNameJobPaymentShow.Text = salary.Worker.Business.Name;
                LabelMonthJobPaymentShow.Text = salary.Month;
                LabelYearJobPaymentShow.Text = salary.Year.ToString();
                LabelWorkerNameIncomeShow.Text = salary.Worker.LastName + " " + salary.Worker.FirstName;
                if (GroupBoxDetailSalalryIncome.Text != "תלוש משכורת עבור" + " " + salary.Worker.LastName + " " + salary.Worker.FirstName)
                    GroupBoxDetailSalalryIncome.Text = "תלוש משכורת עבור" + " " + salary.Worker.LastName + " " + salary.Worker.FirstName;
                LabelBusinessNameIncomeShow.Text = salary.Worker.Business.Name;
                LabelMonthIncomeShow.Text = salary.Month;
                LabelYearIncomeShow.Text = salary.Year.ToString();
                if (GroupBoxDetailSalalryTax.Text != "תלוש משכורת עבור" + " " + salary.Worker.LastName + " " + salary.Worker.FirstName)
                    GroupBoxDetailSalalryTax.Text = "תלוש משכורת עבור" + " " + salary.Worker.LastName + " " + salary.Worker.FirstName;
                LabelWorkerNameTaxShow.Text = salary.Worker.LastName + " " + salary.Worker.FirstName;
                LabelBusinessNameTaxShow.Text = salary.Worker.Business.Name;
                LabelMonthTaxShow.Text = salary.Month;
                LabelYearTaxShow.Text = salary.Year.ToString();
                if (GroupBoxDetailSalaryPension.Text != "תלוש משכורת עבור" + " " + salary.Worker.LastName + " " + salary.Worker.FirstName)
                    GroupBoxDetailSalaryPension.Text = "תלוש משכורת עבור" + " " + salary.Worker.LastName + " " + salary.Worker.FirstName;
                LabelWorkerNamePensionShow.Text = salary.Worker.LastName + " " + salary.Worker.FirstName;
                LabelBusinessNamePensionShow.Text = salary.Worker.Business.Name;
                LabelMonthPensionShow.Text = salary.Month;
                LabelYearPensionShow.Text = salary.Year.ToString();
                LabelWorkerSummaryShow.Text = salary.Worker.LastName + " " + salary.Worker.FirstName;
                LabelBusinessSummaryShow.Text = salary.Worker.Business.Name;
                LabelMonthSummaryShow.Text = ComboBoxMonth.SelectedItem.ToString();
                LabelYearSummaryShow.Text = ComboBoxYear.SelectedItem.ToString();
            }
            else
            {
                GroupBoxDetailSalalryJobPayment.Text = "תלוש משכורת עבור";
                LabelWorkerNameJobPaymentShow.Text = "שם העובד/ת";
                LabelBusinessNameJobPaymentShow.Text = "שם העסק";
                LabelMonthJobPaymentShow.Text = "0";
                LabelYearJobPaymentShow.Text = "0";
                GroupBoxDetailSalalryIncome.Text = "תלוש משכורת עבור";
                LabelWorkerNameIncomeShow.Text = "שם העובד/ת";
                LabelBusinessNameIncomeShow.Text = "שם העסק";
                LabelMonthIncomeShow.Text = "0";
                LabelYearIncomeShow.Text = "0";
                GroupBoxDetailSalalryTax.Text = "תלוש משכורת עבור";
                LabelWorkerNameTaxShow.Text = "שם העובד/ת";
                LabelBusinessNameTaxShow.Text = "שם העסק";
                LabelMonthTaxShow.Text = "0";
                LabelYearTaxShow.Text = "0";
                GroupBoxDetailSalaryPension.Text = "תלוש משכורת עבור";
                LabelWorkerNamePensionShow.Text = "שם העובד/ת";
                LabelBusinessNamePensionShow.Text = "שם העסק";
                LabelMonthPensionShow.Text = "0";
                LabelYearPensionShow.Text = "0";
                LabelWorkerSummaryShow.Text = "שם העובד/ת";
                LabelBusinessSummaryShow.Text = "שם העסק";
                LabelMonthSummaryShow.Text = "0";
                LabelYearSummaryShow.Text = "0";
            }
        }

        private void MoveSelectedItemBetweenListBox(ListBox ListBoxFrom, ListBox ListBoxTo, bool IsToSalary)
        {
            IncomeArr incomeArr = null;

            //מוצאים את הפריט הנבחר

            Income selectedItem = ListBoxFrom.SelectedItem as Income;

            if (IsToSalary)
                ListBoxInSalaryIncomesPrice.Items.Add(selectedItem.DefaultPayment);
            else
            {
                ListBoxInSalaryIncomesPrice.Items.RemoveAt(ListBoxInSalaryIncomesPrice.SelectedIndex);
                TextBoxIncomePrice.Text = "";
            }

            //מוסיפים את הפריט הנבחר לרשימת ההכנסות נוספות הפוטנציאליים
            //אם כבר יש הכנסות נוספות ברשימת הפוטנציאליים

            if (ListBoxTo.DataSource != null)
                incomeArr = ListBoxTo.DataSource as IncomeArr;
            else
                incomeArr = new IncomeArr();

            incomeArr.Add(selectedItem);
            IncomeArrToForm(ListBoxTo, incomeArr);

            ///הסרת הפריט הנבחר מרשימת ההכנסות נוספות הנבחרים

            IncomeArr incomeArrForm;
            incomeArrForm = ListBoxFrom.DataSource as IncomeArr;
            incomeArrForm.Remove(selectedItem);
            IncomeArrToForm(ListBoxFrom, incomeArrForm);
        }

        public double SumBasicSalary()
        {
            double sum = 0;
            if (LabelMonthlyPaymentText.Text != "0")
            {
                sum += double.Parse(LabelMonthlyPaymentText.Text.Replace("₪", ""));
            }
            else
            {
                if (LabelHourlyRateText.Text.Replace("₪", "") != "0" && TextBoxAmountHours100.Text != "")
                {
                    LabelSum100.Text = (double.Parse(LabelHourlyRateText.Text.Replace("₪", "")) * double.Parse(TextBoxAmountHours100.Text)).ToString();
                    LabelSum100.Text = (Math.Round(double.Parse(LabelSum100.Text) * 10) / 10.0).ToString() + "₪";
                    sum = double.Parse(LabelHourlyRateText.Text.Replace("₪", "")) * double.Parse(TextBoxAmountHours100.Text);
                }
                if (TextBoxAmountHours100.Text == "")
                    LabelSum100.Text = "0";

                if (LabelHourlyRateText.Text.Replace("₪", "") != "0" && TextBoxAmountHours125.Text != "")
                {
                    LabelSum125.Text = (double.Parse(LabelHourlyRateText.Text.Replace("₪", "")) * double.Parse(TextBoxAmountHours125.Text)).ToString();
                    LabelSum125.Text = (Math.Round(double.Parse(LabelSum125.Text) * 10) / 10.0).ToString() + "₪";
                    sum += double.Parse(LabelHourlyRateText.Text.Replace("₪", "")) * double.Parse(TextBoxAmountHours125.Text);
                }
                if (TextBoxAmountHours125.Text == "")
                    LabelSum125.Text = "0";

                if (LabelHourlyRateText.Text.Replace("₪", "") != "0" && TextBoxAmountHours150.Text != "")
                {
                    LabelSum150.Text = (double.Parse(LabelHourlyRateText.Text.Replace("₪", "")) * double.Parse(TextBoxAmountHours150.Text)).ToString();
                    LabelSum150.Text = (Math.Round(double.Parse(LabelSum150.Text) * 10) / 10.0).ToString() + "₪";
                    sum += double.Parse(LabelHourlyRateText.Text.Replace("₪", "")) * double.Parse(TextBoxAmountHours150.Text);
                }
                if (TextBoxAmountHours150.Text == "")
                    LabelSum150.Text = "0";
            }
            sum = Math.Round(sum * 10)/10.0;
            LabelNumSumJobPayment.Text = sum.ToString() + "₪";
            LabelNumJobPayment.Text = sum.ToString() + "₪";
            return sum;
        } 

        public double SumIncomes()
        {
            double sum = 0;
            for (int i = 0; i < ListBoxInSalaryIncomesPrice.Items.Count; i++)
            {
                sum += (double)ListBoxInSalaryIncomesPrice.Items[i];
            }
            sum = Math.Round(sum * 10) / 10.0;
            LabelNumSumIncome.Text = sum.ToString() + "₪";
            LabelNumIncome.Text = sum.ToString() + "₪";
            return sum;
        }

        public double SumTax()
        {
            double sum = 0;

            if (RadionButtonPriceTax.Checked == true)
            {
                if (TextBoxPriceIncomeTax.Text != "")
                {
                    LabelNumIncomeTax.Text = TextBoxPriceIncomeTax.Text + "₪";
                    sum += double.Parse(TextBoxPriceIncomeTax.Text);
                    LabelPrecentIncomeTaxText.Text = (double.Parse(TextBoxPriceIncomeTax.Text) /
                            double.Parse(LabelSumPaymentsShow.Text) * 100).ToString();
                    LabelPrecentIncomeTaxText.Text =
                        (Math.Round(double.Parse(LabelPrecentIncomeTaxText.Text) * 10) / 10.0).ToString();
                    LabelPriceIncomeTaxText.Text = TextBoxPriceIncomeTax.Text + "₪";
                    TextBoxPrecentIncomeTax.Text = LabelPrecentIncomeTaxText.Text;
                    LabelPrecentIncomeTaxText.Text += "%";
                }

                if (TextBoxPriceNationalInsurance.Text != "")
                {
                    LabelNumNationalInsurance.Text = TextBoxPriceNationalInsurance.Text + "₪";
                    sum += double.Parse(TextBoxPriceNationalInsurance.Text);
                    LabelPrecentNationalInsuranceText.Text = (double.Parse(TextBoxPriceNationalInsurance.Text) /
                            double.Parse(LabelSumPaymentsShow.Text) * 100).ToString();
                    LabelPrecentNationalInsuranceText.Text =
                        (Math.Round(double.Parse(LabelPrecentNationalInsuranceText.Text) * 10) / 10.0).ToString();
                    LabelPriceNationalInsuranceText.Text = TextBoxPriceNationalInsurance.Text + "₪";
                    TextBoxPrecentNationalInsurance.Text = LabelPrecentNationalInsuranceText.Text;
                    LabelPrecentNationalInsuranceText.Text += "%";
                }

                if (TextBoxPriceHealthInsurance.Text != "")
                {
                    LabelNumHealthInsurance.Text = TextBoxPriceHealthInsurance.Text + "₪";
                    sum += double.Parse(TextBoxPriceHealthInsurance.Text);                               
                    LabelPrecentHealthInsuranceText.Text = ((double.Parse(TextBoxPriceHealthInsurance.Text) /
                            double.Parse(LabelSumPaymentsShow.Text)) * 100).ToString();
                    LabelPrecentHealthInsuranceText.Text =
                        (Math.Round(double.Parse(LabelPrecentHealthInsuranceText.Text) * 10) / 10.0).ToString();
                    LabelPriceHealthInsuranceText.Text = TextBoxPriceHealthInsurance.Text + "₪";
                    TextBoxPrecentHealthInsurance.Text = LabelPrecentHealthInsuranceText.Text;
                    LabelPrecentHealthInsuranceText.Text += "%";
                }
            }            
            else
            {
                if (TextBoxPrecentIncomeTax.Text != "")
                {
                    LabelPriceIncomeTaxText.Text = ((double.Parse(TextBoxPrecentIncomeTax.Text) / 100.0) *
                    double.Parse(LabelSumPaymentsShow.Text)).ToString();
                    LabelPriceIncomeTaxText.Text =
                    (Math.Round(double.Parse(LabelPriceIncomeTaxText.Text) * 10) / 10.0).ToString();
                    LabelPrecentIncomeTaxText.Text = TextBoxPrecentIncomeTax.Text + "%";
                    sum += double.Parse(LabelPriceIncomeTaxText.Text);
                    LabelPriceIncomeTaxText.Text += "₪";
                    TextBoxPriceIncomeTax.Text = LabelPriceIncomeTaxText.Text;
                    LabelNumIncomeTax.Text = LabelPriceIncomeTaxText.Text;
                }

                if (TextBoxPrecentNationalInsurance.Text != "")
                {
                    LabelPriceNationalInsuranceText.Text = ((double.Parse(TextBoxPrecentNationalInsurance.Text) / 100.0) *
                    double.Parse(LabelSumPaymentsShow.Text)).ToString();
                    LabelPriceNationalInsuranceText.Text = 
                        (Math.Round(double.Parse(LabelPriceNationalInsuranceText.Text) * 10) / 10.0).ToString();
                    LabelPrecentNationalInsuranceText.Text = TextBoxPrecentNationalInsurance.Text + "%";
                    sum += double.Parse(LabelPriceNationalInsuranceText.Text);
                    LabelPriceNationalInsuranceText.Text += "₪";
                    TextBoxPriceNationalInsurance.Text = LabelPriceNationalInsuranceText.Text;
                    LabelNumNationalInsurance.Text = LabelPriceNationalInsuranceText.Text;
                }

                if (TextBoxPrecentHealthInsurance.Text != "")
                {
                    LabelPriceHealthInsuranceText.Text = ((double.Parse(TextBoxPrecentHealthInsurance.Text) / 100.0) *
                    double.Parse(LabelSumPaymentsShow.Text)).ToString();
                    LabelPriceHealthInsuranceText.Text =
                        (Math.Round(double.Parse(LabelPriceHealthInsuranceText.Text) * 10) / 10.0).ToString();
                    LabelPrecentHealthInsuranceText.Text = TextBoxPrecentHealthInsurance.Text + "%";
                    sum += double.Parse(LabelPriceHealthInsuranceText.Text);
                    LabelPriceHealthInsuranceText.Text += "₪";
                    TextBoxPriceHealthInsurance.Text = LabelPriceHealthInsuranceText.Text;
                    LabelNumHealthInsurance.Text = LabelPriceHealthInsuranceText.Text;
                }              
            }

            if (LabelSumPaymentsShow.Text == "0")
            {
                LabelPrecentIncomeTaxText.Text = "0";
                LabelPrecentNationalInsuranceText.Text = "0";
                LabelPrecentHealthInsuranceText.Text = "0";
                TextBoxPrecentIncomeTax.Text = "";
                TextBoxPrecentNationalInsurance.Text = "";
                TextBoxPrecentHealthInsurance.Text = "";
            }

            sum = Math.Round(sum * 10) / 10.0;
            LabelNumSumTax.Text = sum.ToString() + "₪";
            return sum;
        }

        public double SumPension()
        {
            double sum = 0;

            if (RadionButtonPricePension.Checked == true)
            {
                if (TextBoxPricePensionPayment.Text != "")
                {
                    LabelNumPensionPayment.Text = TextBoxPricePensionPayment.Text + "₪";
                    sum += double.Parse(TextBoxPricePensionPayment.Text);
                    LabelPrecentPensionPaymentText.Text = (double.Parse(TextBoxPricePensionPayment.Text) /
                            double.Parse(LabelSumPaymentsShow.Text) * 100).ToString();
                    LabelPrecentPensionPaymentText.Text =
                        (Math.Round(double.Parse(LabelPrecentPensionPaymentText.Text) * 10) / 10.0).ToString();
                    LabelPricePensionPaymentText.Text = TextBoxPricePensionPayment.Text + "₪";
                    TextBoxPrecentPensionPayment.Text = LabelPrecentPensionPaymentText.Text;
                    LabelPrecentPensionPaymentText.Text += "%";
                }

                if (TextBoxPriceAdvancedStudyFund.Text != "")
                {
                    LabelNumAdvancedStudyFund.Text = TextBoxPriceAdvancedStudyFund.Text + "₪";
                    sum += double.Parse(TextBoxPriceAdvancedStudyFund.Text);                
                    LabelPrecentAdvancedStudyFundText.Text = (double.Parse(TextBoxPriceAdvancedStudyFund.Text) /
                            double.Parse(LabelSumPaymentsShow.Text) * 100).ToString();
                    LabelPrecentAdvancedStudyFundText.Text =
                        (Math.Round(double.Parse(LabelPrecentAdvancedStudyFundText.Text) * 10) / 10.0).ToString();
                    LabelPriceAdvancedStudyFundText.Text = TextBoxPriceAdvancedStudyFund.Text + "₪";
                    TextBoxPrecentAdvancedStudyFund.Text = LabelPrecentAdvancedStudyFundText.Text;
                    LabelPrecentAdvancedStudyFundText.Text += "%";
                }
            }            
            else
            {
                if (TextBoxPrecentPensionPayment.Text != "")
                {
                    LabelPricePensionPaymentText.Text = ((double.Parse(TextBoxPrecentPensionPayment.Text) / 100.0) *
                    double.Parse(LabelSumPaymentsShow.Text)).ToString();
                    LabelPricePensionPaymentText.Text =
                        (Math.Round(double.Parse(LabelPricePensionPaymentText.Text) * 10) / 10.0).ToString();
                    LabelPrecentPensionPaymentText.Text = TextBoxPrecentPensionPayment.Text + "%";
                    sum += double.Parse(LabelPricePensionPaymentText.Text);
                    LabelPricePensionPaymentText.Text += "₪";
                    TextBoxPricePensionPayment.Text = LabelPricePensionPaymentText.Text;
                    LabelNumPensionPayment.Text = LabelPricePensionPaymentText.Text;
                }

                if (TextBoxPrecentAdvancedStudyFund.Text != "")
                {
                    LabelPriceAdvancedStudyFundText.Text = ((double.Parse(TextBoxPrecentAdvancedStudyFund.Text) / 100.0)*
                        double.Parse(LabelSumPaymentsShow.Text)).ToString();
                    LabelPriceAdvancedStudyFundText.Text =
                        (Math.Round(double.Parse(LabelPriceAdvancedStudyFundText.Text) * 10) / 10.0).ToString();
                    LabelPrecentAdvancedStudyFundText.Text = TextBoxPrecentAdvancedStudyFund.Text + "%";
                    sum += double.Parse(LabelPriceAdvancedStudyFundText.Text);
                    LabelPriceAdvancedStudyFundText.Text += "₪";
                    TextBoxPriceAdvancedStudyFund.Text = LabelPriceAdvancedStudyFundText.Text;
                    LabelNumAdvancedStudyFund.Text = LabelPriceAdvancedStudyFundText.Text;
                }
            }

            if (LabelSumPaymentsShow.Text == "0")
            {
                LabelPrecentPensionPaymentText.Text = "0";
                LabelPrecentAdvancedStudyFundText.Text = "0";
                TextBoxPrecentPensionPayment.Text = "";
                TextBoxPrecentAdvancedStudyFund.Text = "";
            }

            sum = Math.Round(sum * 10) / 10.0;
            LabelNumSumPension.Text = sum.ToString() + "₪";
            return sum;
        }

        private void CalculateData(double sumIncome = 0)
        {
            double sum, sumNeto;
            if (sumIncome == 0)
            {
                LabelSumPaymentsShow.Text = (SumBasicSalary() + SumIncomes()).ToString();
                LabelSumPaymentsShow.Text =
                (Math.Round(double.Parse(LabelSumPaymentsShow.Text) * 10) / 10.0).ToString();
                sum = SumBasicSalary() + SumIncomes() - SumTax() - SumPension();
                LabelSumPaymentsShow.Text += "₪";
            }               
            else
            {
                LabelSumPaymentsShow.Text = (SumBasicSalary() + sumIncome).ToString();
                LabelSumPaymentsShow.Text =
                (Math.Round(double.Parse(LabelSumPaymentsShow.Text) * 10) / 10.0).ToString();
                sum = SumBasicSalary() + sumIncome - SumTax() - SumPension();
                LabelSumPaymentsShow.Text += "₪";
            }

            sum = Math.Round(sum * 10) / 10.0;
            LabelNumBruto.Text = sum.ToString() + "₪";
            sumNeto = 0.83 * sum;
            LabelNumNeto.Text = (Math.Round(sumNeto * 10) / 10.0).ToString() + "₪";
        }

        private bool IsHebLetter(char c)
        {

            // פעולת עזר – האם האות היא אות בעברית

            return (c >= 'א' && c <= 'ת');
        }

        private void FormSalary_InputLanguageChanged(object sender, InputLanguageChangedEventArgs e)
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
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.KeyChar = char.MinValue;
        }

        private void TextBoxFilterDetailSalary_KeyUp(object sender, KeyEventArgs e)
        {
            SetSalaryByFilter();
        }

        private void ComboBoxFilterDetailSalary_TextChanged(object sender, EventArgs e)
        {
                SetSalaryByFilter();
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SetSalaryByFilter();
        }

        private void SetSalaryByFilter()
        {
            int idSalary = 0;
            int year = 0;
            int idWorker = 0;
            int isPaid;
            int isEntered;

            //אם המשתמש רשם ערך בשדה המזהה

            if (TextBoxIdSalaryFilter.Text != "")
                idSalary = int.Parse(TextBoxIdSalaryFilter.Text);

            if (ComboBoxYearFilter.SelectedItem != null)
                year = int.Parse(ComboBoxYearFilter.SelectedItem.ToString());

            if (TextBoxIdWorkerFilter.Text != "")
                idWorker = int.Parse(TextBoxIdWorkerFilter.Text);

            if (CheckBoxChoseFilterIsPaid.Checked == true)
            {
                if (CheckBoxIsPaidFilter.Checked == false)
                    isPaid = 0;
                else
                    isPaid = 1;
            }
            else
                isPaid = 2;

            if (CheckBoxChoseFilterIsEntered.Checked == true)
            {
                if (CheckBoxIsEnteredFilter.Checked == false)
                    isEntered = 0;
                else
                    isEntered = 1;
            }
            else
                isEntered = 2;

            //מייצרים אוסף של כלל התלושי משכורת
            // החזרת כל העובדים באותו העסק
            WorkerArr workerArr = new WorkerArr();
            workerArr.Fill();
            WorkerArr workerArrFilter;
            workerArrFilter = workerArr.Filter(LabelBusinessName.Text);

            //ממירה את הטנ "מ אוסף תלושי המשכורת לטופס
            SalaryArr salaryArr = new SalaryArr();
            salaryArr.Fill();

            int[] yearArr = new int[ComboBoxYear.Items.Count];
            int NumYear = 2015;
            for (int i = 0; i < ComboBoxYear.Items.Count; i++)
            {
                yearArr[i] = NumYear;
                NumYear++;
            }

           salaryArr = salaryArr.Filter(workerArrFilter, yearArr);

            //מסננים את אוסף התלושי משכורת לפי שדות הסינון שרשם המשתמש

            salaryArr = salaryArr.Filter(salaryArr.Count, idSalary, ComboBoxMonthFilter.Text, year, idWorker, 
                TextBoxLastNameFilter.Text, TextBoxPhoneNumberFilter.Text, LabelBusinessName.Text, 
                isPaid, isEntered);

            //מציבים בתיבת הרשימה את אוסף התלושי משכורת

            ListBoxSalary.DataSource = salaryArr;
        }

        private void TextBoxFilterIncome_KeyUp(object sender, KeyEventArgs e)
        {
            int id = 0;

            //אם המשתמש רשם ערך בשדה המזהה

            if (TextBoxIDIncomeFilter.Text != "")
                id = int.Parse(TextBoxIDIncomeFilter.Text);

            //מייצרים אוסף של כלל ההכנסות

            IncomeArr incomeArr = new IncomeArr();
            incomeArr.Fill();

            //מסננים את אוסף ההכנסות לפי שדות הסינון שרשם המשתמש

            incomeArr = incomeArr.Filter(id, TextBoxIncomeFilter.Text);

            //מציבים בתיבת הרשימה את אוסף ההכנסות

            ListBoxPotentialIncomes.DataSource = incomeArr;

            //אחרי שמסננים את אוסף ההכנסות לפי שדות הסינון שרשם המשתמש
            if (ListBoxInSalaryIncomes.DataSource != null)
                incomeArr.Remove(ListBoxInSalaryIncomes.DataSource as IncomeArr);

            //מציבים בתיבת הרשימה את אוסף המוצרים
            IncomeArrToForm(ListBoxPotentialIncomes, incomeArr);
        }

        private void CalculateData_KeyUp(object sender, KeyEventArgs e)
        {
            CalculateData();
        }

        public bool CheckForm()
        {
            bool flag = true;
            int removeFrom;

            // בדיקת עמוד פרטים ראשוניים
            if (ComboBoxMonth.Text.Contains("אוקטובר") || ComboBoxMonth.Text.Contains("נובמבר") ||
                ComboBoxMonth.Text.Contains("דצמבר"))
            {
                removeFrom = 2;
            }
            else
                removeFrom = 1;

            if (int.Parse(ComboBoxYear.Text) == DateTime.Now.Year
                && (int.Parse(ComboBoxMonth.Text.Remove(removeFrom)) > DateTime.Now.Month + 1 ||
                (DateTime.Now.Day < 25 && int.Parse(ComboBoxMonth.Text.Remove(removeFrom)) == DateTime.Now.Month + 1)))
            {
                flag = false;
                LabelNumberMonth.ForeColor = Color.Red;
            }
            else
                LabelNumberMonth.ForeColor = Color.Black;

            if (int.Parse(ComboBoxYear.Text) > DateTime.Now.Year && 
                (DateTime.Now.Month != 12 || DateTime.Now.Day < 25))
            {
                flag = false;
                LabelNumberYear.ForeColor = Color.Red;
            }
            else
                LabelNumberYear.ForeColor = Color.Black;

            if (LabelIDWorkerTextShow.Text == "0")
            {
                LabelWorkerName.ForeColor = Color.Red;
            }
            else
                LabelWorkerName.ForeColor = Color.Black;

            // בדיקת עמוד תשלום חודשי בסיסי
            // בדיקה שהלקוח לא מזין גם תחת משכורת קבועה וגם במשכורת לפי שעות
            if (LabelMonthlyPaymentText.Text != "0" && (TextBoxAmountHours100.Text.Length > 0 || 
                TextBoxAmountHours125.Text.Length > 0 || TextBoxAmountHours150.Text.Length > 0))
            {
                flag = false;
                LabelMonthlyPayment.ForeColor = Color.Red;
                LabelHourlyRate.ForeColor = Color.Red;
                TextBoxAmountHours100.BackColor = Color.Red;
                TextBoxAmountHours125.BackColor = Color.Red;
                TextBoxAmountHours150.BackColor = Color.Red;
            }
            else
            {
                LabelMonthlyPayment.ForeColor = Color.Black;
                LabelHourlyRate.ForeColor = Color.Black;
                TextBoxAmountHours100.BackColor = Color.White;
                TextBoxAmountHours125.BackColor = Color.White;
                TextBoxAmountHours150.BackColor = Color.White;
            }

            // בדיקות תקינות לתיבות הטקסט בעמוד תשלום חודשי בסיסי
            if (LabelMonthlyPaymentText.Text.EndsWith("."))
            {
                flag = false;
                LabelMonthlyPayment.ForeColor = Color.Red;
            }
            else
                LabelMonthlyPayment.ForeColor = Color.Black;

            if (LabelHourlyRateText.Text.EndsWith("."))
            {
                flag = false;
                LabelHourlyRateText.ForeColor = Color.Red;
            }
            else
                LabelHourlyRateText.ForeColor = Color.Black;

            if (TextBoxAmountHours100.Text.EndsWith("."))
            {
                flag = false;
                TextBoxAmountHours100.BackColor = Color.Red;
            }
            else
                TextBoxAmountHours100.BackColor = Color.White;

            if (TextBoxAmountHours125.Text.EndsWith("."))
            {
                flag = false;
                TextBoxAmountHours125.BackColor = Color.Red;
            }
            else
                TextBoxAmountHours125.BackColor = Color.White;

            if (TextBoxAmountHours150.Text.EndsWith("."))
            {
                flag = false;
                TextBoxAmountHours150.BackColor = Color.Red;
            }
            else
                TextBoxAmountHours150.BackColor = Color.White;

            // בדיקת עמוד הכנסות נוספות
            if (ListBoxInSalaryIncomes.Items.Count == 0)
            {
                flag = false;
                ListBoxInSalaryIncomes.BackColor = Color.Red;
            }
            else
                ListBoxInSalaryIncomes.BackColor = Color.AntiqueWhite;

            // בדיקת עמוד ניכויי חובה- מיסים
            if (RadionButtonPriceTax.Checked == true)
            {
                if (TextBoxPriceIncomeTax.Text.Length == 0 || TextBoxPriceIncomeTax.Text.EndsWith("."))
                {
                    flag = false;
                    TextBoxPriceIncomeTax.BackColor = Color.Red;
                }
                else
                    TextBoxPriceIncomeTax.BackColor = Color.White;

                if (TextBoxPriceNationalInsurance.Text.Length == 0 || TextBoxPriceNationalInsurance.Text.EndsWith("."))
                {
                    flag = false;
                    TextBoxPriceNationalInsurance.BackColor = Color.Red;
                }
                else
                    TextBoxPriceNationalInsurance.BackColor = Color.White;

                if (TextBoxPriceHealthInsurance.Text.Length == 0 || TextBoxPriceHealthInsurance.Text.EndsWith("."))
                {
                    flag = false;
                    TextBoxPriceHealthInsurance.BackColor = Color.Red;
                }
                else
                    TextBoxPriceHealthInsurance.BackColor = Color.White;
            }
            else
            {
                if (TextBoxPrecentIncomeTax.Text.Length == 0 || TextBoxPriceIncomeTax.Text.EndsWith("."))
                {
                    flag = false;
                    TextBoxPriceIncomeTax.BackColor = Color.Red;
                }
                else
                    TextBoxPrecentIncomeTax.BackColor = Color.White;

                if (TextBoxPrecentNationalInsurance.Text.Length == 0 || TextBoxPriceNationalInsurance.Text.EndsWith("."))
                {
                    flag = false;
                    TextBoxPrecentNationalInsurance.BackColor = Color.Red;
                }
                else
                    TextBoxPrecentNationalInsurance.BackColor = Color.White;

                if (TextBoxPrecentHealthInsurance.Text.Length == 0 || TextBoxPriceHealthInsurance.Text.EndsWith("."))
                {
                    flag = false;
                    TextBoxPrecentHealthInsurance.BackColor = Color.Red;
                }
                else
                    TextBoxPrecentHealthInsurance.BackColor = Color.White;
            }
            

            // בדיקת עמוד זכויות פנסיה- גמל
            if (RadionButtonPricePension.Checked == true)
            {
                if (TextBoxPricePensionPayment.Text.Length == 0 || TextBoxPricePensionPayment.Text.EndsWith("."))
                {
                    flag = false;
                    TextBoxPricePensionPayment.BackColor = Color.Red;
                }
                else
                    TextBoxPricePensionPayment.BackColor = Color.White;

                if (TextBoxPriceAdvancedStudyFund.Text.Length == 0 || TextBoxPriceAdvancedStudyFund.Text.EndsWith("."))
                {
                    flag = false;
                    TextBoxPriceAdvancedStudyFund.BackColor = Color.Red;
                }
                else
                    TextBoxPriceAdvancedStudyFund.BackColor = Color.White;
            }
            else
            {
                if (TextBoxPrecentPensionPayment.Text.Length == 0 || TextBoxPrecentPensionPayment.Text.EndsWith("."))
                {
                    flag = false;
                    TextBoxPrecentPensionPayment.BackColor = Color.Red;
                }
                else
                    TextBoxPrecentPensionPayment.BackColor = Color.White;

                if (TextBoxPrecentAdvancedStudyFund.Text.Length == 0 || TextBoxPrecentAdvancedStudyFund.Text.EndsWith("."))
                {
                    flag = false;
                    TextBoxPrecentAdvancedStudyFund.BackColor = Color.Red;
                }
                else
                    TextBoxPrecentAdvancedStudyFund.BackColor = Color.White;
            }
            

            return flag;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (!CheckForm())
            {
                MessageBox.Show("הטופס לא נשלח בהצלחה, השגיאות מסומנות באדום", "שגיאה", MessageBoxButtons.OK,
                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
            }
            else
            {
                // סיכום נתונים
                CalculateData();

                //יצירת תלוש משכורת מהטופס
                Salary salary = FormToSalary();
                DetailSalaryToForm(salary);


                //הוספת התלוש משכורת למסד הנתונים
                SalaryIncomeArr salaryIncomeArrNew;

                SalaryArr salaryArr = new SalaryArr();
                salaryArr.Fill();

                if (salary.Id == 0)
                {
                    if (!salaryArr.IsContain(salary))
                    {
                        if (salary.Insert())
                        {
                            salaryArr.Fill();
                            //מוצאים את התלוש משכורת החדשה - לפי המזהה הגבוה ביותר
                            salary = salaryArr.GetSalaryWithMaxId();

                            salaryIncomeArrNew = FormToSalaryIncomeArr(salary);

                            //מוסיפים את ההכנסות נוספות החדשים לתלוש משכורת
                            salaryIncomeArrNew.Insert();

                            MessageBox.Show("המשכורת נוספה בהצלחה", "מידע", MessageBoxButtons.OK,
                                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                        }
                        else
                            MessageBox.Show("המשכורת לא נוספה בהצלחה, נסה בשנית", "שגיאה", MessageBoxButtons.OK,
                                MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                    }
                    else
                        MessageBox.Show("המשכורת שהזנת קיימת", "מידע", MessageBoxButtons.OK,
                                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                }
                else
                {
                    //עדכון מוצר קיים
                    if (salary.Update())
                    {
                        salaryIncomeArrNew = FormToSalaryIncomeArr(salary);

                        //מוחקים את ההכנסות נוספות הקודמים של התלוש משכורת
                        //אוסף כלל הזוגות - תלוש משכורת-פריט
                        SalaryIncomeArr salaryIncomeArrOld = new SalaryIncomeArr();
                        salaryIncomeArrOld.Fill();

                        //סינון לפי התלוש משכורת הנוכחית
                        salaryIncomeArrOld = salaryIncomeArrOld.FilterSalary(salary);

                        //מחיקת כל ההכנסות נוספות באוסף התלוש משכורת-פריט של התלוש משכורת הנוכחית
                        salaryIncomeArrOld.Delete();

                        //מוסיפים את ההכנסות נוספות החדשים לתלוש משכורת
                        salaryIncomeArrNew = FormToSalaryIncomeArr(salary);
                        salaryIncomeArrNew.Insert();

                        MessageBox.Show("המידע עודכן בהצלחה", "מידע", MessageBoxButtons.OK,
                            MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                    }
                    else
                        MessageBox.Show("המידע לא עודכן בהצלחה, נסה בשנית", "שגיאה", MessageBoxButtons.OK,
                            MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                }

                // ניקוי טופס וטעינת ערכים מחדש
                SalaryArrToForm(LabelBusinessName.Text);
                SetSalaryByFilter();
                IncomeArrToForm(ListBoxPotentialIncomes);
                IncomeArrPriceToForm(null);
                SalaryToForm(null);
                DetailSalaryToForm(null);
                WorkerToForm(null);
                ListBoxInSalaryIncomes.DataSource = null;
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            SalaryToForm(null);
            DetailSalaryToForm(null);
            WorkerToForm(null);
            IncomeArrToForm(ListBoxPotentialIncomes);
            IncomeArrPriceToForm(null);
            TextBoxIncomePrice.Text = "";
            ListBoxInSalaryIncomes.DataSource = null;
            ListBoxSalary.SelectedIndex = -1;
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            ListBoxSalary.SelectedIndex = -1;
            Salary salary = FormToSalary();
            if (salary.Id == 0)
            {
                MessageBox.Show("לא נבחר תלוש משכורת למחיקה", "מידע", MessageBoxButtons.OK,
                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
            }
            else
            {
                if (MessageBox.Show("אתה בטוח שברצונך למחוק?", "אזהרה", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2,
                    MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading) ==
                    System.Windows.Forms.DialogResult.Yes)
                {
                    SalaryIncomeArr salaryIncomeArr = new SalaryIncomeArr();
                    salaryIncomeArr.Fill();
                    if (salaryIncomeArr.FilterSalary(salary).Delete())
                    {
                        salary.Delete();
                    }
                    DetailSalaryToForm(null);
                    SalaryToForm(null);
                    WorkerToForm(null);
                    SalaryArrToForm(LabelBusinessName.Text);
                    SetSalaryByFilter();
                }
            }
        }

        private void ButtonBeginning_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormBeginning formBeginning = new FormBeginning(LabelUserNameText.Text);
            formBeginning.ShowDialog();
        }

        private void ListBoxSalary_DoubleClick(object sender, EventArgs e)
        {
            //תלוש המשכורת שנבחר

            Salary salary = ListBoxSalary.SelectedItem as Salary;

            //הצגת חלקי תלוש המשכורת בלשוניות השונות

            SalaryToForm(salary);
            WorkerToForm(salary.Worker);
            DetailSalaryToForm(salary);

            //לשונית הכנסות לתלוש משכורת
            //תיבת רשימה - הכנסות בתלוש משכורת
            //מוצאים את ההכנסות בתלוש המשכורת הנוכחי
            //כל הזוגות הכנסה-תלוש משכורת

            SalaryIncomeArr salaryIncomeArr = new SalaryIncomeArr();
            salaryIncomeArr.Fill();

            //סינון לפי תלוש משכורת נוכחי

            salaryIncomeArr = salaryIncomeArr.FilterSalary(salary);
            IncomeArrPriceToForm(salaryIncomeArr);

            //רק אוסף הפריטים מתוך אוסף הזוגות הכנסה-תלוש משכורת

            IncomeArr incomeArrInSalary = salaryIncomeArr.GetIncomeArr();
            IncomeArrToForm(ListBoxInSalaryIncomes, incomeArrInSalary);

            //תיבת רשימה - הכנסות פוטנציאליות
            //כל ההכנסות - פחות אלו שכבר נבחרו

            IncomeArr incomeArrNotInSalary = new IncomeArr();
            incomeArrNotInSalary.Fill();

            //הורדת ההכנסות שכבר קיימות בתלוש משכורת

            incomeArrNotInSalary.Remove(incomeArrInSalary);
            IncomeArrToForm(ListBoxPotentialIncomes, incomeArrNotInSalary);
        }

        private void ListBoxPotentialIncomes_DoubleClick(object sender, EventArgs e)
        {
            MoveSelectedItemBetweenListBox(ListBoxPotentialIncomes, ListBoxInSalaryIncomes, true);
        }

        private void ListBoxInSalaryIncomes_DoubleClick(object sender, EventArgs e)
        {
            MoveSelectedItemBetweenListBox(ListBoxInSalaryIncomes, ListBoxPotentialIncomes, false);
        }

        private void ListBoxInSalaryIncomes_Click(object sender, EventArgs e)
        {
            ListBoxInSalaryIncomesPrice.SelectedIndex = ListBoxInSalaryIncomes.SelectedIndex;
            TextBoxIncomePrice.Text = ListBoxInSalaryIncomesPrice.Items[ListBoxInSalaryIncomes.SelectedIndex].ToString();
        }

        private void ListBoxInSalaryIncomesPrice_Click(object sender, EventArgs e)
        {
            ListBoxInSalaryIncomes.SelectedIndex = ListBoxInSalaryIncomesPrice.SelectedIndex;
            TextBoxIncomePrice.Text = ListBoxInSalaryIncomesPrice.Items[ListBoxInSalaryIncomes.SelectedIndex].ToString();
        }

        private void TextBoxIncomePrice_TextChanged(object sender, EventArgs e)
        {
            if (ListBoxInSalaryIncomesPrice.SelectedIndex >= 0)
            {
                int k = ListBoxInSalaryIncomesPrice.SelectedIndex;
                //עדכון מחר הכנסה                     
                ListBoxInSalaryIncomesPrice.Items[k] =
                double.Parse(TextBoxIncomePrice.Text);
            }
        }

        private void ButtonIncome_Click(object sender, EventArgs e)
        {
            FormIncome formIncome = new FormIncome(LabelUserNameText.Text);
            formIncome.ShowDialog();
        }

        private void printDocumentV1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // מגדיר את המרחק משמאל ומלמעלה
            e.Graphics.DrawImage(m_bitmap, 0, 0);
        }

        private void ButtonPrint_Click(object sender, EventArgs e)
        {
            CaptureScreen();

            printPreviewDialog1.Document = printDocumentV1;
            printPreviewDialog1.ShowDialog();
        }

        private void CaptureScreen()
        {
            //תפיסת החלק של הטופס להדפסה כולל הרשימה והכותרת שמעליה - לתוך תמונת ה 

            int addAboveListView = -30;
            int moveLeft = 0;
            Graphics graphics = GroupBoxSummaryData.CreateGraphics();
            Size curSize = GroupBoxSummaryData.Size;
            curSize.Height += addAboveListView;
            curSize.Width += moveLeft;
            m_bitmap = new Bitmap(curSize.Width, curSize.Height, graphics);
            graphics = Graphics.FromImage(m_bitmap);
            Point panelLocation = PointToScreen(GroupBoxSummaryData.Location);
            graphics.CopyFromScreen(panelLocation.X, panelLocation.Y - addAboveListView,
            moveLeft, 0, curSize);
        }

        private void RadionButtonPriceTax_CheckedChanged(object sender, EventArgs e)
        {
            TablePrecentTax.Hide();
            LabelIncomeTaxPrecent.Hide();
            LabelNationalInsurancePrecent.Hide();
            LabelHealthInsurancePrecent.Hide();
            TablePriceTax.Show();
            LabelIncomeTaxMoney.Show();
            LabelNationalInsuranceMoney.Show();
            LabelHealthInsuranceMoney.Show();
        }

        private void RadionButtonPrecentTax_CheckedChanged(object sender, EventArgs e)
        {
            TablePriceTax.Hide();
            LabelIncomeTaxMoney.Hide();
            LabelNationalInsuranceMoney.Hide();
            LabelHealthInsuranceMoney.Hide();
            TablePrecentTax.Show();
            LabelIncomeTaxPrecent.Show();
            LabelNationalInsurancePrecent.Show();
            LabelHealthInsurancePrecent.Show();
        }

        private void RadionButtonPricePension_CheckedChanged(object sender, EventArgs e)
        {
            TablePrecentPension.Hide();
            LabelPensionPaymentPrecent.Hide();
            LabelAdvancedStudyFundPrecent.Hide();
            TablePricePension.Show();
            LabelPensionPaymentMoney.Show();
            LabelAdvancedStudyFundMoney.Show();
        }

        private void RadionButtonPrecentPension_CheckedChanged(object sender, EventArgs e)
        {
            TablePricePension.Hide();
            LabelPensionPaymentMoney.Hide();
            LabelAdvancedStudyFundMoney.Hide();
            TablePrecentPension.Show();
            LabelPensionPaymentPrecent.Show();
            LabelAdvancedStudyFundPrecent.Show();
        }

        private void RadionButtonPaid_Click(object sender, EventArgs e)
        {

        }

        private void RadionButtonNotPaid_CheckedChanged(object sender, EventArgs e)
        {
            LabelIsPaidText.Text = "לא שולם";
        }
    }
}
