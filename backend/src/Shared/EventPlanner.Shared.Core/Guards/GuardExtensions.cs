using System.Text.RegularExpressions;
using EventPlanner.Shared.Core.Exceptions;

namespace EventPlanner.Shared.Core.Guards;

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