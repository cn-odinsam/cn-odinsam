namespace Cola.Core.Models.Core.ColaLog;

public class ExceptionLog : LogInfo
{
    public Exception? LogException { get; set; }
}