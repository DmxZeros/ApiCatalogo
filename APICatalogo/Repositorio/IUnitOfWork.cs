using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICatalogo.Repositorio
{
    public interface IUnitOfWork
    {
        IProdutoRepositorio ProdutoRepositorio { get; }

        ICategoriaRepositorio CategoriaRepositorio { get; }

        void Commit();

    }
}
