/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using Niacomsoft.ProductiveLibrary.Resources;
using Niacomsoft.ProductiveLibrary.Resources.Internal;

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Niacomsoft.ProductiveLibrary.Patterns
{
  /// <summary> 提供了构建器模式相关的抽象 <see langword="abstract" /> 方法。 </summary>
  /// <typeparam name="T"> 目标类型。 </typeparam>
  /// <seealso cref="IBuilder{T}" />
  public abstract class BuilderBase<T> : IBuilder<T> where T : class
  {
    #region Constructors

    /// <summary> 初始化 <see cref="BuilderBase{T}" /> 类的新实例。 </summary>
    protected BuilderBase() => PropertyBuffer = new Dictionary<string, object>();

    #endregion Constructors

    #region Properties

    /// <summary> 属性缓存。 </summary>
    /// <value> 获取 <see cref="IDictionary{TKey, TValue}" /> 类型的集合，用于表示属性缓存。 </value>
    /// <seealso cref="IDictionary{TKey, TValue}" />
    protected virtual IDictionary<string, object> PropertyBuffer { get; }

    #endregion Properties

    #region Methods

    /// <summary> 获取名称为 <paramref name="name" /> 的属性值。 </summary>
    /// <param name="name"> 属性名称。 </param>
    /// <returns> 属性安全值。 </returns>
    protected virtual SafeValue<object> GetPropertyValue(string name)
    {
      InvalidPropertyName(name);
      return new SafeValue<object>(PropertyBuffer[name]);
    }

    /// <summary>
    ///   当字符串 <paramref name="name" /> 等于 <see langword="null" />、 <see cref="string.Empty" />
    ///   或空格符时，将引发一个 <see cref="ArgumentException" /> 类型的异常。
    /// </summary>
    /// <param name="name"> 属性名称。 </param>
    [SuppressMessage("Design", "Ex0100:Member may throw undocumented exception", Justification = "<挂起>")]
    protected virtual void InvalidPropertyName(string name)
    {
      if (name.IsWhiteSpace())
        throw new ArgumentException(SR.GetString(nameof(Strings.ArgumentException_string_null_or_whitespace_without_argument_name)), nameof(name));
    }

    /// <inheritdoc />
    public abstract T Build();

    /// <inheritdoc />
    public abstract T Build(params object[] args);

    /// <inheritdoc />
    [SuppressMessage("Design", "Ex0100:Member may throw undocumented exception", Justification = "<挂起>")]
    public virtual IBuilder<T> WithProperty(string name, object value)
    {
      InvalidPropertyName(name);
      PropertyBuffer[name] = value;
      return this;
    }

    /// <inheritdoc />
    public virtual IBuilder<T> WithProperty<TValue>(string name, TValue value) => WithProperty(name, value);

    #endregion Methods
  }
}