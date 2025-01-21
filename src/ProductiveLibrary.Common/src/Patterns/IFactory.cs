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

    #endregion Methods
  }

  #endregion Interfaces
}