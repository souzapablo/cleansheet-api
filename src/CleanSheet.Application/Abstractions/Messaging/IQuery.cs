using CleanSheet.Domain.Primitives;
using MediatR;

namespace CleanSheet.Application.Abstractions.Messaging;
internal interface IQuery : IRequest<Result>;
internal interface IQuery<TResponse> : IRequest<Result<TResponse>>;