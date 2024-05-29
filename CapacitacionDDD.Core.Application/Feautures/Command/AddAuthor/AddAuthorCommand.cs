using CapacitacionDDD.Core.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapacitacionDDD.Core.Application.Feautures.Command.AddAuthor
{
    public class AddAuthorCommand : Author, IRequest<int>
    {


    }
}
