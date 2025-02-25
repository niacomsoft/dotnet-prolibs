/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using System.Threading;
using System.Threading.Tasks;

namespace Niacomsoft.ProductiveLibrary.Security
{
  /// <summary> 提供了生成随机密码相关的基本方法。 </summary>
  /// <seealso cref="IPasswordGenerator" />
  public class PasswordGenerator : IPasswordGenerator
  {
    #region Constants

    /// <summary> 随机密码最小长度。 </summary>
    public const int MinimumLength = 8;

    #endregion Constants

    #region Constructors

    /// <summary> 初始化 <see cref="PasswordGenerator" /> 类的新实例。 </summary>
    /// <seealso cref="SecretSalt.CharacterPasswordSalt" />
    public PasswordGenerator() : this(SecretSalt.CharacterPasswordSalt)
    {
    }

    /// <summary> 初始化 <see cref="PasswordGenerator" /> 类的新实例。 </summary>
    /// <param name="salt">
    ///   生成随机密码的盐值。
    ///   <para> <see cref="SecretSalt" /> 类型的值。 </para>
    /// </param>
    public PasswordGenerator(SecretSalt salt)
    {
      InitialSalt = salt;
    }

    #endregion Constructors

    #region Properties

    /// <inheritdoc />
    public virtual SecretSalt InitialSalt { get; }

    #endregion Properties

    #region Methods

    /// <inheritdoc />
    public virtual string Next(int length)
    {
      throw new System.NotImplementedException();
    }

    /// <inheritdoc />
    public virtual Task<string> NextAsync(int length, CancellationToken? cancellationToken = null)
    {
      throw new System.NotImplementedException();
    }

    #endregion Methods
  }
}