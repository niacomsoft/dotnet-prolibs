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

    /// <summary> 是否启用 <c> Critical </c> 诊断。 </summary>
    /// <value> 获取 <see cref="bool" /> 类型的值，用于表示是否启用 <c> Critical </c> 诊断。 </value>
    protected virtual bool CriticalEnabled => true;

    /// <inheritdoc />
    public virtual void LogCritical(string message, Exception error, bool throwError = true, params object[] args)
    {
      Log(DiagnosticsLevel.Critical, message, error, throwError, args);
    }

    /// <inheritdoc />
    public virtual void LogCritical(string message, params object[] args)
    {
      Log(DiagnosticsLevel.Critical, message, args);
    }

    /// <inheritdoc />
    public virtual bool LogCriticalElse(bool where, string message, params object[] args)
    {
      return LogElse(where, DiagnosticsLevel.Critical, message, args);
    }

    /// <inheritdoc />
    public virtual bool LogCriticalIf(bool where, string message, params object[] args)
    {
      return LogIf(where, DiagnosticsLevel.Critical, message, args);
    }

    #endregion Methods
  }
}