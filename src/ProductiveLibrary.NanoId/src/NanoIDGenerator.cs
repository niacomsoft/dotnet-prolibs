/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using NanoidDotNet;

using Niacomsoft.ProductiveLibrary.Utilities;

using System.Threading;
using System.Threading.Tasks;

namespace Niacomsoft.ProductiveLibrary
{
  /// <summary>
  ///   提供了生成 <c> Nano ID </c> 标识符相关的方法。
  ///   <para> 密闭的，不能从此类型派生。 </para>
  /// </summary>
  /// <seealso cref="AsyncIDGenerator{T}" />
  /// <seealso cref="IAsyncNanoIDGenerator" />
  public sealed class NanoIDGenerator : AsyncIDGenerator<string>, IAsyncNanoIDGenerator
  {
    #region Methods

    /// <summary> 生成一个 <c> Nano ID </c> 标识符。 </summary>
    /// <returns> <c> Nano ID </c> 标识符。 </returns>
    public override string New()
    {
      return Nanoid.Generate(NanoIdGenerateOptions.Default.Alphabets, NanoIdGenerateOptions.Default.Length);
    }

    /// <inheritdoc />
    public string New(NanoIdGenerateOptions options)
    {
      if (AssertUtilities.IsNull(options))
      {
        return New();
      }

      return Nanoid.Generate(options.Alphabets, options.Length);
    }

    /// <inheritdoc />
    public Task<string> NewAsync(NanoIdGenerateOptions options, CancellationToken? cancellationToken = null)
    {
      return Task.Run(() => New(options), cancellationToken ?? CancellationToken.None);
    }

    #endregion Methods
  }
}