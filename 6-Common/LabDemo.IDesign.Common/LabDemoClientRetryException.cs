namespace LabDemo.IDesign.Common;

/// <summary>
/// Under certain scenarios, we want to return to the client whether or not the client
/// can retry the effort for better or different results.
/// For example, when the database is down for under a second
/// </summary>
/// <remarks>
/// An alternative approach: return a result code back that includes an error code indicating retry
/// as in https://www.milanjovanovic.tech/blog/functional-error-handling-in-dotnet-with-the-result-pattern/// 
/// </remarks>
internal class LabDemoClientRetryException : Exception
{
}
