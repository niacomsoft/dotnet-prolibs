/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using Niacomsoft.ProductiveLibrary.Resources;

using System;
using _Trace = System.Diagnostics.Trace;
using System.Diagnostics.CodeAnalysis;

namespace Niacomsoft.ProductiveLibrary.Diagnostics
{
  /// <summary> 提供了输出调试器诊断信息相关的静态 <see langword="static" /> 方法。 </summary>
  public static partial class Doctor
  {
    #region Methods

    /// <summary> 获取诊断级别 <paramref name="value" /> 等效的显示名称。 </summary>
    /// <param name="value">
    ///   诊断级别。
    ///   <para> <see cref="DiagnosticsLevel" /> 枚举类型中的一个值。 </para>
    /// </param>
    /// <returns> 诊断级别显示名称。 </returns>
    [SuppressMessage("Design", "Ex0100:Member may throw undocumented exception", Justification = "<挂起>")]
    private static string GetDiagnosticsLevelDisplayName(DiagnosticsLevel value)
    {
      var valueKey = Enum.GetName(typeof(DiagnosticsLevel), value);
      return $"[{SR.GetString(valueKey).ToUpper()}]";
    }

    /// <summary> 输出一行诊断信息。 </summary>
    /// <param name="message"> 需要输出的诊断信息。 </param>
    /// <param name="sourceCategory">
    ///   诊断源头类别。
    ///   <para> 可能为空的 <see cref="DiagnosticsSourceCategory" /> 类型值。 </para>
    /// </param>
    /// <param name="level">
    ///   诊断级别。
    ///   <para> <see cref="DiagnosticsLevel" /> 枚举类型中的一个值。 </para>
    /// </param>
    /// <seealso cref="DiagnosticsLevel" />
    /// <seealso cref="DiagnosticsSourceCategory" />
    /// <seealso cref="_Trace.WriteLine(string, string)" />
    public static void WriteLine(string message, DiagnosticsSourceCategory? sourceCategory = null, DiagnosticsLevel level = DiagnosticsLevel.Information) => _Trace.WriteLine($"{GetDiagnosticsLevelDisplayName(level)} - {message}", sourceCategory?.ToString());

    /// <summary>
    ///   当条件表达式 <paramref name="where" /> 等于 <see langword="false" /> 时，输出一行诊断信息。并最终返回 <paramref name="where" />。
    /// </summary>
    /// <param name="where"> 条件表达式。 </param>
    /// <param name="message"> 需要输出的诊断信息。 </param>
    /// <param name="sourceCategory">
    ///   诊断源头类别。
    ///   <para> 可能为空的 <see cref="DiagnosticsSourceCategory" /> 类型值。 </para>
    /// </param>
    /// <param name="level">
    ///   诊断级别。
    ///   <para> <see cref="DiagnosticsLevel" /> 枚举类型中的一个值。 </para>
    /// </param>
    /// <returns> <paramref name="where" />。 </returns>
    /// <seealso cref="DiagnosticsLevel" />
    /// <seealso cref="DiagnosticsSourceCategory" />
    /// <seealso cref="WriteLineIf(bool, string, DiagnosticsSourceCategory?, DiagnosticsLevel)" />
    public static bool WriteLineElse(bool where, string message, DiagnosticsSourceCategory? sourceCategory = null, DiagnosticsLevel level = DiagnosticsLevel.Information) => !WriteLineIf(!where, message, sourceCategory, level);

    /// <summary>
    ///   当条件表达式 <paramref name="where" /> 等于 <see langword="true" /> 时，输出一行诊断信息。并最终返回 <paramref name="where" />。
    /// </summary>
    /// <param name="where"> 条件表达式。 </param>
    /// <param name="message"> 需要输出的诊断信息。 </param>
    /// <param name="sourceCategory">
    ///   诊断源头类别。
    ///   <para> 可能为空的 <see cref="DiagnosticsSourceCategory" /> 类型值。 </para>
    /// </param>
    /// <param name="level">
    ///   诊断级别。
    ///   <para> <see cref="DiagnosticsLevel" /> 枚举类型中的一个值。 </para>
    /// </param>
    /// <returns> <paramref name="where" />。 </returns>
    /// <seealso cref="DiagnosticsLevel" />
    /// <seealso cref="DiagnosticsSourceCategory" />
    public static bool WriteLineIf(bool where, string message, DiagnosticsSourceCategory? sourceCategory = null, DiagnosticsLevel level = DiagnosticsLevel.Information)
    {
      if (where)
      {
        WriteLine(message, sourceCategory, level);
      }
      return where;
    }

    #endregion Methods
  }
}