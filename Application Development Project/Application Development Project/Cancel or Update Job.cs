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
    public partial class Cancel_or_Update_Job : Form
    {
        public Cancel_or_Update_Job()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-AA823FE\\SQLEXPRESS;Initial Catalog=Connection;Integrated Security=True");
        private void lbl_CustomerName_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }



        private void btn_UPDATE_Click(object sender, EventArgs e)
        {
            //Collecting Form Values

            String JobID = txt_JobID.Text;
            String CustomerID = txt_CustomerID.Text;
            String CustomerName = txt_CustomerName.Text;
            string ProductName = txt_ProductName.Text;
            String ProductCategorey = cmb_ProductCategory.Text;
            string Quentity = txt_Quentity.Text;
            string ProductImage = pcb_Productimage.Text;
            String startLocation = txt_StartLocation.Text;
            string EndLocation = txt_EndLocation.Text;

            //validation


            if (JobID == "")
            { MessageBox.Show("Job ID Cannot be empty");

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
                    String query = "Update CustomerTabel values('" + txt_CustomerID.Text + "','" + txt_CustomerName.Text + "','" + txt_ProductName.Text + "','" + cmb_ProductCategory.Text + "','" + txt_Quentity.Text + "','" + pcb_Productimage.Text + "','" + txt_StartLocation.Text + "','" + txt_EndLocation.Text + "'where id ='" +txt_CustomerID + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    { MessageBox.Show("Updated Successfully"); }
                    con.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }



            }
           

        }
        private void Populate()
        {
            con.Open();
            string query = "Select * from CustomerTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);

            var ds = new DataSet();
            sda.Fill(ds);
            dgv_CancelorUpdatejob.DataSource = ds.Tables[0];
            con.Close();

        }
        private void btn_CANCEL_Click(object sender, EventArgs e)
        {

            //Collecting Form Values

            String JobID = txt_JobID.Text;
            String CustomerID = txt_CustomerID.Text;
            String CustomerName = txt_CustomerName.Text;
            string ProductName = txt_ProductName.Text;
            String ProductCategorey = cmb_ProductCategory.Text;
            string Quentity = txt_Quentity.Text;
            string ProductImage = pcb_Productimage.Text;
            String startLocation = txt_StartLocation.Text;
            string EndLocation = txt_EndLocation.Text;
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
    } }
