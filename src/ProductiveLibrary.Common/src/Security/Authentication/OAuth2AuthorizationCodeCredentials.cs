/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

namespace Niacomsoft.ProductiveLibrary.Security.Authentication
{
  /// <summary> 提供了 OAuth2 授权码身份认证凭据相关的基本方法。 </summary>
  /// <seealso cref="Credentials" />
  /// <seealso cref="IOAuth2AuthorizationCodeCredentials" />
  public class OAuth2AuthorizationCodeCredentials : Credentials, IOAuth2AuthorizationCodeCredentials
  {
    #region Fields

    private string _authCode;

    #endregion Fields

    #region Constructors

    /// <summary> 初始化 <see cref="OAuth2AuthorizationCodeCredentials" /> 类的新实例。 </summary>
    public OAuth2AuthorizationCodeCredentials()
    {
    }

    /// <summary> 初始化 <see cref="OAuth2AuthorizationCodeCredentials" /> 类的新实例。 </summary>
    /// <param name="authCode"> OAuth2 授权码。 </param>
    public OAuth2AuthorizationCodeCredentials(string authCode)
    {
      AuthorizationCode = authCode;
    }

    #endregion Constructors

    #region Properties

    /// <inheritdoc />
    public virtual string AuthorizationCode
    {
      get
      {
        return _authCode;
      }
      set
      {
        ThrowIfMissingRequiredInfo(value, nameof(AuthorizationCode));
        _authCode = value;
      }
    }

    #endregion Properties

    #region Methods

    /// <summary> 从授权码创建一个身份认证凭据。 </summary>
    /// <param name="authCode"> OAuth2 授权码。 </param>
    /// <returns> 实现了 <see cref="IOAuth2AuthorizationCodeCredentials" /> 类型接口的对象实例。 </returns>
    public static IOAuth2AuthorizationCodeCredentials FormAuthorizationCode(string authCode)
    {
      return new OAuth2AuthorizationCodeCredentials(authCode);
    }

    #endregion Methods
  }
}