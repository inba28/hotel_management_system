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
    public partial class BillingInformation : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Inba\\source\\repos\\HotelManagementSystem\\HotelManagementSystem\\HotelManagementDB.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        SqlDataAdapter sda;
        public BillingInformation()
        {
            InitializeComponent();
            displaydata();
        }

        private void displaydata()
        {
            con.Open();
            cmd = new SqlCommand("SELECT * FROM room_billing;", con);
            sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dg_room_guests.DataSource = dt;
            con.Close();
        }

        private void cleardata()
        {
            txt_id.Text = "";
            txt_guest_name.Text = "";
            txt_guest_phone.Text = "";
            txt_room_no.Text = "";
            txt_room_type.Text = "";
            txt_check_in.Text = "";
            txt_check_out.Text = "";
            txt_days.Text = "";
            txt_price.Text = "";
            cb_status.SelectedIndex = -1;
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

        private void btn_update_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("UPDATE room_billing SET status = @status WHERE id = @id", con);
            con.Open();
            cmd.Parameters.AddWithValue("@id", txt_id.Text);
            cmd.Parameters.AddWithValue("@status", cb_status.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            displaydata(); cleardata();
            MessageBox.Show("Billing details updated successfully!");
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("SELECT * FROM room_billing WHERE CONCAT(id,guest_name,guest_phone,room_no) LIKE '%" + txt_search_box.Text +"%'", con);
            con.Open();
            sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dg_room_guests.DataSource = dt;
            con.Close();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            displaydata();
        }

        private void Receipt_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == "" || txt_guest_name.Text == "" || txt_guest_phone.Text == "" || txt_room_no.Text == "" || txt_room_type.Text == "" || txt_check_in.Text == "" || txt_check_out.Text == "" || txt_days.Text == "" || txt_price.Text == "" || cb_status.Text == "")
            {
                MessageBox.Show("Select at least one Bill and Check whether all the fields are filled!");
            }
            else
            {
                Receipt receipt = new Receipt();
                receipt.CreateReceipt(txt_id.Text, txt_guest_name.Text, txt_guest_phone.Text, txt_room_no.Text, txt_room_type.Text, txt_check_in.Text, txt_check_out.Text, txt_days.Text, txt_price.Text, cb_status.Text);
                receipt.Show();
                this.Hide();
            }
        }

    private void dg_room_guests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dg_room_guests.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_guest_name.Text = dg_room_guests.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_guest_phone.Text = dg_room_guests.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_room_no.Text = dg_room_guests.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_room_type.Text = dg_room_guests.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_check_in.Text = dg_room_guests.Rows[e.RowIndex].Cells[5].Value.ToString();
            txt_check_out.Text = dg_room_guests.Rows[e.RowIndex].Cells[6].Value.ToString();
            txt_days.Text = dg_room_guests.Rows[e.RowIndex].Cells[7].Value.ToString();
            txt_price.Text = dg_room_guests.Rows[e.RowIndex].Cells[8].Value.ToString();
            cb_status.Text = dg_room_guests.Rows[e.RowIndex].Cells[9].Value.ToString();
        }
    }
}
