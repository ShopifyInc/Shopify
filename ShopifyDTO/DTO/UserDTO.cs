using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifyDTO.DTO
{
    public class UserDTO
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string dob;

        public string Dob
        {
            get { return dob; }
            set { dob = value; }
        }
        private string gender;

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        private string contactNumber;

        public string ContactNumber
        {
            get { return contactNumber; }
            set { contactNumber = value; }
        }

        private string userId;

        public string UserId
        {
            get { return userId; }
            set { userId = value; }
        }
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
    }
}
