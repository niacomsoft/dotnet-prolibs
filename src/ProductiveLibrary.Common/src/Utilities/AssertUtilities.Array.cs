/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using System;

namespace Niacomsoft.ProductiveLibrary.Utilities
{
  public static partial class AssertUtilities
  {
    #region Methods

    /// <summary>
    ///   当数组 <paramref name="array" /> 等于 <see langword="null" /> 或长度 <c>
    ///   <paramref name="array" />.LongLength = 0 </c> 时，返回 <see langword="true" />；否则返回
    ///   <see langword="false" /> 。
    /// </summary>
    /// <param name="array"> 指定数组。 </param>
    /// <returns> <see cref="bool" /> 类型的值。 </returns>
    /// <seealso cref="Array" />
    public static bool IsEmptyArray(Array array)
    {
      return IsNull(array) || IsZero(array.LongLength);
    }

    /// <summary>
    ///   当数组 <paramref name="array" /> 不等于 <see langword="null" /> 且长度 <c>
    ///   <paramref name="array" />.LongLength &gt; 0 </c> 时，返回 <see langword="true" />；否则返回
    ///   <see langword="false" /> 。
    /// </summary>
    /// <param name="array"> 指定数组。 </param>
    /// <returns> <see cref="bool" /> 类型的值。 </returns>
    /// <seealso cref="Array" />
    /// <seealso cref="IsEmptyArray(Array)" />
    public static bool NotEmptyArray(Array array)
    {
      return !IsEmptyArray(array);
    }

    #endregion Methods
  }
}