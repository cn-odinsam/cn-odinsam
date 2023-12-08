using Cola.Core.Models.Core.ColaLog;
using Cola.Core.Models.Enums.Logs;
using Microsoft.Extensions.DependencyInjection;

namespace Cola.Core.ColaLog.Core.LogUtils;

public class LogErrorUtil : AbsLogException
{
    public LogErrorUtil(EnumLogLevel logLevel, LogConfig config, IServiceCollection? service) : base(logLevel, config,
        service)
    {
    }

    public override LogResponse? WriteLog(LogInfo log)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        var logResult = WriteLogContent(log);
        Console.ResetColor();
        return logResult;
    }
}