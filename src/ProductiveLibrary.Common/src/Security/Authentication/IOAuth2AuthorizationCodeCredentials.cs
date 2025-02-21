/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

namespace Niacomsoft.ProductiveLibrary.Security.Authentication
{
  #region Interfaces

  /// <summary> 提供了 OAuth2 授权码身份认证凭据的接口。 </summary>
  /// <seealso cref="ICredentials" />
  public interface IOAuth2AuthorizationCodeCredentials : ICredentials
  {
    #region Properties

    /// <summary> OAuth2 授权码。 </summary>
    /// <value> 设置或获取一个字符串，用于表示 OAuth2 授权码。 </value>
    string AuthorizationCode { get; set; }

    #endregion Properties
  }

  #endregion Interfaces
}