using System.Collections.Generic;
using System.Linq;

namespace ZpProject.Classes
{
    internal static class CalcHelper
    {
        public static decimal TotalSum(this IEnumerable<Payment> payments)
        {
            return payments.Sum(x => x.Value * (x.PaymentType.IsIncrement ?  1 : -1));
        }

        public static int MakePayments(DataClassesDataContext context, short year, byte month)
        {
            var period = context.PaymentPeriods.FirstOrDefault(x => x.Year == year && x.Month == month);
            if (period == null)
            {
                return 0;
            }

            var employees = context.Employees.Where(x => x.Status == Employee.StatusActive).Where(x => x.PaymentEmployees.Count(y => y.PaymentPeriodID == period.ID) == 0).ToArray();
            foreach (var employee in employees)
            {
                var paymentEmployee = new PaymentEmployee { EmployeeID = employee.ID, PaymentPeriodID = period.ID };
                context.PaymentEmployees.InsertOnSubmit(paymentEmployee);
            }

            context.SubmitChanges();

            return employees.Length;
        }
    }
}