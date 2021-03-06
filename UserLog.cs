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

        private DisableButtonEvent disable = new DisableButtonEvent();
        private Form StartingForm;

        public UserLog(Form form)
        {
            InitializeComponent();
            StartingForm = form;
            disable.Writing += ShouldBeEnabled;
            SignIn.Enabled = false;
        }

        public void ShouldBeEnabled(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(IDBox.Text) && !String.IsNullOrEmpty(PassBox.Text))
            {
                SignIn.Enabled = true;
            }
            else
            {
                SignIn.Enabled = false;
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
                ILogable user = new User();
                User person = new User() { ID = IDBox.Text };
                person.SetPassword(PassBox.Text);
                DatabaseManager dbManager = new DatabaseManager();
                dbManager.UserDidNotFind += Info;

                bool authentication = Authentication.Login(dbManager,person, out user);

                if (!authentication)
                {
                    // Prevents ovveridding the message from the event.
                    if (MessageLabel.Text == "")
                    {
                        MessageLabel.Text = "User or password is incorrect.";
                    }
                }
                else
                {
                    BookingForm bookingForm = new BookingForm(StartingForm, user);
                    bookingForm.Show();
                    this.Close();
                    StartingForm.Hide();
                }

            }
        }

        private void IDBox_TextChanged(object sender, EventArgs e)
        {
            IDBox.ChangeBorderColorToRed();
            disable.OnWriting(sender, e);
        }

        private void IDBox_Click(object sender, System.EventArgs e)
        {
            IDBox.ChangeBorderColorToRed();
            disable.OnWriting(sender, e);
        }

        private void PassBox_TextChanged(object sender, EventArgs e)
        {
            PassBox.ChangeBorderColorToRed();
            disable.OnWriting(sender, e);
        }

        private void PassBox_Click(object sender, System.EventArgs e)
        {
            PassBox.ChangeBorderColorToRed();
            disable.OnWriting(sender, e);
        }

        // This method is needed for an event occuring when the user gave wrong ID.
        public void Info(string s)
        {
            MessageLabel.Text = s;
            MessageLabel.Left = 40;
        }
    }
}
