using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_system
{
    public class Authentication
    {
        // Data provided by the person who wants to log in.
        private readonly ILogable _userToLogIn;

        public Authentication(ILogable userToLogIn)
        {
            _userToLogIn = userToLogIn;
        }


        public string Login()
        {
            var isAuthenticated = _userToLogIn.Login(_userToLogIn); ;

            if (!isAuthenticated)
                return "User or password is incorrect.";

            return "Success";

        }
    }
}
