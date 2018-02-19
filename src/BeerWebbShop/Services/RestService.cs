using BeerWebbShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using RestSharp;
using Newtonsoft.Json.Linq;

namespace BeerWebbShop.Services
{
    public class RestService
    {
        private const string Customer = "api/customer";

        private const string Product = "api/product";

        private const string User = "api/user";

        private const string Order = "api/order";
        
        

        public async Task<Product> CreateProduct(Product product)
        {
            var client = new RestClient(new Uri("http://localhost:50987/" + Product));
            var request = new RestRequest("CreateProduct", Method.POST);
            request.AddHeader("Accept", "application/json");

            var jsonObject = JsonConvert.SerializeObject(product);
            request.AddParameter("application/json", jsonObject, ParameterType.RequestBody);
            
            var taskCompletion = new TaskCompletionSource<IRestResponse>();

            var handle = client.ExecuteAsync(request, r => taskCompletion.SetResult(r));

            var response = (RestResponse)(await taskCompletion.Task);

            return JsonConvert.DeserializeObject<Product>(response.Content);
        }

        public async Task<User> CreateUser(User user)
        {
            var client = new RestClient(new Uri("http://localhost:50987/" + User));
            var request = new RestRequest("CreateUser", Method.POST);
            request.AddHeader("Accept", "application/json");

            var jsonObject = JsonConvert.SerializeObject(user);
            request.AddParameter("application/json", jsonObject, ParameterType.RequestBody);

            var taskCompletion = new TaskCompletionSource<IRestResponse>();

            var handle = client.ExecuteAsync(request, r => taskCompletion.SetResult(r));

            var response = (RestResponse)(await taskCompletion.Task);

            return JsonConvert.DeserializeObject<User>(response.Content);
        }


        public async Task<RestResponse> GetByUsernameAndPassword(User user)
        {
            var client = new RestClient(new Uri("http://localhost:50987/" + User));
            var request = new RestRequest("ValidateUser", Method.POST);
            request.AddHeader("Accept", "application/json");

            var jsonObject = JsonConvert.SerializeObject(user);
            request.AddParameter("application/json", jsonObject, ParameterType.RequestBody);

            var taskCompletion = new TaskCompletionSource<IRestResponse>();

            var handle = client.ExecuteAsync(request, r => taskCompletion.SetResult(r));

            var response = (RestResponse)(await taskCompletion.Task);

            return response;

        }
        

        public async Task<List<Product>> GetAllProducts()
        {
            var client = new RestClient(new Uri("http://localhost:50987/" + Product));
            var request = new RestRequest("GetAllProducts", Method.GET);
            request.AddHeader("Accept", "application/json");
            
            var taskCompletion = new TaskCompletionSource<IRestResponse>();

            var handle = client.ExecuteAsync(request, r => taskCompletion.SetResult(r));

            var response = (RestResponse)(await taskCompletion.Task);
            
            return JsonConvert.DeserializeObject<List<Product>>(response.Content); 

        }

        public async Task<Customer> CheckIfCustomerExist(Customer customer)
        {
            var client = new RestClient(new Uri("http://localhost:50987/" + Customer));
            var request = new RestRequest("CheckIfCustomerExist", Method.POST);
            request.AddHeader("Accept", "application/json");

            var jsonObject = JsonConvert.SerializeObject(customer);
            request.AddParameter("application/json", jsonObject, ParameterType.RequestBody);

            var taskCompletion = new TaskCompletionSource<IRestResponse>();

            client.ExecuteAsync(request, r => taskCompletion.SetResult(r));

            var response = (RestResponse)(await taskCompletion.Task);

            return JsonConvert.DeserializeObject<Customer>(response.Content);

        }

        public async Task<Customer> CreateCustomer(Customer customer)
        {
            var client = new RestClient(new Uri("http://localhost:50987/" + Customer));
            var request = new RestRequest("CreateCustomer", Method.POST);
            request.AddHeader("Accept", "application/json");

            var jsonObject = JsonConvert.SerializeObject(customer);
            request.AddParameter("application/json", jsonObject, ParameterType.RequestBody);

            var taskCompletion = new TaskCompletionSource<IRestResponse>();

            var handle = client.ExecuteAsync(request, r => taskCompletion.SetResult(r));

            var response = (RestResponse)(await taskCompletion.Task);

            return JsonConvert.DeserializeObject<Customer>(response.Content);

        }


        public async Task<Order> CreateOrder(Order order)
        {
            var client = new RestClient(new Uri("http://localhost:50987/" + Order));
            var request = new RestRequest("CreateOrder", Method.POST);
            request.AddHeader("Accept", "application/json");

            var jsonObject = JsonConvert.SerializeObject(order);
            request.AddParameter("application/json", jsonObject, ParameterType.RequestBody);

            var taskCompletion = new TaskCompletionSource<IRestResponse>();

            var handle = client.ExecuteAsync(request, r => taskCompletion.SetResult(r));

            var response = (RestResponse)(await taskCompletion.Task);

            return JsonConvert.DeserializeObject<Order>(response.Content);

        }



    }
}