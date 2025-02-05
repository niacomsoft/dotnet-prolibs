/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using System;
using System.Collections.Generic;
using System.Linq;

namespace Niacomsoft.ProductiveLibrary.Collections.Generic
{
  /// <summary> 为实现了 <see cref="IEnumerable{T}" /> 类型接口的类型提供了扩展方法。 </summary>
  public static class EnumerableExtensions
  {
    #region Methods

    /// <summary>
    ///   当 <paramref name="me" /> 等于 <see langword="null" /> 或者元素个数等于 <c> 0 </c> 时，返回
    ///   <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </summary>
    /// <typeparam name="T"> 元素类型。 </typeparam>
    /// <param name="me"> <typeparamref name="T" /> 类型的数组或集合。 </param>
    /// <returns>
    ///   当 <paramref name="me" /> 等于 <see langword="null" /> 或者元素个数等于 <c> 0 </c> 时，返回
    ///   <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </returns>
    /// <seealso cref="IEnumerable{T}" />
    /// <exception cref="OverflowException">
    ///   当调用 <c> <see cref="IEnumerable{T}" />.LongCount() </c> 方法时，可能引发此类型的异常。
    /// </exception>
    public static bool Empty<T>(this IEnumerable<T> me) => me.IsNull() || me.LongCount().IsZero();

    /// <summary>
    ///   当 <paramref name="me" /> 等于 <see langword="null" /> 或者元素个数等于 <c> 0 </c> 时，返回
    ///   <see langword="false" />；否则返回 <see langword="true" /> 。
    /// </summary>
    /// <typeparam name="T"> 元素类型。 </typeparam>
    /// <param name="me"> <typeparamref name="T" /> 类型的数组或集合。 </param>
    /// <returns>
    ///   当 <paramref name="me" /> 等于 <see langword="null" /> 或者元素个数等于 <c> 0 </c> 时，返回
    ///   <see langword="false" />；否则返回 <see langword="true" /> 。
    /// </returns>
    /// <seealso cref="IEnumerable{T}" />
    /// <exception cref="OverflowException">
    ///   当调用 <c> <see cref="IEnumerable{T}" />.LongCount() </c> 方法时，可能引发此类型的异常。
    /// </exception>
    public static bool HasItems<T>(this IEnumerable<T> me) => !me.Empty<T>();

    #endregion Methods
  }
}