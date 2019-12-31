using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopifyDSL.DL;
using System.Data;
using ShopifyDTO.DTO;

namespace ShopifyBLL.ShopifyBL
{
   public  class SalesBL
    {
        //-----------------------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------------------

        public static DataSet GetSalesBL(string ShowIdBill)
        {
            DataSet sales = null;

            try
            {
                sales = SalesDSL.GetSalesDL(ShowIdBill);

            }
            catch (Exception exe)
            {
                Console.Out.WriteLine("****error : SalesDTOBLL.cs:GetSalesBL:" + exe.Message.ToString());
            }

            return sales;
        }



        public static int SaleEachInsertBL(SalesDTO shopifyItems)
        {
            int output = 0;

            try
            {

                shopifyItems.TotalSale = shopifyItems.Quantity * shopifyItems.Unitprice;


                output = SalesDSL.SaleEachInsertDL(shopifyItems);
                shopifyItems.Total = SalesDSL.GetTotalSaleDL(shopifyItems.Salesid);
            }
            catch (Exception exe)
            {
                Console.Out.WriteLine("****error : SalesDTOBLL.cs:SaleEachInsertBL:" + exe.Message.ToString());
            }
            return output;

        }


        public static int SalesInsertBL(SalesDTO shopifyItems)
        {
            int output = 0;

            try
            {

                shopifyItems.Total = SalesDSL.GetTotalSaleDL(shopifyItems.Salesid);

                output = SalesDSL.SalesInsertDL(shopifyItems);
            }
            catch (Exception exe)
            {
                Console.Out.WriteLine("****error : SalesDTOBLL.cs:SalesInsertBL:" + exe.Message.ToString());
            }
            return output;

        }




        public static String GetLastSalesId()
        {
            string LastStudentId = null;
            string newStudentId = null;

            try
            {
                LastStudentId = SalesDSL.GetLastSalesIdDL();
                if (LastStudentId != null)
                {
                    newStudentId = UtilityHelper.GenerateID(LastStudentId);
                }
                else
                {
                    newStudentId = "101";
                }
            }
            catch (Exception exe)
            {
                Console.Out.WriteLine("****error : SalesDTOBLL.cs:GetLastSalesIdBL:" + exe.Message.ToString());
            }

            return newStudentId;
        }



    }
}
