/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using Niacomsoft.ProductiveLibrary.Diagnostics;

using System;

namespace Niacomsoft.ProductiveLibrary.Runtime.Diagnostics
{
  #region Interfaces

  /// <summary> 提供了记录运行时日志的接口。 </summary>
  public partial interface ILogWriter
  {
    #region Methods

    /// <summary> 记录运行时日志。 </summary>
    /// <param name="level">
    ///   诊断日志级别。
    ///   <para> <see cref="DiagnosticsLevel" /> 枚举类型中的一个值。 </para>
    /// </param>
    /// <param name="message"> 日志信息。 </param>
    /// <param name="error"> 运行时异常。 </param>
    /// <param name="throwError"> 记录运行时异常日志后，是否抛出 <paramref name="error" />。 </param>
    /// <param name="args"> 日志信息扩展参数。 </param>
    /// <seealso cref="DiagnosticsLevel" />
    /// <seealso cref="Exception" />
    void Log(DiagnosticsLevel level, string message, Exception error, bool throwError = true, params object[] args);

    /// <summary> 记录运行时日志。 </summary>
    /// <param name="level">
    ///   诊断日志级别。
    ///   <para> <see cref="DiagnosticsLevel" /> 枚举类型中的一个值。 </para>
    /// </param>
    /// <param name="message"> 日志信息。 </param>
    /// <param name="args"> 日志信息扩展参数。 </param>
    /// <seealso cref="DiagnosticsLevel" />
    void Log(DiagnosticsLevel level, string message, params object[] args);

    /// <summary> 当 <paramref name="where" /> 等于 <see langword="false" /> 时记录运行时日志。 </summary>
    /// <param name="where"> 条件表达式。 </param>
    /// <param name="level">
    ///   诊断日志级别。
    ///   <para> <see cref="DiagnosticsLevel" /> 枚举类型中的一个值。 </para>
    /// </param>
    /// <param name="message"> 日志信息。 </param>
    /// <param name="args"> 日志信息扩展参数。 </param>
    /// <returns> <paramref name="where" />。 </returns>
    /// <seealso cref="DiagnosticsLevel" />
    bool LogElse(bool where, DiagnosticsLevel level, string message, params object[] args);

    /// <summary> 当 <paramref name="where" /> 等于 <see langword="true" /> 时记录运行时日志。 </summary>
    /// <param name="where"> 条件表达式。 </param>
    /// <param name="level">
    ///   诊断日志级别。
    ///   <para> <see cref="DiagnosticsLevel" /> 枚举类型中的一个值。 </para>
    /// </param>
    /// <param name="message"> 日志信息。 </param>
    /// <param name="args"> 日志信息扩展参数。 </param>
    /// <returns> <paramref name="where" />。 </returns>
    /// <seealso cref="DiagnosticsLevel" />
    bool LogIf(bool where, DiagnosticsLevel level, string message, params object[] args);

    #endregion Methods
  }

  #endregion Interfaces
}