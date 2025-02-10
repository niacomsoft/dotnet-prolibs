/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

namespace Niacomsoft.ProductiveLibrary.Patterns
{
  /// <summary> 提供了链式构建 T 类型对象实例相关的抽象 <see langword="abstract" /> 方法。 </summary>
  /// <typeparam name="T"> 引用类型。 </typeparam>
  /// <typeparam name="TBuilder"> 实现了 <see cref="IBuilder{T}" /> 类型接口的类型。 </typeparam>
  /// <seealso cref="Builder{T}" />
  /// <seealso cref="IBuilder{T}" />
  /// <seealso cref="IFluentBuilder{T, TBuilder}" />
  public abstract class FluentBuilder<T, TBuilder> : Builder<T>, IFluentBuilder<T, TBuilder> where T : class where TBuilder : IBuilder<T>
  {
    #region Constructors

    /// <summary> 初始化 <see cref="FluentBuilder{T, TBuilder}" /> 类的新实例。 </summary>
    protected FluentBuilder()
    {
    }

    #endregion Constructors

    #region Methods

    /// <inheritdoc />
    public virtual TBuilder WithProperty(string propertyName, object propertyValue)
    {
      return (TBuilder)SetPropertyValue(propertyName, propertyValue);
    }

    #endregion Methods
  }
}