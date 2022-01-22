namespace Defence.Core.Handlers.Internals.Abstractions;

/// <summary>
/// you should seek its duty on its implementer
/// </summary>
internal interface IDefenceContextHandler
{
  string GetRequestTraceId();
  
  bool ShouldThrowExceptions();
}