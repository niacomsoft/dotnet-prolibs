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

    /// <summary> 是否启用 <c> Error </c> 的诊断级别。 </summary>
    /// <value> 获取 <see cref="bool" /> 类型的值，用于表示是否启用 <c> Error </c> 的诊断级别。 </value>
    protected virtual bool ErrorEnabled => true;

    #endregion Properties

    #region Methods

    /// <inheritdoc />
    public virtual void LogError(string message, Exception error, bool throwError = true, params object[] args)
    {
      Log(DiagnosticsLevel.Error, message, error, throwError, args);
    }

    /// <inheritdoc />
    public virtual void LogError(string message, params object[] args)
    {
      Log(DiagnosticsLevel.Error, message, args);
    }

    /// <inheritdoc />
    public virtual bool LogErrorElse(bool where, string message, params object[] args)
    {
      return LogElse(where, DiagnosticsLevel.Error, message, args);
    }

    /// <inheritdoc />
    public virtual bool LogErrorIf(bool where, string message, params object[] args)
    {
      return LogIf(where, DiagnosticsLevel.Error, message, args);
    }

    #endregion Methods
  }
}