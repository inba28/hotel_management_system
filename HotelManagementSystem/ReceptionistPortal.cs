using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class ReceptionistPortal : Form
    {
        public ReceptionistPortal()
        {
            InitializeComponent();
        }

        private void btn_log_out_Click(object sender, EventArgs e)
        {
            Login loginform = new Login();
            loginform.Show();
            this.Hide();
        }

        private void btn_room_management_Click(object sender, EventArgs e)
        {
            RoomManagement room_management_form = new RoomManagement();
            room_management_form.Show();
            this.Hide();
        }

        private void btn_raise_complaint_service_Click(object sender, EventArgs e)
        {
            ServiceAndComplaint service_and_complaint_form = new ServiceAndComplaint();
            service_and_complaint_form.Show();
            this.Hide();
        }

        private void btn_billing_Click(object sender, EventArgs e)
        {
            BillingInformation billingfrom = new BillingInformation();
            billingfrom.Show();
            this.Hide();
        }
    }
}
