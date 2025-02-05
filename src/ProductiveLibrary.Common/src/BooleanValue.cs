/* ********************************************************************************************************************** *\
* LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
* © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

namespace Niacomsoft.ProductiveLibrary
{
  /// <summary> 提供了描述布尔类型值相关的方法。 </summary>
  /// <typeparam name="T"> 描述布尔类型值的类型。 </typeparam>
  public readonly struct BooleanValue<T>
  {
    #region Constructors

    /// <summary> 初始化 <see cref="BooleanValue{T}" /> 类型值的新实例。 </summary>
    /// <param name="trueValue">
    ///   描述 <see langword="true" /> 的 <typeparamref name="T" /> 类型的值或对象实例。
    /// </param>
    public BooleanValue(T trueValue) : this(trueValue, default)
    {
      TrueValue = trueValue;
    }

    /// <summary> 初始化 <see cref="BooleanValue{T}" /> 类型值的新实例。 </summary>
    /// <param name="trueValue">
    ///   描述 <see langword="true" /> 的 <typeparamref name="T" /> 类型的值或对象实例。
    /// </param>
    /// <param name="falseValue">
    ///   描述 <see langword="false" /> 的 <typeparamref name="T" /> 类型的值或对象实例。
    /// </param>
    public BooleanValue(T trueValue, T falseValue)
    {
      TrueValue = trueValue;
      FalseValue = new SafeValue<T>(falseValue);
    }

    #endregion Constructors

    #region Properties

    /// <summary> 描述 <see langword="false" /> 的 <typeparamref name="T" /> 类型的值或对象实例。 </summary>
    /// <value>
    ///   获取 <typeparamref name="T" /> 类型的值或对象实例，用于表示描述 <see langword="false" /> 的值。
    /// </value>
    public SafeValue<T> FalseValue { get; }

    /// <summary> 描述 <see langword="true" /> 的 <typeparamref name="T" /> 类型的值或对象实例。 </summary>
    /// <value> 获取 <typeparamref name="T" /> 类型的值或对象实例，用于表示描述 <see langword="true" /> 的值。 </value>
    public T TrueValue { get; }

    #endregion Properties
  }
}