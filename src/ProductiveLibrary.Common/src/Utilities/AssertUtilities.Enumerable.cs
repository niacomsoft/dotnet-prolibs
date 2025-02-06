/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using System.Collections.Generic;
using System.Linq;

namespace Niacomsoft.ProductiveLibrary.Utilities
{
  public static partial class AssertUtilities
  {
    #region Methods

    /// <summary>
    ///   当 <see cref="IEnumerable{T}" /> 类型的集合等于 <see langword="null" /> 或元素个数等于 <c> 0 </c> 时，返回
    ///   <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </summary>
    /// <typeparam name="T"> 集合中元素的类型。 </typeparam>
    /// <param name="collection"> 实现了 <see cref="IEnumerable{T}" /> 类型接口的对象实例。 </param>
    /// <returns> <see cref="bool" /> 类型的值。 </returns>
    /// <seealso cref="IEnumerable{T}" />
    public static bool IsEmptyCollection<T>(IEnumerable<T> collection)
    {
      return IsNull(collection) || !collection.Any();
    }

    /// <summary>
    ///   当 <see cref="IEnumerable{T}" /> 类型的集合不等于 <see langword="null" /> 且元素个数 <c> &gt; 0 </c>
    ///   时，返回 <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </summary>
    /// <typeparam name="T"> 集合中元素的类型。 </typeparam>
    /// <param name="collection"> 实现了 <see cref="IEnumerable{T}" /> 类型接口的对象实例。 </param>
    /// <returns> <see cref="bool" /> 类型的值。 </returns>
    /// <seealso cref="IEnumerable{T}" />
    /// <seealso cref="IsEmptyCollection{T}(IEnumerable{T})" />
    public static bool NotEmptyCollection<T>(IEnumerable<T> collection)
    {
      return !IsEmptyCollection(collection);
    }

    #endregion Methods
  }
}