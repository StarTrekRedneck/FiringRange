using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace WebApplication1.Areas.MyOrders.Controllers
{
    [Route("api/myorders/")]
    public class MyOrdersController : Controller
    {
        // GET: api/myorders
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "order1", "order2" };
        }

        // GET api/orders/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "order" + id;
        }
    }
}
