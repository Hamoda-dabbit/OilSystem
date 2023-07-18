using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OilManegment.PL.UserControls.Dues
{
    public partial class Catch_Receipt : UserControl
    {
        private PL.Forms.InternalForms.Select_customer frm_selctCustomer = new Forms.InternalForms.Select_customer();
        private PL.Forms.InternalForms.Select_store frm_selectStore = new Forms.InternalForms.Select_store();

        public Catch_Receipt()
        {
            InitializeComponent();
        }

        private void Btn_open_CustomerNameForm_Click(object sender, EventArgs e)
        {
            frm_selctCustomer.ShowDialog();
        }

        private void Btn_open_StoreForm_Click(object sender, EventArgs e)
        {
            frm_selectStore.ShowDialog();
        }
    }
}
