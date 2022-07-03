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
    public partial class Manage_Customer_Details : Form
    {
        public Manage_Customer_Details()
        {
            InitializeComponent();
        }

        private SqlConnection con;
        private SqlCommand cmd;


        private void btn_ADD_Click(object sender, EventArgs e)
        {

            //Collecting Form Values

            String CustomerID = txt_CustomerID.Text;
            String CustomerName = txt_CustomerName.Text;
            String CustomerContacNo = txt_CustomerContacNo.Text;
            string CustomerEmail = txt_CustomerEmail.Text;
            string CustomerAddrass = txt_CustomerAddress.Text;


            //Validation

            if (CustomerID == "")
            { MessageBox.Show("Customer ID Cannot be empty"); }
            if (CustomerName == "")
            { MessageBox.Show("Customer Name cannot be Empty"); }
            if (CustomerContacNo == "")
            { MessageBox.Show("Customer Contac No Cannot be Empty"); }
            if (CustomerEmail == "")
            { MessageBox.Show(" Customer Email Cannot be Empty"); }
            if (CustomerAddrass == "")
            { MessageBox.Show(" Customer Addrass Cannot be Empty"); }


            //interact with tabel
            try
            {
               /* con.Open();
                cmd = new SqlCommand("INSERT INTO CustomerTable([CustomerName],[CustomerContacNo],[CustomerEmail],[CustomerAddress],[CustomerUserName],[CustomerPassword]) VALUES ('" + txt_FullName.Text + "','" + txt_PhoneNumber.Text + "','" + txt_Email.Text + "','" + txt_Address.Text + "','" + txt_UserName.Text + "','" + txt_Password.Text + "') ", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registration Success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                Customer_login obj = new Customer_login();
                obj.Show();
                this.Hide();*/

            }
            catch (Exception ex)
            {
                con.Close();


            }




        }


        private void btn_UPDATE_Click(object sender, EventArgs e)
        {
            //Collecting Form Values

            String CustomerID = txt_CustomerID.Text;
            String CustomerName = txt_CustomerName.Text;
            String CustomerContacNo = txt_CustomerContacNo.Text;
            string CustomerEmail = txt_CustomerEmail.Text;
            string CustomerAddrass = txt_CustomerAddress.Text;


            //Validation

            if (CustomerID == "")
            { MessageBox.Show("Customer ID Cannot be empty"); }
            if (CustomerName == "")
            { MessageBox.Show("Customer Name cannot be Empty"); }
            if (CustomerContacNo == "")
            { MessageBox.Show("Customer Contac No Cannot be Empty"); }
            if (CustomerEmail == "")
            { MessageBox.Show(" Customer Email Cannot be Empty"); }
            if (CustomerAddrass == "")
            { MessageBox.Show(" Customer Addrass Cannot be Empty"); }



            //interact with tabel
            try
            {
                con.Open();
                String query = "Update CustomerTabel values('" + txt_CustomerName.Text + "','" + txt_CustomerContacNo.Text + "','" + txt_CustomerEmail.Text + "','" + txt_CustomerAddress.Text + "'where id ='" + txt_CustomerID + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                { MessageBox.Show("Customer Updated Successfully"); }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void btn_DELETE_Click(object sender, EventArgs e)
        {
            //Collecting Form Values

            String CustomerID = txt_CustomerID.Text;
            String CustomerName = txt_CustomerName.Text;
            String CustomerContacNo = txt_CustomerContacNo.Text;
            string CustomerEmail = txt_CustomerEmail.Text;
            string CustomerAddrass = txt_CustomerAddress.Text;


            //interact with tabel

            try
            {
                con.Open();
                String query = "Delete CustomerTabel values('" + txt_CustomerName.Text + "','" + txt_CustomerContacNo.Text + "','" + txt_CustomerEmail.Text + "','" + txt_CustomerAddress.Text + "'where id ='" + txt_CustomerID.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                { MessageBox.Show("Customer Deleted Successfully"); }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_SEARCH_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_CustomerID.Text != "")
                {
                    dgv_CustomerDetails.DataSource = null;
                    PopulateCustomer(txt_CustomerID.Text);
               

                }
                else
                {
                    PopulateCustomer("%");
                }
            }
            catch (Exception exception)
            {

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
        private void PopulateCustomer(String para)
        {
            try
            {
                con.Open();
                string query = "Select [CustomerID],[CustomerName],[CustomerContacNo],[CustomerEmail],[CustomerAddress],[CustomerUserName] from CustomerTable where CustomerID LIKE '"+para+ "' OR CustomerUserName LIKE '" + para + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);

                var ds = new DataSet();
                sda.Fill(ds);
                dgv_CustomerDetails.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                //throw;
            }

        }

        private void Manage_Customer_Details_Load(object sender, EventArgs e)
        {
            
            try
            {
                DBString obj = new DBString();
                string conn = obj.GetConnection();
                con = new SqlConnection(conn);
                PopulateCustomer("%");

            }
            catch (Exception ex)
            {

            }
        }

        private void lbl_CustomerID_Click(object sender, EventArgs e)
        {

        }
    }
}

