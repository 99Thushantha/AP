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

namespace Application_Development_Project
{
    public partial class Customer_login : Form
    {
        public Customer_login()
        {
            InitializeComponent();
        }

        SqlDataAdapter da;
        private SqlConnection con;
        private void Customer_login_Load(object sender, EventArgs e)
        {
             try
            {
                DBString obj = new DBString();
                string conn = obj.GetConnection();
                con = new SqlConnection(conn);

            }
            catch (Exception ex)
            {

            }
        
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            //Read from values

            String UserName = txt_UserName.Text;
            String Password = txt_Paasword.Text;
            lbl_UN_error.Text = "";
            lbl_UN_errorPw.Text = "";


            //Validation

            if (UserName == "")
            {
                lbl_UN_error.Text = "Please Enter Your UserName.";
                lbl_UN_error.ForeColor = Color.Red;
                //MessageBox.Show("Please Enter Your UserName.");
            }
            else if (Password == "")
            {
                lbl_UN_errorPw.Text = "Please Enter Your Password.";
                lbl_UN_errorPw.ForeColor = Color.Red;
                //MessageBox.Show("Please Enter your Password.");
            }
            else
            {
                  try
                    {
                        con.Open();
                        da = new SqlDataAdapter("select CustomerUserName,CustomerPassword from CustomerTable where CustomerUserName ='" + txt_UserName.Text + "' and CustomerPassword = '" + txt_Paasword.Text + "' ", con);
                        DataTable tt = new DataTable();
                        da.Fill(tt);
                        if (tt.Rows.Count == 1)
                        {

                            con.Close();
                            this.Hide();
                            Customer_Dashboard obj = new Customer_Dashboard();
                            obj.ShowDialog();
                            this.Dispose();

                        }
                        else
                        {
                            MessageBox.Show("Incorrect login details", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                        }
                    }
                    catch (Exception exception)
                    {
                        con.Close();


                    }
                
              
            }


            
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            try
            {
                Customer_Registration obj = new Customer_Registration(); //create registration form object
                obj.Show(); //call registration form
                this.Hide(); //hide current form
            }
            catch(Exception ex)
            {
                
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {

        }

        private void label_1_Click(object sender, EventArgs e)
        {

        }

        private void txt_UserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
 }
