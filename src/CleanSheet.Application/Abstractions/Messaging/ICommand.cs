using CleanSheet.Domain.Primitives;
using MediatR;

namespace CleanSheet.Application.Abstractions.Messaging;
public interface ICommand : IRequest<Result>;

public interface ICommand<TResponse> : IRequest<Result<TResponse>>;
