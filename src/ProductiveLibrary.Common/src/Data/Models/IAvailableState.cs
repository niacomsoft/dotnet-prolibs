/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

namespace Niacomsoft.ProductiveLibrary.Data.Models
{
  #region Interfaces

  /// <summary> 提供了描述激活状态的接口。 </summary>
  /// <typeparam name="T"> 描述激活状态的类型。 </typeparam>
  public interface IAvailableState<T>
  {
    #region Properties

    /// <summary> 是否处于激活状态。 </summary>
    /// <value> 设置或获取 <typeparamref name="T" /> 类型的值或对象实例，用于表示是否处于激活状态。 </value>
    T Available { get; set; }

    #endregion Properties
  }

  /// <summary> 提供了使用 32 位整型值描述激活状态的接口。 </summary>
  /// <seealso cref="IAvailableState{T}" />
  public interface IAvailableState : IAvailableState<int>
  { }

  #endregion Interfaces
}