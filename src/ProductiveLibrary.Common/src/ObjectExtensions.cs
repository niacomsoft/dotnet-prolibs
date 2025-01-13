/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using Niacomsoft.ProductiveLibrary.Diagnostics;
using Niacomsoft.ProductiveLibrary.Resources;
using Niacomsoft.ProductiveLibrary.Resources.Internal;

namespace Niacomsoft.ProductiveLibrary
{
  /// <summary> 为 <see cref="object" /> 类型提供了扩展方法。 </summary>
  public static class ObjectExtensions
  {
    /// <summary>
    ///   当 <paramref name="me" /> 等于 <see langword="null" /> 时，返回 <see langword="true" />；否则返回
    ///   <see langword="false" /> 。
    /// </summary>
    /// <param name="me"> <see cref="object" /> </param>
    /// <returns>
    ///   当 <paramref name="me" /> 等于 <see langword="null" /> 时，返回 <see langword="true" />；否则返回
    ///   <see langword="false" /> 。
    /// </returns>
    public static bool IsNull(this object me) => Doctor.DebugIf(me is null, SR.GetString(Strings.Diagnostics_message_isnull), DiagnosticsSourceCategory.Common);
  }
}