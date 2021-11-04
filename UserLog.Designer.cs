
namespace Booking_system
{
    partial class UserLog
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
            this.SignIn = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.IDBox = new Booking_system.ColorTextBox();
            this.PassBox = new Booking_system.ColorTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(102, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign in as a User";
            // 
            // SignIn
            // 
            this.SignIn.Location = new System.Drawing.Point(269, 385);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(126, 52);
            this.SignIn.TabIndex = 1;
            this.SignIn.Text = "Sign In";
            this.SignIn.UseVisualStyleBackColor = true;
            this.SignIn.Click += new System.EventHandler(this.SignIn_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(29, 385);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(126, 52);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "User ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.ForeColor = System.Drawing.Color.Red;
            this.MessageLabel.Location = new System.Drawing.Point(80, 106);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(0, 20);
            this.MessageLabel.TabIndex = 7;
            // 
            // IDBox
            // 
            this.IDBox.BorderColor = System.Drawing.SystemColors.GrayText;
            this.IDBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.IDBox.Location = new System.Drawing.Point(80, 202);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(233, 27);
            this.IDBox.TabIndex = 8;
            this.IDBox.Click += new System.EventHandler(this.IDBox_Click);
            this.IDBox.TextChanged += new System.EventHandler(this.IDBox_TextChanged);
            // 
            // PassBox
            // 
            this.PassBox.BorderColor = System.Drawing.SystemColors.GrayText;
            this.PassBox.Location = new System.Drawing.Point(80, 289);
            this.PassBox.Name = "PassBox";
            this.PassBox.Size = new System.Drawing.Size(233, 27);
            this.PassBox.TabIndex = 9;
            this.PassBox.Click += new System.EventHandler(this.PassBox_Click);
            this.PassBox.TextChanged += new System.EventHandler(this.PassBox_TextChanged);
            this.PassBox.PasswordChar = '*';
            // 
            // UserLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(423, 468);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.SignIn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserLog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SignIn;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label MessageLabel;
        private ColorTextBox IDBox;
        private ColorTextBox PassBox;
    }
}