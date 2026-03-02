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
    public partial class Form2 : Form
    {
       
       

        public Form2()
        {
            InitializeComponent();
             
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Mobile m = new Mobile("Laptop");
            m.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Mobile m= new Mobile("Electronics");
            m.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Mobile m = new Mobile("Music");
            m.Show();
        }
    }
}
