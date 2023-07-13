using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OilManegment.SHARED
{
    class Style_Form_Class
    {
        void set_size_form(Control containar)
        {
            foreach (Control X in containar.Controls)
            {
                X.Dock = DockStyle.None;
                X.Visible = false;
            }
        }
        private void resize(Control containar)
        {
            int oldWidth = 1366;
            int oldHeight = 768;
            foreach (Control X in containar.Controls)
            {
                X.Width = X.Width * containar.Width / oldWidth;
                X.Height = X.Height * containar.Height / oldHeight;

                int x = X.Location.X * containar.Width / oldWidth;
                int y = X.Location.Y * containar.Height / oldHeight;
                X.Location = new Point(x, y);
                float fontSize = X.Font.Size * containar.Width / oldWidth;
                X.Font = new Font("Tahoma", fontSize);

            }
        }
    }
}
