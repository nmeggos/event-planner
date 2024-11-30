using System.Net;

namespace EventPlanner.Shared.Core.Exceptions;

public class BadRequestException : BaseException
{
    public BadRequestException(string message) : base(message)
    {
        StatusCode = HttpStatusCode.BadRequest;
    }
}