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

using ShopifyBLL.ShopifyBL;
using ShopifyDTO.DTO;

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
            string username;
            string password;
            username = txtUserId.Text;
            password = txtPassword.Text;
            DataTable dtLogin = null;
            try
            {


                dtLogin = UserBL.UserLogin(username, password);
                if (dtLogin.Rows.Count > 0)
                {
                    this.Hide();
                    //userDetails login = new userDetails();
                   // login.ShowDialog();
                }
                else
                {
                    // MessageBox.Show("Please Enter Vallid UserId and UserName");
                    if (txtPassword.Text == string.Empty || txtUserId.Text == string.Empty)
                    {


                        foreach (Control control in this.Controls)
                        {
                            if (!Validate())
                            {
                                DialogResult = DialogResult.None;
                                return;
                            }
                        }
                    }
                }



            }

            catch
            {
                MessageBox.Show("Please Enter Vallid UserId and UserName");
            }

           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm login = new RegistrationForm();
            login.ShowDialog();

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            Forgot_Password login = new Forgot_Password();
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
    }
}
