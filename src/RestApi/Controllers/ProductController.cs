using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestApi.Model;
using RestApi.Repository;


namespace RestApi.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
    
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        // GET api/values
        [HttpGet("GetAllProducts")]
        public List<Product> GetAllProducts()
        {
            return _productRepository.GetAllProducts();
        }



        // GET api/values/5
        [HttpGet("{id}")]
        public Product Get(int id)
        {
           return _productRepository.GetProductById(id);
        }

        // POST api/values
        [HttpPost("CreateProduct")]
        public IActionResult CreateProduct([FromBody] Product product)
        {
            try
            {
                _productRepository.CreateProduct(product);
            }
            catch (System.Exception e)
            {

                return BadRequest("Something whent wrong, please contact Funny Beer");
            }
          

            return Ok();
        }

        // PUT api/values/5
        [HttpPut()]
        public void Put([FromBody]Product product)
        {
            _productRepository.UpdateProduct(product);
        }

        // DELETE api/values/5
        [HttpDelete()]
        public void Delete(Product product)
        {
            _productRepository.DeleteProduct(product);
        }
    }
}
