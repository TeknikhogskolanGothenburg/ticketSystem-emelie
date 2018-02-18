using RestApi.Model;
using System.Collections.Generic;

namespace RestApi.Repository
{
    public interface ICustomerRepository
    {
        Customer CreateCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        void DeleteCustomer(Customer customer);
        Customer GetCustomerById(int id);
        Customer GetCustomerByEmail(string Email);
        List<Customer> GetAllCustomers();
        Customer CheckIfCustomerExist(Customer customer);
    }
}
