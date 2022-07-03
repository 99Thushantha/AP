using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_Development_Project
{
    public partial class Customer_Registration : Form
    {
        public Customer_Registration()
        {
            InitializeComponent();
        }

        private SqlConnection con;
        private SqlCommand cmd;
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private string InputValidation()
        {
            try
            {
                if (String.IsNullOrEmpty(txt_FullName.Text))
                {
                    return "Full Name can't empty";
                }
                else if (String.IsNullOrEmpty(txt_UserName.Text))
                {
                    return "Username can't empty";
                }
                else if (String.IsNullOrEmpty(txt_Password.Text))
                {
                    return "Password can't empty";
                }
                else if (String.IsNullOrEmpty(txt_ConfirmPassword.Text))
                {
                    return "Confirm Password can't empty";
                }
                else if (String.IsNullOrEmpty(txt_Email.Text))
                {
                    return "Email can't empty";
                }

                else if (String.IsNullOrEmpty(txt_Address.Text))
                {
                    return "Address can't empty";
                }
                else if (String.IsNullOrEmpty(txt_PhoneNumber.Text))
                {
                    return "Phone can't empty";
                }
                else if (!rbl_Female.Checked && !rbl_Male.Checked)
                {
                    return "Please select gender";
                }
                else if (txt_PhoneNumber.Text.ToString().Length != 10)
                {
                    return "Invalide Phone Number";
                }
                DateTime date = Convert.ToDateTime(dateTimePicker1.Text);
                string dd = (date.ToString("dd/MM/yyyy"));
                DateTime DOB = DateTime.ParseExact(dd, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                if (DOB >= DateTime.Today)
                {
                    return "Invalide Birthday";
                }
                else if (!chk_terms.Checked)
                {
                    return "Please Agreee to the Terms and Conditions";
                }

                return "";
            }

            catch (Exception ex)
            {
                return "Something wrong please try again";
            }

        }
        private void btn_Register_Click(object sender, EventArgs e)
        {

            String Error = InputValidation();
            String isEmailValid = null;
            if (Error != "")
            {
                MessageBox.Show(Error, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Error = null;
            }
            else if (!String.IsNullOrEmpty(txt_Email.Text))
            {
                try
                {
                    MailAddress mm = new MailAddress(txt_Email.Text); isEmailValid = "valid";
                }
                catch (FormatException ex)
                {
                    isEmailValid = null; MessageBox.Show("Invalid Email", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (!String.IsNullOrEmpty(txt_ConfirmPassword.Text) && !String.IsNullOrEmpty(txt_Password.Text) && isEmailValid != null)
            {
                if (txt_Password.Text.ToString() == txt_ConfirmPassword.Text.ToString())
                {
                    CustomerRegister();
                }
                else
                {
                    MessageBox.Show("Passsword not matched", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void CustomerRegister()
        {
            try
            {
                string Gender;
                if (rbl_Male.Checked)
                {
                    Gender = "Male";
                }
                else
                {
                    Gender = "Female";
                }

                con.Open();
                cmd = new SqlCommand("INSERT INTO CustomerTable([CustomerName],[CustomerContacNo],[CustomerEmail],[CustomerAddress],[CustomerUserName],[CustomerPassword],[DOB],[Gender]) VALUES ('"+txt_FullName.Text+"','"+txt_PhoneNumber.Text+"','"+txt_Email.Text+"','"+txt_Address.Text+ "','" + txt_UserName.Text + "','" + txt_Password.Text + "','"+Gender+"',) ", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registration Success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                Customer_login obj = new Customer_login();
                obj.Show();
                this.Hide();

            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show(e.ToString());
 
            }
        }

        private void txt_PhoneNumber_KeyDown(object sender, KeyEventArgs e)
        {
            



        }

        private void txt_PhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txt_FullName_KeyPress(object sender, KeyPressEventArgs e)
        {
              char ch = e.KeyChar;
                if (!Char.IsLetter(ch) && ch != 8 && ch != (char)Keys.Space)
                {
                    e.Handled = true;
                }
            
        }

        private void Customer_Registration_Load(object sender, EventArgs e)
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

