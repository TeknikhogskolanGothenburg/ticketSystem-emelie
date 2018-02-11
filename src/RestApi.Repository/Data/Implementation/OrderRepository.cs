using RestApi.Model;
using System.Collections.Generic;
using System.Linq;

namespace RestApi.Repository
{
    class OrderRepository : IOrderRepository
    {
        private DataBaseContext _context;

        public OrderRepository(DataBaseContext context) => _context = context;

        public Order GetOrderById(int id) => _context.Orders.FirstOrDefault(o => o.Id == id);

        public Order GetOrderByCustomerId(int CustomerId) => _context.Orders.FirstOrDefault(o => o.CustomerId == CustomerId);

        public void DeleteOrder(Order order) => _context.Orders.Remove(order);

        public void UpdateOrder(Order order) => _context.Orders.Update(order);

        public List<Order> GetAllOrders() => _context.Orders.OrderBy(o => o.OrderDate).ToList();

    }
}





