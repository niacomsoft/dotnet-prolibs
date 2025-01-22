/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

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
    public static void Trace(string message, DiagnosticsSourceCategory? sourceCategory = null) => WriteLine(message, sourceCategory, DiagnosticsLevel.Trace);

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
    public static bool TraceElse(bool where, string message, DiagnosticsSourceCategory? sourceCategory = null) => WriteLineElse(!where, message, sourceCategory, DiagnosticsLevel.Trace);

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
    public static bool TraceIf(bool where, string message, DiagnosticsSourceCategory? sourceCategory = null) => WriteLineIf(where, message, sourceCategory, DiagnosticsLevel.Trace);

    #endregion Methods
  }
}