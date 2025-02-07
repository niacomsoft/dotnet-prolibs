/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

namespace Niacomsoft.ProductiveLibrary.Patterns
{
  #region Interfaces

  /// <summary> 提供了创建 <typeparamref name="TResult" /> 类型对象实例的工厂方法的接口。 </summary>
  /// <typeparam name="T1"> 参数类型。 </typeparam>
  /// <typeparam name="T2"> 参数类型。 </typeparam>
  /// <typeparam name="T3"> 参数类型。 </typeparam>
  /// <typeparam name="T4"> 参数类型。 </typeparam>
  /// <typeparam name="TResult">
  ///   返回值类型。
  ///   <para> 引用类型。 </para>
  /// </typeparam>
  public interface IKnownTypeFactory<in T1, in T2, in T3, in T4, out TResult> where TResult : class
  {
    #region Methods

    /// <summary> 创建 <typeparamref name="TResult" /> 类型的对象实例。 </summary>
    /// <param name="arg1"> <typeparamref name="T1" /> 类型的参数值。 </param>
    /// <param name="arg2"> <typeparamref name="T2" /> 类型的参数值。 </param>
    /// <param name="arg3"> <typeparamref name="T3" /> 类型的参数值。 </param>
    /// <param name="arg4"> <typeparamref name="T4" /> 类型的参数值。 </param>
    /// <returns> <typeparamref name="TResult" /> 类型的对象实例。 </returns>
    TResult CreateInstance(T1 arg1, T2 arg2, T3 arg3, T4 arg4);

    #endregion Methods
  }

  #endregion Interfaces
}