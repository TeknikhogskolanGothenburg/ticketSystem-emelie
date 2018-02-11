using RestApi.Model;
using System.Collections.Generic;

namespace RestApi.Repository
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
        void DeleteOrder(Order order);
        void UpdateOrder(Order order);
        Order GetOrderById(int id);
        Order GetOrderByCustomerId(int id);
        List<Order> GetAllOrders();
    }
}
