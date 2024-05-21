using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Mvc.Controllers
{
    public class CategoriaController : Controller
    {

        [HttpGet]
        public IActionResult Salvar() {

            return View();
        }

    [HttpPost]
          public IActionResult Salvar(Categoria categoria) {

            return View();
        }
    }
}