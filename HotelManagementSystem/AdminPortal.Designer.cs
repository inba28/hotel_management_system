namespace HotelManagementSystem
{
    partial class AdminPortal
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
            this.lbl_admin_portal = new System.Windows.Forms.Label();
            this.btn_user_management = new System.Windows.Forms.Button();
            this.btn_change_room = new System.Windows.Forms.Button();
            this.btn_change_supervisor = new System.Windows.Forms.Button();
            this.btn_log_out = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_admin_portal
            // 
            this.lbl_admin_portal.AutoSize = true;
            this.lbl_admin_portal.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_admin_portal.Location = new System.Drawing.Point(302, 47);
            this.lbl_admin_portal.Name = "lbl_admin_portal";
            this.lbl_admin_portal.Size = new System.Drawing.Size(373, 69);
            this.lbl_admin_portal.TabIndex = 0;
            this.lbl_admin_portal.Text = "Admin Portal";
            this.lbl_admin_portal.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_user_management
            // 
            this.btn_user_management.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_user_management.Location = new System.Drawing.Point(279, 215);
            this.btn_user_management.Name = "btn_user_management";
            this.btn_user_management.Size = new System.Drawing.Size(406, 76);
            this.btn_user_management.TabIndex = 1;
            this.btn_user_management.Text = "User Management";
            this.btn_user_management.UseVisualStyleBackColor = true;
            this.btn_user_management.Click += new System.EventHandler(this.btn_user_management_Click);
            // 
            // btn_change_room
            // 
            this.btn_change_room.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_change_room.Location = new System.Drawing.Point(279, 372);
            this.btn_change_room.Name = "btn_change_room";
            this.btn_change_room.Size = new System.Drawing.Size(406, 76);
            this.btn_change_room.TabIndex = 2;
            this.btn_change_room.Text = "Change Room Type";
            this.btn_change_room.UseVisualStyleBackColor = true;
            this.btn_change_room.Click += new System.EventHandler(this.btn_change_room_Click);
            // 
            // btn_change_supervisor
            // 
            this.btn_change_supervisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_change_supervisor.Location = new System.Drawing.Point(279, 533);
            this.btn_change_supervisor.Name = "btn_change_supervisor";
            this.btn_change_supervisor.Size = new System.Drawing.Size(406, 76);
            this.btn_change_supervisor.TabIndex = 3;
            this.btn_change_supervisor.Text = "Change Room Supervisor";
            this.btn_change_supervisor.UseVisualStyleBackColor = true;
            this.btn_change_supervisor.Click += new System.EventHandler(this.btn_change_supervisor_Click);
            // 
            // btn_log_out
            // 
            this.btn_log_out.Location = new System.Drawing.Point(887, 12);
            this.btn_log_out.Name = "btn_log_out";
            this.btn_log_out.Size = new System.Drawing.Size(107, 29);
            this.btn_log_out.TabIndex = 4;
            this.btn_log_out.Text = "Log Out";
            this.btn_log_out.UseVisualStyleBackColor = true;
            this.btn_log_out.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.btn_log_out);
            this.Controls.Add(this.btn_change_supervisor);
            this.Controls.Add(this.btn_change_room);
            this.Controls.Add(this.btn_user_management);
            this.Controls.Add(this.lbl_admin_portal);
            this.Name = "AdminPortal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Portal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_admin_portal;
        private System.Windows.Forms.Button btn_user_management;
        private System.Windows.Forms.Button btn_change_room;
        private System.Windows.Forms.Button btn_change_supervisor;
        private System.Windows.Forms.Button btn_log_out;
    }
}