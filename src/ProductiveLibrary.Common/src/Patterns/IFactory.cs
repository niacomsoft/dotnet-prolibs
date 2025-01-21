/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

namespace Niacomsoft.ProductiveLibrary.Patterns
{
  #region Interfaces

  /// <summary> 提供了工厂模式的接口。 </summary>
  /// <typeparam name="TResult"> 结果类型。 </typeparam>
  public interface IFactory<TResult>
  {
    #region Methods

    /// <summary> 创建一个 <typeparamref name="TResult" /> 类型的值或对象实例。 </summary>
    /// <returns> <typeparamref name="TResult" /> 类型的值或对象实例。 </returns>
    TResult CreateNew();

    /// <summary> 创建一个 <typeparamref name="TResult" /> 类型的值或对象实例。 </summary>
    /// <param name="args"> 参数数组。 </param>
    /// <returns> <typeparamref name="TResult" /> 类型的值或对象实例。 </returns>
    TResult CreateNew(params object[] args);

    #endregion Methods
  }

  #endregion Interfaces
}