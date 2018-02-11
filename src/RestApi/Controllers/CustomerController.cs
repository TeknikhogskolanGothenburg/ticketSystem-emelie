using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestApi.Model;
using RestApi.Repository;


namespace RestApi.Controllers
{
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        
        // GET api/values
        [HttpGet]
        public List<Customer> Get()
        {
            return _customerRepository.GetAllCustomers();
           
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Customer Get(int id)
        {
           return _customerRepository.GetCustomerById(id);
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] Customer customer)
        {
         
            _customerRepository.CreateCustomer(customer);

            return Ok();
        }

        // PUT api/values/5
        [HttpPut())]
        public void Put([FromBody]Customer customer)
        {
            _customerRepository.UpdateCustomer(customer);
        }

        // DELETE api/values/5
        [HttpDelete()]
        public void Delete(Customer customer)
        {
            _customerRepository.DeleteCustomer(customer);
        }
    }
}
