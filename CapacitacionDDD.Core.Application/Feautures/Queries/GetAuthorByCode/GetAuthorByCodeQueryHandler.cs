using CapacitacionDDD.Core.Application.Contracts.Persistence;
using CapacitacionDDD.Core.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapacitacionDDD.Core.Application.Feautures.Queries.GetAuthorByCode
{
public class GetAuthorByCodeQueryHandler : IRequestHandler<GetAuthorByCodeQuery, Author>

    {

        ILibraryUnitOfWork _libraryUnitOfWork;

        public GetAuthorByCodeQueryHandler(ILibraryUnitOfWork libraryUnitOfWork)

        {

            _libraryUnitOfWork = libraryUnitOfWork;

        }

        public async Task<Author> Handle(GetAuthorByCodeQuery request, CancellationToken cancellationToken)

        {

            var result = _libraryUnitOfWork.AuthorRepository.GetAuthorByCode(request.Code);

            return result.Result;

        }

    }
}
