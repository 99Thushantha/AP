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
    
    public partial class Admin_Login : Form
    {
        private SqlConnection con;
        private SqlDataAdapter da;
        public Admin_Login()
        {
            InitializeComponent();
        }
        

        private void btn_Login_Click(object sender, EventArgs e)
        { 

            //Read from value
            
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
                    da = new SqlDataAdapter("select username,password from AdminTable where username ='" + txt_UserName.Text + "' and password = '" + txt_Paasword.Text + "' ", con);
                    DataTable tt = new DataTable();
                    da.Fill(tt);
                    if (tt.Rows.Count == 1)
                    {

                        con.Close();
                        this.Hide();
                        admin_Dashboard obj = new admin_Dashboard();
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
            {
                try
                {
                    Admin_Register obj = new Admin_Register(); //create registration form object
                    obj.Show(); //call registration form
                    this.Hide(); //hide current form
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {

        }

        private void label_1_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Login_Load(object sender, EventArgs e)
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
    }
   
        

        }
    


