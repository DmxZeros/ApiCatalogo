using APICatalogo.Context;
using APICatalogo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICatalogo.Repositorio
{
    public class CategoriaRepositorio: Repositorio<Categoria>, ICategoriaRepositorio
    {
        public CategoriaRepositorio(AppDbContext contexto) : base(contexto)
        {
               
        }

        public IEnumerable<Categoria> GetCategoriasProdutos()
        {
            return Get().Include(p => p.Produtos);
        }
    }
}
