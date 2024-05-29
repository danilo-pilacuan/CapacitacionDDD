using CapacitacionDDD.Core.Application.Contracts.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapacitacionDDD.Core.Application.Feautures.Command.AddAuthor
{
    public class AddAuthorCommandHandler : IRequestHandler<AddAuthorCommand, int>
    {
        ILibraryUnitOfWork _unitOfWork;

        public AddAuthorCommandHandler(ILibraryUnitOfWork libraryUnitOfWork)
        {
            _unitOfWork = libraryUnitOfWork;
        }

        public async Task<int> Handle(AddAuthorCommand request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.AuthorRepository.AddAuthor(request);
            return result;
        }
    }
}
