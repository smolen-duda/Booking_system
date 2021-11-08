using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Dynamic.Core;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Booking_system
{
    public class DatabaseManager
    {
        public DatabaseManager()
        {

        }


        public delegate void UserDoesNotExistsHandler(string message);
        public event UserDoesNotExistsHandler UserDidNotFind;



        // This method finds person in a respective table in the database.
        // All classes mantaining person's data must implement interface ILogable.

        public ILogable Find(ILogable user)
        {
            Type accountType = user.GetType();
            using (Context db = new Context())
            {
                string id = user.GetID();
                var userDatabase = user;
                try
                {
                    userDatabase=db.Set(accountType).Where("ID=@0",id).First();
                    return userDatabase;
                }
                catch(Exception e)
                {
                    if(e.HResult== -2146233079)
                    {
                        OnUserDidNotFind("There is no such an account. Please sign up first.");
                    }
                    else
                    {
                        MessageBox.Show(e.Message);
                    }

                    return null;
                }
            }
        }


        public void OnUserDidNotFind(string str)
        {
            if(UserDidNotFind!=null)
            {
                UserDidNotFind(str);
            }
        }


        //This method adds a new account in a respective table in the database.

        public void CreateNewAccount(ILogable person)
        {

            Type accountType = person.GetType();
            using (Context db = new Context())
            {
                string id = person.GetID();
                var userDatabase = person;
                try
                {
                    db.Set(accountType).Add(person);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        public List<List<Room>> Search(int people, int rooms, DateTime from, DateTime to)
        {
            List<List<Room>> options = new List<List<Room>>();

            using (Context db = new Context())
            {
                
            }

                return options;
        }

        //Checks availability of the room in given dates.
        private bool CheckAvailability(Room room, DateTime from, DateTime to)
        {
            bool availability = false;

            using (Context db = new Context())
            {
                if(!db.Reservations.Where(r => r.Rooms.Contains(room) && (from < r.ToDate || to > r.FromDate)).Any())
                {
                    availability = true;
                }
            }

            return availability;
        }
        

    }
}
