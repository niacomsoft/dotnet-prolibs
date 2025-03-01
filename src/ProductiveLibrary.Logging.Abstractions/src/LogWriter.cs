/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using Niacomsoft.ProductiveLibrary.Diagnostics;
using Niacomsoft.ProductiveLibrary.Resources;
using Niacomsoft.ProductiveLibrary.Resources.Internal;
using Niacomsoft.ProductiveLibrary.Utilities;

using System;
using System.Diagnostics.CodeAnalysis;

namespace Niacomsoft.ProductiveLibrary.Runtime.Diagnostics
{
  /// <summary> 提供了记录运行时诊断日志相关的抽象 <see langword="abstract" /> 方法。 </summary>
  public abstract partial class LogWriter : ILogWriter
  {
    #region Methods

    /// <summary> 是否启用了指定的诊断级别。 </summary>
    /// <param name="level">
    ///   诊断级别。
    ///   <para> <see cref="DiagnosticsLevel" /> 枚举类型中的一个值。 </para>
    /// </param>
    /// <returns>
    ///   当启用了指定的诊断级别 <paramref name="level" /> 时，返回 <see langword="true" />；否则返回
    ///   <see langword="false" /> 。
    /// </returns>
    /// <seealso cref="DiagnosticsLevel" />
    protected virtual bool EnableDiagnosticsLevel(DiagnosticsLevel level)
    {
      switch (level)
      {
        case DiagnosticsLevel.Trace:
          return TraceEnabled;

        case DiagnosticsLevel.Debug:
          return DebugEnabled;

        case DiagnosticsLevel.Information:
          return InformationEnabled;

        case DiagnosticsLevel.Warning:
          return WarningEnabled;

        case DiagnosticsLevel.Error:
          return ErrorEnabled;

        case DiagnosticsLevel.Critical:
          return CriticalEnabled;

        default:
          return InformationEnabled;
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
    protected abstract void LogImpl(DiagnosticsLevel level, string message, Exception error, params object[] args);

    /// <summary> 记录运行时日志。 </summary>
    /// <param name="level">
    ///   诊断日志级别。
    ///   <para> <see cref="DiagnosticsLevel" /> 枚举类型中的一个值。 </para>
    /// </param>
    /// <param name="message"> 日志信息。 </param>
    /// <param name="args"> 日志信息扩展参数。 </param>
    /// <seealso cref="DiagnosticsLevel" />
    protected abstract void LogImpl(DiagnosticsLevel level, string message, params object[] args);

    /// <inheritdoc />
    [SuppressMessage("Design", "Ex0100:Member may throw undocumented exception", Justification = "<挂起>")]
    public virtual void Log(DiagnosticsLevel level, string message, Exception error, bool throwError = true, params object[] args)
    {
      if ((AssertUtilities.NotNull(error) || AssertUtilities.NotWhiteSpace(message)) && EnableDiagnosticsLevel(level))
      {
        if (AssertUtilities.IsNull(error))
        {
          LogImpl(level, message, args);
        }
        else
        {
          LogImpl(level, Guard.DefaultIfWhiteSpace(message, SR.Format(nameof(Strings.LogWriter_exceptional_message_when_message_empty), error.GetType().FullName, error.Message)), error, args);

          if (throwError)
          {
            throw error;
          }
        }
      }
    }

    /// <inheritdoc />
    public virtual void Log(DiagnosticsLevel level, string message, params object[] args)
    {
      if (AssertUtilities.NotWhiteSpace(message) && EnableDiagnosticsLevel(level))
      {
        LogImpl(level, message, args);
      }
    }

    /// <inheritdoc />
    public virtual bool LogElse(bool where, DiagnosticsLevel level, string message, params object[] args)
    {
      return !LogIf(!where, level, message, args);
    }

    /// <inheritdoc />
    public virtual bool LogIf(bool where, DiagnosticsLevel level, string message, params object[] args)
    {
      if (where)
      {
        Log(level, message, args);
      }

      return where;
    }

    #endregion Methods
  }
}