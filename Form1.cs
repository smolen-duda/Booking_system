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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimalize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void NewAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewAccount newAccount = new NewAccount();
            newAccount.Show();

        }

        private void UserSign_Click(object sender, EventArgs e)
        {
            UserLog userLog = new UserLog(this);
            userLog.Show();
        }

        private void AdminSign_Click(object sender, EventArgs e)
        {
            AdminLog adminLog = new AdminLog(this);
            adminLog.Show();
        }

        private void Tester_Click(object sender, EventArgs e)
        {
            ILogable user = new User() { Name = "Jan", Surname = "Kowalski", ID = "87110302233",
                                            PhoneNumber = "666222333", Email = "jan.kowalski@mail.com" };
            BookingForm bookingForm = new BookingForm(this,user);
            bookingForm.Show();
        }


    }
}
