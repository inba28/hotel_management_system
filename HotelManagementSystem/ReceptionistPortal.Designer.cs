namespace HotelManagementSystem
{
    partial class ReceptionistPortal
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
            this.btn_raise_complaint_service = new System.Windows.Forms.Button();
            this.btn_room_management = new System.Windows.Forms.Button();
            this.lbl_receptionist_portal = new System.Windows.Forms.Label();
            this.btn_log_out = new System.Windows.Forms.Button();
            this.btn_billing = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_raise_complaint_service
            // 
            this.btn_raise_complaint_service.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_raise_complaint_service.Location = new System.Drawing.Point(300, 530);
            this.btn_raise_complaint_service.Name = "btn_raise_complaint_service";
            this.btn_raise_complaint_service.Size = new System.Drawing.Size(406, 100);
            this.btn_raise_complaint_service.TabIndex = 3;
            this.btn_raise_complaint_service.Text = "Raise a Complaint / Service Request";
            this.btn_raise_complaint_service.UseVisualStyleBackColor = true;
            this.btn_raise_complaint_service.Click += new System.EventHandler(this.btn_raise_complaint_service_Click);
            // 
            // btn_room_management
            // 
            this.btn_room_management.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_room_management.Location = new System.Drawing.Point(300, 193);
            this.btn_room_management.Name = "btn_room_management";
            this.btn_room_management.Size = new System.Drawing.Size(406, 100);
            this.btn_room_management.TabIndex = 1;
            this.btn_room_management.Text = "Room Management";
            this.btn_room_management.UseVisualStyleBackColor = true;
            this.btn_room_management.Click += new System.EventHandler(this.btn_room_management_Click);
            // 
            // lbl_receptionist_portal
            // 
            this.lbl_receptionist_portal.AutoSize = true;
            this.lbl_receptionist_portal.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_receptionist_portal.Location = new System.Drawing.Point(244, 79);
            this.lbl_receptionist_portal.Name = "lbl_receptionist_portal";
            this.lbl_receptionist_portal.Size = new System.Drawing.Size(533, 69);
            this.lbl_receptionist_portal.TabIndex = 0;
            this.lbl_receptionist_portal.Text = "Receptionist Portal";
            // 
            // btn_log_out
            // 
            this.btn_log_out.Location = new System.Drawing.Point(887, 12);
            this.btn_log_out.Name = "btn_log_out";
            this.btn_log_out.Size = new System.Drawing.Size(107, 29);
            this.btn_log_out.TabIndex = 4;
            this.btn_log_out.Text = "Log Out";
            this.btn_log_out.UseVisualStyleBackColor = true;
            this.btn_log_out.Click += new System.EventHandler(this.btn_log_out_Click);
            // 
            // btn_billing
            // 
            this.btn_billing.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_billing.Location = new System.Drawing.Point(300, 359);
            this.btn_billing.Name = "btn_billing";
            this.btn_billing.Size = new System.Drawing.Size(406, 100);
            this.btn_billing.TabIndex = 2;
            this.btn_billing.Text = "Billing Information";
            this.btn_billing.UseVisualStyleBackColor = true;
            this.btn_billing.Click += new System.EventHandler(this.btn_billing_Click);
            // 
            // ReceptionistPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.btn_billing);
            this.Controls.Add(this.btn_log_out);
            this.Controls.Add(this.btn_raise_complaint_service);
            this.Controls.Add(this.btn_room_management);
            this.Controls.Add(this.lbl_receptionist_portal);
            this.Name = "ReceptionistPortal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receptionist Portal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_raise_complaint_service;
        private System.Windows.Forms.Button btn_room_management;
        private System.Windows.Forms.Label lbl_receptionist_portal;
        private System.Windows.Forms.Button btn_log_out;
        private System.Windows.Forms.Button btn_billing;
    }
}