/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using System;

namespace Niacomsoft.ProductiveLibrary
{
  #region Interfaces

  /// <summary> 提供了安全值的接口。 </summary>
  /// <typeparam name="T"> 安全值类型。 </typeparam>
  public interface ISafeValue<T>
  {
    #region Properties

    /// <summary>
    ///   原始值是否有值。
    ///   <para>
    ///     当 <see cref="Value" /> 不等于 <see langword="null" /> 时，返回 <see langword="true" />；否则返回
    ///     <see langword="false" /> 。
    ///   </para>
    /// </summary>
    /// <value> 获取 <see cref="bool" /> 类型的值，用于表示原始值是否有值。 </value>
    bool HasValue { get; }

    /// <summary> 原始值。 </summary>
    /// <value> 获取 <typeparamref name="T" /> 类型的值或对象实例，用于表示原始值。 </value>
    T Value { get; }

    #endregion Properties

    #region Methods

    /// <summary>
    ///   当 <see cref="HasValue" /> 等于 <see langword="null" /> 时返回 <see cref="Value" />；否则返回
    ///   <paramref name="defaultBuilder" /> 的方法返回值。
    /// </summary>
    /// <param name="defaultBuilder">
    ///   当 <see cref="HasValue" /> 等于 <see langword="false" /> 时，构建默认值返回值的方法。
    /// </param>
    /// <returns>
    ///   当 <see cref="HasValue" /> 等于 <see langword="null" /> 时返回 <see cref="Value" />；否则返回
    ///   <paramref name="defaultBuilder" /> 的方法返回值。
    /// </returns>
    /// <seealso cref="Func{TResult}" />
    /// <exception cref="ArgumentNullException">
    ///   当 <see cref="HasValue" /> 等于 <see langword="false" /> 且 <paramref name="defaultBuilder" />
    ///   等于 <see langword="null" /> 时，将引发此类型的异常。
    /// </exception>
    T GetDefaultValueIfNull(Func<T> defaultBuilder);

    /// <summary>
    ///   当 <see cref="HasValue" /> 等于 <see langword="null" /> 时返回 <see cref="Value" />；否则返回
    ///   <paramref name="defaultValue" />。
    /// </summary>
    /// <param name="defaultValue">
    ///   当 <see cref="HasValue" /> 等于 <see langword="false" /> 时，需要返回的默认值。
    /// </param>
    /// <returns>
    ///   当 <see cref="HasValue" /> 等于 <see langword="null" /> 时返回 <see cref="Value" />；否则返回
    ///   <paramref name="defaultValue" />。
    /// </returns>
    T GetDefaultValueIfNull(T defaultValue);

    #endregion Methods
  }

  #endregion Interfaces
}