/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using Microsoft.Extensions.Logging;

using Niacomsoft.ProductiveLibrary.Diagnostics;

using System;

namespace Niacomsoft.ProductiveLibrary.Runtime.Diagnostics
{
  /// <summary>
  ///   提供了基于 <see cref="ILogger" /> 记录运行时诊断日志相关的抽象 <see langword="abstract" /> 方法。
  /// </summary>
  /// <seealso cref="LogWriter" />
  public abstract class MicrosoftLogWriterBase : LogWriter
  {
    #region Constructors

    /// <summary> 初始化 <see cref="MicrosoftLogWriterBase" /> 类的新实例。 </summary>
    /// <param name="logger">
    ///   记录运行时诊断日志的方法。
    ///   <para> 实现了 <see cref="ILogger" /> 类型接口的对象实例。 </para>
    /// </param>
    protected MicrosoftLogWriterBase(ILogger logger) : base()
    {
      Logger = logger;
    }

    #endregion Constructors

    #region Properties

    /// <summary> 是否启用 <c> Critical </c> 诊断。 </summary>
    /// <value> 获取 <see cref="bool" /> 类型的值，用于表示是否启用 <c> Critical </c> 诊断。 </value>
    protected override bool CriticalEnabled => Logger.IsEnabled(LogLevel.Critical);

    /// <summary> 是否启用 <c> Error </c> 的诊断级别。 </summary>
    /// <value> 获取 <see cref="bool" /> 类型的值，用于表示是否启用 <c> Error </c> 的诊断级别。 </value>
    protected override bool ErrorEnabled => Logger.IsEnabled(LogLevel.Error);

    /// <summary> 是否启用 <c> Information </c> 诊断级别。 </summary>
    /// <value> 获取 <see cref="bool" /> 类型的值，用于表示是否启用 <c> Information </c> 诊断级别。 </value>
    protected override bool InformationEnabled => Logger.IsEnabled(LogLevel.Information);

    /// <summary> 记录运行时日志的方法。 </summary>
    /// <value> 获取 <see cref="ILogger" /> 类型的对象实例，用于表示记录运行时日志的方法。 </value>
    /// <seealso cref="ILogger" />
    protected virtual ILogger Logger { get; }

    /// <summary> 是否启用 <c> Warning </c> 诊断级别。 </summary>
    /// <value> 获取 <see cref="bool" /> 类型的值，用于表示是否启用 <c> Warning </c> 诊断级别。 </value>
    protected override bool WarningEnabled => Logger.IsEnabled(LogLevel.Warning);

    /// <summary> 是否启用了 <c> Debug </c> 诊断级别。 </summary>
    /// <value> 获取 <see cref="bool" /> 类型的值，用于表示是否启用了 <c> Debug </c> 诊断级别。 </value>
    public override bool DebugEnabled => Logger.IsEnabled(LogLevel.Debug);

    /// <summary> 是否启用了 <c> Trace </c> 诊断级别。 </summary>
    /// <value> 获取 <see cref="bool" /> 类型的值，用于表示是否启用了 <c> Trace </c> 诊断级别。 </value>
    public override bool TraceEnabled => Logger.IsEnabled(LogLevel.Trace);

    #endregion Properties

    #region Methods

    /// <summary> 将 <paramref name="level" /> 转换为 <see cref="LogLevel" /> 枚举类型中的一个值。 </summary>
    /// <param name="level"> <see cref="DiagnosticsLevel" /> 枚举类型中的一个值。 </param>
    /// <returns> <see cref="LogLevel" /> 枚举类型中的一个值。 </returns>
    /// <seealso cref="DiagnosticsLevel" />
    /// <seealso cref="LogLevel" />
    protected virtual LogLevel ConvertDiagnosticsLevel(DiagnosticsLevel level)
    {
      switch (level)
      {
        case DiagnosticsLevel.Trace:
          return LogLevel.Trace;

        case DiagnosticsLevel.Debug:
          return LogLevel.Debug;

        case DiagnosticsLevel.Information:
          return LogLevel.Information;

        case DiagnosticsLevel.Warning:
          return LogLevel.Warning;

        case DiagnosticsLevel.Error:
          return LogLevel.Error;

        case DiagnosticsLevel.Critical:
          return LogLevel.Critical;

        default:
          return LogLevel.Debug;
      }
    }

    /// <summary> 记录运行时日志。 </summary>
    /// <param name="level">
    ///   诊断日志级别。
    ///   <para> <see cref="DiagnosticsLevel" /> 枚举类型中的一个值。 </para>
    /// </param>
    /// <param name="message"> 日志信息。 </param>
    /// <param name="error"> 运行时异常。 </param>
    /// <param name="args"> 日志信息扩展参数。 </param>
    /// <seealso cref="DiagnosticsLevel" />
    /// <seealso cref="Exception" />
    protected override void LogImpl(DiagnosticsLevel level, string message, Exception error, params object[] args)
    {
      Logger.Log(ConvertDiagnosticsLevel(level), error, message, args);
    }

    /// <summary> 记录运行时日志。 </summary>
    /// <param name="level">
    ///   诊断日志级别。
    ///   <para> <see cref="DiagnosticsLevel" /> 枚举类型中的一个值。 </para>
    /// </param>
    /// <param name="message"> 日志信息。 </param>
    /// <param name="args"> 日志信息扩展参数。 </param>
    /// <seealso cref="DiagnosticsLevel" />
    protected override void LogImpl(DiagnosticsLevel level, string message, params object[] args)
    {
      Logger.Log(ConvertDiagnosticsLevel(level), message, args);
    }

    #endregion Methods
  }

  /// <summary>
  ///   提供了基于 <see cref="ILogger{TCategoryName}" /> 记录运行时诊断日志相关的抽象 <see langword="abstract" /> 方法。
  /// </summary>
  /// <typeparam name="TCategoryName"> 标识日志类别的类型。 </typeparam>
  /// <seealso cref="ILogWriter{T}" />
  /// <seealso cref="MicrosoftLogWriterBase" />
  public abstract class MicrosoftLogWriterBase<TCategoryName> : MicrosoftLogWriterBase, ILogWriter<TCategoryName>
  {
    #region Constructors

    /// <summary> 初始化 <see cref="MicrosoftLogWriterBase{T}" /> 类的新实例。 </summary>
    /// <param name="logger">
    ///   记录运行时诊断日志的方法。
    ///   <para> 实现了 <see cref="ILogger{TCategoryName}" /> 类型接口的对象实例。 </para>
    /// </param>
    protected MicrosoftLogWriterBase(ILogger<TCategoryName> logger) : base(logger)
    {
    }

    #endregion Constructors
  }
}