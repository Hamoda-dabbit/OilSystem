using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OilManegment.PL.UserControls.Bills
{
    public partial class Oil_Purchase_Bill_From_Customers : UserControl
    {
        private PL.Forms.InternalForms.Select_customer frm_selctClient = new Forms.InternalForms.Select_customer();
        private PL.Forms.InternalForms.Select_employee frm_selectEmployee = new Forms.InternalForms.Select_employee();
        private PL.Forms.InternalForms.Select_store frm_selectStore = new Forms.InternalForms.Select_store();
        public Oil_Purchase_Bill_From_Customers()
        {
            InitializeComponent();
        }

        private void Btn_open_CustomerNameForm_Click(object sender, EventArgs e)
        {
            frm_selctClient.ShowDialog();
        }

        private void Btn_open_EmployeeForm_Click(object sender, EventArgs e)
        {
            frm_selectEmployee.ShowDialog();
        }

        private void Btn_open_StoreForm_Click(object sender, EventArgs e)
        {
            frm_selectStore.ShowDialog();
        }
    }
}
