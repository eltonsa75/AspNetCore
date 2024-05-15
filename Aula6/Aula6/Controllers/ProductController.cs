using Microsoft.AspNetCore.Mvc;
using Aula6.Models;

namespace Aula6.Controllers
{
    public class ProductController : Controller
    {
        [HttpGet]
        public IActionResult Save()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Save(Product product)
        {
            
            if(!ModelState.IsValid)
            ViewBag.Validacao = "produto inválido para cadastro";

            return View();
        }
    }
}
