/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

namespace Niacomsoft.ProductiveLibrary.Data.Models
{
  #region Interfaces

  /// <summary> 提供了描述别名的接口。 </summary>
  public interface IAlias
  {
    #region Properties

    /// <summary> 别名。 </summary>
    /// <value> 设置或获取一个字符串，用于表示别名。 </value>
    string Alias { get; set; }

    #endregion Properties
  }

  #endregion Interfaces
}