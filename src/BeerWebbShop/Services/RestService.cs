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
        private const string Customer = "api/Customer";

        private const string Product = "api/Product";

        private const string User = "api/User";

        

       
       

        public async Task<Product> AddProduct(Product product)
        {
            var client = new RestClient(new Uri("http://localhost:50987/" + Product));
            var request = new RestRequest("AddProduct", Method.POST);
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
        







    }
}