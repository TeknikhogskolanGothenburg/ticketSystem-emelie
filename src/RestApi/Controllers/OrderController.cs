using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestApi.Model;
using RestApi.Repository;


namespace RestApi.Controllers
{
    [Route("api/[controller]")]
    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepository;
        

        public OrderController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        // GET api/values
        [HttpGet]
        public List<Order> Get()
        {
            return _orderRepository.GetAllOrders();

        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Order Get(int id)
        {
            return _orderRepository.GetOrderById(id);
        }

        // POST api/values
        [HttpPost("CreateOrder")]
        public IActionResult CreateOrder([FromBody] Order order)
        {
            _orderRepository.CreateOrder(order);

            return Ok();
        }


        // PUT api/values/5
        [HttpPut()]
        public void Put([FromBody]Order order)
        {
            _orderRepository.UpdateOrder(order);
        }

        // DELETE api/values/5
        [HttpDelete()]
        public void Delete(Order order)
        {
            _orderRepository.DeleteOrder(order);
        }

    }
}

