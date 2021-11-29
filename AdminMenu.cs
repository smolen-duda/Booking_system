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
    public partial class AdminMenu : Form
    {
        private Form StartingForm;
        private Administrator LoggedAdmin;
        private const string description = "Insert Name or Surname or ID/Reservation ID/ Room Number.";
        private object empty = new { Name = "", Surname = "", ID = "", Email = "", PhoneNumber = "" };
        private BindingList<User> clients = new BindingList<User>();
        private BindingSource source = new BindingSource();
        private List<string> data;
        private int CurrentClientID;
        private DataGridViewComboBoxEditingControl cbec = null;
        private string button;
        private int reservationData;

        private bool isSourceChanged = false;


        public AdminMenu(Form form, ILogable admin)
        {
            InitializeComponent();
            StartingForm = form;
            LoggedAdmin = (Administrator)admin;
            Title.Text = "You are logged as " + LoggedAdmin.Name + " " + LoggedAdmin.Surname;
            BindGrid();
            clients.Clear();
            isSourceChanged = false;
        }

        private void BindGrid()
        {

            DataView.DataSource = new List<object>() { empty };

            DataView.Columns["Reservations"].DisplayIndex = 6;

        }

        public void DisableButton()
        {
            DataGridViewDisableButtonCell btn = (DataGridViewDisableButtonCell)DataView.Rows[0].Cells[0];
            btn.Enabled = false;
            DataView.Invalidate();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            StartingForm.RemoveOwnedForm(this);
            StartingForm.Show();
            this.Close();
        }


        private void DataBox_MouseEnter(object sender, EventArgs e)
        {
            if (DataBox.Text == description)
            {
                DataBox.Text = string.Empty;
                DataBox.ForeColor = System.Drawing.Color.Black;
            }

        }

        private void DataBox_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(DataBox.Text))
            {
                DataBox.Text = description;
                DataBox.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void FindClient_Click(object sender, EventArgs e)
        {
            button = "client";
            isSourceChanged = false;
            data = DataBox.Text.ToLower().Trim().Split(" ").ToList();
            DatabaseManager dbManager = new DatabaseManager();
            clients = new BindingList<User>(dbManager.FindClient(data));
            List<object> clientsToDisplay = ClientsToDisplayForm();

            if (clientsToDisplay.Count == 0)
            {
                clientsToDisplay.Add(empty);
            }
            source.DataSource = clientsToDisplay;
            DataView.DataSource =source;
            DataView.Columns["Reservations"].Visible = true;
            DataView.Columns["Action"].Visible = false;
               
            DataView.Columns["Reservations"].DisplayIndex = 6;
            if (clientsToDisplay.Contains(empty))
            {
                DisableButton();
            }
        }

        //
        //
        //
        //
        //

        // Those methods are for event that occures when SelectedItem in column Action is changed.

        private void DataView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is DataGridViewComboBoxEditingControl)
            {
                cbec = e.Control as DataGridViewComboBoxEditingControl;
                cbec.SelectedIndexChanged -= Cbec_SelectedIndexChanged;
                cbec.SelectedIndexChanged += Cbec_SelectedIndexChanged;
            }
        }

        private void Cbec_SelectedIndexChanged(object sender, EventArgs e)
        {
            int currentRow = this.DataView.CurrentCell.RowIndex;
            int reservationID = Int32.Parse(this.DataView.Rows[currentRow].Cells[2].Value.ToString());
            if (cbec != null)
            {
                string action = cbec.SelectedItem.ToString();
                string message = "An error occures. Please try again.";
                int option = 0;
                if (cbec.SelectedItem == cbec.Items[0])
                {
                    message = "You are changing the status of the " +
                        "reservation to \"Paid\". Are you sure?";
                    option = 1;
                }
                else if (cbec.SelectedItem == cbec.Items[1])
                {
                    message = "Are you sure that you want " +
                        "to cancel this reservation?";
                    option = 2;
                }
                ConfirmationForm confirmationForm = new ConfirmationForm(message,option,reservationID);
                confirmationForm.ShowDialog();

                DatabaseManager dbManager = new DatabaseManager();
                if (button == "client")
                {
                    clients = new BindingList<User>(dbManager.FindClient(data));
                    source.DataSource = ReservationsToDisplayForm(clients[CurrentClientID].Reservations.ToList());
                    DataView.DataSource = source;
                    DataView.Columns["Action"].DisplayIndex = 8;
                }
                else if(button=="reservation")
                {
                    Reservation reservation= dbManager.FindReservation(reservationData);
                    List<Reservation> reservationList = new List<Reservation>();
                    reservationList.Add(reservation);
                    source.DataSource = ReservationsToDisplayForm(reservationList);
                    DataView.DataSource = source;
                    DataView.Columns["Action"].DisplayIndex = 8;
                }
                else if(button=="room")
                {

                }
                DataView.Refresh();
            }

        }






        private void DataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {   if (isSourceChanged == false)
            {
                int row = e.RowIndex;
                int col = e.ColumnIndex;
                if (row > -1 && col > -1)
                {
                    DataGridViewDisableButtonCell btn = (DataGridViewDisableButtonCell)DataView.Rows[row].Cells[col];

                    if (btn.Enabled)
                    {
                        DataView.Columns["Reservations"].Visible = false;
                        DataView.Columns["Action"].Visible = true;


                        source.DataSource = ReservationsToDisplayForm(clients[row].Reservations.ToList());
                        DataView.DataSource = source;
                        DataView.Columns["Action"].DisplayIndex = 8;
                        DataView.Refresh();

                        CurrentClientID = row;
                    }
                }
                isSourceChanged = true;
            }
        }


        // It creates a new list with objects to display in DataGridView.

        private List<object> ClientsToDisplayForm()
        {
            List<object> clientsToDisplay = new List<object>();
            foreach(User o in clients)
            {
                object temp = new { Name = o.Name, Surname = o.Surname, ID = o.ID, PhoneNumber = o.PhoneNumber, Email = o.Email };
                clientsToDisplay.Add(temp);
            }
            return clientsToDisplay;
        }


        // It creates a new list with objects to display in DataGridView.
        private List<object> ReservationsToDisplayForm(List<Reservation> reservations)
        {
            List<object> reservationsToDisplay = new List<object>();

            if (reservations[0]!=null)
            {
                foreach (Reservation r in reservations)
                {
                    DatabaseManager dbManager = new DatabaseManager();
                    List<Room> rooms = dbManager.GetRoomsForReservation(r);
                    string str = "";
                    int counter = 0;

                    foreach (Room room in rooms)
                    {
                        if (counter < 2)
                        {
                            str += room.Number + " ";
                        }
                        else
                        {
                            counter = 0;
                            str += room.Number + "\n";
                        }
                    }



                    object temp = new { ReservationID = r.ReservationID, From = r.FromDate, To = r.ToDate, DateOfCreating = r.DateOfReservationMaking, Status = r.Status, Fee = r.Fee, Rooms = str };
                    reservationsToDisplay.Add(temp);
                }
            }
            else
            {
                object temp = new { ReservationID = "", From = "", To = "", DateOfCreating = "", Status = "", Fee = "", Rooms = "" };
                reservationsToDisplay.Add(temp);
                DataView.Columns["Action"].Visible = false;
            }
            return reservationsToDisplay;
        }

        private void FindReservation_Click(object sender, EventArgs e)
        {
            button = "reservation";
            DatabaseManager dbManager = new DatabaseManager();
            Reservation reservation;
            if(Int32.TryParse(DataBox.Text.Trim(), out reservationData))
            {
                isSourceChanged = false;
                reservation =dbManager.FindReservation(reservationData);

                DataView.Columns["Reservations"].Visible = false;
                DataView.Columns["Action"].Visible = true;

                List<Reservation> reservationList = new List<Reservation>();
                reservationList.Add(reservation);

                source.DataSource = ReservationsToDisplayForm(reservationList);
                DataView.DataSource = source;
                DataView.Columns["Action"].DisplayIndex = 8;
                DataView.Refresh();
            }
            else
            {
                MessageBox.Show("ReservationID has to be an integer.");
            }
            isSourceChanged = true;
            

        }
    }
}
