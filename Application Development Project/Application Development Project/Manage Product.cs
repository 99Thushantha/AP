using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Application_Development_Project
{
    public partial class Manage_Product : Form
    {
        public Manage_Product()
        {
            InitializeComponent();
        }

        SqlConnection con;

        private void cmb_ProductName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void Admin_Product_Load(object sender, EventArgs e)
        {
            try
            {
                DBString obj = new DBString();
                string conn = obj.GetConnection();
                con = new SqlConnection(conn);
               
            }
            catch(Exception ex)
            {

            }
        }

        private void btn_ADD_Click(object sender, EventArgs e)
        {
            // Collecting Form Values
            String ProductID = txt_ProductID.Text;
            String ProductName = txt_ProductName.Text;
            String ProductCategorey = cmb_ProductCategory.Text;
            String ProductImage = pcb_ProductImage.Text;
            String ProductPrice = txt_ProductPrice.Text;





            //validation

            if (ProductID == "")
            { MessageBox.Show("Product ID is Cannot be empty"); }
           else if (ProductName == "")
            { MessageBox.Show("Product Name cannot be Empty"); }
           else if (ProductCategorey == "")
            { MessageBox.Show("ProductCategorey cannot be Empty"); }
           else if (ProductImage == "")
            { MessageBox.Show("Product Image cannot be Empty"); }
           else if (ProductPrice == "")
            { MessageBox.Show("Product Price cannot be Empty"); }


            

            //interact with tabel
            try
            {
                con.Open();
                String query = "insert into ProductTabel (Product Name,ProductCategorey,Product Image,Product Price)values('" + txt_ProductName.Text + "','" + cmb_ProductCategory.Text + "',  '"+pcb_ProductImage.Text +"','"+txt_ProductPrice.Text+"'where id ='"+txt_ProductID+"')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Record Added Successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void Populate()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from ProductTable";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgv_ManageProduct.DataSource = dt;

            con.Close();


        }
        private void Manage_Product_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void btn_UPDATE_Click(object sender, EventArgs e)
        {
            //Collecting Form Values
            String ProductID = txt_ProductID.Text;
            String ProductName = txt_ProductName.Text;
            String ProductCategorey = cmb_ProductCategory.Text;
            String ProductImage = pcb_ProductImage.Text;
            String ProductPrice = txt_ProductPrice.Text;




            //validation

            if (ProductID == "")
            { MessageBox.Show("Product ID is Cannot be empty"); }
           else if (ProductName == "")
            { MessageBox.Show("Product Name cannot be Empty"); }
           else if (ProductCategorey == "")
            { MessageBox.Show("ProductCategorey cannot be Empty"); }
           else if (ProductImage == "")
            { MessageBox.Show("Product Image cannot be Empty"); }
           else if (ProductPrice == "")
            { MessageBox.Show("Product Price cannot be Empty"); }





            //interact with tabel
            try
            {
                con.Open();
                String query = "update ProductTabel (Product Name,ProductCategorey,Product Image,Product Price)values('" + txt_ProductName.Text + "','" + cmb_ProductCategory.Text + "',  '" + pcb_ProductImage.Text + "','" + txt_ProductPrice.Text + "',where id = '"+txt_ProductID+"')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Record Updated Successfully");
                Populate();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           



        }

        private void btn_DELETE_Click(object sender, EventArgs e)
        {     // Collecting Form Values

            String ProductID = txt_ProductID.Text;
            String ProductName = txt_ProductName.Text;
            String ProductCategorey = cmb_ProductCategory.Text;
            String ProductImage = pcb_ProductImage.Text;
            String ProductPrice = txt_ProductPrice.Text;



            //validation

            if (ProductID == "")
            { MessageBox.Show("Product ID is Cannot be empty"); }
           else if (ProductName == "")
            { MessageBox.Show("Product Name cannot be Empty"); }
           else if (ProductCategorey == "")
            { MessageBox.Show("ProductCategorey cannot be Empty"); }
           else if (ProductImage == "")
            { MessageBox.Show("Product Image cannot be Empty"); }
           else if (ProductPrice == "")
            { MessageBox.Show("Product Price cannot be Empty"); }


            //interact with tabel
            try
            {
                con.Open();
                String query = "delete ProductTabel (Product Name,ProductCategorey,Product Image,Product Price)values('" + txt_ProductName.Text + "','" + cmb_ProductCategory.Text + "',  '" + pcb_ProductImage.Text + "','" + txt_ProductPrice.Text + "',where id = '" + txt_ProductID + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Record Deleted Successfully");
                Populate();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           

        }

        private void btn_SEARCH_Click(object sender, EventArgs e)
        {   // Collecting Form Values

            String ProductID = txt_ProductID.Text;
            String ProductName = txt_ProductName.Text;
            String ProductCategorey = cmb_ProductCategory.Text;
            String ProductImage = pcb_ProductImage.Text;
            String ProductPrice = txt_ProductPrice.Text;

            //validation
            if (ProductID == "")
            { MessageBox.Show("Product ID is Cannot be empty"); }
            else if (ProductName == "")
            { MessageBox.Show("Product Name cannot be Empty"); }
           else  if (ProductCategorey == "")
            { MessageBox.Show("ProductCategorey cannot be Empty"); }
            else if (ProductImage == "")
            { MessageBox.Show("Product Image cannot be Empty"); }
            else if (ProductPrice == "")
            { MessageBox.Show("Product Price cannot be Empty"); }

            //interact with tabel
            try
            {
                con.Open();
                String query = "select * from ProductTabel where id ='" + txt_ProductID + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();

            
                Populate();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void btn_Home_Click(object sender, EventArgs e)
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
