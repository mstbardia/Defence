using Defence.Internals.Abstractions;
using Defence.Internals.Options;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;

namespace Defence.Internals.Handlers;

/// <summary>
/// this handler provides necessary info about request and library configurations
/// </summary>
internal class DefenceContextHandler : IDefenceContextHandler
{
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly IOptions<DefenceServiceOptions> _options;

    public DefenceContextHandler(IHttpContextAccessor httpContextAccessor , IOptions<DefenceServiceOptions> options)
    {
        _httpContextAccessor = httpContextAccessor;
        _options = options;
    }
    
    public string GetRequestTraceId()
    {
        return _httpContextAccessor.HttpContext.TraceIdentifier;
    }

    public bool ShouldThrowExceptions()
    {
        return _options.Value.ThrowExceptions;
    }
}