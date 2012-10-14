using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ZpProject.Classes;

namespace ZpProject.Forms
{
    public partial class NewPeriodForm : Form
    {
        private List<PaymentPeriod> _periods;

        private void FillPeriods()
        {
            using (var context = new DataClassesDataContext())
            {
                _periods.Clear();
                _periods.AddRange(context.PaymentPeriods);
            }
        }

        private void FillForm()
        {
            cmbYear.SelectedIndexChanged -= CmbYearSelectedIndexChanged;
            cmbMonth.SelectedIndexChanged -= CmbYearSelectedIndexChanged;

            cmbMonth.Items.Clear();
            var months = UIHelper.Months.Select(x => x.Substring(0, 1).ToUpper() + x.Substring(1));
            foreach (var month in months)
            {
                cmbMonth.Items.Add(month);
            }
            cmbMonth.SelectedIndex = DateTime.Today.Month - 1;

            cmbYear.Items.Clear();
            int currentYear = DateTime.Today.Year;
            for (int i = currentYear; i >= currentYear - 5; i--)
            {
                cmbYear.Items.Add(i);
            }
            cmbYear.SelectedIndex = 0;

            cmbYear.SelectedIndexChanged += CmbYearSelectedIndexChanged;
            cmbMonth.SelectedIndexChanged += CmbYearSelectedIndexChanged;
        }

        private void RefreshUI()
        {
            btnOk.Enabled = _periods.Count(x => x.Month == Month && x.Year == Year) == 0;
        }

        private void Initialize()
        {
            FillPeriods();
            FillForm();
            RefreshUI();
        }

        private void CmbYearSelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshUI();
        }

        private void BtnOkClick(object sender, EventArgs e)
        {
            RefreshUI();
            if (!btnOk.Enabled)
            {
                DialogResult = DialogResult.None;
                return;
            }

            using (var context = new DataClassesDataContext())
            {
                var paymentPeriod = new PaymentPeriod { Year = Year, Month = Month };
                context.PaymentPeriods.InsertOnSubmit(paymentPeriod);
                context.SubmitChanges();
            }

            if (MessageBox.Show(this, string.Format("Расчетный период за {0} создан.\r\nВы хотите сформировать начисления?", UIHelper.PeriodToString(Year, Month)), "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                using (var context = new DataClassesDataContext())
                {
                    CalcHelper.MakePayments(context, Year, Month);
                }
            }
        }

        public NewPeriodForm()
        {
            InitializeComponent();

            _periods = new List<PaymentPeriod>();
        }

        public static bool Execute(IWin32Window owner, out short year, out byte month)
        {
            using (var form = new NewPeriodForm())
            {
                form.Initialize();
                if (form.ShowDialog(owner) == DialogResult.OK)
                {
                    year = form.Year;
                    month = form.Month;

                    return true;
                }
            }

            year = 0;
            month = 0;
            return false;
        }

        public short Year
        {
            get
            {
                return Convert.ToInt16(cmbYear.SelectedItem);
            }
        }

        public byte Month
        {
            get
            {
                return (byte)(cmbMonth.SelectedIndex + 1);
            }
        }
    }
}