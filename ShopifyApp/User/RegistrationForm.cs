using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopifyBLL.ShopifyBL;
using ShopifyDTO.DTO;
namespace ShopifyApp
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UserDTO shopifyItems = null;
            int output = 0;
            try
            {
                if (txtRName.Text == string.Empty||txtRContactnumber.Text==string.Empty||txtRPassword.Text==string.Empty||txtRUserid.Text==string.Empty)
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
                else
                {
                    shopifyItems = new UserDTO();
                    shopifyItems.Name = txtRName.Text;


                    if (rbtnMale.Checked == true)
                        shopifyItems.Gender = "Male";

                    else
                    {
                        shopifyItems.Gender = "female";
                    }

                    shopifyItems.Dob = dtp.Value.ToShortDateString();
                    shopifyItems.ContactNumber = txtRContactnumber.Text;

                    shopifyItems.UserId = txtRUserid.Text;
                    shopifyItems.Password = txtRPassword.Text;
                    output = UserBL.InsertUser(shopifyItems);


                    if (output > 0)
                    {
                        lblMessage.Text = "Successfully added";


                    }
                    else
                    {
                        lblMessage.Text = "Fail";
                    }
                    //LoadStudents();
                }
            }


            catch
            {

            }
        
        }
    

        private void txtRPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRName_Validating(object sender, CancelEventArgs e)
        {
            if(txtRName.Text==string.Empty)
            {
                ep.SetError(txtRName, "Please Enter The Name!");
            }
            else
            {
                ep.SetError(txtRName, string.Empty);

            }


        }

        private void rbtnMale_Validating(object sender, CancelEventArgs e)
        {
          
        }

        private void txtRContactnumber_Validating(object sender, CancelEventArgs e)
        {
            if (txtRContactnumber.Text == string.Empty)
            {
                ep.SetError(txtRContactnumber, "Please Enter The ContactNumber!");
            }
            else
            {
                ep.SetError(txtRContactnumber, string.Empty);
            }
        }
    }
}
