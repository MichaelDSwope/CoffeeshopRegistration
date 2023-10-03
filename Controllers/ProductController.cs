using CoffeeShopRegistration.Models;
using CoffeeShopRegistration.Models.Data;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShopRegistration.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public ProductController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }



        public IActionResult Index(string?searchTerm)
        {
            if (searchTerm != null)
            {
                return View(_appDbContext.Products.Where(x => x.Name.ToLower().Contains(searchTerm.ToLower())).ToList());
            }

            List<Product> products = _appDbContext.Products.OrderBy(x => x.Name).ToList();
            return View(products);
        }


        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            Product product = _appDbContext.Products.FirstOrDefault(x => x.Id == id);

            if (product == null)
            {
                return NotFound();

            }
            return View(product);
        }
        
    }
        
    
}
