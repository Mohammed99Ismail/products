using System.Collections.Generic;
using System.Threading.Tasks;
using Product.Web.Api.Models;

namespace Product.Web.Api.Persistence
{
    public interface IProductsRepository
    {
          void AddProduct(Products p);
          void DeleteProduct(Products p);
          Task<Products> GetProduct(int id);
          Task<IEnumerable<Products>> GetProducts();
    }
}