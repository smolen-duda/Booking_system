using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booking_system
{
    public partial class AdminLog : Form
    {
        private DisableButtonEvent disable = new DisableButtonEvent();
        private Form StartingForm;

        public AdminLog(Form form)
        {
            InitializeComponent();
            StartingForm = form;
            disable.Writing += ShouldBeEnabled;
            SignIn.Enabled = false;
        }

        public void ShouldBeEnabled(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(IDBox.Text) && !String.IsNullOrEmpty(PassBox.Text))
            {
                SignIn.Enabled = true;
            }
        }


        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            MessageLabel.Text = "";
            if (String.IsNullOrEmpty(IDBox.Text) && String.IsNullOrEmpty(PassBox.Text))
            {
                MessageLabel.Text = "Provide ID and password.";
            }
            else if (String.IsNullOrEmpty(PassBox.Text))
            {
                MessageLabel.Text = "Provide password.";
            }
            else if (String.IsNullOrEmpty(IDBox.Text))
            {
                MessageLabel.Text = "Provide ID.";
            }
            else
            {
                Administrator admin = new Administrator() { ID = IDBox.Text };
                admin.SetPassword(PassBox.Text);

                DatabaseManager dbManager = new DatabaseManager();
                dbManager.UserDidNotFind += Info;

                bool authentication = Authentication.Login(dbManager,admin);

                if (!authentication)
                {
                    // Prevents ovveridding the message from the event.
                    if (MessageLabel.Text == "")
                    {
                        MessageLabel.Text = "ID or password is incorrect.";
                    }
                }
                else
                {
                    AdminMenu adminMenu = new AdminMenu(StartingForm);
                    adminMenu.Show();
                    this.Close();
                    StartingForm.Hide();
                }
            }

        }

        private void IDBox_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(IDBox.Text))
            {
                IDBox.BorderColor = Color.Red;
                SignIn.Enabled = false;
            }
            else
            {
                IDBox.BorderColor = Color.Gray;
                disable.OnWriting(sender, e);
            }
        }
        private void IDBox_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(IDBox.Text))
            {
                IDBox.BorderColor = Color.Red;
                SignIn.Enabled = false;
            }
            else
            {
                IDBox.BorderColor = Color.Gray;
                disable.OnWriting(sender, e);
            }
        }

        private void PassBox_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(PassBox.Text))
            {
                PassBox.BorderColor = Color.Red;
                SignIn.Enabled = false;
            }
            else
            {
                PassBox.BorderColor = Color.Gray;
                disable.OnWriting(sender, e);
            }
        }

        private void PassBox_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(PassBox.Text))
            {
                PassBox.BorderColor = Color.Red;
                SignIn.Enabled = false;
            }
            else
            {
                PassBox.BorderColor = Color.Gray;
                disable.OnWriting(sender, e);
            }
        }


        // This method is needed for an event occuring when the user gave wrong ID.
        public void Info(string s)
        {
            MessageLabel.Text = s;
            MessageLabel.Left = 40;
        }
    }
}
