using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class ServiceAndComplaint : Form
    {
        public ServiceAndComplaint()
        {
            InitializeComponent();
        }

        private void cleardata()
        {
            txt_room_no.Text = "";
            cb_request_type.Text = "";
            rtxt_description.Text = "";
        }

        private void btn_log_out_Click(object sender, EventArgs e)
        {
            Login loginform = new Login();
            loginform.Show();
            this.Hide();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            ReceptionistPortal receptionistform = new ReceptionistPortal();
            receptionistform.Show();
            this.Hide();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Inba\\source\\repos\\HotelManagementSystem\\HotelManagementSystem\\HotelManagementDB.mdf;Integrated Security=True;Connect Timeout=30");
                SqlCommand cmd = new SqlCommand("INSERT INTO room_complaints (room_no,request_type,description) VALUES (@room_no,@request_type,@description)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@room_no", txt_room_no.Text);
                cmd.Parameters.AddWithValue("@request_type", cb_request_type.Text);
                cmd.Parameters.AddWithValue("@description", rtxt_description.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                cleardata();
                MessageBox.Show("Complaint registered successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fill in all the details. Enter a valid Room Number.\n\n" + ex.Message);
            }
        }
    }
}
