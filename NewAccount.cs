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
    public partial class NewAccount : Form
    {
        public NewAccount()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            DatabaseManager dbManager = new DatabaseManager();

            User user = new User() { Name = NameBox.Text, Surname = SurnameBox.Text, ID = IDBox.Text, PhoneNumber = PhoneBox.Text, Email = EmailBox.Text };
            user.SetPassword(PasswordBox.Text);
            try
            {
                dbManager.CreateNewAccount(user);
                MessageBox.Show("Account created.");
                this.Close();
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
            

        }

      /*  private void NewAccount_Load(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(NameBox.Text) || String.IsNullOrEmpty(Surname.Text) || String.IsNullOrEmpty(ID.Text) 
                || String.IsNullOrEmpty(Password.Text) || String.IsNullOrEmpty(PasswordCheck.Text))
            {
                SignUp.Enabled = false;
            }
        }*/
    }
}
