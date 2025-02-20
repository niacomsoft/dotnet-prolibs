/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

namespace Niacomsoft.ProductiveLibrary.Models
{
  #region Interfaces

  /// <summary> 提供了描述昵称的接口。 </summary>
  public interface INickName
  {
    #region Properties

    /// <summary> 昵称。 </summary>
    /// <value> 设置或获取一个字符串，用于表示昵称。 </value>
    string NickName { get; set; }

    #endregion Properties
  }

  #endregion Interfaces
}