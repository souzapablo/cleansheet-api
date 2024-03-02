using CleanSheet.Domain.Primitives;
using MediatR;

namespace CleanSheet.Application.Abstractions.Messaging;
public interface IQuery : IRequest<Result>;
public interface IQuery<TResponse> : IRequest<Result<TResponse>>;