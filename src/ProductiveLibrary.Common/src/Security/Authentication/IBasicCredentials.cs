/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

namespace Niacomsoft.ProductiveLibrary.Security.Authentication
{
  #region Interfaces

  /// <summary> 提供了基于用户名、密码的基础身份认证凭据的接口。 </summary>
  /// <seealso cref="ICredentials" />
  public interface IBasicCredentials : ICredentials
  {
    #region Properties

    /// <summary> 用户口令。 </summary>
    /// <value> 设置或获取一个字符串，用于表示用户口令。 </value>
    string Password { get; set; }

    /// <summary> 用户名。 </summary>
    /// <value> 设置或获取一个字符串，用于表示用户名。 </value>
    string UserName { get; set; }

    #endregion Properties
  }

  #endregion Interfaces
}