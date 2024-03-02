using CleanSheet.Domain.Primitives;
using MediatR;

namespace CleanSheet.Application.Abstractions.Messaging;
public interface IQueryHandler : IRequestHandler<IQuery, Result>;
public interface IQueryHandler<TResponse> : IRequestHandler<IQuery<TResponse>, Result<TResponse>>;