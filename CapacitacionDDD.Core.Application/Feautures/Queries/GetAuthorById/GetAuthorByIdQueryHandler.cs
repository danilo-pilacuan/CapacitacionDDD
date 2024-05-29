using CapacitacionDDD.Core.Application.Contracts.Persistence;
using CapacitacionDDD.Core.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapacitacionDDD.Core.Application.Feautures.Queries.GetAuthorById
{
    public class GetAuthorByIdQueryHandler : IRequestHandler<GetAuthorByIdQuery, Author>
    {
        ILibraryUnitOfWork _libraryUnitOfWork;

        public GetAuthorByIdQueryHandler(ILibraryUnitOfWork libraryUnitOfWork)
        {
            _libraryUnitOfWork = libraryUnitOfWork;
        }

        public async Task<Author> Handle(GetAuthorByIdQuery request, CancellationToken cancellationToken)
        {
            var result = await _libraryUnitOfWork.AuthorRepository.GetAuthorById(request.Id);
            return result;

        }
    
}
}
