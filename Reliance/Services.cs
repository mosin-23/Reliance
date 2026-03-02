using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reliance
{
    public partial class Services : Form
    {
        public Services()
        {
            InitializeComponent();
            Label lbl1 = new Label();
            lbl1.Text = "✔ 1 Year Warranty on Electronics";
            lbl1.AutoSize = true;
            lbl1.Location = new Point(20, 30);

            Label lbl2 = new Label();
            lbl2.Text = "✔ Free Home Delivery above ₹1000";
            lbl2.AutoSize = true;
            lbl2.Location = new Point(20, 60);

            Label lbl3 = new Label();
            lbl3.Text = "✔ 7 Day Easy Return Policy";
            lbl3.AutoSize = true;
            lbl3.Location = new Point(20, 90);

            Label lbl4 = new Label();
            lbl4.Text = "✔ Genuine Products Guarantee";
            lbl4.AutoSize = true;
            lbl4.Location = new Point(20, 120);

            Label lbl5 = new Label();
            lbl5.Text = "✔ 24/7 Customer Support";
            lbl5.AutoSize = true;
            lbl5.Location = new Point(20, 150);

            groupBox1.Controls.Add(lbl1);
            groupBox1.Controls.Add(lbl2);
            groupBox1.Controls.Add(lbl3);
            groupBox1.Controls.Add(lbl4);
            groupBox1.Controls.Add(lbl5);
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
