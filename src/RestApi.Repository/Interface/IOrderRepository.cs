using RestApi.Model;
using System.Collections.Generic;

namespace RestApi.Repository
{
    public interface IOrderRepository
    {
        
        Order GetOrderById(int id);
        Order GetOrderByCustomerId(int id);
        void DeleteOrder(Order order);
        void UpdateOrder(Order order);
        List<Order> GetAllOrders();
    }
}
