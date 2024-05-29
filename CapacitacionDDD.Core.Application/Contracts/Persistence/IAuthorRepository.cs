using CapacitacionDDD.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapacitacionDDD.Core.Application.Contracts.Persistence
{
    public interface IAuthorRepository
    {
        Task<Author> GetAuthorById(int id);

        Task<Author> GetAuthorByCode(string code);

        Task<int> AddAuthor(Author author);

        Task<int> UpdateAuthor(Author author);

        Task<int> DeleteAuthor(Author author);
    }
}
