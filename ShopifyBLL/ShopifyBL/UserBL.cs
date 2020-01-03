using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopifyDTO.DTO;
using ShopifyDSL.DL;
using System.Data;

namespace ShopifyBLL.ShopifyBL
{
   public class UserBL
    {
        public static int InsertUser(UserDTO userDTO)
        {
            int output = 0;
            try
            {
                output = UserDSL.InsertUser(userDTO);
            }
            catch
            {

            }
            return output;

        }

       

        public static bool UserLogin(UserDTO userDTO)
        {
            Boolean flag = false;
            DataSet dsUser = null;

            dsUser= UserDSL.UserLogin(userDTO);

            Object[] Data = null;

            if (dsUser.Tables[0].Rows.Count > 0)
            {
                Data = dsUser.Tables[0].Rows[0].ItemArray;

                string userid = Data[0].ToString();
                string password = Data[1].ToString();

                if (userDTO.UserId == userid && userDTO.Password == password)
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            }
            return flag;
        }


        public static int DeleteItem(string id)
        {
            int output = 0;

            try
            {
                output = UserDSL.DeleteItem(id);



            }
            catch (Exception e3)
            {
                Console.Out.WriteLine(" inside catch-ERROR : ShopifyItemsBLL.cs :DeleteItem()" + e3.Message.ToString());


            }

            return output;
        }





        //loaduserid

        public static DataSet GetUserID()
        {
            //String sql = "";

            DataSet dsStockID = null;

            try
            {

                dsStockID = UserDSL.GetUserID();


            }
            catch (Exception e3)
            {
                Console.Out.WriteLine(" inside catch-ERROR : ShopifyItemsBLL.cs :GetContactIDs" + e3.Message.ToString());


            }

            return dsStockID;
        }

    }
}
