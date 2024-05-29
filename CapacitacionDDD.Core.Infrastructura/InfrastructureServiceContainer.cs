using CapacitacionDDD.Core.Application.Contracts.Persistence;
using CapacitacionDDD.Core.Domain;
using CapacitacionDDD.Core.Infrastructura.Context;
using CapacitacionDDD.Core.Infrastructura.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapacitacionDDD.Core.Infrastructura
{
    public class InfrastructureServiceContainer
    {
        public static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<LibraryContext>(options => options.UseInMemoryDatabase("Library"));
            using (var context = services.BuildServiceProvider().GetService<LibraryContext>())
            {
                context!.Autores.Add(new Author { Id = 1, Code = "A1", Name = "Jorge Icaza", Country = "Ecuador" });
                context!.Autores.Add(new Author { Id = 2, Code = "A2", Name = "Juan Montalvo", Country = "Ecuador" });
                context!.Autores.Add(new Author { Id = 4, Code = "A4", Name = "Julio Cortazar", Country = "Argentina" });
                context.SaveChanges();
            }
            services.AddScoped<ILibraryUnitOfWork, LibraryUnitOfWorkRepository>();

            services.AddScoped<IAuthorRepository, AuthorRepository>();
        }
    }
}
