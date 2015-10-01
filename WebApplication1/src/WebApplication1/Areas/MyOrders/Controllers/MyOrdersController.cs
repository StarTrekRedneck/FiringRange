using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using WebApplication1.Areas.MyOrders.DTOs;

namespace WebApplication1.Areas.MyOrders.Controllers
{
    [Route("api/myorders/")]
    public class MyOrdersController : Controller
    {
        private IEnumerable<Order> _orders;


        public MyOrdersController()
        {
            InitializeOrders();
        }

        private void InitializeOrders()
        {
            _orders = new[] { new Order { OrderNum = 1, ProductId = 1337, Qty = 1, Total = 50 },
                              new Order { OrderNum = 2, ProductId = 42, Qty = 1, Total = 25 },
                              new Order { OrderNum = 3, ProductId = 314, Qty = 2, Total = 17 },
                              new Order { OrderNum = 4, ProductId = 451, Qty = 10, Total = 120 }
                            };
        }

        // GET: api/myorders
        [HttpGet]
        public IEnumerable<Order> Get()
        {
            return _orders;
        }

        // GET api/orders/5
        [HttpGet("{orderNumber}")]
        public Order Get(int orderNumber)
        {
            return _orders.Where(o => o.OrderNum == orderNumber).FirstOrDefault();
        }
    }
}
