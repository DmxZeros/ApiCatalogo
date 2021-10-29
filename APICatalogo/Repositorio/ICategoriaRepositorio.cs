using APICatalogo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICatalogo.Repositorio
{
    public interface ICategoriaRepositorio: IRepositorio<Categoria>
    {
        IEnumerable<Categoria> GetCategoriasProdutos();
    }
}
