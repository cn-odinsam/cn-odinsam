using Cola.Core.Models.Core.ColaLog;
using Cola.Core.Models.Enums.Logs;

namespace Cola.Core.ColaLog.Core;

public interface IColaLogFace
{
    EnumLogLevel LogLevel { get; set; }
    LogConfig? Config { get; set; }

    /// <summary>
    ///     写入日志
    /// </summary>
    /// <param name="log">log</param>
    LogResponse? WriteLog(LogInfo log);
}