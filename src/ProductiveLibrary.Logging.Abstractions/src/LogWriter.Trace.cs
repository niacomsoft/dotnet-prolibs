/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using Niacomsoft.ProductiveLibrary.Diagnostics;

using System;

namespace Niacomsoft.ProductiveLibrary.Runtime.Diagnostics
{
  public abstract partial class LogWriter
  {
    #region Methods

    /// <summary> 是否启用了 <c> Trace </c> 诊断级别。 </summary>
    /// <value> 获取 <see cref="bool" /> 类型的值，用于表示是否启用了 <c> Trace </c> 诊断级别。 </value>
    public virtual bool TraceEnabled
    {
      get
      {
#if DEBUG
        return true;
#else
        return false;
#endif
      }
    }

    /// <inheritdoc />
    public virtual void LogTrace(string message, Exception error, bool throwError = true, params object[] args)
    {
      Log(DiagnosticsLevel.Trace, message, error, throwError, args);
    }

    /// <inheritdoc />
    public virtual void LogTrace(string message, params object[] args)
    {
      Log(DiagnosticsLevel.Trace, message, args);
    }

    /// <inheritdoc />
    public virtual bool LogTraceElse(bool where, string message, params object[] args)
    {
      return LogElse(where, DiagnosticsLevel.Trace, message, args);
    }

    /// <inheritdoc />
    public virtual bool LogTraceIf(bool where, string message, params object[] args)
    {
      return LogIf(where, DiagnosticsLevel.Trace, message, args);
    }

    #endregion Methods
  }
}