namespace HotelManagementSystem
{
    partial class SupervisorPortal
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
            this.complaints_services = new System.Windows.Forms.Label();
            this.dg_services_complaints = new System.Windows.Forms.DataGridView();
            this.rtxt_description = new System.Windows.Forms.RichTextBox();
            this.txt_room_no = new System.Windows.Forms.TextBox();
            this.lbl_description = new System.Windows.Forms.Label();
            this.lbl_request_type = new System.Windows.Forms.Label();
            this.lbl_room_no = new System.Windows.Forms.Label();
            this.txt_request_type = new System.Windows.Forms.TextBox();
            this.btn_resolve = new System.Windows.Forms.Button();
            this.btn_log_out = new System.Windows.Forms.Button();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_services_complaints)).BeginInit();
            this.SuspendLayout();
            // 
            // complaints_services
            // 
            this.complaints_services.AutoSize = true;
            this.complaints_services.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complaints_services.Location = new System.Drawing.Point(150, 49);
            this.complaints_services.Name = "complaints_services";
            this.complaints_services.Size = new System.Drawing.Size(691, 69);
            this.complaints_services.TabIndex = 0;
            this.complaints_services.Text = "Services and Complaints";
            // 
            // dg_services_complaints
            // 
            this.dg_services_complaints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_services_complaints.Location = new System.Drawing.Point(162, 509);
            this.dg_services_complaints.Name = "dg_services_complaints";
            this.dg_services_complaints.RowHeadersWidth = 51;
            this.dg_services_complaints.RowTemplate.Height = 24;
            this.dg_services_complaints.Size = new System.Drawing.Size(682, 181);
            this.dg_services_complaints.TabIndex = 10;
            this.dg_services_complaints.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_services_complaints_CellClick);
            // 
            // rtxt_description
            // 
            this.rtxt_description.Location = new System.Drawing.Point(480, 277);
            this.rtxt_description.Name = "rtxt_description";
            this.rtxt_description.ReadOnly = true;
            this.rtxt_description.Size = new System.Drawing.Size(272, 130);
            this.rtxt_description.TabIndex = 8;
            this.rtxt_description.Text = "";
            // 
            // txt_room_no
            // 
            this.txt_room_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_room_no.Location = new System.Drawing.Point(480, 191);
            this.txt_room_no.Name = "txt_room_no";
            this.txt_room_no.ReadOnly = true;
            this.txt_room_no.Size = new System.Drawing.Size(272, 32);
            this.txt_room_no.TabIndex = 6;
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_description.Location = new System.Drawing.Point(246, 272);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(121, 26);
            this.lbl_description.TabIndex = 4;
            this.lbl_description.Text = "Description";
            // 
            // lbl_request_type
            // 
            this.lbl_request_type.AutoSize = true;
            this.lbl_request_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_request_type.Location = new System.Drawing.Point(246, 232);
            this.lbl_request_type.Name = "lbl_request_type";
            this.lbl_request_type.Size = new System.Drawing.Size(146, 26);
            this.lbl_request_type.TabIndex = 3;
            this.lbl_request_type.Text = "Request Type";
            // 
            // lbl_room_no
            // 
            this.lbl_room_no.AutoSize = true;
            this.lbl_room_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_room_no.Location = new System.Drawing.Point(246, 194);
            this.lbl_room_no.Name = "lbl_room_no";
            this.lbl_room_no.Size = new System.Drawing.Size(111, 26);
            this.lbl_room_no.TabIndex = 2;
            this.lbl_room_no.Text = "Room No.";
            // 
            // txt_request_type
            // 
            this.txt_request_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_request_type.Location = new System.Drawing.Point(480, 229);
            this.txt_request_type.Name = "txt_request_type";
            this.txt_request_type.ReadOnly = true;
            this.txt_request_type.Size = new System.Drawing.Size(272, 32);
            this.txt_request_type.TabIndex = 7;
            // 
            // btn_resolve
            // 
            this.btn_resolve.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_resolve.Location = new System.Drawing.Point(437, 433);
            this.btn_resolve.Name = "btn_resolve";
            this.btn_resolve.Size = new System.Drawing.Size(135, 46);
            this.btn_resolve.TabIndex = 9;
            this.btn_resolve.Text = "Resolve";
            this.btn_resolve.UseVisualStyleBackColor = true;
            this.btn_resolve.Click += new System.EventHandler(this.btn_resolve_Click);
            // 
            // btn_log_out
            // 
            this.btn_log_out.Location = new System.Drawing.Point(887, 12);
            this.btn_log_out.Name = "btn_log_out";
            this.btn_log_out.Size = new System.Drawing.Size(107, 29);
            this.btn_log_out.TabIndex = 11;
            this.btn_log_out.Text = "Log Out";
            this.btn_log_out.UseVisualStyleBackColor = true;
            this.btn_log_out.Click += new System.EventHandler(this.btn_log_out_Click);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(246, 158);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(34, 26);
            this.lbl_id.TabIndex = 1;
            this.lbl_id.Text = "ID";
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(480, 155);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(272, 32);
            this.txt_id.TabIndex = 5;
            // 
            // SupervisorPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.btn_log_out);
            this.Controls.Add(this.btn_resolve);
            this.Controls.Add(this.txt_request_type);
            this.Controls.Add(this.rtxt_description);
            this.Controls.Add(this.txt_room_no);
            this.Controls.Add(this.lbl_description);
            this.Controls.Add(this.lbl_request_type);
            this.Controls.Add(this.lbl_room_no);
            this.Controls.Add(this.dg_services_complaints);
            this.Controls.Add(this.complaints_services);
            this.Name = "SupervisorPortal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supervisor Portal";
            ((System.ComponentModel.ISupportInitialize)(this.dg_services_complaints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label complaints_services;
        private System.Windows.Forms.DataGridView dg_services_complaints;
        private System.Windows.Forms.RichTextBox rtxt_description;
        private System.Windows.Forms.TextBox txt_room_no;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.Label lbl_request_type;
        private System.Windows.Forms.Label lbl_room_no;
        private System.Windows.Forms.TextBox txt_request_type;
        private System.Windows.Forms.Button btn_resolve;
        private System.Windows.Forms.Button btn_log_out;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox txt_id;
    }
}