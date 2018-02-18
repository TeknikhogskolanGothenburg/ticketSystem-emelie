using System.Collections.Generic;
using RestApi.Model;


namespace RestApi.Repository
{
    public interface IProductRepository
    {
        void CreateProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(Product product);
        Product GetProductById(int id);
        List<Product> GetAllProducts();
       
    }
}
