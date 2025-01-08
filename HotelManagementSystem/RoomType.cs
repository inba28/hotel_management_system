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
    public partial class RoomType : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Inba\\source\\repos\\HotelManagementSystem\\HotelManagementSystem\\HotelManagementDB.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        SqlDataAdapter sda;
        public RoomType()
        {
            InitializeComponent();
            displaydata();
        }

        private void displaydata()
        {
            con.Open();
            cmd = new SqlCommand("SELECT * FROM rooms", con);
            sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dg_room_type.DataSource = dt;
            con.Close();
        }

        private void cleardata()
        {
            txt_room_no.Text = "";
            txt_room_type.Text = "";
            txt_room_price.Text = "";
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
                
                SqlCommand cmd = new SqlCommand("UPDATE rooms SET room_type = @room_type, room_price = @room_price WHERE room_no = @room_no", con);
                con.Open();
                cmd.Parameters.AddWithValue("@room_no", txt_room_no.Text);
                cmd.Parameters.AddWithValue("@room_type", txt_room_type.Text);
                cmd.Parameters.AddWithValue("@room_price", txt_room_price.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                displaydata(); cleardata();
                MessageBox.Show("Room type and price updated successfully!");
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Fill in all the details!\n\n" + ex.Message);
            }
        }

        private void dg_room_type_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_room_no.Text = dg_room_type.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_room_type.Text = dg_room_type.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_room_price.Text = dg_room_type.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}
