using CleanSheet.Domain.Primitives;

namespace CleanSheet.Domain.Errors;
public static class UserErrors
{
    public static Error EmailUnavailable => new("EmailUnavailable", "E-mail is already in use.");
}
