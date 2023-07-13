using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OilManegment.PL.UserControls.Managing_Products_And_People
{
    public partial class Stores : UserControl
    {
        public Stores()
        {
            InitializeComponent();
        }

        private void Btn_refresh_Click(object sender, EventArgs e)
        {
            txtName.Text = label27.ForeColor.ToString();
        }
    }
}
