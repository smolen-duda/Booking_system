
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
            this.EndDate.MinDate = new System.DateTime(2021, 11, 8, 0, 0, 0, 0);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(273, 27);
            this.EndDate.TabIndex = 1;
            this.EndDate.Value = new System.DateTime(2021, 11, 8, 0, 0, 0, 0);
            // 
            // StartDate
            // 
            this.StartDate.Location = new System.Drawing.Point(61, 58);
            this.StartDate.MinDate = new System.DateTime(2021, 11, 8, 0, 0, 0, 0);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(276, 27);
            this.StartDate.TabIndex = 0;
            this.StartDate.Value = new System.DateTime(2021, 11, 8, 0, 0, 0, 0);
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
    }
}