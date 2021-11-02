
namespace Booking_system
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Close1 = new System.Windows.Forms.Button();
            this.Minimalize = new System.Windows.Forms.Button();
            this.Admin = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NewAccount = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // Close1
            // 
            this.Close1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Close1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Close1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Close1.Location = new System.Drawing.Point(1156, 12);
            this.Close1.Name = "Close1";
            this.Close1.Size = new System.Drawing.Size(33, 30);
            this.Close1.TabIndex = 0;
            this.Close1.Text = "x\r\n";
            this.Close1.UseVisualStyleBackColor = false;
            this.Close1.Click += new System.EventHandler(this.Close_Click);
            // 
            // Minimalize
            // 
            this.Minimalize.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Minimalize.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Minimalize.Location = new System.Drawing.Point(1117, 12);
            this.Minimalize.Name = "Minimalize";
            this.Minimalize.Size = new System.Drawing.Size(33, 30);
            this.Minimalize.TabIndex = 1;
            this.Minimalize.Text = "_";
            this.Minimalize.UseVisualStyleBackColor = false;
            this.Minimalize.Click += new System.EventHandler(this.Minimalize_Click);
            // 
            // Admin
            // 
            this.Admin.BackColor = System.Drawing.Color.Tan;
            this.Admin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Admin.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Admin.ImageKey = "(brak)";
            this.Admin.Location = new System.Drawing.Point(658, 314);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(155, 62);
            this.Admin.TabIndex = 2;
            this.Admin.Text = "Administrator";
            this.Admin.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Tan;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(436, 314);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 62);
            this.button2.TabIndex = 3;
            this.button2.Text = "User";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(508, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 62);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sign in as ";
            this.label1.UseMnemonic = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(551, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Or create";
            // 
            // NewAccount
            // 
            this.NewAccount.AutoSize = true;
            this.NewAccount.BackColor = System.Drawing.Color.Transparent;
            this.NewAccount.Location = new System.Drawing.Point(616, 400);
            this.NewAccount.Name = "NewAccount";
            this.NewAccount.Size = new System.Drawing.Size(92, 20);
            this.NewAccount.TabIndex = 6;
            this.NewAccount.TabStop = true;
            this.NewAccount.Text = "new account";
            this.NewAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NewAccount_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1196, 723);
            this.Controls.Add(this.NewAccount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.Minimalize);
            this.Controls.Add(this.Close1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking system";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Close1;
        private System.Windows.Forms.Button Minimalize;
        private System.Windows.Forms.Button Admin;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel NewAccount;
    }
}

