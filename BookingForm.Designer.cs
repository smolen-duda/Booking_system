
namespace Booking_system
{
    partial class BookingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingForm));
            this.LogOut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ReservationPanel = new System.Windows.Forms.Panel();
            this.Cancel = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.PhoneBox = new Booking_system.ColorTextBox();
            this.EmailBox = new Booking_system.ColorTextBox();
            this.IDBox = new Booking_system.ColorTextBox();
            this.SurnameBox = new Booking_system.ColorTextBox();
            this.NameBox = new Booking_system.ColorTextBox();
            this.Reserve = new System.Windows.Forms.Button();
            this.Configuration = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NumberOfRoomsBox = new Booking_system.ColorTextBox();
            this.NumberOfPeopleBox = new Booking_system.ColorTextBox();
            this.RoomsPanel = new System.Windows.Forms.Panel();
            this.Check = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EndDate = new System.Windows.Forms.DateTimePicker();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.ReservationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogOut
            // 
            this.LogOut.BackColor = System.Drawing.Color.Transparent;
            this.LogOut.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LogOut.Location = new System.Drawing.Point(1095, 12);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(89, 36);
            this.LogOut.TabIndex = 0;
            this.LogOut.Text = "Log out";
            this.LogOut.UseVisualStyleBackColor = false;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.ReservationPanel);
            this.panel1.Controls.Add(this.NumberOfRoomsBox);
            this.panel1.Controls.Add(this.NumberOfPeopleBox);
            this.panel1.Controls.Add(this.RoomsPanel);
            this.panel1.Controls.Add(this.Check);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.EndDate);
            this.panel1.Controls.Add(this.StartDate);
            this.panel1.Location = new System.Drawing.Point(226, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(694, 683);
            this.panel1.TabIndex = 1;
            // 
            // ReservationPanel
            // 
            this.ReservationPanel.AutoScroll = true;
            this.ReservationPanel.Controls.Add(this.Cancel);
            this.ReservationPanel.Controls.Add(this.label10);
            this.ReservationPanel.Controls.Add(this.PhoneBox);
            this.ReservationPanel.Controls.Add(this.EmailBox);
            this.ReservationPanel.Controls.Add(this.IDBox);
            this.ReservationPanel.Controls.Add(this.SurnameBox);
            this.ReservationPanel.Controls.Add(this.NameBox);
            this.ReservationPanel.Controls.Add(this.Reserve);
            this.ReservationPanel.Controls.Add(this.Configuration);
            this.ReservationPanel.Controls.Add(this.label9);
            this.ReservationPanel.Controls.Add(this.label8);
            this.ReservationPanel.Controls.Add(this.label7);
            this.ReservationPanel.Controls.Add(this.label6);
            this.ReservationPanel.Controls.Add(this.label5);
            this.ReservationPanel.Location = new System.Drawing.Point(15, 250);
            this.ReservationPanel.Name = "ReservationPanel";
            this.ReservationPanel.Size = new System.Drawing.Size(669, 429);
            this.ReservationPanel.TabIndex = 9;
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.Peru;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.Location = new System.Drawing.Point(18, 348);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(138, 54);
            this.Cancel.TabIndex = 23;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(18, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(600, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Warning! All changes provided above will be saved in your profile. ID cannot be c" +
    "hanged.";
            // 
            // PhoneBox
            // 
            this.PhoneBox.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PhoneBox.Location = new System.Drawing.Point(409, 74);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(216, 27);
            this.PhoneBox.TabIndex = 21;
            this.PhoneBox.TextChanged += new System.EventHandler(this.PhoneBox_TextChanged);
            this.PhoneBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneBox_KeyPress);
            // 
            // EmailBox
            // 
            this.EmailBox.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.EmailBox.Location = new System.Drawing.Point(77, 131);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(231, 27);
            this.EmailBox.TabIndex = 20;
            this.EmailBox.TextChanged += new System.EventHandler(this.EmailBox_TextChanged);
            // 
            // IDBox
            // 
            this.IDBox.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.IDBox.Enabled = false;
            this.IDBox.Location = new System.Drawing.Point(46, 74);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(262, 27);
            this.IDBox.TabIndex = 19;
            this.IDBox.TextChanged += new System.EventHandler(this.IDBox_TextChanged);
            this.IDBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IDBox_KeyPress);
            // 
            // SurnameBox
            // 
            this.SurnameBox.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SurnameBox.Location = new System.Drawing.Point(427, 18);
            this.SurnameBox.Name = "SurnameBox";
            this.SurnameBox.Size = new System.Drawing.Size(198, 27);
            this.SurnameBox.TabIndex = 18;
            this.SurnameBox.TextChanged += new System.EventHandler(this.SurnameBox_TextChanged);
            this.SurnameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SurnameBox_KeyPress);
            // 
            // NameBox
            // 
            this.NameBox.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.NameBox.Location = new System.Drawing.Point(77, 18);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(231, 27);
            this.NameBox.TabIndex = 17;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            this.NameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameBox_KeyPress);
            // 
            // Reserve
            // 
            this.Reserve.BackColor = System.Drawing.Color.Peru;
            this.Reserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reserve.Location = new System.Drawing.Point(489, 345);
            this.Reserve.Name = "Reserve";
            this.Reserve.Size = new System.Drawing.Size(136, 57);
            this.Reserve.TabIndex = 15;
            this.Reserve.Text = "Reserve";
            this.Reserve.UseVisualStyleBackColor = false;
            this.Reserve.Click += new System.EventHandler(this.Reserve_Click);
            // 
            // Configuration
            // 
            this.Configuration.BackColor = System.Drawing.Color.White;
            this.Configuration.Location = new System.Drawing.Point(18, 211);
            this.Configuration.Name = "Configuration";
            this.Configuration.Size = new System.Drawing.Size(607, 117);
            this.Configuration.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(17, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 27);
            this.label9.TabIndex = 12;
            this.label9.Text = "Email:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Location = new System.Drawing.Point(346, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 27);
            this.label8.TabIndex = 10;
            this.label8.Text = "Phone:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(17, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 27);
            this.label7.TabIndex = 8;
            this.label7.Text = "ID:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(346, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 27);
            this.label6.TabIndex = 6;
            this.label6.Text = "Surname:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(17, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 27);
            this.label5.TabIndex = 0;
            this.label5.Text = "Name:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumberOfRoomsBox
            // 
            this.NumberOfRoomsBox.BorderColor = System.Drawing.SystemColors.GrayText;
            this.NumberOfRoomsBox.Location = new System.Drawing.Point(526, 111);
            this.NumberOfRoomsBox.MaxLength = 2;
            this.NumberOfRoomsBox.Name = "NumberOfRoomsBox";
            this.NumberOfRoomsBox.Size = new System.Drawing.Size(77, 27);
            this.NumberOfRoomsBox.TabIndex = 10;
            this.NumberOfRoomsBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOfRoomsBox_KeyPress);
            // 
            // NumberOfPeopleBox
            // 
            this.NumberOfPeopleBox.BorderColor = System.Drawing.SystemColors.GrayText;
            this.NumberOfPeopleBox.Location = new System.Drawing.Point(231, 111);
            this.NumberOfPeopleBox.MaxLength = 2;
            this.NumberOfPeopleBox.Name = "NumberOfPeopleBox";
            this.NumberOfPeopleBox.Size = new System.Drawing.Size(77, 27);
            this.NumberOfPeopleBox.TabIndex = 9;
            this.NumberOfPeopleBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOfPeopleBox_KeyPress);
            // 
            // RoomsPanel
            // 
            this.RoomsPanel.AutoScroll = true;
            this.RoomsPanel.Location = new System.Drawing.Point(12, 253);
            this.RoomsPanel.Name = "RoomsPanel";
            this.RoomsPanel.Size = new System.Drawing.Size(669, 429);
            this.RoomsPanel.TabIndex = 8;
            // 
            // Check
            // 
            this.Check.BackColor = System.Drawing.Color.Peru;
            this.Check.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Check.Location = new System.Drawing.Point(258, 176);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(193, 48);
            this.Check.TabIndex = 2;
            this.Check.Text = "Check availability";
            this.Check.UseVisualStyleBackColor = false;
            this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(389, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "Number of rooms:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(92, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Number of people:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(366, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "To:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "From: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EndDate
            // 
            this.EndDate.Location = new System.Drawing.Point(400, 58);
            this.EndDate.MinDate = new System.DateTime(2021, 11, 25, 0, 0, 0, 0);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(273, 27);
            this.EndDate.TabIndex = 1;
            this.EndDate.Value = new System.DateTime(2021, 11, 26, 13, 2, 27, 127);
            this.EndDate.ValueChanged += new System.EventHandler(this.EndDate_ValueChanged);
            // 
            // StartDate
            // 
            this.StartDate.Location = new System.Drawing.Point(61, 58);
            this.StartDate.MinDate = new System.DateTime(2021, 11, 24, 0, 0, 0, 0);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(276, 27);
            this.StartDate.TabIndex = 0;
            this.StartDate.Value = new System.DateTime(2021, 11, 25, 13, 2, 27, 128);
            this.StartDate.ValueChanged += new System.EventHandler(this.StartDate_ValueChanged);
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1196, 721);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LogOut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookingForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ReservationPanel.ResumeLayout(false);
            this.ReservationPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker EndDate;
        private System.Windows.Forms.DateTimePicker StartDate;
        private System.Windows.Forms.Button Check;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel RoomsPanel;
        private ColorTextBox NumberOfRoomsBox;
        private ColorTextBox NumberOfPeopleBox;
        private System.Windows.Forms.Panel ReservationPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private ColorTextBox PhoneBox;
        private ColorTextBox EmailBox;
        private ColorTextBox IDBox;
        private ColorTextBox SurnameBox;
        private ColorTextBox NameBox;
        private System.Windows.Forms.Button Reserve;
        private System.Windows.Forms.Label Configuration;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Cancel;
    }
}