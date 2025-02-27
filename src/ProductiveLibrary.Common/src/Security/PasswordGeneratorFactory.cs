/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using Niacomsoft.ProductiveLibrary.Patterns;

namespace Niacomsoft.ProductiveLibrary.Security
{
  /// <summary> 提供了创建 <see cref="IPasswordGenerator" /> 类型的对象实例的基本工厂方法。 </summary>
  /// <seealso cref="IKnownTypeFactory{T1, TResult}" />
  /// <seealso cref="IKnownTypeFactory{TResult}" />
  /// <seealso cref="IPasswordGenerator" />
  /// <seealso cref="IPasswordGeneratorFactory" />
  public class PasswordGeneratorFactory : IPasswordGeneratorFactory, IKnownTypeFactory<SecretSalt, IPasswordGenerator>
  {
    #region Methods

    /// <summary> 创建 <see cref="IPasswordGenerator" /> 类型的对象实例。 </summary>
    /// <returns> <see cref="IPasswordGenerator" /> 类型的对象实例。 </returns>
    /// <seealso cref="PasswordGenerator" />
    public virtual IPasswordGenerator CreateInstance()
    {
      return new PasswordGenerator();
    }

    /// <summary> 创建 <see cref="IPasswordGenerator" /> 类型的对象实例。 </summary>
    /// <param name="salt"> 生成随机密码所需的盐值。 </param>
    /// <returns> <see cref="IPasswordGenerator" /> 类型的对象实例。 </returns>
    /// <seealso cref="IPasswordGenerator" />
    /// <seealso cref="PasswordGenerator" />
    /// <seealso cref="SecretSalt" />
    public virtual IPasswordGenerator CreateInstance(SecretSalt salt)
    {
      return new PasswordGenerator(salt);
    }

    #endregion Methods
  }
}