using APICatalogo.Context;
using APICatalogo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICatalogo.Repositorio
{
    public class ProdutoRepositorio: Repositorio<Produto>, IProdutoRepositorio
    {
        public ProdutoRepositorio(AppDbContext contexto): base(contexto)
        {

        }

        public IEnumerable<Produto> GetProdutosPorPreco()
        {
            return Get().OrderBy(p => p.Preco).ToList();
        }
    }
}
