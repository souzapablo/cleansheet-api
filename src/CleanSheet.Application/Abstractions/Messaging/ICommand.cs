using CleanSheet.Domain.Primitives;
using MediatR;

namespace CleanSheet.Application.Abstractions.Messaging;
internal interface ICommand : IRequest<Result>;

internal interface ICommand<TResponse> : IRequest<Result<TResponse>>;
