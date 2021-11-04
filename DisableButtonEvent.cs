using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Booking_system
{

    public class DisableButtonEvent
    {
        public DisableButtonEvent()
        {

        }

        public delegate void WritingEventHandler(object sender, EventArgs e);
        public event WritingEventHandler Writing;

        public void OnWriting(object sender, EventArgs e)
        {
            if (Writing != null)
            {
                Writing(sender, e);
            }
        }


    }
}
        
    
