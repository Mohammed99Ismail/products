using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Product.Web.Api.Models
{   
    [Table("ProductTable")]
    public class Products
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Photo { get; set; }
        public int Price { get; set; }
        public DateTime? LastUpdate { get; set; }
    }
}