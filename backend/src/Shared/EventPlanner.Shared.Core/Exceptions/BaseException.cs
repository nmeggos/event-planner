using System.Net;

namespace EventPlanner.Shared.Core.Exceptions;

public class BaseException : Exception
{
    protected BaseException(string message) : base(message)
    {
    }
    
    public HttpStatusCode StatusCode { get; protected set; }
}