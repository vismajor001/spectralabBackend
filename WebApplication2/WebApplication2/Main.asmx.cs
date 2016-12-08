using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Web.Script.Services;
using WebApplication1.ManagementSystem.Tables;
using System.Web.Script.Serialization;
using ExtensionMethods;

namespace WebApplication1
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "https://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 :System.Web.Services.WebService
    {
        [WebMethod()]
        public static string  ListOfPurchase()
        {

            DataContext db = new DataContext("Database=PurchaseDB;Server=DESKTOP-6GQP7S7\\SQLEXPRESS;Integrated Security=SSPI");

            List<Purchase> result = new List<Purchase>();
            // Get a typed table to run queries.
            Table<Purchase> Purchase = db.GetTable<Purchase>();
           

            // Attach the log to show generated SQL.
            db.Log = Console.Out;

            // Query for customers in London.
            IQueryable<Purchase> purchaseQuery =
                from purch  in Purchase
                select purch;
            var json = new Object();
            foreach (Purchase purch in purchaseQuery)
            {
                json= new JavaScriptSerializer().Serialize(purch);
                result.Add(purch);


            }

            // Prevent console window from closing.

            return result.ToJSON();

        }
        [WebMethod()]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]//Specify return format.
        public  static string ListOfInventory()
        {

            DataContext db1 = new DataContext("Database=InventoryDB;Server=DESKTOP-6GQP7S7\\SQLEXPRESS;Integrated Security=SSPI");

            List<Object> result1 = new List<Object>();
            // Get a typed table to run queries.
            Table<Inventory> Inventory = db1.GetTable<Inventory>();


            // Attach the log to show generated SQL.
            db1.Log = Console.Out;

            // Query for customers in London.
            IQueryable<Inventory> inventoryQuery =
                from x in Inventory
                select x;
            var json=new Object();
            foreach (Inventory x in inventoryQuery)
            {
                
                json = new JavaScriptSerializer().Serialize(x);
                result1.Add(json);
            }

            // Prevent console window from closing.

            return result1.ToJSON();

        }
        [WebMethod()]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public  static string ListOfDetector()
        {

            DataContext db = new DataContext("Database=InventoryDB;Server=DESKTOP-6GQP7S7\\SQLEXPRESS;Integrated Security=SSPI");

            List<Object> result = new List<Object>();
            // Get a typed table to run queries.
            Table<Detector> Detector = db.GetTable<Detector>();

            // Query for customers in London.
            IQueryable<Detector> DetectorQuery =
                from x in Detector
                select x;
            var json = new Object();
            foreach (Detector x in DetectorQuery)
            {
                json = new JavaScriptSerializer().Serialize(x);
                result.Add(json);


            }

   

            return result.ToJSON();

        }
        [System.Web.Services.WebMethod()]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static string ListOfSales()
        {

            DataContext db = new DataContext("Database=SalesDB;Server=DESKTOP-6GQP7S7\\SQLEXPRESS;Integrated Security=SSPI");

            List<Object> result = new List<Object>();
            // Get a typed table to run queries.
            Table<Sales> Sales = db.GetTable<Sales>();


            // Attach the log to show generated SQL.
            db.Log = Console.Out;

            // Query for customers in London.
            IQueryable<Sales> SalesQuery =
                from x in Sales
                select x;
            var json = new Object();
            foreach (Sales x in SalesQuery)
            {
                json = new JavaScriptSerializer().Serialize(x);
                result.Add(json);

               
            }

            // Prevent console window from closing.
            Console.ReadLine();

            return result.ToJSON();

        }

        [System.Web.Services.WebMethod()]
        public  static string ListOfSalesDetail()
        {

            DataContext db = new DataContext("Database=STOREDB;Server=DESKTOP-6GQP7S7\\SQLEXPRESS;Integrated Security=SSPI");

            List<SalesDetail> result = new List<SalesDetail>();
            // Get a typed table to run queries.
            Table<SalesDetail> SalesDetail = db.GetTable<SalesDetail>();


            // Attach the log to show generated SQL.
            db.Log = Console.Out;

            // Query for customers in London.
            IQueryable<SalesDetail> SalesDetailQuery =
                from x in SalesDetail
                select x;
            foreach (SalesDetail x in SalesDetailQuery)
            {
                result.Add(x);

                Console.WriteLine("ID={0}, City={1}", x.InvoiceNo,
                    x.PurchaseNo);
            }

            // Prevent console window from closing.
            Console.ReadLine();

            return result.ToJSON();

        }



    }
}
namespace ExtensionMethods
{
    public static class JSONHelper
    {
        public static string ToJSON(this object obj)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            return serializer.Serialize(obj);
        }

        public static string ToJSON(this object obj, int recursionDepth)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            serializer.RecursionLimit = recursionDepth;
            return serializer.Serialize(obj);
        }
    }
}