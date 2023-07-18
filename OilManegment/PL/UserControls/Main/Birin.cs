using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OilManegment.PL.UserControls
{
    public partial class Birin : UserControl
    {
        private PL.Forms.InternalForms.Select_customer frm_selctClient = new Forms.InternalForms.Select_customer();
        public Birin()
        {
            InitializeComponent();
        }


        private void Btn_open_customerNameForm_Click(object sender, EventArgs e)
        {
            frm_selctClient.ShowDialog();
        }
    }
}
