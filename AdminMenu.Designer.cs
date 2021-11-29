
namespace Booking_system
{
    partial class AdminMenu
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
            this.LogOut = new System.Windows.Forms.Button();
            this.FindClient = new System.Windows.Forms.Button();
            this.FindRoom = new System.Windows.Forms.Button();
            this.FindReservation = new System.Windows.Forms.Button();
            this.MakeReservation = new System.Windows.Forms.Button();
            this.CancelReservation = new System.Windows.Forms.Button();
            this.AddNewRoom = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.DataBox = new System.Windows.Forms.TextBox();
            this.DataView = new System.Windows.Forms.DataGridView();
            this.Reservations = new Booking_system.DataGridViewDisableButtonColumn();
            this.Action = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).BeginInit();
            this.SuspendLayout();
            // 
            // LogOut
            // 
            this.LogOut.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.LogOut.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LogOut.Location = new System.Drawing.Point(1028, 16);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(115, 40);
            this.LogOut.TabIndex = 0;
            this.LogOut.Text = "Log out";
            this.LogOut.UseVisualStyleBackColor = false;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // FindClient
            // 
            this.FindClient.Location = new System.Drawing.Point(85, 82);
            this.FindClient.Name = "FindClient";
            this.FindClient.Size = new System.Drawing.Size(136, 45);
            this.FindClient.TabIndex = 1;
            this.FindClient.Text = "Find Client";
            this.FindClient.UseVisualStyleBackColor = true;
            this.FindClient.Click += new System.EventHandler(this.FindClient_Click);
            // 
            // FindRoom
            // 
            this.FindRoom.Location = new System.Drawing.Point(369, 82);
            this.FindRoom.Name = "FindRoom";
            this.FindRoom.Size = new System.Drawing.Size(136, 45);
            this.FindRoom.TabIndex = 2;
            this.FindRoom.Text = "Find Room";
            this.FindRoom.UseVisualStyleBackColor = true;
            // 
            // FindReservation
            // 
            this.FindReservation.Location = new System.Drawing.Point(227, 82);
            this.FindReservation.Name = "FindReservation";
            this.FindReservation.Size = new System.Drawing.Size(136, 45);
            this.FindReservation.TabIndex = 3;
            this.FindReservation.Text = "Find Reservation";
            this.FindReservation.UseVisualStyleBackColor = true;
            this.FindReservation.Click += new System.EventHandler(this.FindReservation_Click);
            // 
            // MakeReservation
            // 
            this.MakeReservation.Location = new System.Drawing.Point(995, 208);
            this.MakeReservation.Name = "MakeReservation";
            this.MakeReservation.Size = new System.Drawing.Size(148, 45);
            this.MakeReservation.TabIndex = 5;
            this.MakeReservation.Text = "Make Reservation";
            this.MakeReservation.UseVisualStyleBackColor = true;
            // 
            // CancelReservation
            // 
            this.CancelReservation.Location = new System.Drawing.Point(995, 82);
            this.CancelReservation.Name = "CancelReservation";
            this.CancelReservation.Size = new System.Drawing.Size(148, 45);
            this.CancelReservation.TabIndex = 6;
            this.CancelReservation.Text = "Cancel Reservation";
            this.CancelReservation.UseVisualStyleBackColor = true;
            // 
            // AddNewRoom
            // 
            this.AddNewRoom.Location = new System.Drawing.Point(995, 146);
            this.AddNewRoom.Name = "AddNewRoom";
            this.AddNewRoom.Size = new System.Drawing.Size(148, 45);
            this.AddNewRoom.TabIndex = 7;
            this.AddNewRoom.Text = "Add New Room";
            this.AddNewRoom.UseVisualStyleBackColor = true;
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(85, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(443, 47);
            this.Title.TabIndex = 8;
            // 
            // DataBox
            // 
            this.DataBox.AccessibleDescription = "";
            this.DataBox.Location = new System.Drawing.Point(85, 153);
            this.DataBox.Name = "DataBox";
            this.DataBox.Size = new System.Drawing.Size(549, 27);
            this.DataBox.TabIndex = 9;
            this.DataBox.MouseEnter += new System.EventHandler(this.DataBox_MouseEnter);
            this.DataBox.MouseLeave += new System.EventHandler(this.DataBox_MouseLeave);
            // 
            // DataView
            // 
            this.DataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Reservations,
            this.Action});
            this.DataView.Location = new System.Drawing.Point(87, 236);
            this.DataView.Name = "DataView";
            this.DataView.RowHeadersWidth = 51;
            this.DataView.RowTemplate.Height = 29;
            this.DataView.Size = new System.Drawing.Size(858, 258);
            this.DataView.TabIndex = 10;
            this.DataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataView_CellContentClick);
            this.DataView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.DataView_EditingControlShowing);
            // 
            // Reservations
            // 
            this.Reservations.HeaderText = "Reservations";
            this.Reservations.MinimumWidth = 6;
            this.Reservations.Name = "Reservations";
            this.Reservations.Text = "See";
            this.Reservations.UseColumnTextForButtonValue = true;
            this.Reservations.Width = 125;
            // 
            // Action
            // 
            this.Action.HeaderText = "Action";
            this.Action.Items.AddRange(new object[] {
            "Pay reservation fee",
            "Cancel reservation"});
            this.Action.MinimumWidth = 6;
            this.Action.Name = "Action";
            this.Action.Visible = false;
            this.Action.Width = 180;
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1196, 723);
            this.Controls.Add(this.DataView);
            this.Controls.Add(this.DataBox);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.AddNewRoom);
            this.Controls.Add(this.CancelReservation);
            this.Controls.Add(this.MakeReservation);
            this.Controls.Add(this.FindReservation);
            this.Controls.Add(this.FindRoom);
            this.Controls.Add(this.FindClient);
            this.Controls.Add(this.LogOut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMenu";
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.Button FindClient;
        private System.Windows.Forms.Button FindRoom;
        private System.Windows.Forms.Button FindReservation;
        private System.Windows.Forms.Button MakeReservation;
        private System.Windows.Forms.Button CancelReservation;
        private System.Windows.Forms.Button AddNewRoom;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox DataBox;
        private System.Windows.Forms.DataGridView DataView;
        private DataGridViewDisableButtonColumn Reservations;
        private System.Windows.Forms.DataGridViewComboBoxColumn Action;
    }
}