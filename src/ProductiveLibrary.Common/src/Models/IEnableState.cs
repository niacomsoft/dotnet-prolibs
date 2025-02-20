/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

namespace Niacomsoft.ProductiveLibrary.Models
{
  #region Interfaces

  /// <summary> 提供了描述是否启用状态的接口。 </summary>
  /// <typeparam name="T"> 描述是否启用状态的值类型。 </typeparam>
  public interface IEnableState<T>
  {
    #region Properties

    /// <summary> 是否启用。 </summary>
    /// <value> 设置或获取 <typeparamref name="T" /> 类型的值或对象实例，用于表示是否启用。 </value>
    T Enable { get; set; }

    #endregion Properties
  }

  /// <summary> 提供了 <see cref="bool" /> 类型描述是否启用状态的接口。 </summary>
  /// <seealso cref="IEnableState{T}" />
  public interface IEnableState : IEnableState<bool>
  {
  }

  #endregion Interfaces
}