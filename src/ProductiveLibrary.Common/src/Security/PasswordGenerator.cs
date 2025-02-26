/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using Niacomsoft.ProductiveLibrary.Resources;
using Niacomsoft.ProductiveLibrary.Resources.Internal;
using Niacomsoft.ProductiveLibrary.Utilities;

using System;
using System.Diagnostics.CodeAnalysis;
using System.Text;
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

    #region Fields

    private readonly int _randomMaximumValue;

    #endregion Fields

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
    [SuppressMessage("Design", "Ex0100:Member may throw undocumented exception", Justification = "<挂起>")]
    public PasswordGenerator(SecretSalt salt)
    {
      _randomMaximumValue = (SaltChars = (InitialSalt = salt).Salt).Length - 1;
      RandomAlgorithm = new Random();
    }

    #endregion Constructors

    #region Properties

    /// <summary> 随机算法服务。 </summary>
    /// <value> 获取 <see cref="Random" /> 类型的对象实例，用于表示随机算法服务。 </value>
    /// <seealso cref="Random" />
    protected virtual Random RandomAlgorithm { get; }

    /// <summary> 生成随机密码的盐值字符数组。 </summary>
    /// <value> 获取 <see cref="char" /> 类型的数组，用于表示生成随机密码的盐值。 </value>
    protected virtual char[] SaltChars { get; }

    /// <inheritdoc />
    public virtual SecretSalt InitialSalt { get; }

    #endregion Properties

    #region Methods

    /// <summary> 将盐值数组 <see cref="SaltChars" /> 打乱顺序。 </summary>
    /// <exception cref="OverflowException">
    ///   当访问 <c> <see cref="SaltChars" />.Length </c> 属性时，可能引发此类型的异常。
    /// </exception>
    protected virtual void Shuffle()
    {
      for (int i = 0; i < SaltChars.Length; i++)
      {
        var currentBuf = SaltChars[i];
        var randomIdx = RandomAlgorithm.Next(0, _randomMaximumValue);
        SaltChars[i] = SaltChars[randomIdx];
        SaltChars[randomIdx] = currentBuf;
      }
    }

    /// <inheritdoc />
    /// <exception cref="ArgumentOutOfRangeException">
    ///   当 <c> <paramref name="length" /> &lt; <see cref="MinimumLength" /></c> 时，将引发此类型的异常。
    /// </exception>
    /// <exception cref="OverflowException">
    ///   当调用 <see cref="Shuffle()" /> 方法时，可能引发此类型的异常。
    /// </exception>
    public virtual string Next(int length)
    {
      if (AssertUtilities.LessThan(length, MinimumLength))
      {
        throw new ArgumentOutOfRangeException(nameof(length), length, SR.Format(nameof(Strings.ArgumentOutOfRangeException_with_argument_name_and_range), nameof(length), $"length >= 8"));
      }
      var pwdBuilder = new StringBuilder();
      for (int i = 0; i < length; i++)
      {
        Shuffle();
        pwdBuilder.Append(SaltChars[RandomAlgorithm.Next(0, _randomMaximumValue)]);
      }
      return pwdBuilder.ToString();
    }

    /// <inheritdoc />
    public virtual Task<string> NextAsync(int length, CancellationToken? cancellationToken = null)
    {
      return Task.Run(() => Next(length), cancellationToken ?? CancellationToken.None);
    }

    #endregion Methods
  }
}