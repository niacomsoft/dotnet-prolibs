/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

namespace Niacomsoft.ProductiveLibrary.Patterns
{
  #region Interfaces

  /// <summary> 提供了链式构建 <typeparamref name="T" /> 类型对象实例的接口。 </summary>
  /// <typeparam name="T"> 引用类型。 </typeparam>
  /// <typeparam name="TBuilder"> 实现了 <see cref="IBuilder{T}" /> 类型接口的类型。 </typeparam>
  /// <seealso cref="IBuilder{T}" />
  public interface IFluentBuilder<T, TBuilder> : IBuilder<T> where T : class where TBuilder : IBuilder<T>
  {
    #region Methods

    /// <summary> 设置名称为 <paramref name="propertyName" /> 的属性值。 </summary>
    /// <param name="propertyName"> 属性名称。 </param>
    /// <param name="propertyValue"> 属性值。 </param>
    /// <returns> <typeparamref name="TBuilder" /> 类型的对象实例。 </returns>
    TBuilder WithProperty(string propertyName, object propertyValue);

    #endregion Methods
  }

  #endregion Interfaces
}