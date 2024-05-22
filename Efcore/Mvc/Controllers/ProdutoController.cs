using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Dados;
using Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;


namespace Mvc.Controllers
{
      public class ProdutoController : Controller
    {  

         private readonly ApplicationDbContext _context;

         public ProdutoController(ApplicationDbContext context)
         {
            _context = context;
         } 

         public IActionResult Index() {

            var produtos = _context.Produtos.ToList();

            return View(produtos);
         }

        [HttpGet]
        public IActionResult Salvar() 
        {
            ViewBag.Categorias = _context.Categorias.ToList();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Salvar(Produto modelo)
        {
            
            _context.Produtos.Add(modelo);
            await _context.SaveChangesAsync();
            return View();
        }      
    }
}