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
    public partial class Manage_Job : Form
    {
        public Manage_Job()
        {
            InitializeComponent();
        }

        private void btn_UPDATE_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Quentity_Click(object sender, EventArgs e)
        {

        }

        private void btn_Accept_Click(object sender, EventArgs e)
        {
               //Collecting Form Values


            String CustomerID = txt_CustomerID.Text;
            String CustomerName = txt_CustomerName.Text;
            string ProductName = txt_ProductName.Text;
            String ProductCategorey = cmb_ProductCategory.Text;
            string Quentity = txt_Quentity.Text;
            string ProductImage = pcb_Productimage.Text;
            String startLocation = txt_StartLocation.Text;
            string EndLocation = txt_Endlocation.Text;


            //validation

            if (CustomerID == "")
            { MessageBox.Show("Customer ID Cannot be empty"); }
            if (CustomerName == "")
            { MessageBox.Show("Customer Name cannot be Empty"); }
            if (ProductName == "")
            { MessageBox.Show("Product Name Cannot be Empty"); }
            if (ProductCategorey == "")
            { MessageBox.Show("Product Categorey Cannot be Empty"); }
            if (Quentity == "")
            { MessageBox.Show("Quentity Cannot be Empty"); }
            if (ProductImage == "")
            { MessageBox.Show("Product Image Cannot be Empty"); }
            if (startLocation == "")
            { MessageBox.Show("start Location Cannot be Empty"); }
            if (EndLocation == "")
            { MessageBox.Show("End Location Cannot be Empty"); }


        }

        private void btn_Decline_Click(object sender, EventArgs e)
        {
            //Collecting Form Values


            String CustomerID = txt_CustomerID.Text;
            String CustomerName = txt_CustomerName.Text;
            string ProductName = txt_ProductName.Text;
            String ProductCategorey = cmb_ProductCategory.Text;
            string Quentity = txt_Quentity.Text;
            string ProductImage = pcb_Productimage.Text;
            String startLocation = txt_StartLocation.Text;
            string EndLocation = txt_Endlocation.Text;
        }
    }
}
