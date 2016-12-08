using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1;
using WebApplication1.ManagementSystem.Tables;
namespace WebApplication2.Controllers
{
    public class WebrequestController : ApiController
    {
        // GET: api/Webrequest

            public IEnumerable<string> Get()
        {

            
           return new string[] { "value1", "value2", "value2", "value2", "value2" };
        }

        // GET: api/Webrequest/5
        public string Get(int id)
        {
            if (id == 1){
                return WebService1.ListOfInventory();
            }
            else if (id == 2) {
                return WebService1.ListOfPurchase();
            }
            else if(id == 3)
            {
                return WebService1.ListOfDetector();

            }else if(id == 4)
            {

                return WebService1.ListOfSales();

            }else if(id == 5)
            {

                return WebService1.ListOfSalesDetail();
            } else
            {
                return null;
            }
            

            

        }
        
       

        // POST: api/Webrequest
        public void Post([FromBody]string value)
        {

        }

        // PUT: api/Webrequest/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Webrequest/5
        public void Delete(int id)
        {
        }
    }
}
