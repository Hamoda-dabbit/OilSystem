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
    public partial class Customer_Sales_Bill : UserControl
    {
        private PL.Forms.InternalForms.Select_customer frm_selctCustomer = new Forms.InternalForms.Select_customer();
        private PL.Forms.InternalForms.Select_employee frm_selectEmployee = new Forms.InternalForms.Select_employee();
        private PL.Forms.InternalForms.Select_merchant frm_select_merchant = new Forms.InternalForms.Select_merchant();

        public Customer_Sales_Bill()
        {
            InitializeComponent();
        }

        private void Btn_open_CustomerNameForm_Click(object sender, EventArgs e)
        {
            frm_selctCustomer.ShowDialog();
        }

        private void Btn_open_CustomerNameForm_Click_1(object sender, EventArgs e)
        {
            frm_selctCustomer.ShowDialog();
        }
        private void Btn_open_EmployeeForm_Click(object sender, EventArgs e)
        {
            frm_selectEmployee.ShowDialog();
        }

        private void Btn_open_MerchantNameForm_Click(object sender, EventArgs e)
        {
            frm_select_merchant.ShowDialog();
        }


    }
}
