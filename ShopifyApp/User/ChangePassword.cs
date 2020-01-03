using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopifyDTO.DTO;
using ShopifyApp.User;
using ShopifyBLL.ShopifyBL;

namespace ShopifyApp.User
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
        //    UserDTO userDTO = new UserDTO();
        //    userDTO.UserId = txtUserID.Text;
        //    userDTO.CurrentPassword = txtCurrentPassword.Text;
        //    userDTO.Type = cmbForChangePassword.Text;
        //    userDTO.NewPassword = txtNewPassord.Text;
        //    userDTO.ConfirmNewPassword = txtConfirmPassword.Text;


           //bool validUser = UserBL.UserChangePassword(userDTO);

        }
    }
}
