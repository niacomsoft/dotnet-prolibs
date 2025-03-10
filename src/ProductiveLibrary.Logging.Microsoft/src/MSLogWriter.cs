/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using Microsoft.Extensions.Logging;

using Niacomsoft.ProductiveLibrary.Diagnostics;

using System;

namespace Niacomsoft.ProductiveLibrary.Runtime.Diagnostics
{
  /// <summary> 提供了基于记录运行时诊断日志相关的基本方法。 </summary>
  /// <seealso cref="IMSLogWriter" />
  /// <seealso cref="LogWriter" />
  public class MSLogWriter : LogWriter, IMSLogWriter
  {
    #region Fields

    private readonly ILogger _logger;

    #endregion Fields

    #region Constructors

    /// <summary> 初始化 <see cref="MSLogWriter" /> 类的新实例。 </summary>
    /// <param name="logger"> 实现了 <see cref="ILogger" /> 类型接口的对象实例。 </param>
    public MSLogWriter(ILogger logger)
    {
      _logger = logger;
    }

    #endregion Constructors

    #region Properties

    /// <inheritdoc />
    ILogger IMSLogWriter.Logger
    {
      get { return _logger; }
    }

    #endregion Properties

    #region Methods

    /// <summary> 将 <paramref name="source" /> 转换为 <see cref="LogLevel" /> 类型的值。 </summary>
    /// <param name="source"> <see cref="DiagnosticsLevel" /> 枚举类型中的一个值。 </param>
    /// <returns> <see cref="LogLevel" /> 枚举类型中的一个值。 </returns>
    protected virtual LogLevel ConvertToLogLevel(DiagnosticsLevel source)
    {
      switch (source)
      {
        case DiagnosticsLevel.Trace:
          return LogLevel.Trace;

        case DiagnosticsLevel.Debug:
          return LogLevel.None;

        case DiagnosticsLevel.Information:
          return LogLevel.Information;

        case DiagnosticsLevel.Warning:
          return LogLevel.Warning;

        case DiagnosticsLevel.Error:
          return LogLevel.Error;

        case DiagnosticsLevel.Critical:
          return LogLevel.Critical;

        default:
          return LogLevel.None;
      }
    }

    /// <inheritdoc />
    protected override bool EnableDiagnosticsLevel(DiagnosticsLevel level)
    {
      var target = ConvertToLogLevel(level);
      return target != LogLevel.None && _logger.IsEnabled(ConvertToLogLevel(level));
    }

    /// <inheritdoc />
    protected override void LogImpl(DiagnosticsLevel level, string message, Exception error, params object[] args)
    {
      _logger.Log(ConvertToLogLevel(level), error, message, args);
    }

    /// <inheritdoc />
    protected override void LogImpl(DiagnosticsLevel level, string message, params object[] args)
    {
      _logger.Log(ConvertToLogLevel(level), message, args);
    }

    #endregion Methods
  }
}