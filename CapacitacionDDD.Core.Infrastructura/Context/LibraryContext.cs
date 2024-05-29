using CapacitacionDDD.Core.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapacitacionDDD.Core.Infrastructura.Context
{
    public class LibraryContext : DbContext
    {
        public DbSet<Author> Autores { get; set; }

        public LibraryContext(DbContextOptions<LibraryContext> options)
            : base(options)
        {

        }

    }
}
