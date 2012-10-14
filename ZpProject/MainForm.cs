using System;
using System.Windows.Forms;
using ZpProject.Classes;
using ZpProject.Forms;
using System.Linq;
using System.Data;

namespace ZpProject
{
    public partial class MainForm : Form
    {
        private string _textTemplate;

        private void FillTitle()
        {
            Text = string.Format(_textTemplate, UIHelper.PeriodToString(ShowYear, ShowMonth));
        }

        private PaymentPeriod GetPeriod(DataClassesDataContext context)
        {
            var result = context.PaymentPeriods.FirstOrDefault(x => x.Year == ShowYear && x.Month == ShowMonth);
            if (result == null)
            {
                result = new PaymentPeriod { Year = ShowYear, Month = ShowMonth };
                context.PaymentPeriods.InsertOnSubmit(result);
                context.SubmitChanges();
            }

            return result;
        }

        private void FillGrid()
        {
            dgvItems.Rows.Clear();

            using (var context = new DataClassesDataContext())
            {
                var period = GetPeriod(context);
                int periodID = period.ID;

                var items = context.PaymentEmployees.Where(x => x.PaymentPeriodID == periodID).Where(x => IsShowCategory1 && x.Employee.Category == 1 || IsShowCategory2 && x.Employee.Category == 2).Select(x => new { x.EmployeeID, x.Employee.FIO, Department = x.Employee.Department.Name, Category = x.Employee.CategoryName, Sum = x.Payments.TotalSum() });
                foreach (var item in items)
                {
                    var row = new DataGridViewRow();
                    row.CreateCells(dgvItems, item.FIO, item.Department, item.Category, item.Sum);
                    row.Tag = item.EmployeeID;

                    dgvItems.Rows.Add(row);
                }
            }
        }

        public MainForm()
        {
            InitializeComponent();

            var today = DateTime.Today;
            ShowMonth = (byte)today.Month;
            ShowYear = (short)today.Year;
        }

        private void TsmDepartmentsClick(object sender, EventArgs e)
        {
            DepartmentsForm.Execute(this);
        }

        private void TsmEmployeesClick(object sender, EventArgs e)
        {
            EmployeesForm.Execute(this);
        }

        private void TsmPaymentTypesClick(object sender, EventArgs e)
        {
            PaymentTypesForm.Execute(this);
        }

        public byte ShowMonth { get; set; }
        public short ShowYear { get; set; }

        public bool IsShowCategory1
        {
            get;
            set;
        }

        public bool IsShowCategory2
        {
            get;
            set;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _textTemplate = Text;

            FillTitle();
            FillGrid();

            tsmViewCategory1.PerformClick();
            tsmViewCategory2.PerformClick();
        }

        private void dgvItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvItems.Rows[e.RowIndex];
            int employeeID = (int)row.Tag;

            PaymentsForm.Execute(this, employeeID, ShowYear, ShowMonth);

            FillGrid();
        }

        private void tsmViewCategory1_Click(object sender, EventArgs e)
        {
            IsShowCategory1 = tsmViewCategory1.Checked;

            FillGrid();
        }

        private void tsmViewCategory2_Click(object sender, EventArgs e)
        {
            IsShowCategory2 = tsmViewCategory2.Checked;

            FillGrid();
        }

        private void tsmPaymentsCreate_Click(object sender, EventArgs e)
        {
            bool isPeriodFilled = false;

            using (var context = new DataClassesDataContext())
            {
                var period = GetPeriod(context);
                isPeriodFilled = period.PaymentEmployees.Count > 0;
            }

            if (!isPeriodFilled || MessageBox.Show(this, "Начисления по периоду уже сформированны.\r\nВы хотите попробовать добавить сотрудников,\r\nотсутствующих в назначении?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                int added = 0;
                using (var context = new DataClassesDataContext())
                {
                    added = CalcHelper.MakePayments(context, ShowYear, ShowMonth);
                }

                FillGrid();

                if (added > 0)
                {
                    MessageBox.Show(this, string.Format("Добавленно сотрудников: {0}", added), "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(this, "Сотрудников без назначений не найденно", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void tsmIntervalCustom_Click(object sender, EventArgs e)
        {
            short year = ShowYear;
            byte month = ShowMonth;

            if (ChoosePeriodForm.Execute(this, ref year, ref month))
            {
                ShowYear = year;
                ShowMonth = month;

                FillTitle();
                FillGrid();
            }
        }

        private void tsmInterval_DropDownOpening(object sender, EventArgs e)
        {
            var today = DateTime.Today;
            bool isToday = today.Year == ShowYear && today.Month == ShowMonth;
            tsmIntervalCurrent.Checked = isToday;
            tsmIntervalCustom.Checked = !isToday;
        }

        private void tsmIntervalCurrent_Click(object sender, EventArgs e)
        {
            var today = DateTime.Today;
            ShowMonth = (byte)today.Month;
            ShowYear = (short)today.Year;

            FillTitle();
            FillGrid();
        }
    }
}