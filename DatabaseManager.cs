using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Dynamic.Core;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Net.Mail;
using System.Net;

namespace Booking_system
{
    public class DatabaseManager
    {
        public DatabaseManager()
        {
            
        }


        public delegate void UserDoesNotExistsHandler(string message);
        public event UserDoesNotExistsHandler UserDidNotFind;



        // This method finds person with the given ID in a respective table in the database. 
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

                    MessageBox.Show("Account created.");
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

        public List<List<Room>> SearchForRooms(int people, int numberOfRooms, DateTime from, DateTime to)
        {
            int maxRoom;
            List<List<Room>> possibleRooms = new List<List<Room>>();
            using (Context db = new Context())
            {
                maxRoom = db.Rooms.Max(r => r.NumberOfBeds);
                List<List<int>> possibleConfigurations=IntegerPartition.Partition(people, maxRoom, numberOfRooms);
                foreach (List<int> configuration in possibleConfigurations)
                {
                    List<Room> temp = new List<Room>();
                    foreach (int i in configuration)
                    {
                        List<Room> rooms=db.Rooms.Include("Reservations").Where(r => r.NumberOfBeds == i).ToList();
                        if (rooms.Any())
                        {
                            bool isDone=IsUsedIfNotThenAdd(rooms, temp, from, to);
                            if (!isDone)
                            {
                                temp.Clear();
                                break;
                            }
                        }
                        else
                        {
                            temp.Clear();
                            break;
                        }

                    }
                    if (temp.Count != 0)
                    {
                        possibleRooms.Add(temp);
                    }
                    
                }
            }
            return possibleRooms;
        }

        private bool IsUsedIfNotThenAdd(List<Room> rooms, List<Room> choosenRooms, DateTime from, DateTime to)
        {
            if (!choosenRooms.Contains(rooms[0])&& CheckAvailability(rooms[0], from,to))
            {
                choosenRooms.Add(rooms[0]);
                return true;
            }
            else
            {
                List<Room> roomsCopy = new List<Room>(rooms);
                roomsCopy.RemoveAt(0);
                if (roomsCopy.Count != 0)
                {
                   return IsUsedIfNotThenAdd(roomsCopy, choosenRooms, from, to);
                }
                else
                {
                    return false;
                }
            }
        }

        //Checks availability of the room in given dates.
        private bool CheckAvailability(Room room, DateTime from, DateTime to)
        {
            bool availability = false;

            using (Context db = new Context())
            {
                List<Reservation> reservations = db.Reservations.Where(r => r.Rooms.Select(ro => ro.RoomID).Contains(room.RoomID) && r.ToDate >= from).ToList();
                bool condition=Availability(reservations, from, to);

                if (condition)
                {
                    availability = true;
                }
            }

            return availability;
        }

        private bool Availability(List<Reservation> reservations, DateTime from,DateTime to)
        {
            DateTime start;
            DateTime end;
            foreach(Reservation reservation in reservations)
            {
                if(from<reservation.FromDate.Date)
                {
                    start = reservation.FromDate.Date;
                }
                else
                {
                    start = from;
                }
                if(to<reservation.ToDate.Date)
                {
                    end = to;
                }
                else
                {
                    end = reservation.ToDate.Date;
                }
                if(start<end)
                {
                    return false;
                }
            }
            return true;
        }


        // This method adds new reservation.
        public void MakeReservation(User user, Reservation reservation, List<Room> rooms)
        {
            using(Context db = new Context())
            {
                try
                {
                    db.Users.Attach(user);
                    foreach (Room room in rooms)
                    {
                        db.Rooms.Attach(room);
                    }
                    db.Reservations.Add(reservation);

                    db.SaveChanges();
                    try
                    {
                        SendMail(reservation);
                    }
                    catch(Exception e)
                    {
                        throw;
                    }

                    MessageBox.Show("Reservation is made.");
                }
                catch(Exception ex)
                {
                    throw;
                }
                
            }
        }
        

        //This method sends an email to the user with confimation of the reservation.

        private void SendMail(Reservation reservation)
        {
            try
            {
                SmtpClient clientDetails = new SmtpClient();
                // here is clientDetails.Port 
                // here is clientDetails.Host 
                clientDetails.DeliveryMethod = SmtpDeliveryMethod.Network;
                clientDetails.EnableSsl = true;
                clientDetails.UseDefaultCredentials = false;
                // Here are clientDetails.Credentials.

                MailMessage mailDetails = new MailMessage();
                // mailDetails.From = here is an email adress of sender.
                mailDetails.To.Add(reservation.User.Email);
                mailDetails.Subject = "Reservation " + reservation.ReservationID;
                mailDetails.IsBodyHtml = false;
                string message = "Dear " + reservation.User.Name + " " + reservation.User.Surname + "\n" +
                    "your reservation from "+reservation.FromDate.ToString()+" to "+reservation.ToDate.ToString()+" is confirmed.\n"+
                    "Yours sincerely\n"+
                    "Hotel service";
                mailDetails.Body = message;

                clientDetails.Send(mailDetails);
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        // This method updates user data if the user changes some personal data during making a reservation.

        public void UpdateUserData(User user, string name,string surname, string id, string phone, string mail)
        {
            using (Context db = new Context())
            {
                db.Users.Attach(user);
                user.Name = name;
                user.Surname = surname;
                user.ID = id;
                user.PhoneNumber = phone;
                user.Email = mail;
                try
                {
                    db.SaveChanges();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //This method search for users which pass the criteria  given as a one string.
        //It is used when the admin wants to find a given user.

        public List<User> FindClient(List<string> data)
        {
            using (Context db = new Context())
            {
                Func<User, bool> p = u =>
                {
                     if (data.Count >= 3)
                     {
                         return data.Contains(u.Name.ToLower()) && data.Contains(u.Surname.ToLower()) && data.Contains(u.ID.ToLower());
                     }
                     else if (data.Count == 2)
                     {
                         return (data.Contains(u.Name.ToLower()) && data.Contains(u.Surname.ToLower()) && !data.Contains(u.ID.ToLower()))
                         ||
                         (data.Contains(u.Name.ToLower()) && !data.Contains(u.Surname.ToLower()) && data.Contains(u.ID.ToLower()))
                         ||
                         (!data.Contains(u.Name.ToLower()) && data.Contains(u.Surname.ToLower()) && data.Contains(u.ID.ToLower()));

                     }
                     else if (data.Count == 1)
                     {
                         return data.Contains(u.Name.ToLower()) || data.Contains(u.Surname.ToLower()) || data.Contains(u.ID.ToLower());
                     }
                     else
                     {
                         return true;
                     }
                };
                List<User> clients = db.Users.Where(p).ToList();
                return clients;
            }
        }
    }
}
