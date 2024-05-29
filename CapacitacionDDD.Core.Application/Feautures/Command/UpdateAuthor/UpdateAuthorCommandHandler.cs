using CapacitacionDDD.Core.Application.Contracts.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapacitacionDDD.Core.Application.Feautures.Command.UpdateAuthor
{
    public class UpdateAutorCommandHandler : IRequestHandler<UpdateAuthorCommand, int>
    {
        ILibraryUnitOfWork _libraryUnitOfWork;

        public UpdateAutorCommandHandler(ILibraryUnitOfWork libraryUnitOfWork)
        {
            _libraryUnitOfWork = libraryUnitOfWork;
        }

        public async Task<int> Handle(UpdateAuthorCommand request, CancellationToken cancellationToken)
        {
            var result = await _libraryUnitOfWork.AuthorRepository.UpdateAuthor(request);
            return result;
        }
    }
}
