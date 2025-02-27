/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using Niacomsoft.ProductiveLibrary.Resources;
using Niacomsoft.ProductiveLibrary.Resources.Internal;
using Niacomsoft.ProductiveLibrary.Utilities;

using System;

namespace Niacomsoft.ProductiveLibrary.Security
{
  /// <summary> 提供了用于生成随机密码的盐值相关的方法。 </summary>
  public struct SecretSalt
  {
    #region Fields

    /// <summary> 包含了字母（大小写）和数字的盐值。 </summary>
    public static readonly SecretSalt CharacterPasswordSalt = new SecretSalt("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789");

    /// <summary> 包含特殊字符的复杂盐值。 </summary>
    public static readonly SecretSalt ComplexPasswordSalt = new SecretSalt("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789<>?/;:[{]}|~!@#$%^&*-_=+");

    /// <summary> 仅包含数字的盐值。 </summary>
    public static readonly SecretSalt NumericPasswordSalt = new SecretSalt("0123456789");

    #endregion Fields

    #region Constructors

    /// <summary> 初始化 <see cref="SecretSalt" /> 类型值的新实例。 </summary>
    /// <param name="salt"> 生成随机密码的盐值数组。 </param>
    /// <exception cref="ArgumentException">
    ///   当 <paramref name="salt" /> 等于 <see langword="null" /> 或 <c>
    ///   <paramref name="salt" />.Length == 0 </c> 时，将引发此类型的异常。
    /// </exception>
    public SecretSalt(char[] salt)
    {
      if (AssertUtilities.IsEmptyArray(salt))
      {
        throw new ArgumentException(SR.Format(nameof(Strings.ArgumentNullException_with_argument_name), nameof(salt)), nameof(salt));
      }

      Salt = salt;
    }

    /// <summary> 初始化 <see cref="SecretSalt" /> 类型值的新实例。 </summary>
    /// <param name="salt"> 生成随机密码的盐值字符串。 </param>
    public SecretSalt(string salt) : this(AssertUtilities.IsWhiteSpace(salt) ? null : salt.ToCharArray())
    {
    }

    #endregion Constructors

    #region Properties

    /// <summary> 生成随机的盐值数组。 </summary>
    /// <value> 获取 <see cref="char" /> 类型的数组，用于表示生成随机的盐值。 </value>
    public char[] Salt { get; }

    #endregion Properties
  }
}