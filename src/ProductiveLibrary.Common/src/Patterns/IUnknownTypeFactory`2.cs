/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

namespace Niacomsoft.ProductiveLibrary.Patterns
{
  #region Interfaces

  /// <summary> 提供了创建 <typeparamref name="TResult" /> 类型对象实例的工厂方法的接口。 </summary>
  /// <typeparam name="T1"> 参数类型。 </typeparam>
  /// <typeparam name="TResult">
  ///   返回值类型。
  ///   <para> 引用类型。 </para>
  /// </typeparam>
  /// <seealso cref="IKnownTypeFactory{T1, TResult}" />
  public interface IUnknownTypeFactory<in T1, out TResult> : IKnownTypeFactory<T1, TResult> where TResult : class
  {
    #region Methods

    /// <summary> 创建 <typeparamref name="TResult" /> 类型的对象实例。 </summary>
    /// <param name="arg1"> <typeparamref name="T1" /> 类型的参数值。 </param>
    /// <param name="args"> 未知类型的参数数组。 </param>
    /// <returns> <typeparamref name="TResult" /> 类型的对象实例。 </returns>
    TResult CreateInstance(T1 arg1, params object[] args);

    #endregion Methods
  }

  #endregion Interfaces
}