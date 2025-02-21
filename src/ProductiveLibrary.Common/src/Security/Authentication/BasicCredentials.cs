/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

namespace Niacomsoft.ProductiveLibrary.Security.Authentication
{
  /// <summary> 提供了基于用户名、密码的身份认证凭据相关的基本方法。 </summary>
  /// <seealso cref="Credentials" />
  /// <seealso cref="IBasicCredentials" />
  public class BasicCredentials : Credentials, IBasicCredentials
  {
    #region Fields

    private string _password;

    private string _userName;

    #endregion Fields

    #region Constructors

    /// <summary> 初始化 <see cref="BasicCredentials" /> 类的新实例。 </summary>
    public BasicCredentials()
    {
    }

    /// <summary> 初始化 <see cref="BasicCredentials" /> 类的新实例。 </summary>
    /// <param name="userName"> 用户名。 </param>
    /// <param name="password"> 用户口令。 </param>
    public BasicCredentials(string userName, string password)
    {
      Password = password;
      UserName = userName;
    }

    #endregion Constructors

    #region Properties

    /// <inheritdoc />
    public virtual string Password
    {
      get { return _password; }
      set
      {
        ThrowIfMissingRequiredInfo(value, nameof(Password));
        _password = value;
      }
    }

    /// <inheritdoc />
    public virtual string UserName
    {
      get
      {
        return _userName;
      }
      set
      {
        ThrowIfMissingRequiredInfo(value, nameof(UserName));
        _userName = value;
      }
    }

    #endregion Properties

    #region Methods

    /// <summary> 创建一个基本的身份认证凭据。 </summary>
    /// <param name="userName"> 用户名。 </param>
    /// <param name="password"> 用户口令。 </param>
    /// <returns> 实现了 <see cref="IBasicCredentials" /> 类型接口的对象实例。 </returns>
    public static IBasicCredentials CreateBasicCredentials(string userName, string password)
    {
      return new BasicCredentials(userName, password);
    }

    #endregion Methods
  }
}