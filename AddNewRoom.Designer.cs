
namespace Booking_system
{
    partial class AddNewRoom
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NumberBox = new Booking_system.ColorTextBox();
            this.NumberOfBedsBox = new Booking_system.ColorTextBox();
            this.FeeBox = new Booking_system.ColorTextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of beds";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fee";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(35, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(309, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "Provide data for the new room.";
            // 
            // NumberBox
            // 
            this.NumberBox.BorderColor = System.Drawing.Color.Gray;
            this.NumberBox.Location = new System.Drawing.Point(195, 99);
            this.NumberBox.Name = "NumberBox";
            this.NumberBox.Size = new System.Drawing.Size(149, 27);
            this.NumberBox.TabIndex = 3;
            this.NumberBox.Click += new System.EventHandler(this.NumberBox_Click);
            this.NumberBox.TextChanged += new System.EventHandler(this.NumberBox_TextChanged);
            // 
            // NumberOfBedsBox
            // 
            this.NumberOfBedsBox.BorderColor = System.Drawing.Color.Gray;
            this.NumberOfBedsBox.Location = new System.Drawing.Point(195, 145);
            this.NumberOfBedsBox.Name = "NumberOfBedsBox";
            this.NumberOfBedsBox.Size = new System.Drawing.Size(149, 27);
            this.NumberOfBedsBox.TabIndex = 4;
            this.NumberOfBedsBox.Click += new System.EventHandler(this.NumberOfBedsBox_Click);
            this.NumberOfBedsBox.TextChanged += new System.EventHandler(this.NumberOfBedsBox_TextChanged);
            // 
            // FeeBox
            // 
            this.FeeBox.BorderColor = System.Drawing.Color.Gray;
            this.FeeBox.Location = new System.Drawing.Point(195, 187);
            this.FeeBox.Name = "FeeBox";
            this.FeeBox.Size = new System.Drawing.Size(149, 27);
            this.FeeBox.TabIndex = 5;
            this.FeeBox.Click += new System.EventHandler(this.FeeBox_Click);
            this.FeeBox.TextChanged += new System.EventHandler(this.FeeBox_TextChanged);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(217, 257);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(127, 48);
            this.Add.TabIndex = 6;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(35, 257);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(127, 48);
            this.Cancel.TabIndex = 7;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // AddNewRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(393, 351);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.FeeBox);
            this.Controls.Add(this.NumberOfBedsBox);
            this.Controls.Add(this.NumberBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddNewRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewRoom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private ColorTextBox NumberBox;
        private ColorTextBox NumberOfBedsBox;
        private ColorTextBox FeeBox;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Cancel;
    }
}