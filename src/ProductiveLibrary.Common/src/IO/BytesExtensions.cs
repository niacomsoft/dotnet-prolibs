/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using Niacomsoft.ProductiveLibrary.Resources;
using Niacomsoft.ProductiveLibrary.Resources.Internal;

using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Niacomsoft.ProductiveLibrary.IO
{
  /// <summary> 为 <see cref="byte" /> 类型数组提供了扩展方法。 </summary>
  public static class BytesExtensions
  {
    #region Methods

    /// <summary> 将字节数组 <paramref name="me" /> 写入流 <paramref name="stream" />。 </summary>
    /// <param name="me"> 需要写入的字节数组。 </param>
    /// <param name="stream"> 目标流。 </param>
    /// <param name="startIndex"> 字节数组 <paramref name="me" /> 起始索引。 </param>
    /// <param name="length"> 字节数组 <paramref name="me" /> 长度。 </param>
    /// <returns> <see cref="Result" /> 类型的对象实例。 </returns>
    /// <seealso cref="Result" />
    /// <seealso cref="Stream" />
    public static Result SafeWrite(this byte[] me, Stream stream, int? startIndex = null, int? length = null)
    {
      try
      {
        me.Write(stream, startIndex, length);
        return Result.Done();
      }
      catch (Exception error)
      {
        return Result.FromException(error);
      }
    }

    /// <summary> 将字节数组 <paramref name="me" /> 写入流 <paramref name="stream" />。 </summary>
    /// <param name="me"> 需要写入的字节数组。 </param>
    /// <param name="stream"> 目标流。 </param>
    /// <param name="startIndex"> 字节数组 <paramref name="me" /> 起始索引。 </param>
    /// <param name="length"> 字节数组 <paramref name="me" /> 长度。 </param>
    /// <seealso cref="Stream" />
    /// <exception cref="ArgumentNullException">
    ///   当 <paramref name="stream" /> 等于 <see langword="null" /> 时，可能引发此类型的异常。
    /// </exception>
    /// <exception cref="OverflowException"> 当访问 <c> me.Length </c> 属性时，可能引发此类型的异常。 </exception>
    /// <exception cref="IOException">
    ///   当调用 <see cref="Stream.Write(byte[], int, int)" /> 方法时，可能引发此类型的异常。
    /// </exception>
    /// <exception cref="NotSupportedException">
    ///   当调用 <see cref="Stream.Write(byte[], int, int)" /> 方法时，可能引发此类型的异常。
    /// </exception>
    public static void Write(this byte[] me, Stream stream, int? startIndex = null, int? length = null)
    {
      if (!me.Empty())
      {
        if (stream.IsNull())
        {
          throw new ArgumentNullException(nameof(stream), SR.Format(nameof(Strings.ArgumentNullException_with_argument_name), nameof(stream)));
        }

        stream.Write(me, startIndex ?? 0, length ?? me.Length);
      }
    }

    /// <summary> (可等待的方法) 将字节数组 <paramref name="me" /> 写入流 <paramref name="stream" />。 </summary>
    /// <param name="me"> 需要写入的字节数组。 </param>
    /// <param name="stream"> 目标流。 </param>
    /// <param name="startIndex"> 字节数组 <paramref name="me" /> 起始索引。 </param>
    /// <param name="length"> 字节数组 <paramref name="me" /> 长度。 </param>
    /// <param name="cancellationToken"> <see cref="CancellationToken" /> 类型的值。 </param>
    /// <seealso cref="CancellationToken" />
    /// <seealso cref="Stream" />
    /// <seealso cref="Task" />
    /// <exception cref="ArgumentNullException">
    ///   当 <paramref name="stream" /> 等于 <see langword="null" /> 时，可能引发此类型的异常。
    /// </exception>
    /// <exception cref="OverflowException"> 当访问 <c> me.Length </c> 属性时，可能引发此类型的异常。 </exception>
    /// <exception cref="IOException">
    ///   当调用 <see cref="Stream.Write(byte[], int, int)" /> 方法时，可能引发此类型的异常。
    /// </exception>
    /// <exception cref="NotSupportedException">
    ///   当调用 <see cref="Stream.Write(byte[], int, int)" /> 方法时，可能引发此类型的异常。
    /// </exception>
    [SuppressMessage("Async/await", "CRR0029:ConfigureAwait(true) is called implicitly", Justification = "<挂起>")]
    public static async Task WriteAsync(this byte[] me, Stream stream, int? startIndex = null, int? length = null, CancellationToken? cancellationToken = null)
    {
      if (!me.Empty())
      {
        if (stream.IsNull())
        {
          throw new ArgumentNullException(nameof(stream), SR.Format(nameof(Strings.ArgumentNullException_with_argument_name), nameof(stream)));
        }

        await stream.WriteAsync(me, startIndex ?? 0, length ?? me.Length, cancellationToken ?? CancellationToken.None);
      }
    }

    #endregion Methods
  }
}