/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

namespace Niacomsoft.ProductiveLibrary.Models
{
  #region Interfaces

  /// <summary> 提供了描述显示名称的接口。 </summary>
  public interface IDisplayName
  {
    #region Properties

    /// <summary> 显示名称。 </summary>
    /// <value> 设置或获取一个字符串，用于表示显示名称。 </value>
    string DisplayName { get; set; }

    #endregion Properties
  }

  #endregion Interfaces
}