/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

namespace Niacomsoft.ProductiveLibrary.Data.Models
{
  #region Interfaces

  /// <summary> 提供了描述电邮地址的接口。 </summary>
  public interface IEmailAddress
  {
    #region Properties

    /// <summary> 电邮地址。 </summary>
    /// <value> 设置或获取一个字符串，用于表示电邮地址。 </value>
    string EmailAddress { get; set; }

    #endregion Properties
  }

  #endregion Interfaces
}