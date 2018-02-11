using RestApi.Model;
using System.Collections.Generic;
using System.Linq;


namespace RestApi.Repository
{
    public class ProductRepository : IProductRepository
    {
        private DataBaseContext _context;

        public ProductRepository(DataBaseContext context) => _context = context;

        public void CreateProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void DeleteProduct(Product product) => _context.Products.Remove(product);

        public List<Product> GetAllProducts() => _context.Products.OrderBy(p => p.ProductName).ToList();

        public Product GetProductById(int id) => _context.Products.FirstOrDefault(p => p.Id == id);

        public void UpdateProduct(Product product) => _context.Products.Update(product);
       
    }
}
