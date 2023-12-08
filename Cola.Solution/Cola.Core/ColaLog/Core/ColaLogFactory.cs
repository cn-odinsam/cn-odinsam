using System.Reflection;
using Cola.Core.Models.Core.ColaLog;
using Cola.Core.Models.Enums.Logs;
using Microsoft.Extensions.DependencyInjection;

namespace Cola.Core.ColaLog.Core;

/// <summary>
///     ColaLogFactory
/// </summary>
public class ColaLogFactory
{
    public static IColaLogFace? GetOdinLogUtils(EnumLogLevel logLevel, LogConfig? config, IServiceCollection service)
    {
        var ns = "Cola.CaLog.Core.LogUtils";
        var classFullName = $"{ns}.Log{logLevel.ToString()}Util";
        var clsName = Assembly.GetExecutingAssembly().GetType(classFullName);
        if (clsName != null)
            return Activator.CreateInstance(clsName, logLevel, config, service) as IColaLogFace;
        return null;
    }
}