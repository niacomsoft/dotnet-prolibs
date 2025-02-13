/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using Niacomsoft.ProductiveLibrary.Resources;
using Niacomsoft.ProductiveLibrary.Resources.Internal;
using Niacomsoft.ProductiveLibrary.Utilities;

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Niacomsoft.ProductiveLibrary.IO
{
  /// <summary> 为 <see cref="Bytes" /> 类型和 <see cref="byte" /> 类型的数组提供了扩展方法。 </summary>
  public static class BytesExtensions
  {
    #region Methods

    /// <summary>
    ///   将字节数组 <paramref name="bytes" /> 写入流 <paramref name="destinationStream" />。
    /// </summary>
    /// <param name="bytes"> 字节数组。 </param>
    /// <param name="destinationStream"> 目标流。 </param>
    /// <seealso cref="Stream" />
    /// <exception cref="ArgumentNullException">
    ///   当 <paramref name="destinationStream" /> 等于 <see langword="null" /> 时，可能引发此类型的异常。
    /// </exception>
    /// <exception cref="IOException">
    ///   当调用 <see cref="Stream.Write(byte[], int, int)" /> 方法时，可能引发此类型的异常。
    /// </exception>
    /// <exception cref="NotSupportedException">
    ///   当调用 <see cref="Stream.Write(byte[], int, int)" /> 方法时，可能引发此类型的异常。
    /// </exception>
    public static void Write(this Bytes bytes, Stream destinationStream)
    {
      if (bytes.HasData)
      {
        if (AssertUtilities.IsNull(destinationStream))
        {
          throw new ArgumentNullException(nameof(destinationStream), SR.Format(nameof(Strings.ArgumentNullException_with_argument_name), nameof(destinationStream)));
        }

        destinationStream.Write(bytes.Data, bytes.Offset, bytes.Length);
      }
    }

    /// <summary>
    ///   将字节数组 <paramref name="bytes" /> 写入流 <paramref name="destinationStream" />。
    /// </summary>
    /// <param name="bytes"> 字节数组。 </param>
    /// <param name="destinationStream"> 目标流。 </param>
    /// <param name="offset"> 需要写入的字节数组偏移量。 </param>
    /// <param name="length"> 需要写入的字节数组长度。 </param>
    /// <seealso cref="Stream" />
    /// <exception cref="ArgumentNullException">
    ///   当 <paramref name="destinationStream" /> 等于 <see langword="null" /> 时，可能引发此类型的异常。
    /// </exception>
    /// <exception cref="IOException">
    ///   当调用 <see cref="Stream.Write(byte[], int, int)" /> 方法时，可能引发此类型的异常。
    /// </exception>
    /// <exception cref="NotSupportedException">
    ///   当调用 <see cref="Stream.Write(byte[], int, int)" /> 方法时，可能引发此类型的异常。
    /// </exception>
    /// <exception cref="OverflowException">
    ///   当调用 <see cref="Bytes.FromBytes(IEnumerable{byte}, int?, int?)" /> 方法时，可能引发此类型的异常。
    /// </exception>
    public static void Write(this IEnumerable<byte> bytes, Stream destinationStream, int? offset = null, int? length = null)
    {
      Write(Bytes.FromBytes(bytes, offset, length), destinationStream);
    }

    /// <summary>
    ///   (可等待的方法) 将字节数组 <paramref name="bytes" /> 写入流 <paramref name="destinationStream" />。
    /// </summary>
    /// <param name="bytes"> 字节数组。 </param>
    /// <param name="destinationStream"> 目标流。 </param>
    /// <param name="cancellationToken"> 取消异步任务的令牌。 </param>
    /// <seealso cref="Stream" />
    /// <seealso cref="CancellationToken" />
    /// <exception cref="ArgumentNullException">
    ///   当 <paramref name="destinationStream" /> 等于 <see langword="null" /> 时，可能引发此类型的异常。
    /// </exception>
    [SuppressMessage("Design", "Ex0100:Member may throw undocumented exception", Justification = "<挂起>")]
    [SuppressMessage("Async/await", "CRR0029:ConfigureAwait(true) is called implicitly", Justification = "<挂起>")]
    public static async Task WriteAsync(this Bytes bytes, Stream destinationStream, CancellationToken? cancellationToken = null)
    {
      if (bytes.HasData)
      {
        if (AssertUtilities.IsNull(destinationStream))
        {
          throw new ArgumentNullException(nameof(destinationStream), SR.Format(nameof(Strings.ArgumentNullException_with_argument_name), nameof(destinationStream)));
        }

        await destinationStream.WriteAsync(bytes.Data, bytes.Offset, bytes.Length, cancellationToken.GetValueOrDefault(CancellationToken.None));
      }
    }

    /// <summary>
    ///   将字节数组 <paramref name="bytes" /> 写入流 <paramref name="destinationStream" />。
    /// </summary>
    /// <param name="bytes"> 字节数组。 </param>
    /// <param name="destinationStream"> 目标流。 </param>
    /// <param name="offset"> 需要写入的字节数组偏移量。 </param>
    /// <param name="length"> 需要写入的字节数组长度。 </param>
    /// <param name="cancellationToken"> 取消异步任务的令牌。 </param>
    /// <seealso cref="Stream" />
    /// <seealso cref="CancellationToken" />
    /// <exception cref="ArgumentNullException">
    ///   当 <paramref name="destinationStream" /> 等于 <see langword="null" /> 时，可能引发此类型的异常。
    /// </exception>
    /// <exception cref="OverflowException">
    ///   当调用 <see cref="Bytes.FromBytes(IEnumerable{byte}, int?, int?)" /> 方法时，可能引发此类型的异常。
    /// </exception>
    [SuppressMessage("Async/await", "CRR0029:ConfigureAwait(true) is called implicitly", Justification = "<挂起>")]
    public static async Task WriteAsync(this IEnumerable<byte> bytes, Stream destinationStream, int? offset = null, int? length = null, CancellationToken? cancellationToken = null)
    {
      await WriteAsync(Bytes.FromBytes(bytes, offset, length), destinationStream, cancellationToken);
    }

    #endregion Methods
  }
}