/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using Niacomsoft.ProductiveLibrary.Resources;
using Niacomsoft.ProductiveLibrary.Resources.Internal;
using Niacomsoft.ProductiveLibrary.Utilities;

using System;
using System.Collections.Generic;

namespace Niacomsoft.ProductiveLibrary.Patterns
{
  /// <summary>
  ///   提供了构建 <typeparamref name="T" /> 类型的对象实例相关的抽象 <see langword="abstract" /> 方法。
  /// </summary>
  /// <typeparam name="T"> 引用类型。 </typeparam>
  /// <seealso cref="IBuilder{T}" />
  public abstract class Builder<T> : IBuilder<T> where T : class
  {
    #region Constructors

    /// <summary> 初始化 <see cref="Builder{T}" /> 类的新实例。 </summary>
    protected Builder()
    {
      PropertyHolder = new Dictionary<string, object>();
    }

    #endregion Constructors

    #region Properties

    /// <summary> 用于 <typeparamref name="T" /> 属性值的字典集合。 </summary>
    /// <value>
    ///   获取 <see cref="IDictionary{TKey, TValue}" /> 类型的集合，用于存储 <typeparamref name="T" /> 属性值。
    /// </value>
    /// <seealso cref="IDictionary{TKey, TValue}" />
    protected virtual IDictionary<string, object> PropertyHolder { get; }

    #endregion Properties

    #region Methods

    /// <summary> 设置属性 <paramref name="propertyName" /> 的值。 </summary>
    /// <param name="propertyName"> 属性名称。 </param>
    /// <param name="propertyValue"> 属性值。 </param>
    /// <returns> 实现了 <see cref="IBuilder{T}" /> 类型接口的对象实例 <see langword="this" />。 </returns>
    /// <exception cref="ArgumentException">
    ///   当字符串 <paramref name="propertyName" /> 等于 <see langword="null" />、
    ///   <see cref="string.Empty" /> 或空格符时，将引发此类型的异常。
    /// </exception>
    protected virtual IBuilder<T> SetPropertyValue(string propertyName, object propertyValue)
    {
      if (AssertUtilities.IsWhiteSpace(propertyName))
      {
        throw new ArgumentException(SR.Format(nameof(Strings.ArgumentException_string_null_or_whitespace_with_argument_name), nameof(propertyName)), nameof(propertyName));
      }

      PropertyHolder[propertyName] = propertyValue;
      return this;
    }

    /// <summary> 尝试获取属性 <paramref name="propertyName" /> 的值。 </summary>
    /// <param name="propertyName"> 属性名称。 </param>
    /// <param name="propertyValue"> 属性值。 </param>
    /// <returns>
    ///   当 <see cref="PropertyHolder" /> 中存在名称为 <paramref name="propertyName" /> 的属性值时，返回
    ///   <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </returns>
    /// <exception cref="ArgumentException">
    ///   当字符串 <paramref name="propertyName" /> 等于 <see langword="null" />、
    ///   <see cref="string.Empty" /> 或空格符时，将引发此类型的异常。
    /// </exception>
    protected virtual bool TryGetPropertyValue(string propertyName, out object propertyValue)
    {
      if (AssertUtilities.IsWhiteSpace(propertyName))
      {
        throw new ArgumentException(SR.Format(nameof(Strings.ArgumentException_string_null_or_whitespace_with_argument_name), nameof(propertyName)), nameof(propertyName));
      }

      propertyValue = PropertyHolder[propertyName];
      return AssertUtilities.NotNull(propertyValue);
    }

    /// <inheritdoc />
    public abstract T Build();

    #endregion Methods
  }
}