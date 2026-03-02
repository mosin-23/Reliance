using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reliance
{
    public partial class BillForm : Form
    {
        Label lblbill;
        string p, pr;
        public BillForm(string pname,string price)
        {
            InitializeComponent();
            this.Text = "Billing Details";
      
            lblbill = new Label();
            lblbill.AutoSize = true;
            lblbill.Text = "Product:" + pname + " \n\n Bill Amount:" + price;
            lblbill.Font = new Font("Arial", 14, FontStyle.Bold);
            lblbill.Location = new Point(10, 10);
            p = pname;
            pr = price;

        }

        private void BillForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show(
               "Product :" + p,
               "\nPrice :" + pr +
               "\n Order Successful",
               MessageBoxButtons.OK);
            this.Controls.Add(lblbill);
        }
    }
}
