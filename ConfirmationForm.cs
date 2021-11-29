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
    public partial class ConfirmationForm : Form
    {
        private int Option;
        private int ReservationID;
        public ConfirmationForm(string message,int option, int id)
        {
            InitializeComponent();
            label.Text= message;
            Option = option;
            ReservationID = id;
        }

        private void No_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Yes_Click(object sender, EventArgs e)
        {
            DatabaseManager dbManager = new DatabaseManager();
            if(Option==1)
            {
                dbManager.PayTheFee(ReservationID);
            }
            else if(Option==2)
            {
                dbManager.CancelReservation(ReservationID);
            }
            this.Close();
        }
    }
}
