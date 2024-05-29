using CapacitacionDDD.Core.Application.Feautures.Command.AddAuthor;
using CapacitacionDDD.Core.Application.Feautures.Command.UpdateAuthor;
using CapacitacionDDD.Core.Application.Feautures.Queries.GetAuthorByCode;
using CapacitacionDDD.Core.Application.Feautures.Queries.GetAuthorById;
using CapacitacionDDD.Core.Infrastructura;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

Console.WriteLine("Hello, World!");

var services = new ServiceCollection();
var configuration = new ConfigurationBuilder().Build();
InfrastructureServiceContainer.ConfigureServices(services, configuration);

services.AddMediatR(AppDomain.CurrentDomain.GetAssemblies());

var servicesProvider = services.BuildServiceProvider(); 
var mediator = servicesProvider.GetRequiredService<IMediator>();
GetAuthorByIdQuery getAuthorByIdQuery = new GetAuthorByIdQuery(1);
var result = await mediator.Send(getAuthorByIdQuery);
Console.WriteLine("El Autor encontrado por Id es: " + result.Name);


AddAuthorCommand addAuthorCommand = new AddAuthorCommand();
addAuthorCommand.Id = 3;
addAuthorCommand.Code = "A3";
addAuthorCommand.Name = "Juan Leon Mera";
addAuthorCommand.Country = "Ecuador";
var resultId = await mediator.Send(addAuthorCommand);
Console.WriteLine("El Id del autor creado es: " + resultId);

UpdateAuthorCommand updateAuthorCommand = new UpdateAuthorCommand();
updateAuthorCommand.Id = 2;
updateAuthorCommand.Code = "A2";
updateAuthorCommand.Name = "Eugenio Espejo";
updateAuthorCommand.Country = "Ecuador";
await mediator.Send(updateAuthorCommand);

GetAuthorByIdQuery getAuthorByIdQueryUpdate = new GetAuthorByIdQuery(2);
var resulAuthorUpdateQuery = await mediator.Send(getAuthorByIdQueryUpdate);
Console.WriteLine("El autor actualizado es: " + resulAuthorUpdateQuery.Name);

#region Evaluacion DDD
string codigoAutor = "A2";
GetAuthorByCodeQuery getAuthorQuery = new GetAuthorByCodeQuery(codigoAutor);
var authorResult = await mediator.Send(getAuthorQuery);
Console.WriteLine($"El autor encontrado por codigo es: {authorResult.Name}");
#endregion Evaluacion DDD
