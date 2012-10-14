using System;
using System.Windows.Forms;

namespace ZpProject.Classes
{
    internal class UIHelper
    {
        public static readonly string[] Months = new[] { "январь", "февраль", "март", "апрель", "май", "июнь", "июль", "август", "сентябрь", "октябрь", "ноябрь", "декабрь" };

        public static string CategoryToString(int category)
        {
            switch (category)
            {
                case 1:
                    return "Категория 1";
                case 2:
                    return "Категория 2";
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public static string PeriodToString(short year, byte month, bool isMonthLarge)
        {
            if (month < 1 || month > 12)
            {
                throw new ArgumentOutOfRangeException("month");
            }

            string result = string.Format("{0} {1}", Months[month - 1], year);
            
            if (isMonthLarge)
            {
                return result.Substring(0, 1).ToUpper() + result.Substring(1);
            }

            return result;
        }

        public static string PeriodToString(short year, byte month)
        {
            return PeriodToString(year, month, false);
        }

        public static void CollectionKeyUp(object sender, KeyEventArgs args, EventHandler add, EventHandler remove, EventHandler edit)
        {
            if (args.Modifiers == Keys.None)
            {
                switch (args.KeyCode)
                {
                    case Keys.Insert:
                        if (add != null)
                        {
                            add(sender, null);
                        }
                        break;
                    case Keys.Delete:
                        if (remove != null)
                        {
                            remove(sender, null);
                        }
                        break;
                    case Keys.Return:
                        if (edit != null)
                        {
                            edit(sender, null);
                        }
                        break;
                }

                args.Handled = args.KeyCode == Keys.Insert || args.KeyCode == Keys.Delete || args.KeyCode == Keys.Return;
            }
        }
    }
}