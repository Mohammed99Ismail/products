using System;
using Product.Web.Api.Controllers.Resources;
using Product.Web.Api.Persistence;
using Product.Web.Api.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Product.Web.Api.Persistence
{
    public class ProductsRepository:IProductsRepository
    {
        private readonly ProductDbContext context;
        public ProductsRepository(ProductDbContext Context)
        {
            this.context = Context;

        }

        public void AddProduct(Products p)
        {
            context.products.Add(p);
        }

        public void DeleteProduct(Products p)
        {
            context.products.Remove(p);
        }

        
        public async Task<Products> GetProduct(int id)
        {
            return await context.products.SingleOrDefaultAsync(pr=>pr.Id==id);
        }

        public async Task<IEnumerable<Products>> GetProducts()
        {
            return await context.products.ToListAsync();
        }
    }
}