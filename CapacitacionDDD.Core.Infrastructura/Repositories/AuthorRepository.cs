using CapacitacionDDD.Core.Application.Contracts.Persistence;
using CapacitacionDDD.Core.Domain;
using CapacitacionDDD.Core.Infrastructura.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapacitacionDDD.Core.Infrastructura.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        public readonly LibraryContext _context;

        public AuthorRepository(LibraryContext context)
        {
            _context = context;
        }

        public async Task<Author> GetAuthorById(int id)
        {
            return await _context.Autores.FindAsync(id);
        }
        public async Task<Author> GetAuthorByCode(string code)
        {
            return _context.Autores.Where(au => au.Code.Equals(code)).First();
        }

        public async Task<int> AddAuthor(Author author)
        {
            await _context.Autores.AddAsync(author);
            await _context.SaveChangesAsync();
            return author.Id;

        }

        public async Task<int> UpdateAuthor(Author author)
        {
            var existAutor = await _context.Autores.FindAsync(author.Id);
            if (existAutor != null)
            {
                existAutor.Code = author.Code;
                existAutor.Name = author.Name;
                existAutor.Country = author.Country;
                _context.Autores.Update(existAutor);
            }
            var result = await _context.SaveChangesAsync();

            return result;
        }

        public async Task<int> DeleteAuthor(Author author)
        {
            var existAutor = await _context.Autores.FindAsync(author.Id);
            if (existAutor != null)
            {
                existAutor.Code = author.Code;
                existAutor.Name = author.Name;
                existAutor.Country = author.Country;
                _context.Autores.Remove(existAutor);
            }
            var result = await _context.SaveChangesAsync();
            return result;
        }
    }

}
