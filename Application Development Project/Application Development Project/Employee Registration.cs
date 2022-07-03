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
    public partial class Employee_Registration : Form
    {
        public Employee_Registration()
        {
            InitializeComponent();
        }
      

        private SqlConnection con;
        private SqlCommand cmd;

        private void btn_ADD_Click(object sender, EventArgs e)

        {            //Collecting Form Values


            String EmployeeID = txt_EmployeeID.Text;
            String EmployeeUserRole = cmb_EmployeeUserRole.Text;
            string EmployeeName = txt_employeeName.Text;
            string EmployeeContacNumber = txt_EmployeeContacNo.Text;
            string EmployeeAddress = txt_EmployeeAddress.Text;


                        //Validation

            if (EmployeeID == "")
            { MessageBox.Show("Employee ID Cannot be empty"); }
            else if (EmployeeUserRole == "")
            { MessageBox.Show("Employee User Role cannot be Empty"); }
            else if (EmployeeName == "")
            { MessageBox.Show("Employee Name Cannot be Empty"); }
            else if (EmployeeContacNumber == "")
            { MessageBox.Show("Employee Contac Number Cannot be Empty"); }
            else if (EmployeeAddress == "")
            { MessageBox.Show("Employee Address Cannot be Empty"); }

            //interact with tabel
            try
            {
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = ("insert into EmployeeTable (EmployeeUserRole,EmployeeName,EmployeeContacNumber,EmployeeAddress) values ('" + cmb_EmployeeUserRole.Text + "','" + txt_employeeName.Text + "','" + txt_EmployeeContacNo.Text + "','" + txt_EmployeeAddress.Text + "')");
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Employee Regitered Successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }




        }
        private void Populate(string para)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select (EmployeeUserRoleID,EmployeeUserRole,EmployeeName,EmployeeContacNumber,EmployeeAddress) from EmployeeTable where EmployeeID LIKE '" + para + "' OR EmployeeName LIKE '" + para + "' ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgv_EmployeeRegister.DataSource = dt;

            con.Close();


        }

        private void btn_UPDATE_Click(object sender, EventArgs e)
        {            
                  //Collecting Form Values


            String EmployeeID = txt_EmployeeID.Text;
            String EmployeeUserRole = cmb_EmployeeUserRole.Text;
            string EmployeeName = txt_employeeName.Text;
            string EmployeeContacNumber = txt_EmployeeContacNo.Text;
            string EmployeeAddress = txt_EmployeeAddress.Text;


                     //Validation

            if (EmployeeID == "")
            { MessageBox.Show("Employee ID Cannot be empty"); }
            else if (EmployeeUserRole == "")
            { MessageBox.Show("Employee User Role cannot be Empty"); }
            else if (EmployeeName == "")
            { MessageBox.Show("Employee Name Cannot be Empty"); }
            else if (EmployeeContacNumber == "")
            { MessageBox.Show("Employee Contac Number Cannot be Empty"); }
            else if (EmployeeAddress == "")
            { MessageBox.Show("Employee Address Cannot be Empty"); }


            //interact with tabel
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update  EmployeeTabel(EmployeeUserRole,EmployeeName,EmployeeName,EmployeeContacNumber,EmployeeAddress)values('" + cmb_EmployeeUserRole.Text + "','" + txt_employeeName.Text + "','" + txt_EmployeeContacNo.Text + "','" + txt_EmployeeAddress.Text + "', where id ='" + txt_EmployeeID + "')";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Record Updated Successfully");
                PopulateEmp("%");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
      

        private void btn_DELETE_Click(object sender, EventArgs e)
        {
            


            //interact with tabel
            try
            {
                if (txt_EmployeeID.Text != "")
                {
                    if (MessageBox.Show("Are you sure to reset page?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = " delete  EmployeeTable where EmployeeID='" + txt_EmployeeID.Text + "'";
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Record Deleted Successfully");
                        PopulateEmp("%");
                    }
                }
                else
                {
                    MessageBox.Show("Employee ID Cannot be empty");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }


        }
       

        private void btn_SEARCH_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_EmployeeID.Text != "")
                {
                    dgv_EmployeeRegister.DataSource = null;
                    PopulateEmp(txt_EmployeeID.Text);


                }
                else
                {
                    PopulateEmp("%");
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
        private void PopulateEmp(String para)
        {
            try
            {
                con.Open();
                string query = "Select EmployeeID,EmployeeUserRole,EmployeeName,EmployeeContacNumber,EmployeeAddress from EmployeeTable where EmployeeID LIKE '" + para + "' OR EmployeeName LIKE '" + para + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);

                var ds = new DataSet();
                sda.Fill(ds);
                dgv_EmployeeRegister.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception e)
            {
                con.Close();
                Console.WriteLine(e);
                //throw;
            }

        }

        private void Employee_Registration_Load(object sender, EventArgs e)
        {

            try
            {
                DBString obj = new DBString();
                string conn = obj.GetConnection();
                con = new SqlConnection(conn);
                PopulateEmp("%");

            }
            catch (Exception ex)
            {

            }
        }

        private void dgv_EmployeeRegister_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgv_EmployeeRegister.SelectedRows)
                {
                    txt_EmployeeID.Text = row.Cells[0].Value.ToString();
                    cmb_EmployeeUserRole.Text = row.Cells[1].Value.ToString();
                    txt_employeeName.Text = row.Cells[2].Value.ToString();
                    txt_EmployeeContacNo.Text = row.Cells[3].Value.ToString();
                    txt_EmployeeAddress.Text = row.Cells[4].Value.ToString();
   
                }
            }
            catch (Exception exception)
            {
                
            }
        }

        private void dgv_EmployeeRegister_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
