using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OilManegment.PL.Forms
{
    public partial class FRM_Main : Form
    {


        private int panelwidth;
        bool iscollapsed = false;
        public FRM_Main()
        {
            InitializeComponent();
            panelwidth = panelleft.Width;
        }

        private void FRM_Main_Load(object sender, EventArgs e)
        {
            panel_high.Size = new Size(1153, 56 );
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Environment.Exit(0);
        }

        private void Btn_side_Click(object sender, EventArgs e)
        {
            if (iscollapsed == true)
            {
                panelleft.Width = panelwidth;
                iscollapsed = false;
                this.Refresh();
            }
            else
            {
                panelleft.Width = 64;
                iscollapsed = true;
                label5.Text = "iscollapsed " + iscollapsed + "panelwidth " + panelwidth;
                this.Refresh();

            }
        }

        private void Timertime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            int H = dt.Hour;
            int M = dt.Minute;
            int S = dt.Second;
            if (H == 00)
            { labeltime.Text = "0" + H.ToString() + ":" + M.ToString() + ":" + S.ToString() + " ص  "; }
            else if (H > 12)
            {
                H = H - 12;
                labeltime.Text = H.ToString() + ":" + M.ToString() + ":" + S.ToString() + " م  ";
            }
            else
            { labeltime.Text = H.ToString() + ":" + M.ToString() + ":" + S.ToString() + " ص "; }

            labeldate.Text = dt.ToString("dd / MM / yyyy");
            labelday.Text = dt.ToString("dddd");
        }



        private void panelHighDock(Panel currentPanel)
        {
            panelcontrols.Controls.Clear();
            foreach (Control X in panel_high.Controls)
            {
                X.Dock = DockStyle.None;
                X.Visible = false;
            }

            foreach (Control X in currentPanel.Controls)
            {
                X.Height = 47;
                X.Enabled = true;
            }
            currentPanel.Dock = DockStyle.Fill;
            currentPanel.Visible = true;
        }

        private void movesidepanel(Control btn)
        {
            Control containar = btn.Parent;
            foreach (Control X in containar.Controls)
            {
                X.Enabled = true;
            }
            btn.Enabled = false;

            panelside.Visible = true;
            panelside.Top = btn.Top;
            panelside.Height = btn.Height;
        }

    

        private void moveCurrentBtn(Button btn)
        {
            Control containar= btn.Parent;
            foreach (Control X in containar.Controls)
            {
                X.Height = 47;
                X.Enabled = true;
            }

            //btn.FlatAppearance.BorderSize = 0;

            btn.Height = panel_high.Height+10;
            btn.Enabled = false;

        }

        private void Btn_bills_Click(object sender, EventArgs e)
        {
            panelHighDock(panel_options_bills);
            movesidepanel(btn_bills);
        }

        private void Btn_main_Click(object sender, EventArgs e)
        {
            panelHighDock(panel_options_main);
            movesidepanel(btn_main);
        }

        private void Btn_dues_Click(object sender, EventArgs e)
        {
            panelHighDock(panel_options_dues);
            movesidepanel(btn_dues);
        }

        //private void Btn_products_Click(object sender, EventArgs e)
        //{
        //    panelHighDock(panel_options_managing_products_and_people_Click);
        //    movesidepanel(btn_products);
        //}



        private void Btn_productss_Click(object sender, EventArgs e)
        {
            panelHighDock(panel_options_managing_products_and_people_Click);
            movesidepanel(btn_managing_products_and_people);
        }

        private void Btn_managing_products_and_people_Click(object sender, EventArgs e)
        {
            panelHighDock(panel_options_managing_products_and_people_Click);
            movesidepanel(btn_managing_products_and_people);
        }
        private void Btn_calculation_Click(object sender, EventArgs e)
        {
            panelHighDock(panel_options_calculation);
            movesidepanel(btn_calculation);
        }

        private void Btn_usrs_Click(object sender, EventArgs e)
        {
            panelHighDock(panel_options_users);
            movesidepanel(btn_usrs);
        }

        private void Btn_data_Click(object sender, EventArgs e)
        {
            panelHighDock(panel_options_data);
            movesidepanel(btn_data);
        }

        private void Btn_settings_Click(object sender, EventArgs e)
        {
            panelHighDock(panel_options_settings);
            movesidepanel(btn_settings);
            panelcontrols.Controls.Clear();

        }

        //----------------------------------------------------------------

        private void addtocontrolspanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelcontrols.Controls.Clear();
            panelcontrols.Controls.Add(c);
        }


        private void Btn_squeez_oliv_Click(object sender, EventArgs e)
        {
            UserControls.Squeeze_Oliv Us_squeez_oliv = new UserControls.Squeeze_Oliv();
            addtocontrolspanel(Us_squeez_oliv);
            moveCurrentBtn(btn_squeez_oliv);
        }

        private void Btn_birin_Click(object sender, EventArgs e)
        {
            UserControls.Birin Us_birin = new UserControls.Birin();
            addtocontrolspanel(Us_birin);
            moveCurrentBtn(btn_birin);
        }

        private void Btn_reciving_movements_Click(object sender, EventArgs e)
        {
            UserControls.Receiving_Movements Us_reciving_move = new UserControls.Receiving_Movements();
            addtocontrolspanel(Us_reciving_move);
            moveCurrentBtn(btn_reciving_movements);
        }

        private void Btn_oil_delivery_details_Click(object sender, EventArgs e)
        {
            UserControls.Oil_Delivery_Details Us_oil_delivery = new UserControls.Oil_Delivery_Details();
            addtocontrolspanel(Us_oil_delivery);
            moveCurrentBtn(btn_oil_delivery_details);
        }

        private void Btn_receiving_movements_detils_Click(object sender, EventArgs e)
        {
            UserControls.Receiving_Movements_Details Us_reciving_movement_details = new UserControls.Receiving_Movements_Details();
            addtocontrolspanel(Us_reciving_movement_details);
            moveCurrentBtn(btn_receiving_movements_detils);
        }

        //bills
        private void Btn_sales_bills_Click(object sender, EventArgs e)
        {
            UserControls.Bills.Sales_Bills Us_sales_bills = new UserControls.Bills.Sales_Bills();
            addtocontrolspanel(Us_sales_bills);
            moveCurrentBtn(btn_sales_bills);
        }

        private void Btn_purchase_bills_Click(object sender, EventArgs e)
        {
            UserControls.Bills.Purchase_Bills Us_Purchase_Bills = new UserControls.Bills.Purchase_Bills();
            addtocontrolspanel(Us_Purchase_Bills);
            moveCurrentBtn(btn_purchase_bills);
        }

        private void Btn_sale_return_Click(object sender, EventArgs e)
        {
            UserControls.Bills.Sale_Return Us_sale_return = new UserControls.Bills.Sale_Return();
            addtocontrolspanel(Us_sale_return);
            moveCurrentBtn(btn_sale_return);
        }

        private void Btn_oil_purchase_bill_from_customers_Click(object sender, EventArgs e)
        {
            UserControls.Bills.Oil_Purchase_Bill_From_Customers Us_Purchase_Bill = new UserControls.Bills.Oil_Purchase_Bill_From_Customers();
            addtocontrolspanel(Us_Purchase_Bill);
            moveCurrentBtn(btn_oil_purchase_bill_from_customers);
        }

        private void Btn_customer_oil_sales_bill_Click(object sender, EventArgs e)
        {
            UserControls.Bills.Customer_Sales_Bill Us_Customer_Sales_Bill = new UserControls.Bills.Customer_Sales_Bill();
            addtocontrolspanel(Us_Customer_Sales_Bill);
            moveCurrentBtn(btn_customer_oil_sales_bill);
        }

        private void Btn_oil_delivery_bill_to_dealers_Click(object sender, EventArgs e)
        {
            UserControls.Bills.Oil_Delivery_Bill_To_Dealers Us_Oil_Delivery_Bill_To_Dealers = new UserControls.Bills.Oil_Delivery_Bill_To_Dealers();
            addtocontrolspanel(Us_Oil_Delivery_Bill_To_Dealers);
            moveCurrentBtn(btn_oil_delivery_bill_to_dealers);
        }

        //dues
        private void Btn_catch_receipt_Click(object sender, EventArgs e)
        {
            UserControls.Dues.Catch_Receipt Us_catch_receipt = new UserControls.Dues.Catch_Receipt();
            addtocontrolspanel(Us_catch_receipt);
            moveCurrentBtn(btn_catch_receipt);
        }

        private void Btn_payment_voucher_Click(object sender, EventArgs e)
        {
            UserControls.Dues.Payment_Voucher Us_payment_voucher = new UserControls.Dues.Payment_Voucher();
            addtocontrolspanel(Us_payment_voucher);
            moveCurrentBtn(btn_payment_voucher);

        }

        //managing_products_and_people
        private void Btn_products_Click(object sender, EventArgs e)
        {
            UserControls.Managing_Products_And_People.Products Us_products = new UserControls.Managing_Products_And_People.Products();
            addtocontrolspanel(Us_products);
            moveCurrentBtn(btn_products);

        }

        private void Btn_stores_Click_1(object sender, EventArgs e)
        {
            UserControls.Managing_Products_And_People.Stores Us_stores = new UserControls.Managing_Products_And_People.Stores();
            addtocontrolspanel(Us_stores);
            moveCurrentBtn(btn_stores);

        }

        private void Btn_customers_Click_1(object sender, EventArgs e)
        {
            UserControls.Managing_Products_And_People.Customers Us = new UserControls.Managing_Products_And_People.Customers();
            addtocontrolspanel(Us);
            moveCurrentBtn(btn_customers);

        }

        private void Btn_suppliers_Click_1(object sender, EventArgs e)
        {
            UserControls.Managing_Products_And_People.Suppliers Us = new UserControls.Managing_Products_And_People.Suppliers();
            addtocontrolspanel(Us);
            moveCurrentBtn(btn_suppliers);

        }

        private void Btn_merchants_Click(object sender, EventArgs e)
        {
            UserControls.Managing_Products_And_People.Merchants Us = new UserControls.Managing_Products_And_People.Merchants();
            addtocontrolspanel(Us);
            moveCurrentBtn(btn_merchants);

        }

        private void Btn_employees_Click(object sender, EventArgs e)
        {
            UserControls.Managing_Products_And_People.Employees Us = new UserControls.Managing_Products_And_People.Employees();
            addtocontrolspanel(Us);
            moveCurrentBtn(btn_employees);

        }

        //calculation
        private void Btn_expenses_Click(object sender, EventArgs e)
        {
            UserControls.Calculation.Expenses Us = new UserControls.Calculation.Expenses();
            addtocontrolspanel(Us);
            moveCurrentBtn(btn_expenses);
        }

        private void Btn_revenues_Click(object sender, EventArgs e)
        {
            UserControls.Calculation.Revenues Us = new UserControls.Calculation.Revenues();
            addtocontrolspanel(Us);
            moveCurrentBtn(btn_revenues);

        }

        private void Btn_treasury_Click(object sender, EventArgs e)
        {
            UserControls.Calculation.Treasury Us = new UserControls.Calculation.Treasury();
            addtocontrolspanel(Us);
            moveCurrentBtn(btn_treasury);

        }

        //----------------------------------menuItem


        private void البيرينToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Btn_birin_Click(sender,e);
        }

        private void عصرالزيتونToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Btn_squeez_oliv_Click(sender, e);
        }

        private void حركاتالاستلامToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Btn_reciving_movements_Click(sender, e);
        }

        private void تفاصيلتسليمالزيتللزبائنToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Btn_oil_delivery_details_Click(sender, e);
        }

        private void تفاصيلحركاتالاستلامToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Btn_receiving_movements_detils_Click(sender, e);
        }

        private void الرئيسيةToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Btn_main_Click(sender, e);
        }

        private void الفواتيرToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Btn_bills_Click(sender, e);
        }

        private void فاتورةالمبيعاتToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Btn_sales_bills_Click(sender, e);
        }

        private void المستحقاتToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Btn_dues_Click(sender, e);
        }

        private void إدارةالمنتجاتوالأشخاصToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Btn_managing_products_and_people_Click(sender, e);
        }

        private void الحساباتToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Btn_calculation_Click(sender, e);
        }

   
        //################################test


        //################################3

    }
}
