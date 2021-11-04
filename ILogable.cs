﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_system
{
    public interface ILogable
    {
        // Gets uniqe ID (uniqe ID as a PESEL, not this generated by database).
        public string GetID();

        public string GetPassword();

        public void SetPassword(string pass);

        public bool Login(DatabaseManager dbManager);
    }
}
