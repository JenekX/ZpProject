using System;
using ZpProject.Classes;

namespace ZpProject
{
    public partial class Employee
    {
        public const byte StatusActive = 0;
        public const byte StatusDecree = 1;
        public const byte StatusDismiss = 2;

        public string CategoryName
        {
            get
            {
                switch (Category)
                {
                    case 1:
                        return "Категория 1";
                    case 2:
                        return "Категория 2";
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }
    }

    public partial class PaymentType
    {
        public override string ToString()
        {
            return Name;
        }
    }

    public partial class PaymentPeriod
    {
        public override string ToString()
        {
            return UIHelper.PeriodToString(Year, Month, true);
        }
    }
}