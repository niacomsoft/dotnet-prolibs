/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

namespace Niacomsoft.ProductiveLibrary.Collections.Generic
{
  #region Interfaces

  /// <summary> 提供了描述标识的接口。 </summary>
  /// <typeparam name="T"> 标识类型。 </typeparam>
  public interface IKey<T>
  {
    #region Properties

    /// <summary> 标识。 </summary>
    /// <value> 获取 <typeparamref name="T" /> 类型的值或对象实例，用于表示标识。 </value>
    T Value { get; }

    #endregion Properties
  }

  #endregion Interfaces
}