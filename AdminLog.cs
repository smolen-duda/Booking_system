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
        public AdminLog()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(IDBox.Text))
            {
                if (String.IsNullOrEmpty(PassBox.Text))
                {
                    MessageLabel.Text = "Provide ID and password.";
                }
                else
                {
                    MessageLabel.Text = "Provide password.";
                }

                MessageLabel.Text = "Provide ID.";
            }
            else
            {
                Administrator admin = new Administrator() { ID = IDBox.Text };
                admin.SetPassword(PassBox.Text);

                bool authentication = Authentication.Login(admin);

                if (!authentication)
                {
                    MessageLabel.Text = "ID or password is incorrect.";
                }
                else
                {
                    AdminMenu adminMenu = new AdminMenu();
                    adminMenu.Show();
                }
            }

        }
    }
}
