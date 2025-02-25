/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using System.Threading;
using System.Threading.Tasks;

namespace Niacomsoft.ProductiveLibrary.Security
{
  #region Interfaces

  /// <summary> 提供了动态生成随机密码的接口。 </summary>
  public interface IPasswordGenerator
  {
    #region Properties

    /// <summary> 初始化盐值。 </summary>
    /// <value> 获取 <see cref="SecretSalt" /> 类型的值，用于表示初始化盐值。 </value>
    /// <seealso cref="SecretSalt" />
    SecretSalt InitialSalt { get; }

    #endregion Properties

    #region Methods

    /// <summary> 生成下一个随机密码。 </summary>
    /// <param name="length"> 随机密码长度。 </param>
    /// <returns> 随机密码字符串。 </returns>
    string Next(int length);

    /// <summary> (可等待的方法) 生成下一个随机密码。 </summary>
    /// <param name="length"> 随机密码长度。 </param>
    /// <param name="cancellationToken"> <see cref="CancellationToken" /> 类型的值。 </param>
    /// <returns> 随机密码字符串。 </returns>
    /// <seealso cref="CancellationToken" />
    /// <seealso cref="Task{TResult}" />
    Task<string> NextAsync(int length, CancellationToken? cancellationToken = null);

    #endregion Methods
  }

  #endregion Interfaces
}