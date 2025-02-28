/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using System.Threading;
using System.Threading.Tasks;

namespace Niacomsoft.ProductiveLibrary
{
  /// <summary> 提供了异步的生成标识符相关的抽象 <see langword="abstract" /> 方法。 </summary>
  /// <typeparam name="T"> 标识符类型。 </typeparam>
  /// <seealso cref="IAsyncIDGenerator{T}" />
  /// <seealso cref="IDGenerator{T}" />
  public abstract class AsyncIDGenerator<T> : IDGenerator<T>, IAsyncIDGenerator<T>
  {
    #region Methods

    /// <inheritdoc />
    public virtual Task<T> NewAsync(CancellationToken? cancellationToken = null)
    {
      return Task.Run(() => New(), cancellationToken ?? CancellationToken.None);
    }

    #endregion Methods
  }
}