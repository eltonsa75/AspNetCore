using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Dados;
using Dominio.Entidades;
using Microsoft.AspNetCore.Identity.UI.Pages.Internal.Account;
using Microsoft.AspNetCore.Mvc;
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
        public IActionResult Salvar() {

            return View();
        }

    [HttpPost]
          public async Task<IActionResult> Salvar(Categoria categoria) {

            _context.Categorias.Add(categoria);
            await _context.SaveChangesAsync();
            return View();
        }
    }
}