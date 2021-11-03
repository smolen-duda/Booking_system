using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Dynamic.Core;
using System.Windows.Forms;

namespace Booking_system
{
    public class DatabaseManager
    {
        public DatabaseManager()
        {

        }

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
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                return userDatabase;
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

        

    }
}
