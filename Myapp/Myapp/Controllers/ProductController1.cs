using Microsoft.AspNetCore.Mvc;
using Myapp.Models;

namespace Myapp.Controllers
{
    public class productController : Controller
    {
        public IActionResult Index()

        {
            Product p = new Product();
            p.name = "biscuit";
            p.price = 40;
            p.description = "good biscuit and value for money";
            return View(p);
        }

    }
}
