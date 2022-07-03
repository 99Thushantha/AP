using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace Application_Development_Project
{
    public partial class Create_New_Job : Form
    {
        public Create_New_Job()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-AA823FE\\SQLEXPRESS;Initial Catalog=Connection;Integrated Security=True");

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_SEND_Click(object sender, EventArgs e)
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


            //interact with tabel


            try
            {
                con.Open();
                String query = "insert into CustomerTabel values('" + txt_CustomerID.Text + "','" + txt_CustomerName.Text + "','" + txt_ProductName.Text + "','" + cmb_ProductCategory.Text + "','" + txt_Quentity.Text + "','" + pcb_Productimage.Text + "','" + txt_StartLocation.Text + "','" + txt_Endlocation.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void btn_CLEAR_Click(object sender, EventArgs e)
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

        private void btn_HOME_Click(object sender, EventArgs e)
        {
            try
            {
                admin_Dashboard obj = new admin_Dashboard(); //create Admin dashboard form object
                obj.Show(); //call Admin dashboard form
                this.Hide(); //hide current form
            }
            catch (Exception ex)
            {

            }

        }
    }
}
