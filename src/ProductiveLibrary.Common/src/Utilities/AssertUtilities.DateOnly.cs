/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using System;

namespace Niacomsoft.ProductiveLibrary.Utilities
{
  public static partial class AssertUtilities
  {
#if NET6_0_OR_GREATER
    /// <summary>
    ///   当 <paramref name="date" /> 为闰年时，返回 <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </summary>
    /// <param name="date"> 年份数值。 </param>
    /// <returns> <see cref="bool" /> 类型的值。 </returns>
    /// <seealso cref="DateTime" />
    /// <seealso cref="IsLeapYear(int)" />
    public static bool IsLeapYear(DateOnly date)
    {
      return IsLeapYear(date.Year);
    }
#endif
  }
}