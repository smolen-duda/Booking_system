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
    public partial class AddNewRoom : Form
    {

        private DisableButtonEvent disable = new DisableButtonEvent();
        private int number;
        private int numberOfBeds;
        private decimal fee;

        public AddNewRoom()
        {
            InitializeComponent();
            disable.Writing += ShouldBeEnabled;
            Add.Enabled = false;
        }


        public void ShouldBeEnabled(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(NumberBox.Text) && !String.IsNullOrEmpty(NumberOfBedsBox.Text)&& !String.IsNullOrEmpty(FeeBox.Text)
                && Int32.TryParse(NumberBox.Text, out number) && Int32.TryParse(NumberOfBedsBox.Text, out numberOfBeds) && Decimal.TryParse(FeeBox.Text, out fee))
            {
                Add.Enabled = true;
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NumberBox_TextChanged(object sender, EventArgs e)
        {
            NumberBox.ChangeBorderColorToRed(Add, !Int32.TryParse(NumberBox.Text, out number));
            disable.OnWriting(sender, e);
        }
        private void NumberBox_Click(object sender, EventArgs e)
        {
            NumberBox.ChangeBorderColorToRed(Add, !Int32.TryParse(NumberBox.Text, out number));
            disable.OnWriting(sender, e);
        }
        private void NumberOfBedsBox_TextChanged(object sender, EventArgs e)
        {
            NumberOfBedsBox.ChangeBorderColorToRed(Add, !Int32.TryParse(NumberOfBedsBox.Text, out numberOfBeds));
            disable.OnWriting(sender, e);
        }
        private void NumberOfBedsBox_Click(object sender, EventArgs e)
        {
            NumberOfBedsBox.ChangeBorderColorToRed(Add, !Int32.TryParse(NumberOfBedsBox.Text, out numberOfBeds));
            disable.OnWriting(sender, e);
        }
        private void FeeBox_TextChanged(object sender, EventArgs e)
        {
            FeeBox.ChangeBorderColorToRed(Add, !Decimal.TryParse(FeeBox.Text, out fee));
            disable.OnWriting(sender, e);
        }
        private void FeeBox_Click(object sender, EventArgs e)
        {
            FeeBox.ChangeBorderColorToRed(Add, !Decimal.TryParse(FeeBox.Text, out fee));
            disable.OnWriting(sender, e);
        }

        private void Add_Click(object sender, EventArgs e)
        {
            DatabaseManager dbManager = new DatabaseManager();
            dbManager.AddNewRoom(number,numberOfBeds, fee);
        }
    }
}
