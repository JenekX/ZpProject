using System;
using System.Linq;
using System.Windows.Forms;
using ZpProject.Classes;

namespace ZpProject.Forms
{
    public partial class PaymentsForm : Form
    {
        private int _paymentEmployeeID;

        private void FillItems(DataClassesDataContext context)
        {
            dgvItems.Rows.Clear();

            var payments = context.Payments.Where(x => x.PaymentEmployeeID == _paymentEmployeeID).Select(x => new { x.ID, Type = string.Format("{0} ({1})", x.PaymentType.Name, x.PaymentType.Code), x.Value });
            foreach (var payment in payments)
            {
                var row = new DataGridViewRow();
                row.CreateCells(dgvItems, payment.Type, payment.Value);
                row.Tag = payment.ID;

                dgvItems.Rows.Add(row);
            }
        }

        private int GetSelectedIndex()
        {
            return dgvItems.SelectedRows.Count > 0 ? dgvItems.SelectedRows[0].Index : -1;
        }

        private int GetSelectedPaymentID()
        {
            int index = GetSelectedIndex();

            return index != -1 ? (int)dgvItems.Rows[index].Tag : -1;
        }

        private void RefreshUI()
        {
            btnRemove.Enabled = btnEdit.Enabled = cmsMenuRemove.Enabled = cmsMenuEdit.Enabled = GetSelectedIndex() != -1;
        }

        private void RefreshGrid()
        {
            using (var context = new DataClassesDataContext())
            {
                FillItems(context);
                RefreshUI();
            }
        }

        public static void Execute(IWin32Window owner, int employeeID, short year, byte month)
        {
            using (var form = new PaymentsForm())
            {
                form.Initialize(employeeID, year, month);
                form.ShowDialog(owner);
            }
        }

        public PaymentsForm()
        {
            InitializeComponent();
        }

        public bool Initialize(int employeeID, short year, byte month)
        {
            using (var context = new DataClassesDataContext())
            {
                var paymentEmployee = context.PaymentEmployees.FirstOrDefault(x => x.EmployeeID == employeeID && x.PaymentPeriod.Year == year && x.PaymentPeriod.Month == month);
                if (paymentEmployee == null)
                {
                    return false;
                }

                _paymentEmployeeID = paymentEmployee.ID;

                Text = string.Format(Text, paymentEmployee.Employee.FIO, UIHelper.PeriodToString(year, month));

                FillItems(context);
                RefreshUI();

                return true;
            }
        }

        private void DgvItemsSelectionChanged(object sender, EventArgs e)
        {
            RefreshUI();
        }

        private void DgvItemsCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnEditClick(sender, null);
        }

        private void DgvItemsKeyUp(object sender, KeyEventArgs e)
        {
            UIHelper.CollectionKeyUp(sender, e, BtnAddClick, BtnRemoveClick, BtnEditClick);
        }

        private void BtnAddClick(object sender, EventArgs e)
        {
            if (PaymentForm.Execute(this, -1, _paymentEmployeeID))
            {
                RefreshGrid();
                RefreshUI();
            }
        }

        private void BtnRemoveClick(object sender, EventArgs e)
        {
            int paymentID = GetSelectedPaymentID();
            if (paymentID == -1)
            {
                return;
            }

            if (MessageBox.Show(this, "Вы действительно хотите удалить запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                using (var context = new DataClassesDataContext())
                {
                    var payment = context.Payments.FirstOrDefault(x => x.ID == paymentID);
                    if (payment != null)
                    {
                        context.Payments.DeleteOnSubmit(payment);
                        context.SubmitChanges();

                        FillItems(context);
                        RefreshUI();
                    }
                }
            }
        }

        private void BtnEditClick(object sender, EventArgs e)
        {
            int paymentID = GetSelectedPaymentID();
            if (paymentID == -1)
            {
                return;
            }

            if (PaymentForm.Execute(this, paymentID, _paymentEmployeeID))
            {
                RefreshGrid();
                RefreshUI();
            }
        }
    }
}