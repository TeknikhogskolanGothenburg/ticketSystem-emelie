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

        [HttpPost("CreateCustomer")]
        public Customer CreateCustomer(Customer customer)
        {
            return _customerRepository.CreateCustomer(customer);

        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Customer Get(int id)
        {
           return _customerRepository.GetCustomerById(id);
        }

        // POST api/values
        [HttpPost("CheckIfCustomerExist")]
        public Customer CheckIfUserExist([FromBody] Customer customer)
        {
            var result = _customerRepository.CheckIfCustomerExist(customer);

            if (result != null)
            {
                return result;
            }
            return null;

        }

        // PUT api/values/5
        [HttpPut()]
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
