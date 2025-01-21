/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

namespace Niacomsoft.ProductiveLibrary.Patterns
{
  #region Interfaces

  /// <summary> 提供了工厂模式的接口。 </summary>
  /// <typeparam name="T1"> 参数类型。 </typeparam>
  /// <typeparam name="T2"> 参数类型。 </typeparam>
  /// <typeparam name="TResult"> 结果类型。 </typeparam>
  public interface IFactory<T1, T2, TResult>
  {
    #region Methods

    /// <summary> 创建一个 <typeparamref name="TResult" /> 类型的值或对象实例。 </summary>
    /// <param name="arg1"> <typeparamref name="T1" /> 类型的参数。 </param>
    /// <param name="arg2"> <typeparamref name="T2" /> 类型的参数。 </param>
    /// <returns> <typeparamref name="TResult" /> 类型的值或对象实例。 </returns>
    TResult CreateNew(T1 arg1, T2 arg2);

    #endregion Methods
  }

  #endregion Interfaces
}