using RestApi.Model;
using System.Collections.Generic;
using System.Linq;

namespace RestApi.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private DataBaseContext _context;

        public CustomerRepository(DataBaseContext context) => _context = context;

        public void CreateCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        public void UpdateCustomer(Customer customer) => _context.Customers.Update(customer);

        public void DeleteCustomer(Customer customer) => _context.Customers.Remove(customer);

        public Customer GetCustomerById(int id) => _context.Customers.FirstOrDefault(c => c.Id == id);

        public Customer GetCustomerByEmail(string Email) => _context.Customers.FirstOrDefault(c => c.Email == Email);

        public List<Customer> GetAllCustomers() => _context.Customers.OrderBy(c => c.FirstName).ToList();
    }
}
