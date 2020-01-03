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
using ShopifyApp.User;


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
            UserDTO userDTO = null;
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
                    userDTO = new UserDTO();
                    userDTO.Name = txtRName.Text;
                    userDTO.Type = cmbTypee.Text;

                    if (rbtnMale.Checked == true)
                        userDTO.Gender = "Male";

                    else
                    {
                        userDTO.Gender = "female";
                    }

                    
                    userDTO.ContactNumber = txtRContactnumber.Text;

                    userDTO.UserId = txtRUserid.Text;
                    userDTO.Password = txtRPassword.Text;

                    output = UserBL.InsertUser(userDTO);


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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            LoadUserIDs();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm adminForm = new AdminForm();
            adminForm.ShowDialog();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            int output = 0;
            try
            {
                if (MessageBox.Show("DO YOU WANT TO DELETE ? ", "S I S",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    output = ShopifyItemsBLL.DeleteItem(cmbDeleteuser.Text);
                }
                if (output > 0)
                {
                    lblMessage.Text = " details deleted succesfully";
                    //LoadContacts();
                    LoadUserIDs();

                }
                else
                {
                    lblMessage.Text = "try again later";
                }
            }
            catch (Exception e7)
            {
                lblMessage.Text = e7.Message.ToString();
            }



        }


        private void LoadUserIDs()
        {
            DataSet dsStockID = null;
            try
            {
                dsStockID = UserBL.GetUserID();
                if (dsStockID != null)
                {
                    cmbDeleteuser.DataSource = dsStockID.Tables[0];


                    cmbDeleteuser.ValueMember = "UserId";
                    cmbDeleteuser.DisplayMember = "UserId";

                }
                else
                {
                    lblMessage.Text = "No students avialbale";
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message.ToString();

            }
        }
    }
}
