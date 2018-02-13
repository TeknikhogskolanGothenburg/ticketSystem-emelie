using BeerWebbShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace BeerWebbShop.Services
{
    public class RestService
    {
        private const string Addcustomer = "api/Customer/";

        public async Task<HttpResponseMessage> AddCustomerCall(Customer customer)
        {
            using (var client = new HttpClient())
            {
                var dataAsString = JsonConvert.SerializeObject(customer);
                var content = new StringContent(dataAsString);
                var result = await client.PostAsync(new Uri("http://localhost:58585/" + Addcustomer), content);

                if(result.IsSuccessStatusCode)
                {
                    return result;
                }

                return null;
            }
              
            

            
        }
    }
}
