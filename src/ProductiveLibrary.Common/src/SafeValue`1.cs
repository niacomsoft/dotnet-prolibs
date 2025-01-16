/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using Niacomsoft.ProductiveLibrary.Resources;
using Niacomsoft.ProductiveLibrary.Resources.Internal;

using System;
using System.Diagnostics.CodeAnalysis;

namespace Niacomsoft.ProductiveLibrary
{
  /// <summary> 提供了安全值相关的方法。 </summary>
  /// <typeparam name="T"> 原始值类型。 </typeparam>
  public readonly struct SafeValue<T> : ISafeValue<T>
  {
    #region Constructors

    /// <summary> 初始化 <see cref="SafeValue{T}" /> 类型值的新实例。 </summary>
    /// <param name="value"> <typeparamref name="T" /> 类型的值或对象实例。 </param>
    public SafeValue(T value) : this() => Value = value;

    #endregion Constructors

    #region Properties

    /// <inheritdoc />
    public bool HasValue => Value.NotNull();

    /// <inheritdoc />
    public T Value { get; }

    #endregion Properties

    #region Methods

    /// <inheritdoc />
    [SuppressMessage("Style", "IDE0046:转换为条件表达式", Justification = "<挂起>")]
    public T GetDefaultValueIfNull(Func<T> defaultBuilder)
    {
      if (HasValue) return Value;
      if (defaultBuilder.IsNull())
      {
        throw new ArgumentNullException(nameof(defaultBuilder), SR.Format(nameof(Strings.ArgumentNullException_with_argument_name), nameof(defaultBuilder)));
      }
      return defaultBuilder();
    }

    /// <inheritdoc />
    public T GetDefaultValueIfNull(T defaultValue) => GetDefaultValueIfNull(() => defaultValue);

    #endregion Methods
  }
}