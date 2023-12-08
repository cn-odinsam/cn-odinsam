using Cola.Core.Models.Core.ColaLog;

namespace Cola.Core.ColaLog.Core;

public interface IColaLogs
{
    LogConfig? Config { get; set; }

    LogResponse? Info(LogInfo log);

    LogResponse? Info(string logInfo);

    LogResponse? Waring(LogInfo log);
    LogResponse? Waring(string logWaring);

    LogResponse? Error(Exception log);
    LogResponse? Error(ExceptionLog log);
    LogResponse? Error(string logError);
}