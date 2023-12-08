using Cola.Core.Models.Core.ColaLog;
using Cola.Core.Models.Enums.Logs;
using Microsoft.Extensions.DependencyInjection;

namespace Cola.Core.ColaLog.Core;

public class AbsColaLogContent : AbsColaLogFace
{
    protected AbsColaLogContent(EnumLogLevel logLevel, LogConfig config, IServiceCollection? service) : base(logLevel,
        config, service)
    {
    }

    public override LogResponse? WriteLog(LogInfo log)
    {
        return null;
    }
}