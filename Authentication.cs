using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_system
{
    public static class Authentication
    {
        static Authentication()
        {
        }


        public static string Login(ILogable userToLogIn)
        {
            var isAuthenticated = userToLogIn.Login(); ;

            if (!isAuthenticated)
                return "User or password is incorrect.";

            return "Success";

        }
    }
}
