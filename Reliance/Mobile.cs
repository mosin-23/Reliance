using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reliance
{
    public partial class Mobile : Form
    {
        SqlConnection sq;
        SqlDataAdapter dp;
        SqlCommandBuilder cd;
        DataTable dt;
        string con = "Data Source=localhost\\sqlexpress;Initial Catalog=Demo;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        string selectedCategory;
           
        public Mobile(string category)
        {
            InitializeComponent();
            sq = new SqlConnection(con);
            selectedCategory = category;

        }

        private void Mobile_Load(object sender, EventArgs e)
        {
            sq.Open();
            dp = new SqlDataAdapter("select * from product where category=@cat", sq);
            dp.SelectCommand.Parameters.AddWithValue("@cat", selectedCategory);
            cd = new SqlCommandBuilder(dp);
            dt = new DataTable();
            dp.Fill(dt);

            foreach(DataRow row in dt.Rows)
            {
                Panel card = new Panel();
                card.Width = 300;
                card.Height = 150;
                card.BorderStyle = BorderStyle.FixedSingle;
                card.Margin=new Padding(10);
                Label lbname=new Label();
                lbname.Text = row["pname"].ToString();
                lbname.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold);
                lbname.Location = new Point(10, 10);

                Label lbdesc = new Label();
                lbdesc.Text = row["pdesc"].ToString();
                lbdesc.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold);
                lbdesc.Location = new Point(10, 35);
                lbdesc.Size = new Size(180, 50);
                lbdesc.ForeColor = Color.DarkOrange;

                Label lbcat = new Label();
                lbcat.Text ="Category :"+ row["category"].ToString();
                lbcat.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold);
                lbcat.Location = new Point(10, 80);
                lbcat.Width = 150;
                lbcat.Height = 27;
                lbcat.BackColor = Color.CornflowerBlue;
                lbcat.ForeColor = Color.White;

                Button btnprice = new Button();
                btnprice.Text="$"+ row["price"].ToString();
                btnprice.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold);
                btnprice.Location = new Point(10, 110);
                btnprice.Width = 120;
                btnprice.Height = 30;
                btnprice.BackColor = Color.Green;
                btnprice.ForeColor = Color.White;

                string pname=row["pname"].ToString();
                string price = row["price"].ToString();

                btnprice.Click += (s, ev) =>
                {
                    BillForm bill = new BillForm(pname, price);
                    bill.Show();
                };

                card.Controls.Add(lbname);
                card.Controls.Add(lbdesc);
                card.Controls.Add(lbcat);
                card.Controls.Add(btnprice);
                flowLayoutPanel1.Controls.Add(card);



            }


        }
    }
}
