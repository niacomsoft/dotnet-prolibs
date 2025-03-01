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
    #region Properties

    /// <summary> 是否启用 <c> Warning </c> 诊断级别。 </summary>
    /// <value> 获取 <see cref="bool" /> 类型的值，用于表示是否启用 <c> Warning </c> 诊断级别。 </value>
    protected virtual bool WarningEnabled => true;

    #endregion Properties

    #region Methods

    /// <inheritdoc />
    public virtual void LogWarning(string message, Exception error, bool throwError = true, params object[] args)
    {
      Log(DiagnosticsLevel.Warning, message, error, throwError, args);
    }

    /// <inheritdoc />
    public virtual void LogWarning(string message, params object[] args)
    {
      Log(DiagnosticsLevel.Warning, message, args);
    }

    /// <inheritdoc />
    public virtual bool LogWarningElse(bool where, string message, params object[] args)
    {
      return LogElse(where, DiagnosticsLevel.Warning, message, args);
    }

    /// <inheritdoc />
    public virtual bool LogWarningIf(bool where, string message, params object[] args)
    {
      return LogIf(where, DiagnosticsLevel.Warning, message, args);
    }

    #endregion Methods
  }
}