/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using System;

namespace Niacomsoft.ProductiveLibrary
{
  /// <summary> 为数组类型提供了扩展方法。 </summary>
  public static class ArrayExtensions
  {
    #region Methods

    /// <summary>
    ///   当数组等于 <see langword="null" /> 或者 <see cref="Array.LongLength" /> 等于 <c> 0 </c> 时，返回
    ///   <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </summary>
    /// <param name="me"> 需要校验的数组。 </param>
    /// <returns>
    ///   当数组等于 <see langword="null" /> 或者 <see cref="Array.LongLength" /> 等于 <c> 0 </c> 时，返回
    ///   <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </returns>
    /// <seealso cref="Array" />
    public static bool Empty(this Array me) => me.IsNull() || me.LongLength.IsZero();

    /// <summary>
    ///   当数组等于 <see langword="null" /> 或者 <see cref="Array.LongLength" /> 等于 <c> 0 </c> 时，返回
    ///   <see langword="false" />；否则返回 <see langword="true" /> 。
    /// </summary>
    /// <param name="me"> 需要校验的数组。 </param>
    /// <returns>
    ///   当数组等于 <see langword="null" /> 或者 <see cref="Array.LongLength" /> 等于 <c> 0 </c> 时，返回
    ///   <see langword="false" />；否则返回 <see langword="true" /> 。
    /// </returns>
    /// <seealso cref="Array" />
    public static bool HasItems(this Array me) => !me.Empty();

    /// <summary> 创建一个长度为 <paramref name="me" /> 的 <typeparamref name="T" /> 类型数组。 </summary>
    /// <typeparam name="T"> 数据元素类型。 </typeparam>
    /// <param name="me"> 数组初始化长度。 </param>
    /// <returns> <typeparamref name="T" /> 类型的数组。 </returns>
    public static T[] InitializeArray<T>(this int me) => new T[me];

    #endregion Methods
  }
}