using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;

namespace Booking_system
{
    public partial class BookingForm : Form
    {
        private bool isChanged = false; // This variable checks if the user changed some data during making a reservation.
        private List<Room> configuration = new List<Room>();
        private DisableButtonEvent disable = new DisableButtonEvent();
        private List<Button> buttons = new List<Button>();
        private List<Label> labels = new List<Label>();
        private List<List<Room>> rooms = new List<List<Room>>();
        private Form StartingForm;
        private User LoggedUser;
        private List<decimal> prices = new List<decimal>();
        private decimal choosenPrice = 0;

        public BookingForm(Form form, ILogable user)
        {
            InitializeComponent();
            StartingForm = form;
            LoggedUser = (User)user;

            disable.Writing += ShouldBeEnabled;

            EndDate.Value = StartDate.Value.AddDays(1);

            this.ReservationPanel.Hide();
            this.RoomsPanel.Show();
        }

        public void ShouldBeEnabled(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(NameBox.Text) && !String.IsNullOrEmpty(SurnameBox.Text)&& !String.IsNullOrEmpty(IDBox.Text)&&
                !String.IsNullOrEmpty(PhoneBox.Text)&& !String.IsNullOrEmpty(EmailBox.Text))
            {
                Reserve.Enabled = true;
            }
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            configuration.Clear();
            rooms.Clear();
            buttons.Clear();
            StartingForm.RemoveOwnedForm(this);
            StartingForm.Show();
            this.Close();
        }

        private void StartDate_ValueChanged(object sender, EventArgs e)
        {
            EndDate.Value = StartDate.Value.AddDays(1);

            RoomsPanel.Hide();
            ReservationPanel.Hide();
        }

        private void Check_Click(object sender, EventArgs e)
        {
            isChanged = false;
            this.ReservationPanel.Hide();
            this.RoomsPanel.Show();
            RoomsPanel.Controls.Clear();
            prices.Clear();

            NumberOfPeopleBox.ChangeBorderColorToRed();
            NumberOfRoomsBox.ChangeBorderColorToRed();

            if (!String.IsNullOrEmpty(NumberOfPeopleBox.Text) && !String.IsNullOrEmpty(NumberOfRoomsBox.Text))
            {
                int people = Int16.Parse(NumberOfPeopleBox.Text);
                int numberOfRooms = Int16.Parse(NumberOfRoomsBox.Text);
                DateTime from = StartDate.Value.Date;
                DateTime to = EndDate.Value.Date;
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

                labels.Clear();
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
                    prices.Add(price);

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
                configuration.Clear();
                int index =  buttons.IndexOf(newButton);
                configuration =  rooms[index];
                choosenPrice = prices[index];
                this.RoomsPanel.Hide();

                CompleteTheReservationForm(labels[index].Text);
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

        private void CompleteTheReservationForm(string text)
        {
            NameBox.Text = LoggedUser.Name;
            SurnameBox.Text = LoggedUser.Surname;
            IDBox.Text = LoggedUser.ID;
            PhoneBox.Text = LoggedUser.PhoneNumber;
            EmailBox.Text = LoggedUser.Email;

            Configuration.Text ="Choosen option:\n"+text;
        }


        private void Cancel_Click(object sender, EventArgs e)
        {
            this.ReservationPanel.Hide();
            this.RoomsPanel.Show();
            isChanged = false;

        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            IsTextBoxEmpty(NameBox, sender, e);
            isChanged = true;
        }

        private void SurnameBox_TextChanged(object sender, EventArgs e)
        {
            IsTextBoxEmpty(SurnameBox, sender, e);
            isChanged = true;
        }


        private void PhoneBox_TextChanged(object sender, EventArgs e)
        {
            IsTextBoxEmpty(PhoneBox, sender, e);
            isChanged = true;
        }

        private void EmailBox_TextChanged(object sender, EventArgs e)
        {
            IsTextBoxEmpty(EmailBox, sender, e);
            bool isCorrect=new EmailAddressAttribute().IsValid(EmailBox.Text);
            if(!isCorrect)
            {
                EmailBox.BorderColor = Color.Red;
                Reserve.Enabled = false;
            }
            else
            {
                EmailBox.BorderColor = Color.Gray;
                disable.OnWriting(sender, e);
            }
            isChanged = true;

        }

        // Cheks if text in the given textbox is "" or null. If yes it disables Reserve button
        // and changes border color to red, if no changes border color to gray.
        private void IsTextBoxEmpty(ColorTextBox textBox, object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox.Text))
            {
                textBox.BorderColor = Color.Red;
                Reserve.Enabled = false;
            }
            else
            {
                textBox.BorderColor = Color.Gray;
                disable.OnWriting(sender, e);
            }
        }


        // This method disables non integer phone number.
        private void PhoneBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && ((e.KeyChar != '.') || (e.KeyChar != ',')))
            {
                e.Handled = true;
            }
        }


        // This method disables non integer ID.
        private void IDBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && ((e.KeyChar != '.') || (e.KeyChar != ',')))
            {
                e.Handled = true;
            }
        }

        // This method disables numbers in names.
        private void NameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // This method disables numbers in names.
        private void SurnameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Reserve_Click(object sender, EventArgs e)
        {
            DatabaseManager dbManager = new DatabaseManager();
            if (isChanged = true)
            {
                dbManager.UpdateUserData(LoggedUser, NameBox.Text, SurnameBox.Text, IDBox.Text, PhoneBox.Text, EmailBox.Text);
            }

            Reservation reservation = new Reservation();
            reservation.FromDate = StartDate.Value.Date;
            reservation.ToDate = EndDate.Value.Date;
            reservation.User = LoggedUser;
            reservation.Rooms = configuration;
            reservation.Fee =choosenPrice;
            dbManager.MakeReservation(LoggedUser, reservation, configuration);

            BookingForm bookingForm = new BookingForm(StartingForm,LoggedUser);
            this.Close();
            bookingForm.Show();
        }

        private void EndDate_ValueChanged(object sender, EventArgs e)
        {
            RoomsPanel.Hide();
            ReservationPanel.Hide();
        }
    }
}
