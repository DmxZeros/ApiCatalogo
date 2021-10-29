using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APICatalogo.Context;

namespace APICatalogo.Repositorio
{
    public class UnitOfWork: IUnitOfWork
    {
        private ProdutoRepositorio _produtoRepositorio;
        private CategoriaRepositorio _categoriaRepositorio;
        public AppDbContext _context;

        public UnitOfWork(AppDbContext contexto)
        {
            _context = contexto;
        }

        public IProdutoRepositorio ProdutoRepositorio
        {
            get
            {
                return _produtoRepositorio = _produtoRepositorio ?? new ProdutoRepositorio(_context);
            }
        }

        public ICategoriaRepositorio CategoriaRepositorio
        {
            get
            {
                return _categoriaRepositorio = _categoriaRepositorio ?? new CategoriaRepositorio(_context);
            }
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
