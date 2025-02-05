/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using Niacomsoft.ProductiveLibrary.Collections.Generic;
using Niacomsoft.ProductiveLibrary.Diagnostics;
using Niacomsoft.ProductiveLibrary.Resources;
using Niacomsoft.ProductiveLibrary.Resources.Internal;

using System;
using System.Text.RegularExpressions;

namespace Niacomsoft.ProductiveLibrary
{
  /// <summary> 为 <see cref="Type" /> 类型提供了扩展方法。 </summary>
  public static class TypeExtensions
  {
    #region Methods

    /// <summary> 将类型 <paramref name="me" /> 转换为标识。 </summary>
    /// <param name="me"> <see cref="Type" /> 类型的对象实例。 </param>
    /// <returns> 实现了 <see cref="IKey{T}" /> 类型接口的对象实例。 </returns>
    /// <seealso cref="IKey{T}" />
    /// <seealso cref="StringKey" />
    /// <seealso cref="StringKey.FromType(Type)" />
    /// <exception cref="RegexMatchTimeoutException">
    ///   当调用 <see cref="StringKey.FromType(Type)" /> 方法时，可能引发此类型的异常。
    /// </exception>
    public static IKey<string> AsKey(this Type me) => StringKey.FromType(me);

    /// <summary>
    ///   当 <paramref name="me" /> 继承自 <paramref name="baseType" /> 类型时，返回
    ///   <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </summary>
    /// <param name="me"> 需要校验的类型。 </param>
    /// <param name="baseType"> 目标类型。 </param>
    /// <param name="ifNull">
    ///   当 <paramref name="me" /> 或 <paramref name="baseType" /> 等于 <see langword="null" />
    ///   时需要返回的值。
    /// </param>
    /// <returns>
    ///   当 <paramref name="me" /> 继承自 <paramref name="baseType" /> 类型时，返回
    ///   <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </returns>
    public static bool InheritFrom(this Type me, Type baseType, bool ifNull = false)
    {
      return Doctor.DebugIf(me.IsNull() || baseType.IsNull(), SR.GetString(nameof(Strings.Diagnostics_inherit_from))) ? ifNull : me.IsAssignableFrom(baseType);
    }

    #endregion Methods
  }
}