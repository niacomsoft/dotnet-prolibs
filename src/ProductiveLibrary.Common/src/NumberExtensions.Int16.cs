/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using System;
using System.Collections.Generic;

namespace Niacomsoft.ProductiveLibrary
{
  public static partial class NumberExtensions
  {
    #region Methods

    /// <summary>
    ///   当 <paramref name="me" /><c> = </c><paramref name="value" /> 时，返回
    ///   <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </summary>
    /// <param name="me"> 数值。 </param>
    /// <param name="value"> 数值。 </param>
    /// <returns>
    ///   当 <paramref name="me" /><c> = </c><paramref name="value" /> 时，返回
    ///   <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </returns>
    public static bool Equal(this short me, short value) => me == value;

    /// <summary> 获取 <paramref name="me" /> 等效的字节数组。 </summary>
    /// <param name="me"> 数值。 </param>
    /// <returns> 获取 <paramref name="me" /> 等效的字节数组。 </returns>
    /// <seealso cref="BitConverter.GetBytes(short)" />
    public static IEnumerable<byte> GetBytes(this short me) => BitConverter.GetBytes(me);

    /// <summary>
    ///   当 <paramref name="me" /><c> &gt; </c><paramref name="value" /> 时，返回
    ///   <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </summary>
    /// <param name="me"> 数值。 </param>
    /// <param name="value"> 数值。 </param>
    /// <returns>
    ///   当 <paramref name="me" /><c> &gt; </c><paramref name="value" /> 时，返回
    ///   <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </returns>
    public static bool GreaterThan(this short me, short value) => me > value;

    /// <summary>
    ///   当 <paramref name="me" /><c> &gt;= </c><paramref name="value" /> 时，返回
    ///   <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </summary>
    /// <param name="me"> 数值。 </param>
    /// <param name="value"> 数值。 </param>
    /// <returns>
    ///   当 <paramref name="me" /><c> &gt;= </c><paramref name="value" /> 时，返回
    ///   <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </returns>
    public static bool GreaterThanOrEqual(this short me, short value) => me >= value;

    /// <summary>
    ///   当 <paramref name="me" /><c> &gt;= 0 </c> 时，返回 <see langword="true" />；否则返回
    ///   <see langword="false" /> 。
    /// </summary>
    /// <param name="me"> 数值。 </param>
    /// <returns>
    ///   当 <paramref name="me" /><c> &gt;= 0 </c> 时，返回 <see langword="true" />；否则返回
    ///   <see langword="false" /> 。
    /// </returns>
    public static bool IsNatural(this short me) => me.GreaterThanOrEqual(0);

    /// <summary>
    ///   当 <paramref name="me" /><c> &lt; 0 </c> 时，返回 <see langword="true" />；否则返回
    ///   <see langword="false" /> 。
    /// </summary>
    /// <param name="me"> 数值。 </param>
    /// <returns>
    ///   当 <paramref name="me" /><c> &lt; 0 </c> 时，返回 <see langword="true" />；否则返回
    ///   <see langword="false" /> 。
    /// </returns>
    public static bool IsNegative(this short me) => me.LessThan(0);

    /// <summary>
    ///   当 <paramref name="me" /><c> &gt; 0 </c> 时，返回 <see langword="true" />；否则返回
    ///   <see langword="false" /> 。
    /// </summary>
    /// <param name="me"> 数值。 </param>
    /// <returns>
    ///   当 <paramref name="me" /><c> &gt; 0 </c> 时，返回 <see langword="true" />；否则返回
    ///   <see langword="false" /> 。
    /// </returns>
    public static bool IsPositive(this short me) => me.GreaterThan(0);

    /// <summary>
    ///   当 <paramref name="me" /><c> = 0 </c> 时，返回 <see langword="true" />；否则返回
    ///   <see langword="false" /> 。
    /// </summary>
    /// <param name="me"> 数值。 </param>
    /// <returns>
    ///   当 <paramref name="me" /><c> = 0 </c> 时，返回 <see langword="true" />；否则返回
    ///   <see langword="false" /> 。
    /// </returns>
    public static bool IsZero(this short me) => me.Equal(0);

    /// <summary>
    ///   当 <paramref name="me" /><c> &lt; </c><paramref name="value" /> 时，返回
    ///   <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </summary>
    /// <param name="me"> 数值。 </param>
    /// <param name="value"> 数值。 </param>
    /// <returns>
    ///   当 <paramref name="me" /><c> &lt; </c><paramref name="value" /> 时，返回
    ///   <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </returns>
    public static bool LessThan(this short me, short value) => me < value;

    /// <summary>
    ///   当 <paramref name="me" /><c> &lt;= </c><paramref name="value" /> 时，返回
    ///   <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </summary>
    /// <param name="me"> 数值。 </param>
    /// <param name="value"> 数值。 </param>
    /// <returns>
    ///   当 <paramref name="me" /><c> &lt;= </c><paramref name="value" /> 时，返回
    ///   <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </returns>
    public static bool LessThanOrEqual(this short me, short value) => me <= value;

    #endregion Methods
  }
}