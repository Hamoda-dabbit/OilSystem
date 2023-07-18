﻿using System;
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
    public partial class Oil_Delivery_Details : UserControl
    {
        private PL.Forms.InternalForms.Select_movement frm_selectMovement = new Forms.InternalForms.Select_movement();
        private PL.Forms.InternalForms.Select_customer frm_selctClient = new Forms.InternalForms.Select_customer();

        public Oil_Delivery_Details()
        {
            InitializeComponent();
        }

        private void Btn_open_CustomerNameForm_Click(object sender, EventArgs e)
        {
            frm_selctClient.ShowDialog();

        }

        private void Btn_open_movementNumberForm_Click(object sender, EventArgs e)
        {
            frm_selectMovement.ShowDialog();
        }
    }
}
