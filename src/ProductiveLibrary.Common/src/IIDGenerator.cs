/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

namespace Niacomsoft.ProductiveLibrary
{
  #region Interfaces

  /// <summary> 提供了生成标识符的接口。 </summary>
  /// <typeparam name="T"> 标识符类型。 </typeparam>
  public interface IIDGenerator<T>
  {
    #region Methods

    /// <summary> 生成一个标识符。 </summary>
    /// <returns> <typeparamref name="T" /> 类型的标识符。 </returns>
    T New();

    #endregion Methods
  }

  #endregion Interfaces
}