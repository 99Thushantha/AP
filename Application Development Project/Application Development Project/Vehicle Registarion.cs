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
    public partial class Vehicle_Registration : Form
    {
        public Vehicle_Registration()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-AA823FE\\SQLEXPRESS;Initial Catalog=Connection;Integrated Security=True");

        private void btn_ADD_Click(object sender, EventArgs e)
        {   //Collecting Form Values

            String VehicleID = txt_VehicleID.Text;
            String VehicleNumber = txt_VehicleNumber.Text;
            String VehiclOwnerName = txt_VehicleOwnerName.Text;
            String VehicleOwnerContacNumber = txt_VehicleOwnerContac.Text;


            //Validation
            if (VehicleID == "")
            { MessageBox.Show("Vehicle ID Cannot be empty"); }
           else if (VehicleNumber == "")
            { MessageBox.Show("Vehicle Number cannot be Empty"); }
            else if (VehiclOwnerName == "")
            { MessageBox.Show("Vehicl OwnerName Cannot be Empty"); }
            else if (VehicleOwnerContacNumber == "")
            { MessageBox.Show("Vehicle OwnerContacNumber Cannot be Empty"); }


            //interact with tabel
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into VehicleTabel(VehicleNumber,VehiclOwnerName,VehicleOwnerContacNumber) values('" + txt_VehicleID.Text + "','" + txt_VehicleOwnerName.Text + "','" + txt_VehicleOwnerContac.Text + "'where id ='" + txt_VehicleID + "')";

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
            cmd.CommandText = "Select * from VehicleTable";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
           dgv_VehicleRegistration.DataSource = dt;

            con.Close();


        }

        private void btn_UPDATE_Click(object sender, EventArgs e)
        {
            // Collecting Form Values

            String VehicleID = txt_VehicleID.Text;
            String VehicleNumber = txt_VehicleNumber.Text;
            String VehiclOwnerName = txt_VehicleOwnerName.Text;
            String VehicleOwnerContacNumber = txt_VehicleOwnerContac.Text;


            //Validation
            if (VehicleID == "")
            { MessageBox.Show("Vehicle ID Cannot be empty"); }
            else if (VehicleNumber == "")
            { MessageBox.Show("Vehicle Number cannot be Empty"); }
            else if (VehiclOwnerName == "")
            { MessageBox.Show("Vehicl OwnerName Cannot be Empty"); }
            else if (VehicleOwnerContacNumber == "")
            { MessageBox.Show("Vehicle OwnerContacNumber Cannot be Empty"); }

            //interact with tabel
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update VehicleTabel(VehicleNumber,VehiclOwnerName,VehicleOwnerContacNumber) values('" + txt_VehicleID.Text + "','" + txt_VehicleOwnerName.Text + "','" + txt_VehicleOwnerContac.Text + "'where id ='" + txt_VehicleID + "')";

                cmd.ExecuteNonQuery();
                con.Close();

                
                Populate();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }
       



        private void txt_VehicleDriverName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_DELETE_Click(object sender, EventArgs e)
        {   //Collecting Form Values

            String VehicleID = txt_VehicleID.Text;
            String VehicleNumber = txt_VehicleNumber.Text;
            String VehiclOwnerName = txt_VehicleOwnerName.Text;
            String VehicleOwnerContacNumber = txt_VehicleOwnerContac.Text;


            //Validation
            if (VehicleID == "")
            { MessageBox.Show("Vehicle ID Cannot be empty"); }
            if (VehicleNumber == "")
            { MessageBox.Show("Vehicle Number cannot be Empty"); }
            if (VehiclOwnerName == "")
            { MessageBox.Show("Vehicl OwnerName Cannot be Empty"); }
            if (VehicleOwnerContacNumber == "")
            { MessageBox.Show("Vehicle OwnerContacNumber Cannot be Empty"); }

            //interact with tabel
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete VehicleTabel where id='" + txt_VehicleID + "'";
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
            //Collecting Form Values

            String VehicleID = txt_VehicleID.Text;
            String VehicleNumber = txt_VehicleNumber.Text;
            String VehiclOwnerName = txt_VehicleOwnerName.Text;
            String VehicleOwnerContacNumber = txt_VehicleOwnerContac.Text;


            //Validation
            if (VehicleID == "")
            { MessageBox.Show("Vehicle ID Cannot be empty"); }
           else if (VehicleNumber == "")
            { MessageBox.Show("Vehicle Number cannot be Empty"); }
           else if (VehiclOwnerName == "")
            { MessageBox.Show("Vehicl OwnerName Cannot be Empty"); }
           else if (VehicleOwnerContacNumber == "")
            { MessageBox.Show("Vehicle OwnerContacNumber Cannot be Empty"); }

            //interact with tabel
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from  VehicleTabel where id='" + txt_VehicleID + "'";
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

        private void Manage_Transport_Details_Load(object sender, EventArgs e)
        {
            Populate();
        }
    }
    }

