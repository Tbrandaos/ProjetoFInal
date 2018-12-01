using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalThiago.Classes
{
    public class User
    {
        int id;
        string name;
        string password;
        string email;
        UserProfile userProfile;
        bool active;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        internal UserProfile UserProfile
        {
            get
            {
                return userProfile;
            }

            set
            {
                userProfile = value;
            }
        }

        public bool Active
        {
            get
            {
                return active;
            }

            set
            {
                active = value;
            }
        }

        public User()
        {

        }

        public User(string name, string password, string email, UserProfile userProfile, bool active)
        {
            this.Name = name;
            this.Password = password;
            this.Email = email;
            this.UserProfile = userProfile;
            this.Active = active;
        }

        public User(int id, string name, string password, string email, UserProfile userProfile, bool active)
        {
            this.Id = id;
            this.Name = name;
            this.Password = password;
 
            this.Email = email;
            this.UserProfile = userProfile;
            this.Active = active;
        }
    }
}
