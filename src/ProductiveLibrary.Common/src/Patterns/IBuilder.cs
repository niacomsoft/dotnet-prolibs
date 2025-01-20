/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

namespace Niacomsoft.ProductiveLibrary.Patterns
{
  #region Interfaces

  /// <summary> 提供了构建器模式的接口。 </summary>
  /// <typeparam name="T"> 目标类型。 </typeparam>
  public interface IBuilder<T> where T : class
  {
    #region Methods

    /// <summary> 构建 <typeparamref name="T" /> 类型的对象实例。 </summary>
    /// <returns> <typeparamref name="T" /> 类型的对象实例。 </returns>
    T Build();

    /// <summary> 构建 <typeparamref name="T" /> 类型的对象实例。 </summary>
    /// <param name="args"> 参数数组。 </param>
    /// <returns> <typeparamref name="T" /> 类型的对象实例。 </returns>
    T Build(params object[] args);

    /// <summary> 设置名称为 <paramref name="name" /> 的属性值。 </summary>
    /// <param name="name">  属性名称。 </param>
    /// <param name="value"> 属性值。 </param>
    /// <returns>
    ///   实现了 <see cref="IBuilder{T}" /> 类型接口的对象实例。
    ///   <para> 通常为 <see langword="this" /> 。 </para>
    /// </returns>
    IBuilder<T> WithProperty(string name, object value);

    /// <summary> 设置名称为 <paramref name="name" /> 的属性值。 </summary>
    /// <typeparam name="TValue"> 属性值类型。 </typeparam>
    /// <param name="name">  属性名称。 </param>
    /// <param name="value"> <typeparamref name="TValue" /> 类型的属性值。 </param>
    /// <returns>
    ///   实现了 <see cref="IBuilder{T}" /> 类型接口的对象实例。
    ///   <para> 通常为 <see langword="this" /> 。 </para>
    /// </returns>
    IBuilder<T> WithProperty<TValue>(string name, TValue value);

    #endregion Methods
  }

  #endregion Interfaces
}