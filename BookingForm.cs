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
    public partial class BookingForm : Form
    {
        private Form StartingForm;
        public BookingForm(Form form)
        {
            InitializeComponent();
            StartingForm = form;
            EndDate.Value = StartDate.Value.AddDays(1);
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            StartingForm.Show();
        }

        private void StartDate_ValueChanged(object sender, EventArgs e)
        {
            EndDate.Value = StartDate.Value.AddDays(1);
        }

        private void Check_Click(object sender, EventArgs e)
        {
            NumberOfPeopleBox.ChangeBorderColorToRed();
            NumberOfRoomsBox.ChangeBorderColorToRed();

            if (!String.IsNullOrEmpty(NumberOfPeopleBox.Text) && !String.IsNullOrEmpty(NumberOfRoomsBox.Text))
            {
                int people = Int16.Parse(NumberOfPeopleBox.Text);
                int rooms = Int16.Parse(NumberOfRoomsBox.Text);
                DateTime from = StartDate.Value;
                DateTime to = EndDate.Value;
                DatabaseManager dbManager = new DatabaseManager();
                
               // bool availability=dbManager.Search(people,rooms,from,to);

            }
           
            

        }


        // This method disables non integer number of people.
        private void NumberOfPeopleBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && ((e.KeyChar != '.') || (e.KeyChar != ',')))
            {
                e.Handled = true;
            }
        }

        // This method disables non integer number of rooms.
        private void NumberOfRoomsBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && ((e.KeyChar != '.') || (e.KeyChar != ',')))
            {
                e.Handled = true;
            }
        }
    }
}
