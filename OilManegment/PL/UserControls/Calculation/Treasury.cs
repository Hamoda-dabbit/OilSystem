using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OilManegment.PL.UserControls.Calculation
{
    public partial class Treasury : UserControl
    {
        private PL.Forms.InternalForms.Select_employee frm_selectEmployee = new Forms.InternalForms.Select_employee();

        public Treasury()
        {
            InitializeComponent();
        }

        private void Btn_open_EmployeeForm_Click(object sender, EventArgs e)
        {
            frm_selectEmployee.ShowDialog();

        }
    }
}
