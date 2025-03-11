/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using Niacomsoft.ProductiveLibrary.Diagnostics;

using NLog;

using System;

namespace Niacomsoft.ProductiveLibrary.Runtime.Diagnostics
{
  /// <summary> 提供了基于 <see cref="ILogger" /> 记录运行时诊断日志相关的基本方法。 </summary>
  /// <seealso cref="INLogWriter" />
  /// <seealso cref="LogWriter" />
  public class NLogWriter : LogWriter, INLogWriter
  {
    #region Constructors

    /// <summary> 初始化 <see cref="NLogWriter" /> 类的新实例。 </summary>
    /// <param name="logger"> 记录运行时诊断日志的方法。 </param>
    public NLogWriter(ILogger logger)
    {
      Logger = logger;
    }

    #endregion Constructors

    #region Properties

    /// <inheritdoc />
    public virtual ILogger Logger { get; }

    #endregion Properties

    #region Methods

    /// <summary>
    ///   将 <paramref name="source" /> 转换成 <see cref="NLog.LogLevel" /> 类型的对象实例。
    /// </summary>
    /// <param name="source"> <see cref="DiagnosticsLevel" /> 枚举类型中的一个值。 </param>
    /// <returns> <see cref="NLog.LogLevel" /> 类型的对象实例。 </returns>
    /// <seealso cref="DiagnosticsLevel" />
    /// <seealso cref="NLog.LogLevel" />
    protected virtual NLog.LogLevel ConvertToLogLevel(DiagnosticsLevel source)
    {
      switch (source)
      {
        case DiagnosticsLevel.Trace:
          return NLog.LogLevel.Trace;

        case DiagnosticsLevel.Debug:
          return NLog.LogLevel.Debug;

        case DiagnosticsLevel.Information:
          return NLog.LogLevel.Info;

        case DiagnosticsLevel.Warning:
          return NLog.LogLevel.Warn;

        case DiagnosticsLevel.Error:
          return NLog.LogLevel.Error;

        case DiagnosticsLevel.Critical:
          return NLog.LogLevel.Fatal;

        default:
          return NLog.LogLevel.Info;
      }
    }

    /// <inheritdoc />
    protected override bool EnableDiagnosticsLevel(DiagnosticsLevel level)
    {
      return Logger.IsEnabled(ConvertToLogLevel(level));
    }

    /// <inheritdoc />
    protected override void LogImpl(DiagnosticsLevel level, string message, Exception error, params object[] args)
    {
      Logger.Log(ConvertToLogLevel(level), error, message, args);
    }

    /// <inheritdoc />
    protected override void LogImpl(DiagnosticsLevel level, string message, params object[] args)
    {
      Logger.Log(ConvertToLogLevel(level), message, args);
    }

    #endregion Methods
  }
}