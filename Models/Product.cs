using CoffeeShopRegistration.Models.Enums;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CoffeeShopRegistration.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Precision(10,2)]
        public decimal Price { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }
        public ProductCategory Category { get; set; }

    }
}
