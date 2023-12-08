using Cola.Core.Models.Enums.Logs;

namespace Cola.Core.Models.Core.ColaLog;

/// <summary>
///     LogResponse
/// </summary>
public class LogResponse
{
    public string? LogId { get; set; }
    public EnumLogLevel LogLevel { get; set; }
}