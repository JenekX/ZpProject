using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ZpProject.Forms
{
    public partial class DepartmentsForm : Form
    {
        public static void Execute(IWin32Window owner)
        {
            using (var form = new DepartmentsForm())
            {
                form.ShowDialog(owner);
            }
        }

        public DepartmentsForm()
        {
            InitializeComponent();
        }
    }
}
