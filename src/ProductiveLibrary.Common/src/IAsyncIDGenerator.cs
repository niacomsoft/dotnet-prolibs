/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using System.Threading;
using System.Threading.Tasks;

namespace Niacomsoft.ProductiveLibrary
{
  #region Interfaces

  /// <summary> 提供了异步生成标识符的接口。 </summary>
  /// <typeparam name="T"> 标识符类型。 </typeparam>
  /// <seealso cref="IIDGenerator{T}" />
  public interface IAsyncIDGenerator<T> : IIDGenerator<T>
  {
    #region Methods

    /// <summary> (可等待的方法) 生成一个新的标识符。 </summary>
    /// <param name="cancellationToken"> 可能为空的 <see cref="CancellationToken" /> 类型值。 </param>
    /// <returns> <typeparamref name="T" /> 类型的标识符。 </returns>
    /// <seealso cref="CancellationToken" />
    /// <seealso cref="Task{TResult}" />
    Task<T> NewAsync(CancellationToken? cancellationToken = null);

    #endregion Methods
  }

  #endregion Interfaces
}