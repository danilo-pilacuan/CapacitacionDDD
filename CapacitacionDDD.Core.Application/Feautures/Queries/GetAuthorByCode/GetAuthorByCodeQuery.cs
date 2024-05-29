using CapacitacionDDD.Core.Domain;
using MediatR;

namespace CapacitacionDDD.Core.Application.Feautures.Queries.GetAuthorByCode
{
    public class GetAuthorByCodeQuery : IRequest<Author>
    {
        public string Code { get; set; }
        public GetAuthorByCodeQuery(string code)
        {
            Code = code;
        }

    }
}
