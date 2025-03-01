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

    /// <summary> 是否启用了 <c> Debug </c> 诊断级别。 </summary>
    /// <value> 获取 <see cref="bool" /> 类型的值，用于表示是否启用了 <c> Debug </c> 诊断级别。 </value>
    public virtual bool DebugEnabled
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
    public virtual void LogDebug(string message, Exception error, bool throwError = true, params object[] args)
    {
      Log(DiagnosticsLevel.Debug, message, error, throwError, args);
    }

    /// <inheritdoc />
    public virtual void LogDebug(string message, params object[] args)
    {
      Log(DiagnosticsLevel.Debug, message, args);
    }

    /// <inheritdoc />
    public virtual bool LogDebugElse(bool where, string message, params object[] args)
    {
      return LogElse(where, DiagnosticsLevel.Debug, message, args);
    }

    /// <inheritdoc />
    public virtual bool LogDebugIf(bool where, string message, params object[] args)
    {
      return LogIf(where, DiagnosticsLevel.Debug, message, args);
    }

    #endregion Methods
  }
}