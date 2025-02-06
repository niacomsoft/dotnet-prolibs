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
    /// <param name="a"> <see cref="decimal" /> 类型的值。 </param>
    /// <param name="b"> <see cref="decimal" /> 类型的值。 </param>
    /// <returns> <see cref="bool" /> 类型的值。 </returns>
    public static bool Equal(decimal a, decimal b)
    {
      return a == b;
    }

    /// <summary>
    ///   当 <paramref name="a" /><c> &gt; </c><paramref name="b" /> 时，返回
    ///   <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </summary>
    /// <param name="a"> <see cref="decimal" /> 类型的值。 </param>
    /// <param name="b"> <see cref="decimal" /> 类型的值。 </param>
    /// <returns> <see cref="bool" /> 类型的值。 </returns>
    public static bool GreaterThan(decimal a, decimal b)
    {
      return a > b;
    }

    /// <summary>
    ///   当 <paramref name="a" /><c> &gt;= </c><paramref name="b" /> 时，返回
    ///   <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </summary>
    /// <param name="a"> <see cref="decimal" /> 类型的值。 </param>
    /// <param name="b"> <see cref="decimal" /> 类型的值。 </param>
    /// <returns> <see cref="bool" /> 类型的值。 </returns>
    public static bool GreaterThanOrEqual(decimal a, decimal b)
    {
      return a >= b;
    }

    /// <summary>
    ///   当 <paramref name="a" /><c> &lt; 0 </c> 时，返回 <see langword="true" />；否则返回
    ///   <see langword="false" /> 。
    /// </summary>
    /// <param name="a"> <see cref="decimal" /> 类型的值。 </param>
    /// <returns> <see cref="bool" /> 类型的值。 </returns>
    /// <seealso cref="LessThan(decimal, decimal)" />
    public static bool IsNegative(decimal a)
    {
      return LessThan(a, 0);
    }

    /// <summary>
    ///   当 <paramref name="a" /><c> &gt; 0 </c> 时，返回 <see langword="true" />；否则返回
    ///   <see langword="false" /> 。
    /// </summary>
    /// <param name="a"> <see cref="decimal" /> 类型的值。 </param>
    /// <returns> <see cref="bool" /> 类型的值。 </returns>
    /// <seealso cref="GreaterThan(decimal, decimal)" />
    public static bool IsPositive(decimal a)
    {
      return GreaterThan(a, 0);
    }

    /// <summary>
    ///   当 <paramref name="a" /><c> = 0 </c> 时，返回 <see langword="true" />；否则返回
    ///   <see langword="false" /> 。
    /// </summary>
    /// <param name="a"> <see cref="decimal" /> 类型的值。 </param>
    /// <returns> <see cref="bool" /> 类型的值。 </returns>
    /// <seealso cref="Equal(decimal, decimal)" />
    public static bool IsZero(decimal a)
    {
      return Equal(a, 0);
    }

    /// <summary>
    ///   当 <paramref name="a" /><c> &lt; </c><paramref name="b" /> 时，返回
    ///   <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </summary>
    /// <param name="a"> <see cref="decimal" /> 类型的值。 </param>
    /// <param name="b"> <see cref="decimal" /> 类型的值。 </param>
    /// <returns> <see cref="bool" /> 类型的值。 </returns>
    public static bool LessThan(decimal a, decimal b)
    {
      return a < b;
    }

    /// <summary>
    ///   当 <paramref name="a" /><c> &lt;= </c><paramref name="b" /> 时，返回
    ///   <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </summary>
    /// <param name="a"> <see cref="decimal" /> 类型的值。 </param>
    /// <param name="b"> <see cref="decimal" /> 类型的值。 </param>
    /// <returns> <see cref="bool" /> 类型的值。 </returns>
    public static bool LessThanOrEqual(decimal a, decimal b)
    {
      return a <= b;
    }

    #endregion Methods
  }
}