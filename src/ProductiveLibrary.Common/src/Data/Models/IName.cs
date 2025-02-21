/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

namespace Niacomsoft.ProductiveLibrary.Data.Models
{
  #region Interfaces

  /// <summary> 提供了描述名称的接口。 </summary>
  public interface IName
  {
    #region Properties

    /// <summary> 名称。 </summary>
    /// <value> 设置或获取一个字符串，用于表示名称。 </value>
    string Name { get; set; }

    #endregion Properties
  }

  #endregion Interfaces
}