namespace HotelManagementSystem
{
    partial class RoomSupervisor
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
            this.btn_update = new System.Windows.Forms.Button();
            this.lbl_change_room_supervisor = new System.Windows.Forms.Label();
            this.txt_room_no = new System.Windows.Forms.TextBox();
            this.txt_supervisor = new System.Windows.Forms.TextBox();
            this.dg_room_supervisor = new System.Windows.Forms.DataGridView();
            this.lbl_supervisor = new System.Windows.Forms.Label();
            this.lbl_room_no = new System.Windows.Forms.Label();
            this.btn_log_out = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_room_supervisor)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(455, 317);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(100, 50);
            this.btn_update.TabIndex = 5;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // lbl_change_room_supervisor
            // 
            this.lbl_change_room_supervisor.AutoSize = true;
            this.lbl_change_room_supervisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_change_room_supervisor.Location = new System.Drawing.Point(167, 47);
            this.lbl_change_room_supervisor.Name = "lbl_change_room_supervisor";
            this.lbl_change_room_supervisor.Size = new System.Drawing.Size(715, 69);
            this.lbl_change_room_supervisor.TabIndex = 0;
            this.lbl_change_room_supervisor.Text = "Change Room Supervisor";
            // 
            // txt_room_no
            // 
            this.txt_room_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_room_no.Location = new System.Drawing.Point(499, 183);
            this.txt_room_no.Name = "txt_room_no";
            this.txt_room_no.ReadOnly = true;
            this.txt_room_no.Size = new System.Drawing.Size(214, 32);
            this.txt_room_no.TabIndex = 3;
            // 
            // txt_supervisor
            // 
            this.txt_supervisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_supervisor.Location = new System.Drawing.Point(499, 235);
            this.txt_supervisor.Name = "txt_supervisor";
            this.txt_supervisor.Size = new System.Drawing.Size(214, 32);
            this.txt_supervisor.TabIndex = 4;
            // 
            // dg_room_supervisor
            // 
            this.dg_room_supervisor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_room_supervisor.Location = new System.Drawing.Point(162, 415);
            this.dg_room_supervisor.Name = "dg_room_supervisor";
            this.dg_room_supervisor.RowHeadersWidth = 51;
            this.dg_room_supervisor.RowTemplate.Height = 24;
            this.dg_room_supervisor.Size = new System.Drawing.Size(682, 258);
            this.dg_room_supervisor.TabIndex = 6;
            this.dg_room_supervisor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_room_supervisor_CellClick);
            // 
            // lbl_supervisor
            // 
            this.lbl_supervisor.AutoSize = true;
            this.lbl_supervisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_supervisor.Location = new System.Drawing.Point(323, 235);
            this.lbl_supervisor.Name = "lbl_supervisor";
            this.lbl_supervisor.Size = new System.Drawing.Size(116, 26);
            this.lbl_supervisor.TabIndex = 2;
            this.lbl_supervisor.Text = "Supervisor";
            // 
            // lbl_room_no
            // 
            this.lbl_room_no.AutoSize = true;
            this.lbl_room_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_room_no.Location = new System.Drawing.Point(326, 183);
            this.lbl_room_no.Name = "lbl_room_no";
            this.lbl_room_no.Size = new System.Drawing.Size(111, 26);
            this.lbl_room_no.TabIndex = 1;
            this.lbl_room_no.Text = "Room No.";
            // 
            // btn_log_out
            // 
            this.btn_log_out.Location = new System.Drawing.Point(887, 12);
            this.btn_log_out.Name = "btn_log_out";
            this.btn_log_out.Size = new System.Drawing.Size(107, 29);
            this.btn_log_out.TabIndex = 7;
            this.btn_log_out.Text = "Log Out";
            this.btn_log_out.UseVisualStyleBackColor = true;
            this.btn_log_out.Click += new System.EventHandler(this.btn_log_out_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(12, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(107, 29);
            this.btn_back.TabIndex = 8;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // RoomSupervisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_log_out);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.lbl_change_room_supervisor);
            this.Controls.Add(this.txt_room_no);
            this.Controls.Add(this.txt_supervisor);
            this.Controls.Add(this.dg_room_supervisor);
            this.Controls.Add(this.lbl_supervisor);
            this.Controls.Add(this.lbl_room_no);
            this.Name = "RoomSupervisor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Room Supervisor";
            ((System.ComponentModel.ISupportInitialize)(this.dg_room_supervisor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label lbl_change_room_supervisor;
        private System.Windows.Forms.TextBox txt_room_no;
        private System.Windows.Forms.TextBox txt_supervisor;
        private System.Windows.Forms.DataGridView dg_room_supervisor;
        private System.Windows.Forms.Label lbl_supervisor;
        private System.Windows.Forms.Label lbl_room_no;
        private System.Windows.Forms.Button btn_log_out;
        private System.Windows.Forms.Button btn_back;
    }
}