using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestApi.Model;
using RestApi.Model.DTO;
using RestApi.Model.Mapper;
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
        [HttpGet]
        public List<Product> Get()
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
        [HttpPost("AddProduct")]
        public IActionResult AddProduct([FromBody] ProductDto product)
        {
            try
            {
                var productMapper = new Mapper();
                var mappedProduct = productMapper.ProductMap(product);

                _productRepository.CreateProduct(mappedProduct);
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
