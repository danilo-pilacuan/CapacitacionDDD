using CapacitacionDDD.Core.Domain;
using MediatR;

namespace CapacitacionDDD.Core.Application.Feautures.Queries.GetAuthorById
{
    public class GetAuthorByIdQuery : IRequest<Author>
    {
        public int Id { get; set; }
        public GetAuthorByIdQuery(int id)
        {
            Id = id;
        }
    }
}
