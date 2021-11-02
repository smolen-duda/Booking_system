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
    public partial class UserLog : Form
    {
        public UserLog()
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
                User user = new User() { ID = IDBox.Text };
                user.SetPassword(PassBox.Text);

                string authenticationMessage = Authentication.Login(user);

                MessageLabel.Text = authenticationMessage;

            }
        }
    }
}
