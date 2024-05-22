using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Dados;
using Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


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

          public IActionResult Editar(int id) 
        {
             var produto = _context.Produtos.First(c => c.Id == id);
            return View("Salvar", produto);
        }

         public async Task<IActionResult> Deletar(int id) 
        {
             var produto = _context.Produtos.First(c => c.Id == id);
             _context.Produtos.Remove(produto);
             await _context.SaveChangesAsync();

             return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Salvar(Produto modelo)
        {
            
            _context.Produtos.Add(modelo);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }      
    }
}