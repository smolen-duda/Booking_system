using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_system
{
    public static class Authentication
    {

        public static bool Login(DatabaseManager dbManager, ILogable person, out ILogable user)
        {
            user = dbManager.Find(person);
            if (user != null)
            {
                if (user.GetPassword() == person.GetPassword())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

    }
}
