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
    #region Methods

    /// <summary> 获取 <paramref name="me" /> 等效的安全值。 </summary>
    /// <param name="me"> <see cref="object" /> </param>
    /// <returns> <see cref="SafeValue{T}" /> 类型的值。 </returns>
    /// <seealso cref="SafeValue{T}" />
    public static SafeValue<object> GetSafeValue(this object me) => new SafeValue<object>(me);

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

    /// <summary>
    ///   当 <paramref name="me" /> 不等于 <see langword="null" /> 时，返回 <see langword="true" />；否则返回
    ///   <see langword="false" /> 。
    /// </summary>
    /// <param name="me"> <see cref="object" /> </param>
    /// <returns>
    ///   当 <paramref name="me" /> 不等于 <see langword="null" /> 时，返回 <see langword="true" />；否则返回
    ///   <see langword="false" /> 。
    /// </returns>
    /// <seealso cref="IsNull(object)" />
    public static bool NotNull(this object me) => !me.IsNull();

    /// <summary> 将 <paramref name="me" /> 强制转换为 <typeparamref name="T" /> 类型的值或对象实例。 </summary>
    /// <typeparam name="T"> 目标类型。 </typeparam>
    /// <param name="me"> <see cref="object" /> </param>
    /// <returns> <typeparamref name="T" /> 类型的值或对象实例。 </returns>
    public static T To<T>(this object me) => (T)me;

    #endregion Methods
  }
}