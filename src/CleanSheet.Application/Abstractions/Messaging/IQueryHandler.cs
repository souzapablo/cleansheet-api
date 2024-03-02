using CleanSheet.Domain.Primitives;
using MediatR;

namespace CleanSheet.Application.Abstractions.Messaging;
internal interface IQueryHandler : IRequestHandler<IQuery>;
internal interface IQueryHandler<TResponse> : IRequestHandler<IQuery, Result<TResponse>>;