/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

namespace Niacomsoft.ProductiveLibrary.Data.Models
{
  #region Interfaces

  /// <summary> 提供了描述电话号码的接口。 </summary>
  public interface IPhoneNumber
  {
    #region Properties

    /// <summary> 电话号码。 </summary>
    /// <value> 设置或获取一个字符串，用于表示电话号码。 </value>
    string PhoneNumber { get; set; }

    #endregion Properties
  }

  #endregion Interfaces
}