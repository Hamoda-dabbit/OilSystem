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
    public partial class Oil_Delivery_Bill_To_Dealers : UserControl
    {
        private PL.Forms.InternalForms.Select_merchant frm_select_merchant = new Forms.InternalForms.Select_merchant(); 
        public Oil_Delivery_Bill_To_Dealers()
        {
            InitializeComponent();
        }

        private void Btn_open_MerchantNameForm_Click(object sender, EventArgs e)
        {
            frm_select_merchant.ShowDialog();
        }
    }
}
