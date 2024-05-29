using CapacitacionDDD.Core.Infrastructura.Context;
using CapacitacionDDD.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapacitacionDDD.Core.Application.Contracts.Persistence;

namespace CapacitacionDDD.Core.Infrastructura.Repositories
{
    public class LibraryUnitOfWorkRepository : ILibraryUnitOfWork
    {
        public readonly LibraryContext _context;

        public LibraryUnitOfWorkRepository(LibraryContext context)
        {
            _context = context;
        }

        IAuthorRepository _authorRepository { get; set; }

        public IAuthorRepository AuthorRepository => _authorRepository ?? new AuthorRepository(_context);
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
