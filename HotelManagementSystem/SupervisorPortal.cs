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
    public partial class SupervisorPortal : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Inba\\source\\repos\\HotelManagementSystem\\HotelManagementSystem\\HotelManagementDB.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        SqlDataAdapter sda;
        public SupervisorPortal()
        {
            InitializeComponent();
            displaydata();
        }

        private void displaydata()
        {
            con.Open();
            cmd = new SqlCommand("SELECT rc.*,rs.username FROM room_complaints AS rc LEFT JOIN room_supervisors rs ON rc.room_no = rs.room_no", con);
            sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dg_services_complaints.DataSource = dt;
            con.Close();
        }

        private void cleardata()
        {
            txt_id.Text = "";
            txt_room_no.Text = "";
            txt_request_type.Text = "";
            rtxt_description.Text = "";
        }

        private void btn_log_out_Click(object sender, EventArgs e)
        {
            Login loginform = new Login();
            loginform.Show();
            this.Hide();
        }

        private void btn_resolve_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\HotelManagementDB.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand("DELETE FROM room_complaints WHERE id = @id", con);
            con.Open();
            cmd.Parameters.AddWithValue("@id", txt_id.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            displaydata(); cleardata();
            MessageBox.Show("Complaint resolved successfully!");
        }

        private void dg_services_complaints_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dg_services_complaints.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_room_no.Text = dg_services_complaints.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_request_type.Text = dg_services_complaints.Rows[e.RowIndex].Cells[2].Value.ToString();
            rtxt_description.Text = dg_services_complaints.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }
}
