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


        public AdminMenu(Form form, ILogable admin)
        {
            InitializeComponent();
            StartingForm = form;
            LoggedAdmin = (Administrator)admin;
            Title.Text = "You are logged as " + LoggedAdmin.Name + " " + LoggedAdmin.Surname;
            BindGrid();
        }

        private void BindGrid()
        {

            DataView.DataSource = new List<object>() { empty };

            DataView.Columns["Reservations"].DisplayIndex = 5;

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
            List<string> data = DataBox.Text.ToLower().Trim().Split(" ").ToList();
            DatabaseManager dbManager = new DatabaseManager();
            DataView.DataSource = dbManager.FindClient(data);
        }

        private void DataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row=e.RowIndex;
            int col = e.ColumnIndex;
            DataGridViewDisableButtonCell btn = (DataGridViewDisableButtonCell)DataView.Rows[row].Cells[col];
            if (btn.Enabled)
            {
                MessageBox.Show("Click!");
            }
        }
    }
}
