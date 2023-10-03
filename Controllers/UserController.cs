using CoffeeShopRegistration.Models;
using CoffeeShopRegistration.Models.Data;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShopRegistration.Controllers
{
    public class UserController : Controller
    {
        //dependancy injection
        private readonly AppDbContext _appDbContext;

        //we are injecting the DbController through the constructor
        public UserController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IActionResult Index()
        {
            User user = new User();

            return View(user);
        }

        [HttpPost]
        public IActionResult ProcessUserForm([FromForm] User newUser)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            _appDbContext.Users.Add(newUser);
            //This is verty=easy to forget
            //This is where it is actually saved to the database.If you dont it wont be saved.
            _appDbContext.SaveChanges();


            return RedirectToAction("Index","Home");
        }

    }


}
