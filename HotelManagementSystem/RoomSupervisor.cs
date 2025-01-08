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

namespace HotelManagementSystem
{
    public partial class RoomSupervisor : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Inba\\source\\repos\\HotelManagementSystem\\HotelManagementSystem\\HotelManagementDB.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        SqlDataAdapter sda;
        public RoomSupervisor()
        {
            InitializeComponent();
            displaydata();
        }

        private void displaydata()
        {
            con.Open();
            cmd = new SqlCommand("SELECT * FROM room_supervisors", con);
            sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dg_room_supervisor.DataSource = dt;
            con.Close();
        }

        private void cleardata()
        {
            txt_room_no.Text = "";
            txt_supervisor.Text = "";
        }

        private void btn_log_out_Click(object sender, EventArgs e)
        {
            Login loginform = new Login();
            loginform.Show();
            this.Hide();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            AdminPortal adminform = new AdminPortal();
            adminform.Show();
            this.Hide();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("UPDATE room_supervisors SET username = @username WHERE  room_no = @room_no", con);
                con.Open();
                cmd.Parameters.AddWithValue("@room_no", txt_room_no.Text);
                cmd.Parameters.AddWithValue("@username", txt_supervisor.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                displaydata(); cleardata();
                MessageBox.Show("Room Supervisor updated successfully!");
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Fill in all the details! User must be created before assignment.\n\n" + ex.Message);
            }

            
        }

        private void dg_room_supervisor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_room_no.Text = dg_room_supervisor.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_supervisor.Text = dg_room_supervisor.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
