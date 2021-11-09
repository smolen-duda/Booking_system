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
            RoomsPanel.Controls.Clear();

            NumberOfPeopleBox.ChangeBorderColorToRed();
            NumberOfRoomsBox.ChangeBorderColorToRed();

            if (!String.IsNullOrEmpty(NumberOfPeopleBox.Text) && !String.IsNullOrEmpty(NumberOfRoomsBox.Text))
            {
                int people = Int16.Parse(NumberOfPeopleBox.Text);
                int numberOfRooms = Int16.Parse(NumberOfRoomsBox.Text);
                DateTime from = StartDate.Value;
                DateTime to = EndDate.Value;
                DatabaseManager dbManager = new DatabaseManager();

                List<List<Room>> rooms = dbManager.SearchForRooms(people, numberOfRooms, from, to);

                if(rooms.Count==0)
                {
                    Label noRooms = new Label();
                    noRooms.Location = new Point(Check.Location.X-15,  15);
                    noRooms.Text = "No rooms are available.";
                    noRooms.Size = new Size(200, 30);

                    noRooms.BackColor = System.Drawing.Color.White;

                    this.RoomsPanel.Controls.Add(noRooms);

                    noRooms.Show();
                }    

                List<Label> labels = new List<Label>();

                foreach (List<Room> configuration in rooms)
                {
                    var temp = new Label();
                    int coordY = 0;
                    int previousSize = 0;

                    if (labels.Any())
                    {
                        coordY = labels[labels.Count()-1].Location.Y;
                        previousSize = labels[labels.Count() - 1].Size.Height;
                    }

                    temp.Location = new Point(RoomsPanel.Location.X+10, coordY + previousSize+ 15);

                    decimal price = 0;
                    string str = "";
                    foreach (Room room in configuration)
                    {
                        str += room.NumberOfBeds + " Person room\n" ;
                        price += room.Fee;
                    }
                    str += price;

                    temp.Text = str;
                    temp.Size = new Size(400, 100);
                   // temp.Click += new EventHandler(BookinForm_Load);

                    temp.BackColor = System.Drawing.Color.White;

                    this.RoomsPanel.Controls.Add(temp);

                    temp.Show();
                    labels.Add(temp);

                }
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
