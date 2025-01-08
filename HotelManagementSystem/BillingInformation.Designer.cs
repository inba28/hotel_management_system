namespace HotelManagementSystem
{
    partial class BillingInformation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_billing_information = new System.Windows.Forms.Label();
            this.btn_log_out = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.lbl_price = new System.Windows.Forms.Label();
            this.txt_days = new System.Windows.Forms.TextBox();
            this.lbl_days = new System.Windows.Forms.Label();
            this.txt_guest_name = new System.Windows.Forms.TextBox();
            this.txt_room_no = new System.Windows.Forms.TextBox();
            this.txt_room_type = new System.Windows.Forms.TextBox();
            this.lbl_guest_name = new System.Windows.Forms.Label();
            this.lbl_room_type = new System.Windows.Forms.Label();
            this.lbl_room_no = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_status = new System.Windows.Forms.Label();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.dg_room_guests = new System.Windows.Forms.DataGridView();
            this.Receipt = new System.Windows.Forms.Button();
            this.txt_search_box = new System.Windows.Forms.TextBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.lbl_guest_phone = new System.Windows.Forms.Label();
            this.txt_guest_phone = new System.Windows.Forms.TextBox();
            this.lbl_check_in = new System.Windows.Forms.Label();
            this.lbl_check_out = new System.Windows.Forms.Label();
            this.txt_check_in = new System.Windows.Forms.TextBox();
            this.txt_check_out = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_room_guests)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_billing_information
            // 
            this.lbl_billing_information.AutoSize = true;
            this.lbl_billing_information.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_billing_information.Location = new System.Drawing.Point(242, 78);
            this.lbl_billing_information.Name = "lbl_billing_information";
            this.lbl_billing_information.Size = new System.Drawing.Size(508, 69);
            this.lbl_billing_information.TabIndex = 0;
            this.lbl_billing_information.Text = "Billing Information";
            // 
            // btn_log_out
            // 
            this.btn_log_out.Location = new System.Drawing.Point(887, 12);
            this.btn_log_out.Name = "btn_log_out";
            this.btn_log_out.Size = new System.Drawing.Size(107, 29);
            this.btn_log_out.TabIndex = 27;
            this.btn_log_out.Text = "Log Out";
            this.btn_log_out.UseVisualStyleBackColor = true;
            this.btn_log_out.Click += new System.EventHandler(this.btn_log_out_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(12, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(107, 29);
            this.btn_back.TabIndex = 28;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // txt_price
            // 
            this.txt_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price.Location = new System.Drawing.Point(710, 276);
            this.txt_price.Name = "txt_price";
            this.txt_price.ReadOnly = true;
            this.txt_price.Size = new System.Drawing.Size(214, 32);
            this.txt_price.TabIndex = 19;
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.Location = new System.Drawing.Point(530, 282);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(62, 26);
            this.lbl_price.TabIndex = 9;
            this.lbl_price.Text = "Price";
            // 
            // txt_days
            // 
            this.txt_days.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_days.Location = new System.Drawing.Point(710, 241);
            this.txt_days.Name = "txt_days";
            this.txt_days.ReadOnly = true;
            this.txt_days.Size = new System.Drawing.Size(214, 32);
            this.txt_days.TabIndex = 18;
            // 
            // lbl_days
            // 
            this.lbl_days.AutoSize = true;
            this.lbl_days.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_days.Location = new System.Drawing.Point(530, 242);
            this.lbl_days.Name = "lbl_days";
            this.lbl_days.Size = new System.Drawing.Size(126, 26);
            this.lbl_days.TabIndex = 8;
            this.lbl_days.Text = "No. of Days";
            // 
            // txt_guest_name
            // 
            this.txt_guest_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_guest_name.Location = new System.Drawing.Point(252, 202);
            this.txt_guest_name.Name = "txt_guest_name";
            this.txt_guest_name.ReadOnly = true;
            this.txt_guest_name.Size = new System.Drawing.Size(214, 32);
            this.txt_guest_name.TabIndex = 12;
            // 
            // txt_room_no
            // 
            this.txt_room_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_room_no.Location = new System.Drawing.Point(252, 279);
            this.txt_room_no.Name = "txt_room_no";
            this.txt_room_no.ReadOnly = true;
            this.txt_room_no.Size = new System.Drawing.Size(214, 32);
            this.txt_room_no.TabIndex = 14;
            // 
            // txt_room_type
            // 
            this.txt_room_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_room_type.Location = new System.Drawing.Point(252, 320);
            this.txt_room_type.Name = "txt_room_type";
            this.txt_room_type.ReadOnly = true;
            this.txt_room_type.Size = new System.Drawing.Size(214, 32);
            this.txt_room_type.TabIndex = 15;
            // 
            // lbl_guest_name
            // 
            this.lbl_guest_name.AutoSize = true;
            this.lbl_guest_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_guest_name.Location = new System.Drawing.Point(73, 205);
            this.lbl_guest_name.Name = "lbl_guest_name";
            this.lbl_guest_name.Size = new System.Drawing.Size(135, 26);
            this.lbl_guest_name.TabIndex = 2;
            this.lbl_guest_name.Text = "Guest Name";
            // 
            // lbl_room_type
            // 
            this.lbl_room_type.AutoSize = true;
            this.lbl_room_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_room_type.Location = new System.Drawing.Point(73, 323);
            this.lbl_room_type.Name = "lbl_room_type";
            this.lbl_room_type.Size = new System.Drawing.Size(124, 26);
            this.lbl_room_type.TabIndex = 5;
            this.lbl_room_type.Text = "Room Type";
            // 
            // lbl_room_no
            // 
            this.lbl_room_no.AutoSize = true;
            this.lbl_room_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_room_no.Location = new System.Drawing.Point(73, 282);
            this.lbl_room_no.Name = "lbl_room_no";
            this.lbl_room_no.Size = new System.Drawing.Size(111, 26);
            this.lbl_room_no.TabIndex = 4;
            this.lbl_room_no.Text = "Room No.";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(73, 167);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(34, 26);
            this.lbl_id.TabIndex = 1;
            this.lbl_id.Text = "ID";
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(252, 167);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(214, 32);
            this.txt_id.TabIndex = 11;
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.Location = new System.Drawing.Point(530, 323);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(74, 26);
            this.lbl_status.TabIndex = 10;
            this.lbl_status.Text = "Status";
            // 
            // cb_status
            // 
            this.cb_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Items.AddRange(new object[] {
            "Pending",
            "Paid"});
            this.cb_status.Location = new System.Drawing.Point(710, 318);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(214, 34);
            this.cb_status.TabIndex = 20;
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(672, 360);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(123, 38);
            this.btn_update.TabIndex = 21;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // dg_room_guests
            // 
            this.dg_room_guests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_room_guests.Location = new System.Drawing.Point(96, 464);
            this.dg_room_guests.Name = "dg_room_guests";
            this.dg_room_guests.RowHeadersWidth = 51;
            this.dg_room_guests.RowTemplate.Height = 24;
            this.dg_room_guests.Size = new System.Drawing.Size(847, 225);
            this.dg_room_guests.TabIndex = 26;
            this.dg_room_guests.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_room_guests_CellClick);
            // 
            // Receipt
            // 
            this.Receipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Receipt.Location = new System.Drawing.Point(803, 360);
            this.Receipt.Name = "Receipt";
            this.Receipt.Size = new System.Drawing.Size(123, 38);
            this.Receipt.TabIndex = 22;
            this.Receipt.Text = "Receipt";
            this.Receipt.UseVisualStyleBackColor = true;
            this.Receipt.Click += new System.EventHandler(this.Receipt_Click);
            // 
            // txt_search_box
            // 
            this.txt_search_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search_box.Location = new System.Drawing.Point(172, 414);
            this.txt_search_box.Name = "txt_search_box";
            this.txt_search_box.Size = new System.Drawing.Size(387, 32);
            this.txt_search_box.TabIndex = 23;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.Location = new System.Drawing.Point(731, 411);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(123, 38);
            this.btn_refresh.TabIndex = 25;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(581, 411);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(123, 38);
            this.btn_search.TabIndex = 24;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // lbl_guest_phone
            // 
            this.lbl_guest_phone.AutoSize = true;
            this.lbl_guest_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_guest_phone.Location = new System.Drawing.Point(73, 244);
            this.lbl_guest_phone.Name = "lbl_guest_phone";
            this.lbl_guest_phone.Size = new System.Drawing.Size(139, 26);
            this.lbl_guest_phone.TabIndex = 3;
            this.lbl_guest_phone.Text = "Guest Phone";
            // 
            // txt_guest_phone
            // 
            this.txt_guest_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_guest_phone.Location = new System.Drawing.Point(252, 241);
            this.txt_guest_phone.Name = "txt_guest_phone";
            this.txt_guest_phone.ReadOnly = true;
            this.txt_guest_phone.Size = new System.Drawing.Size(214, 32);
            this.txt_guest_phone.TabIndex = 13;
            // 
            // lbl_check_in
            // 
            this.lbl_check_in.AutoSize = true;
            this.lbl_check_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_check_in.Location = new System.Drawing.Point(530, 167);
            this.lbl_check_in.Name = "lbl_check_in";
            this.lbl_check_in.Size = new System.Drawing.Size(98, 26);
            this.lbl_check_in.TabIndex = 6;
            this.lbl_check_in.Text = "Check In";
            // 
            // lbl_check_out
            // 
            this.lbl_check_out.AutoSize = true;
            this.lbl_check_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_check_out.Location = new System.Drawing.Point(530, 206);
            this.lbl_check_out.Name = "lbl_check_out";
            this.lbl_check_out.Size = new System.Drawing.Size(115, 26);
            this.lbl_check_out.TabIndex = 7;
            this.lbl_check_out.Text = "Check Out";
            // 
            // txt_check_in
            // 
            this.txt_check_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_check_in.Location = new System.Drawing.Point(710, 164);
            this.txt_check_in.Name = "txt_check_in";
            this.txt_check_in.ReadOnly = true;
            this.txt_check_in.Size = new System.Drawing.Size(214, 32);
            this.txt_check_in.TabIndex = 16;
            // 
            // txt_check_out
            // 
            this.txt_check_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_check_out.Location = new System.Drawing.Point(710, 202);
            this.txt_check_out.Name = "txt_check_out";
            this.txt_check_out.ReadOnly = true;
            this.txt_check_out.Size = new System.Drawing.Size(214, 32);
            this.txt_check_out.TabIndex = 17;
            // 
            // BillingInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.txt_check_out);
            this.Controls.Add(this.txt_check_in);
            this.Controls.Add(this.lbl_check_out);
            this.Controls.Add(this.lbl_check_in);
            this.Controls.Add(this.txt_guest_phone);
            this.Controls.Add(this.lbl_guest_phone);
            this.Controls.Add(this.txt_search_box);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.Receipt);
            this.Controls.Add(this.dg_room_guests);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.txt_days);
            this.Controls.Add(this.lbl_days);
            this.Controls.Add(this.txt_guest_name);
            this.Controls.Add(this.txt_room_no);
            this.Controls.Add(this.txt_room_type);
            this.Controls.Add(this.lbl_guest_name);
            this.Controls.Add(this.lbl_room_type);
            this.Controls.Add(this.lbl_room_no);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_log_out);
            this.Controls.Add(this.lbl_billing_information);
            this.Name = "BillingInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billing Information";
            ((System.ComponentModel.ISupportInitialize)(this.dg_room_guests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_billing_information;
        private System.Windows.Forms.Button btn_log_out;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.TextBox txt_days;
        private System.Windows.Forms.Label lbl_days;
        private System.Windows.Forms.TextBox txt_guest_name;
        private System.Windows.Forms.TextBox txt_room_no;
        private System.Windows.Forms.TextBox txt_room_type;
        private System.Windows.Forms.Label lbl_guest_name;
        private System.Windows.Forms.Label lbl_room_type;
        private System.Windows.Forms.Label lbl_room_no;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.DataGridView dg_room_guests;
        private System.Windows.Forms.Button Receipt;
        private System.Windows.Forms.TextBox txt_search_box;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label lbl_guest_phone;
        private System.Windows.Forms.TextBox txt_guest_phone;
        private System.Windows.Forms.Label lbl_check_in;
        private System.Windows.Forms.Label lbl_check_out;
        private System.Windows.Forms.TextBox txt_check_in;
        private System.Windows.Forms.TextBox txt_check_out;
    }
}