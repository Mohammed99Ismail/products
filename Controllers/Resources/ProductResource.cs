using System;

namespace Product.Web.Api.Controllers.Resources
{
    public class ProductResource
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }
        public int Price { get; set; }
        public DateTime? LastUpdate { get; set; }
    }
}