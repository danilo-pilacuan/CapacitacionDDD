using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapacitacionDDD.Core.Domain;


namespace CapacitacionDDD.Core.Application.Contracts.Persistence
{
    public interface ILibraryUnitOfWork : IDisposable
    {
        IAuthorRepository AuthorRepository { get; }
    }
}
