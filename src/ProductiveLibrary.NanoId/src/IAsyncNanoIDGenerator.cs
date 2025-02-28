/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using System.Threading;
using System.Threading.Tasks;

namespace Niacomsoft.ProductiveLibrary
{
  #region Interfaces

  /// <summary> 提供了异步的生成 <c> Nano ID </c> 标识符的接口。 </summary>
  /// <seealso cref="IAsyncIDGenerator{T}" />
  /// <seealso cref="INanoIDGenerator" />
  public interface IAsyncNanoIDGenerator : IAsyncIDGenerator<string>, INanoIDGenerator
  {
    #region Methods

    /// <summary> (可等待的方法) 生成新的 <c> Nano ID </c> 标识符。 </summary>
    /// <param name="options">
    ///   生成 <c> Nano ID </c> 标识符的配置选项。
    ///   <para> <see cref="NanoIdGenerateOptions" /> 类型的对象实例。 </para>
    /// </param>
    /// <param name="cancellationToken"> 可能为空的 <see cref="CancellationToken" /> 类型值。 </param>
    /// <returns> <c> Nano ID </c> 标识符。 </returns>
    /// <seealso cref="CancellationToken" />
    /// <seealso cref="NanoIdGenerateOptions" />
    /// <seealso cref="Task{TResult}" />
    Task<string> NewAsync(NanoIdGenerateOptions options, CancellationToken? cancellationToken = null);

    #endregion Methods
  }

  #endregion Interfaces
}