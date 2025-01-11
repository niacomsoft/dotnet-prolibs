/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using Niacomsoft.ProductiveLibrary.Diagnostics;
using Niacomsoft.ProductiveLibrary.Resources;
using Niacomsoft.ProductiveLibrary.Resources.Internal;

using System;
using System.Diagnostics.CodeAnalysis;

namespace Niacomsoft.ProductiveLibrary.Utilities
{
  /// <summary> 提供了 <see cref="object" /> 相关的静态 <see langword="static" /> 方法。 </summary>
  public static class ObjectUtilities
  {
    #region Methods

    /// <summary> 当 <paramref name="source" /> 为 <see langword="null" /> 时，返回 <paramref name="default" /> 方法返回值。 </summary>
    /// <param name="source"> 需要校验的 <see cref="object" /> 类型的对象实例或值。 </param>
    /// <param name="default"> <see cref="Func{TResult}" /> 类型的方法委托。 </param>
    /// <returns> 当 <paramref name="source" /> 为 <see langword="null" /> 时，返回 <paramref name="default" /> 方法返回值。 </returns>
    /// <seealso cref="Func{TResult}" />
    /// <exception cref="ArgumentNullException">
    ///   当 <paramref name="source" /> 和 <paramref name="default" /> 都等于 <see langword="null" /> 时，将引发此类型的异常。
    /// </exception>
    [SuppressMessage("Design", "Ex0100:Member may throw undocumented exception", Justification = "<挂起>")]
    [SuppressMessage("Style", "IDE0046:转换为条件表达式", Justification = "<挂起>")]
    public static object DefaultIfNull(object source, Func<object> @default)
    {
      if (NotNull(source))
      {
        return source;
      }
      return IsNull(@default)
        ? throw new ArgumentNullException(nameof(@default), SR.Format(nameof(Strings.ArgumentNullException_with_argument_name), nameof(@default)))
        : @default();
    }

    /// <summary> 将 <paramref name="source" /> 强制转换为 <typeparamref name="T" /> 类型的值或对象实例。 </summary>
    /// <typeparam name="T"> 目标类型。 </typeparam>
    /// <param name="source"> 需要转换的 <see cref="object" /> 类型的对象实例或值。 </param>
    /// <returns> <typeparamref name="T" /> 类型的值或对象实例。 </returns>
    public static T ExplicitConvertTo<T>(object source) => (T)source;

    /// <summary>
    ///   将 <paramref name="source" /> 转换为 <typeparamref name="T" /> 类型的值或对象实例。
    ///   <para> 等同于 " <c> as </c>" 关键字。 </para>
    /// </summary>
    /// <typeparam name="T"> 目标引用类型。 </typeparam>
    /// <param name="source"> 需要转换的 <see cref="object" /> 类型的对象实例或值。 </param>
    /// <returns> <typeparamref name="T" /> 类型的对象实例。 </returns>
    public static T ImplicitConvertTo<T>(object source) where T : class => source as T;

    /// <summary>
    ///   当 <paramref name="source" /> 为 <typeparamref name="T" /> 类型的值或对象实例时，返回 <see langword="true" />；否则返回
    ///   <see langword="false" /> 。
    ///   <para> 等同于 <c> <paramref name="source" /> is <typeparamref name="T" /></c> </para>
    /// </summary>
    /// <typeparam name="T"> 目标类型。 </typeparam>
    /// <param name="source"> 需要校验的 <see cref="object" /> 类型的对象实例或值。 </param>
    /// <param name="defaultIfNull"> 当 <paramref name="source" /> 等于 <see langword="null" /> 时需要返回的值。 </param>
    /// <returns>
    ///   当 <paramref name="source" /> 为 <typeparamref name="T" /> 类型的值或对象实例时，返回 <see langword="true" />；否则返回
    ///   <see langword="false" /> 。
    /// </returns>
    public static bool Is<T>(object source, bool defaultIfNull = true) => (IsNull(source)) ? defaultIfNull : source is T;

    /// <summary>
    ///   当 <paramref name="source" /> 等于 <see langword="null" /> 时，返回 <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </summary>
    /// <param name="source"> 需要校验的 <see cref="object" /> 类型的对象实例或值。 </param>
    /// <returns>
    ///   当 <paramref name="source" /> 等于 <see langword="null" /> 时，返回 <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </returns>
    [SuppressMessage("Design", "Ex0100:Member may throw undocumented exception", Justification = "<挂起>")]
    public static bool IsNull(object source) => Doctor.DebugIf(source is null, SR.GetString(nameof(Strings.Diagnostics_message_isnull)), DiagnosticsSourceCategory.Common);

    /// <summary>
    ///   当 <paramref name="source" /> 不等于 <see langword="null" /> 时，返回 <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </summary>
    /// <param name="source"> 需要校验的 <see cref="object" /> 类型的对象实例或值。 </param>
    /// <returns>
    ///   当 <paramref name="source" /> 不等于 <see langword="null" /> 时，返回 <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </returns>
    /// <seealso cref="IsNull(object)" />
    public static bool NotNull(object source) => !IsNull(source);

    #endregion Methods
  }
}