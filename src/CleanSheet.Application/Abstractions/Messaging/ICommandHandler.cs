using CleanSheet.Domain.Primitives;
using MediatR;

namespace CleanSheet.Application.Abstractions.Messaging;

internal interface ICommandHandler : IRequestHandler<ICommand, Result>;
internal interface ICommandHandler<TValue> : IRequestHandler<ICommand<TValue>, Result<TValue>>;
