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
        public static int InsertUser(UserDTO shopifyItems)
        {
            int output = 0;
            try
            {
                output = UserDSL.InsertUser(shopifyItems);
            }
            catch
            {

            }
            return output;

        }
        public static DataTable UserLogin(string username, string password)
        {
            DataTable dtLogin = null;
            try
            {
                dtLogin = UserDSL.UserLogin(username, password);
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("***Error :ShopifyBLL.UserLogin()", ex.Message.ToString());
            }
            return dtLogin;
        }
    }
}
