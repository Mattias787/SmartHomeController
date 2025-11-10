using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smartHomeController
{
    public class User
    {

        // private feilds 

        private int userId;
        private string userName;
        private string password;
        private string contactInfo;
        private bool isLoggedIn;

        // public properties

        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public string ContactInfo
        {
            get { return contactInfo; }
            set { contactInfo = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public bool IsLoggedIn
        {
            get { return isLoggedIn; }
            set { isLoggedIn = value; }
        }

        //Constructor

        public User(int userID, string userName, string password, string contactInfo, bool isLoggedIn)
        {
            UserID = userID;
            UserName = userName;
            Password = password;
            ContactInfo = contactInfo;
            IsLoggedIn = isLoggedIn;
        }





        // Methods

        public bool Login(string username, string password)
        {
            if (UserName == userName && Password == password)
            {
                IsLoggedIn = true;
                Console.WriteLine(" Login Successful");
            }
            else {
                IsLoggedIn = false;
                Console.WriteLine($"Login Failed User {userName} or password is incorrect");
            }
            return IsLoggedIn;

        }

        public bool Logout()
        {

            if (IsLoggedIn)
                IsLoggedIn == false;
            Console.WriteLine(" user logged out Sucessfully");
        
        
         else
           {
             Console.WriteLine(" user is not logged in");
            }
        }
    }

    


 }
    


