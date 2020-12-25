using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Product.Web.Api.Controllers.Resources;
using Product.Web.Api.Models;
using Product.Web.Api.Persistence;

namespace Product.Web.Api.Controllers
{
    [Route("api/products")]
    public class ProductsController : Controller
    {
        private readonly IProductsRepository repository;
        private readonly IUnitOfWork unitofwork;
        public ProductsController(IProductsRepository repository, IUnitOfWork unitofwork)
        {
            this.unitofwork = unitofwork;
            this.repository = repository;

        }
        [HttpPost]
        public async Task<IActionResult> CreateProduct([FromBody] ProductResource p)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            Products product = new Products();
            product.Name = p.Name;
            product.Photo = p.Photo;
            product.Price = p.Price;
            product.LastUpdate = DateTime.Now;

            repository.AddProduct(product);

            await unitofwork.Complete();

            return Ok(product);
        }
        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {

            var product = await repository.GetProducts();

            return Ok(product);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProducts(int id, [FromBody] ProductResource product)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var prd = await repository.GetProduct(id);

            prd.Name = product.Name;
            prd.Photo = product.Photo;
            prd.Price = product.Price;
            prd.LastUpdate = DateTime.Now;

            if (prd == null)
                return NotFound();

            await unitofwork.Complete();

            return Ok(prd);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProducts(int id)
        {
            var prd = await repository.GetProduct(id);

            if (prd == null)
                return NotFound();

            repository.DeleteProduct(prd);
            await unitofwork.Complete();

            return Ok(id);
        }
    }
}