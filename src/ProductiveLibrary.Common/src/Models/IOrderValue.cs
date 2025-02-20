/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

namespace Niacomsoft.ProductiveLibrary.Models
{
  #region Interfaces

  /// <summary> 提供了描述排序条件的接口。 </summary>
  /// <typeparam name="T"> 描述排序条件的值类型。 </typeparam>
  public interface IOrderValue<T> where T : struct
  {
    #region Properties

    /// <summary> 用来排序的值。 </summary>
    /// <value> 设置或获取 <typeparamref name="T" /> 类型的值，用于表示用来排序的值。 </value>
    T OrderBy { get; set; }

    #endregion Properties
  }

  #endregion Interfaces
}