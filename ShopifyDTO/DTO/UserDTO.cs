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

        private string type;
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        private string newPassword;
        public string NewPassword
        {
            get { return newPassword; }
            set { newPassword = value; }
        }

        private string confirmNewPassword;
        public string ConfirmNewPassword
        {
            get { return confirmNewPassword; }
            set { confirmNewPassword = value; }
        }


        private string currentPassword;
        public string CurrentPassword
        {
            get { return type; }
            set { type = value; }
        }

        private string dob;

        //public string Dob
        //{
        //    get { return dob; }
        //    set { dob = value; }
        //}
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
