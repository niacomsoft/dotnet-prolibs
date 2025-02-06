/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

namespace Niacomsoft.ProductiveLibrary.Utilities
{
  public static partial class AssertUtilities
  {
    #region Methods

    /// <summary>
    ///   当 <paramref name="a" /><c> = </c><paramref name="b" /> 时，返回 <see langword="true" />；否则返回
    ///   <see langword="false" /> 。
    /// </summary>
    /// <param name="a"> <see cref="short" /> 类型的值。 </param>
    /// <param name="b"> <see cref="short" /> 类型的值。 </param>
    /// <returns> <see cref="bool" /> 类型的值。 </returns>
    public static bool Equal(short a, short b)
    {
      return a == b;
    }

    /// <summary>
    ///   当 <paramref name="a" /><c> &gt; </c><paramref name="b" /> 时，返回
    ///   <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </summary>
    /// <param name="a"> <see cref="short" /> 类型的值。 </param>
    /// <param name="b"> <see cref="short" /> 类型的值。 </param>
    /// <returns> <see cref="bool" /> 类型的值。 </returns>
    public static bool GreaterThan(short a, short b)
    {
      return a > b;
    }

    /// <summary>
    ///   当 <paramref name="a" /><c> &gt;= </c><paramref name="b" /> 时，返回
    ///   <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </summary>
    /// <param name="a"> <see cref="short" /> 类型的值。 </param>
    /// <param name="b"> <see cref="short" /> 类型的值。 </param>
    /// <returns> <see cref="bool" /> 类型的值。 </returns>
    public static bool GreaterThanOrEqual(short a, short b)
    {
      return a >= b;
    }

    /// <summary>
    ///   当 <paramref name="a" /><c> &gt;= 0 </c> 时，返回 <see langword="true" />；否则返回
    ///   <see langword="false" /> 。
    /// </summary>
    /// <param name="a"> <see cref="short" /> 类型的值。 </param>
    /// <returns> <see cref="bool" /> 类型的值。 </returns>
    /// <seealso cref="GreaterThanOrEqual(short, short)" />
    public static bool IsNatural(short a)
    {
      return GreaterThanOrEqual(a, (short)0);
    }

    /// <summary>
    ///   当 <paramref name="a" /><c> &lt; 0 </c> 时，返回 <see langword="true" />；否则返回
    ///   <see langword="false" /> 。
    /// </summary>
    /// <param name="a"> <see cref="short" /> 类型的值。 </param>
    /// <returns> <see cref="bool" /> 类型的值。 </returns>
    /// <seealso cref="LessThan(short, short)" />
    public static bool IsNegative(short a)
    {
      return LessThan(a, (short)0);
    }

    /// <summary>
    ///   当 <paramref name="a" /><c> &gt; 0 </c> 时，返回 <see langword="true" />；否则返回
    ///   <see langword="false" /> 。
    /// </summary>
    /// <param name="a"> <see cref="short" /> 类型的值。 </param>
    /// <returns> <see cref="bool" /> 类型的值。 </returns>
    /// <seealso cref="GreaterThan(short, short)" />
    public static bool IsPositive(short a)
    {
      return GreaterThan(a, (short)0);
    }

    /// <summary>
    ///   当 <paramref name="a" /><c> = 0 </c> 时，返回 <see langword="true" />；否则返回
    ///   <see langword="false" /> 。
    /// </summary>
    /// <param name="a"> <see cref="short" /> 类型的值。 </param>
    /// <returns> <see cref="bool" /> 类型的值。 </returns>
    /// <seealso cref="Equal(short, short)" />
    public static bool IsZero(short a)
    {
      return Equal(a, (short)0);
    }

    /// <summary>
    ///   当 <paramref name="a" /><c> &lt; </c><paramref name="b" /> 时，返回
    ///   <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </summary>
    /// <param name="a"> <see cref="short" /> 类型的值。 </param>
    /// <param name="b"> <see cref="short" /> 类型的值。 </param>
    /// <returns> <see cref="bool" /> 类型的值。 </returns>
    public static bool LessThan(short a, short b)
    {
      return a < b;
    }

    /// <summary>
    ///   当 <paramref name="a" /><c> &lt;= </c><paramref name="b" /> 时，返回
    ///   <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </summary>
    /// <param name="a"> <see cref="short" /> 类型的值。 </param>
    /// <param name="b"> <see cref="short" /> 类型的值。 </param>
    /// <returns> <see cref="bool" /> 类型的值。 </returns>
    public static bool LessThanOrEqual(short a, short b)
    {
      return a <= b;
    }

    #endregion Methods
  }
}