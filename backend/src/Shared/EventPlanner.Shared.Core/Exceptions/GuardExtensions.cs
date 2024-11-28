using System.Text.RegularExpressions;
using Ardalis.GuardClauses;

namespace EventPlanner.Shared.Core.Exceptions;

public static class GuardExtensions
{
    public static string InvalidEmail(this IGuardClause guardClause, string value)
    {
        var emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        
        if (!emailRegex.IsMatch(value))
        {
            throw new BadRequestException($"The email address '{value}' is invalid.");
        }

        return value;
    }
}