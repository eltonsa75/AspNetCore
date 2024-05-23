using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Dados;
using Dominio.Entidades;
using Microsoft.AspNetCore.Identity.UI.Pages.Internal.Account;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Scaffolding;
using Microsoft.Extensions.Logging;

namespace Mvc.Controllers
{ 
    public class CategoriaController : Controller
    {

           private readonly ApplicationDbContext _context;

    public CategoriaController(ApplicationDbContext context)
     {
       _context = context;
    }

     [HttpGet]
        public IActionResult Index() 
        {

            var categorias = _context.Categorias.ToList();

            return View(categorias);
        }

        public IActionResult Editar(int id) 
        {
             var categoria = _context.Categorias.First(c => c.Id == id);
            return View("Salvar", categoria);
        }
        public async Task<IActionResult> Deletar(int id) 
        {
             var categoria = _context.Categorias.First(c => c.Id == id);
             _context.Categorias.Remove(categoria);
             await _context.SaveChangesAsync();

             return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Salvar() {

            return View();
        }

    [HttpPost]
          public async Task<IActionResult> Salvar(Categoria modelo) {

            if(modelo.Id == 0) 
            _context.Categorias.Add(modelo);
            else{
                var categoriaSalva = _context.Categorias.First(c => c.Id == modelo.Id);
                categoriaSalva.Nome = modelo.Nome;
                categoriaSalva.PermiteEstoque = modelo.PermiteEstoque;
            }            
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}