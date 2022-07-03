using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_Development_Project
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void btn_Admin_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    Admin_Login obj = new Admin_Login(); //create Login form object
                    obj.Show(); //call Login form
                    this.Hide(); //hide current form
                }
                catch (Exception ex)
                {

                }

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    Customer_login obj = new Customer_login(); //create Login form object
                    obj.Show(); //call Login form
                    this.Hide(); //hide current form
                }
                catch (Exception ex)
                {

                }

            }
        }
    }
}
