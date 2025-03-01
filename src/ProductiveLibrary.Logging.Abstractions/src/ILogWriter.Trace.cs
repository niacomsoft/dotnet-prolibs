/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using System;

namespace Niacomsoft.ProductiveLibrary.Runtime.Diagnostics
{
  #region Interfaces

  public partial interface ILogWriter
  {
    #region Methods

    /// <summary> 记录 <c> Trace </c> 级别运行时日志。 </summary>
    /// <param name="message"> 日志信息。 </param>
    /// <param name="error"> 运行时异常。 </param>
    /// <param name="throwError"> 记录运行时异常日志后，是否抛出 <paramref name="error" />。 </param>
    /// <param name="args"> 日志信息扩展参数。 </param>
    /// <seealso cref="Exception" />
    void LogTrace(string message, Exception error, bool throwError = true, params object[] args);

    /// <summary> 记录 <c> Trace </c> 级别运行时日志。 </summary>
    /// <param name="message"> 日志信息。 </param>
    /// <param name="args"> 日志信息扩展参数。 </param>
    void LogTrace(string message, params object[] args);

    /// <summary>
    ///   当 <paramref name="where" /> 等于 <see langword="false" /> 时记录 <c> Trace </c> 级别运行时日志。
    /// </summary>
    /// <param name="where"> 条件表达式。 </param>
    /// <param name="message"> 日志信息。 </param>
    /// <param name="args"> 日志信息扩展参数。 </param>
    /// <returns> <paramref name="where" />。 </returns>
    bool LogTraceElse(bool where, string message, params object[] args);

    /// <summary>
    ///   当 <paramref name="where" /> 等于 <see langword="true" /> 时记录 <c> Trace </c> 级别运行时日志。
    /// </summary>
    /// <param name="where"> 条件表达式。 </param>
    /// <param name="message"> 日志信息。 </param>
    /// <param name="args"> 日志信息扩展参数。 </param>
    /// <returns> <paramref name="where" />。 </returns>
    bool LogTraceIf(bool where, string message, params object[] args);

    #endregion Methods
  }

  #endregion Interfaces
}