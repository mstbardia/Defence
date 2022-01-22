namespace Defence.Core.Handlers.Internals.Abstractions;

internal interface IDefenceContextHandler
{
  string GetRequestTraceId();
  
  bool ShouldThrowExceptions();
}