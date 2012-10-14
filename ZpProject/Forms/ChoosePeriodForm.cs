using System;
using System.Windows.Forms;

namespace ZpProject.Forms
{
    public partial class ChoosePeriodForm : Form
    {
        private void FillPeriods(short year, byte month)
        {
            cmbPeriod.Items.Clear();

            using (var context = new DataClassesDataContext())
            {
                int index = 0, selectedIndex = -1;
                var periods = context.PaymentPeriods;
                foreach (var period in periods)
                {
                    if (period.Year == year && period.Month == month)
                    {
                        selectedIndex = index;
                    }

                    cmbPeriod.Items.Add(period);
                    index++;
                }

                cmbPeriod.SelectedIndex = selectedIndex;
            }
        }

        private PaymentPeriod GetSelectedPeriod()
        {
            return cmbPeriod.SelectedItem as PaymentPeriod;
        }

        private void Initialize(short year, byte month)
        {
            FillPeriods(year, month);
        }

        private void BtnNewClick(object sender, EventArgs e)
        {
            short year;
            byte month;

            if (NewPeriodForm.Execute(this, out year, out month))
            {
                FillPeriods(year, month);
            }
        }

        private void BtnOkClick(object sender, EventArgs e)
        {
            var period = GetSelectedPeriod();
            if (period == null)
            {
                DialogResult = DialogResult.None;
                return;
            }

            Year = period.Year;
            Month = period.Month;
        }

        public ChoosePeriodForm()
        {
            InitializeComponent();
        }

        public static bool Execute(IWin32Window owner, ref short year, ref byte month)
        {
            using (var form = new ChoosePeriodForm())
            {
                form.Initialize(year, month);
                if (form.ShowDialog(owner) == DialogResult.OK)
                {
                    year = form.Year;
                    month = form.Month;

                    return true;
                }
            }

            return false;
        }

        public short Year
        {
            get;
            set;
        }

        public byte Month
        {
            get;
            set;
        }
    }
}