using System;


namespace WebApplication1.Areas.MyOrders.DTOs
{
    public class Order
    {
        public Int32 OrderNum { get; set; }
        public Int32 ProductId { get; set; }
        public Int32 Qty { get; set; }
        public Decimal Total { get; set; }
    }
}
