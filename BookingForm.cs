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
        private List<Button> buttons = new List<Button>();
        private List<List<Room>> rooms = new List<List<Room>>();
        private Form StartingForm;
        private User LoggedUser;
        public BookingForm(Form form, ILogable user)
        {
            InitializeComponent();
            StartingForm = form;
            LoggedUser = (User)user;
            EndDate.Value = StartDate.Value.AddDays(1);
            this.ReservationPanel.Hide();
            this.RoomsPanel.Show();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {

            rooms.Clear();
            buttons.Clear();
            this.Close();
            StartingForm.Show();
        }

        private void StartDate_ValueChanged(object sender, EventArgs e)
        {
            EndDate.Value = StartDate.Value.AddDays(1);
        }

        private void Check_Click(object sender, EventArgs e)
        {
            this.ReservationPanel.Hide();
            this.RoomsPanel.Show();
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


                //Searching for all configurations of rooms.

                rooms.Clear();
                rooms = dbManager.SearchForRooms(people, numberOfRooms, from, to);

                // Checking if there are some configurations of rooms.

                if(rooms.Count==0)
                {
                    Label noRooms = CreateNewLabel(Check.Location.X - 15, 15, "No rooms are available.", new Size(200, 30));
                    this.RoomsPanel.Controls.Add(noRooms);
                }

                // Creating labels and buttons for all options.

                List<Label> labels = new List<Label>();
                buttons.Clear();

                foreach (List<Room> configuration in rooms)
                {
                    int coordY = 0;
                    int previousSizeH = 0;
                    int previousSizeW = 400;

                    if (labels.Any())
                    {
                        coordY = labels[labels.Count()-1].Location.Y;
                        previousSizeH = labels[labels.Count() - 1].Size.Height;
                        previousSizeW = labels[labels.Count() - 1].Size.Width;
                    }

                    decimal price = 0;
                    string str = "";
                    foreach (Room room in configuration)
                    {
                        str += room.NumberOfBeds + " Person room\n" ;
                        price += room.Fee;
                    }
                    str +="Price: "+price;

                    Label temp = CreateNewLabel(RoomsPanel.Location.X + 10, coordY + previousSizeH + 15, str, new Size(400, 100));
                    Button tempButton = CreateNewButton(RoomsPanel.Location.X + 40+previousSizeW, coordY + previousSizeH + 45,"Reserve",new Size(100, 40));
                    this.RoomsPanel.Controls.Add(temp);
                    this.RoomsPanel.Controls.Add(tempButton);

                    labels.Add(temp);
                    buttons.Add(tempButton);

                }
            }

        }

        // This method displays informations about possible configurations of rooms in a label. It creates an apriopiate number of labels.
        private Label CreateNewLabel(int locationX, int locationY, string text, Size size)
        {
            Label newLabel = new Label();
            newLabel.Location = new Point(locationX,locationY);
            newLabel.Text = text;
            newLabel.Size =size;

            newLabel.BackColor = System.Drawing.Color.White;
            newLabel.Show();

            return newLabel;
        }

        // This creates an apriopiate number of buttons enabling choosing the given configuration of rooms.
        private Button CreateNewButton(int locationX, int locationY, string text, Size size)
        {
            Button newButton = new Button();
            newButton.Location = new Point(locationX, locationY);
            newButton.Text = text;
            newButton.Size = size;

            newButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            newButton.BackColor = System.Drawing.Color.Peru;
            newButton.Click += (s, e) =>
            {
                int index =  buttons.IndexOf(newButton);
                List<Room> configuration =  rooms[index];
                this.RoomsPanel.Hide();

                CompleteTheReservationForm();
                this.ReservationPanel.Show();
            };


            newButton.Show();
            return newButton;
        }


        // This method disables non integer number of people.
        private void NumberOfPeopleBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && ((e.KeyChar != '.') || (e.KeyChar != ','))|| (NumberOfPeopleBox.Text=="" && e.KeyChar=='0'))
            {
                e.Handled = true;
            }
        }

        // This method disables non integer number of rooms.
        private void NumberOfRoomsBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && ((e.KeyChar != '.') || (e.KeyChar != ',')) || (NumberOfPeopleBox.Text == "" && e.KeyChar == '0'))
            {
                e.Handled = true;
            }
        }

        //This method creates controls for collecting data from user;

        private void CompleteTheReservationForm()
        {
            NameBox.Text = LoggedUser.Name;
            SurnameBox.Text = LoggedUser.Surname;
            IDBox.Text = LoggedUser.ID;
            PhoneBox.Text = LoggedUser.PhoneNumber;
            EmailBox.Text = LoggedUser.Email;
        }


        private void Cancel_Click(object sender, EventArgs e)
        {
            this.ReservationPanel.Hide();
            this.RoomsPanel.Show();

        }
    }
}
