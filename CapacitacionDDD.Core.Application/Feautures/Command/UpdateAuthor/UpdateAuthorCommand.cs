﻿using CapacitacionDDD.Core.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapacitacionDDD.Core.Application.Feautures.Command.UpdateAuthor
{
    public class UpdateAuthorCommand : Author, IRequest<int>
    {

    }
}
