using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Produto
    {
            public int Id { get; set; }
            public string Nome { get; set; }

          public Categoria Categoria {get; set;}
    }
}