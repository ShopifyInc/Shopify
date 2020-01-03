using ShopifyBLL.ShopifyBL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
//using ShopifyBLL.ShopifyBL;
using ShopifyDTO.DTO;
using ShopifyApp.User;
using ShopifyApp.Stock_Managment;

namespace ShopifyApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            UserDTO userDTO = new UserDTO();
            userDTO.UserId = txtUserId.Text;
            userDTO.Password = txtPassword.Text;
            userDTO.Type = cmbSelectUser.Text;

            bool validUser = UserBL.UserLogin(userDTO);
            try
            {
                if (validUser)
                {
                    if (userDTO.Type == "Admin")
                    {
                        this.Hide();
                        AdminForm adminForm = new AdminForm();
                        adminForm.Show();
                    }
                    else if (userDTO.Type == "Cashier")
                    {
                        this.Hide();
                        CashierpageDemo cashierpageDemo = new CashierpageDemo();
                        cashierpageDemo.Show();
                    }
                    else if (userDTO.Type == "Stock Manager")
                    {
                        this.Hide();
                        StockManagerDemo stock_Manager = new StockManagerDemo();
                        stock_Manager.Show();
                    }

                }
                else
                {
                    lblMessaging.Text = "invalid credentials";
                }
            }
            catch (Exception ex)
            {
                lblMessaging.Text = "Invalid Username or Passsword";
            }
        }

            

     

        private void button1_Click_2(object sender, EventArgs e)
        {

        
            this.Hide();
            ChangePassword login = new ChangePassword();
            login.ShowDialog();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUserId_Validating(object sender, CancelEventArgs e)
        {
            if (txtUserId.Text == string.Empty)
            {
                epUser.SetError(txtUserId, "Please Enter The UserId!");
            }
            else
            {
                epUser.SetError(txtUserId, string.Empty);

            }
        }

        private void cmbSelectUser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
