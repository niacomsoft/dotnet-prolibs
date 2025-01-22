/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE Critical.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using System;
using System.Diagnostics.CodeAnalysis;

namespace Niacomsoft.ProductiveLibrary.Diagnostics
{
  public static partial class Doctor
  {
    #region Methods

    /// <summary> 输出一行诊断信息。 </summary>
    /// <param name="message"> 需要输出的诊断信息。 </param>
    /// <param name="sourceCategory">
    ///   诊断源头类别。
    ///   <para> 可能为空的 <see cref="DiagnosticsSourceCategory" /> 类型值。 </para>
    /// </param>
    public static void Critical(string message, DiagnosticsSourceCategory? sourceCategory = null) => WriteLine(message, sourceCategory, DiagnosticsLevel.Critical);

    /// <summary> 输出异常诊断信息并抛出。 </summary>
    /// <param name="error"> 当前的异常信息。 </param>
    /// <param name="sourceCategory">
    ///   诊断源头类别。
    ///   <para> 可能为空的 <see cref="DiagnosticsSourceCategory" /> 类型值。 </para>
    /// </param>
    [SuppressMessage("Design", "Ex0100:Member may throw undocumented exception", Justification = "<挂起>")]
    public static void CriticalAndThrow(Exception error, DiagnosticsSourceCategory? sourceCategory = null)
    {
      Critical(error.ToString(), sourceCategory);
      throw error;
    }

    /// <summary>
    ///   当条件表达式 <paramref name="where" /> 等于 <see langword="false" /> 时，输出一行诊断信息。并最终返回
    ///   <paramref name="where" />。
    /// </summary>
    /// <param name="where"> 条件表达式。 </param>
    /// <param name="message"> 需要输出的诊断信息。 </param>
    /// <param name="sourceCategory">
    ///   诊断源头类别。
    ///   <para> 可能为空的 <see cref="DiagnosticsSourceCategory" /> 类型值。 </para>
    /// </param>
    /// <returns> <paramref name="where" />。 </returns>
    public static bool CriticalElse(bool where, string message, DiagnosticsSourceCategory? sourceCategory = null) => WriteLineElse(!where, message, sourceCategory, DiagnosticsLevel.Critical);

    /// <summary>
    ///   当条件表达式 <paramref name="where" /> 等于 <see langword="true" /> 时，输出一行诊断信息。并最终返回
    ///   <paramref name="where" />。
    /// </summary>
    /// <param name="where"> 条件表达式。 </param>
    /// <param name="message"> 需要输出的诊断信息。 </param>
    /// <param name="sourceCategory">
    ///   诊断源头类别。
    ///   <para> 可能为空的 <see cref="DiagnosticsSourceCategory" /> 类型值。 </para>
    /// </param>
    /// <returns> <paramref name="where" />。 </returns>
    public static bool CriticalIf(bool where, string message, DiagnosticsSourceCategory? sourceCategory = null) => WriteLineIf(where, message, sourceCategory, DiagnosticsLevel.Critical);

    #endregion Methods
  }
}