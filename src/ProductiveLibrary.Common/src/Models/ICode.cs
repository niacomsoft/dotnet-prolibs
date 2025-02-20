/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

namespace Niacomsoft.ProductiveLibrary.Models
{
  #region Interfaces

  /// <summary> 提供了描述编码的接口。 </summary>
  public interface ICode
  {
    #region Properties

    /// <summary> 编码。 </summary>
    /// <value> 设置或获取一个字符串，用于表示编码。 </value>
    string Code { get; set; }

    #endregion Properties
  }

  #endregion Interfaces
}