using System;
using System.Linq;
using System.Windows.Forms;

namespace ZpProject.Forms
{
    public partial class PaymentForm : Form
    {
        private int _paymentID;
        private int _paymentEmployeeID;

        private void FillTypes(DataClassesDataContext context)
        {
            cmbType.Items.Clear();
            
            foreach (var paymentType in context.PaymentTypes)
            {
                cmbType.Items.Add(paymentType);
            }

            if (cmbType.Items.Count > 0)
            {
                cmbType.SelectedIndex = 0;
            }
        }

        private int GetIndexOfPaymentType(int paymentTypeID)
        {
            int result = 0;
            var items = cmbType.Items.OfType<PaymentType>();
            foreach (var item in items)
            {
                if (item.ID == paymentTypeID)
                {
                    return result;
                }

                result++;
            }

            return -1;
        }

        private PaymentType GetSelectedPaymentType()
        {
            return cmbType.SelectedItem as PaymentType;
        }

        private int GetSelectedPaymentTypeID()
        {
            var type = GetSelectedPaymentType();

            return type != null ? type.ID : -1;
        }

        public static bool Execute(IWin32Window owner, int paymentID, int paymentEmployeeID)
        {
            using (var form = new PaymentForm())
            {
                return form.Initialize(paymentID, paymentEmployeeID) && form.ShowDialog(owner) == DialogResult.OK;
            }
        }

        public PaymentForm()
        {
            InitializeComponent();
        }

        public bool Initialize(int paymentID, int paymentEmployeeID)
        {
            _paymentID = paymentID;
            _paymentEmployeeID = paymentEmployeeID;

            Text = string.Format(Text, _paymentID == -1 ? "Добавление" : "Редактирование");

            using (var context = new DataClassesDataContext())
            {
                FillTypes(context);

                if (_paymentID != -1)
                {
                    var payment = context.Payments.FirstOrDefault(x => x.ID == _paymentID);
                    if (payment == null)
                    {
                        return false;
                    }

                    cmbType.SelectedIndex = GetIndexOfPaymentType(payment.PaymentTypeID);
                    nudValue.Value = payment.Value;
                }
            }

            return true;
        }

        private void BtnOkClick(object sender, EventArgs e)
        {
            using (var context = new DataClassesDataContext())
            {
                Payment payment;

                if (_paymentID == -1)
                {
                    payment = new Payment { PaymentEmployeeID = _paymentEmployeeID };
                    context.Payments.InsertOnSubmit(payment);
                }
                else
                {
                    payment = context.Payments.FirstOrDefault(x => x.ID == _paymentID);
                    if (payment == null)
                    {
                        DialogResult = DialogResult.Cancel;
                        return;
                    }
                }

                payment.PaymentTypeID = GetSelectedPaymentTypeID();
                payment.Value = nudValue.Value;

                context.SubmitChanges();
            }
        }
    }
}