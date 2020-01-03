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
using ShopifyDTO.DTO;
using System.Net;
using System.Net.Mail;

namespace ShopifyApp
{
    public partial class Forgot_Password : Form
    {

        string randomcode;
        public static string to;
        public Forgot_Password()
        {
            InitializeComponent();
        }

        private void Forgot_Password_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //txtMobNumber = label3.Text();
            SqlConnection con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\1028290\\Desktop\\gokul\\Shopify\\ShopifyApp\\ShopifyDSL\\Data\\StockItems.mdf; Integrated Security = True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from UserDetails where ContactNumber='" + txtMobNumber.Text + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                label3.Text = dr.GetValue(1).ToString();
                MessageBox.Show("password sent successfully into the registered number");

            }
            else
            {
                MessageBox.Show("not match");

            }



            //string from, pass, messagebody;
            //Random rand = new Random();randomcode = (rand.Next(999999)).ToString();
            //MailMessage message = new MailMessage();
            //to = (textMail.Text).ToString();
            //from = "p99@gmail.com";
            //pass = "tsntest123";
            //messagebody = "your reset code is" + randomcode;
            //message.To.Add(to);
            //message.From = new MailAddress(from);
            //message.Body = messagebody;
            //message.Subject = "password rset code";
            //SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            //smtp.EnableSsl = true;
            //smtp.Port = 587;
            //smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            //smtp.Credentials = new NetworkCredential(from, pass);
            //try
            //{
            //    smtp.Send(message);
            //    MessageBox.Show("code success");

            //}
            //catch(Exception e7)
            //{
            //    MessageBox.Show(e7.Message);
            //}

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
