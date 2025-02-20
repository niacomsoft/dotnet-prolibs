/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

namespace Niacomsoft.ProductiveLibrary.Models
{
  #region Interfaces

  /// <summary> 提供了描述友好名称的接口。 </summary>
  public interface IFriendlyName
  {
    #region Properties

    /// <summary> 友好名称。 </summary>
    /// <value> 设置或获取一个字符串，用于表示友好名称。 </value>
    string FriendlyName { get; set; }

    #endregion Properties
  }

  #endregion Interfaces
}