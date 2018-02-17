using BeerWebbShop.Services;
using NUnit.Framework;

namespace BeerWebbShop.Test
{
    [TestFixture]
    public class TestRestClass
    {
        [Test]
        public void TestRest()
        {
           var service = new RestService();
           //var test = service.AddCustomerCall(new Models.Customer()
           // {
           //     Address = "address",
           //     City = "city",
           //     Country = "country"
           // }).Result;
        }
    }
}
