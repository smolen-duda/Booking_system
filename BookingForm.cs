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
    }
}
