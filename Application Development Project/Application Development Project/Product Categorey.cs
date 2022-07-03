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
    public partial class Product_Categorey : Form
    {
        public Product_Categorey()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-AA823FE\\SQLEXPRESS;Initial Catalog=Connection;Integrated Security=True");
        

                private void btn_ADD_Click(object sender, EventArgs e)
        {
                


                //Collecting Form Values

                String CategoreyID = txt_CategoreyID.Text;
            String CategoreyName = cmb_CategoryName.Text;
            String Description = txt_Description.Text;


            //Validation
            if (CategoreyID == "")
            { MessageBox.Show("Categorey ID is Cannot be empty"); }
            else if (CategoreyName == "")
            { MessageBox.Show("Categorey Name cannot be Empty"); }
            else if (Description == "")
            { MessageBox.Show("Description is Empty"); }

            if (CategoreyID != "" && CategoreyName != "")




                //interact with tabel
                try
                {
                con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into ProductCategoreyTabel(CategoreyName,Description)values('" + txt_CategoreyID.Text + "','" + cmb_CategoryName.Text + "','" + txt_Description.Text + "', where id ='"+txt_CategoreyID+"')";
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Record Added Successfully");

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message);
            }

            

        }
        private void Populate()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from ProductCategoreyTable";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgv_ProductCategorey.DataSource = dt;

            con.Close();
            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Product_Categorey_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void btn_UPDATE_Click(object sender, EventArgs e)
            {


                // Collecting form values

                String CategoreyID = txt_CategoreyID.Text;
            String CategoreyName = cmb_CategoryName.Text;
            String Description = txt_Description.Text;


            //Validation
            if (CategoreyID == "")
            { MessageBox.Show("Categorey ID is Cannot be empty"); }
            else if (CategoreyName == "")
            { MessageBox.Show("Categorey Name cannot be Empty"); }
            else if (Description == "")
            { MessageBox.Show("Description is Empty"); }

            if (CategoreyID != "" && CategoreyName != "")



                //interact with tabel
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update ProductCategoreyTabel set CategoreyName ='" + cmb_CategoryName.Text + "',Description ='" + txt_Description.Text + "', where id='"+txt_CategoreyID+"')";
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
        {
            // Collecting Form Values

            String CategoreyID = txt_CategoreyID.Text;
            String CategoreyName = cmb_CategoryName.Text;
            String Description = txt_Description.Text;

            //Validation
            if (CategoreyID == "")
            { MessageBox.Show("Categorey ID is Cannot be empty"); }
           else if (CategoreyName == "")
            { MessageBox.Show("Categorey Name cannot be Empty"); }
           else if (Description == "")
            { MessageBox.Show("Description is Empty"); }

            if (CategoreyID != "" && CategoreyName != "")

                //interact with tabel
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = " delete from ProductCategoreyTabel where id ='" + txt_CategoreyID +"' ";
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
        {
                

                // Collecting Form Values

                String CategoreyID = txt_CategoreyID.Text;
            String CategoreyName = cmb_CategoryName.Text;
            String Description = txt_Description.Text;

            //Validation
            if (CategoreyID == "")
            { MessageBox.Show("Categorey ID is Cannot be empty"); }
            else if (CategoreyName == "")
            { MessageBox.Show("Categorey Name cannot be Empty"); }
            else if (Description == "")
            { MessageBox.Show("Description is Empty"); }

            if (CategoreyID != "" && CategoreyName != "")

                //interact with tabel
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = " select * from ProductCategoreyTabel where id ='" + txt_CategoreyID + "' ";
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
