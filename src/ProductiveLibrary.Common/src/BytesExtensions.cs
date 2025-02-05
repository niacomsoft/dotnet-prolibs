/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using Niacomsoft.ProductiveLibrary.Resources;
using Niacomsoft.ProductiveLibrary.Resources.Internal;

using System;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Niacomsoft.ProductiveLibrary
{
  /// <summary> 为 <see cref="byte" /> 类型数组提供了扩展方法。 </summary>
  public static class BytesExtensions
  {
    #region Methods

    /// <summary>
    ///   使用指定编码程序 <paramref name="encoding" /> 获取字节数组 <paramref name="me" /> 的字符串。
    /// </summary>
    /// <param name="me"> 字节数组。 </param>
    /// <param name="encoding"> 编码程序。 </param>
    /// <param name="startIndex"> 字节数组 <paramref name="me" /> 起始索引。 </param>
    /// <param name="length"> 字节数组 <paramref name="me" /> 长度。 </param>
    /// <returns> 字节数组。 </returns>
    /// <seealso cref="Encoding" />
    /// <exception cref="ArgumentNullException">
    ///   当 <paramref name="encoding" /> 等于 <see langword="null" /> 时，可能引发此类型的异常。
    /// </exception>
    /// <exception cref="OverflowException"> 当访问 <c> me.Length </c> 属性时，可能引发此类型的异常。 </exception>
    [SuppressMessage("Style", "IDE0046:转换为条件表达式", Justification = "<挂起>")]
    public static string GetString(this byte[] me, Encoding encoding, int? startIndex = null, int? length = null)
    {
      if (me.Empty())
      {
        return null;
      }
      if (encoding.IsNull())
      {
        throw new ArgumentNullException(nameof(encoding), SR.Format(nameof(Strings.ArgumentNullException_with_argument_name), nameof(encoding)));
      }

      return encoding.GetString(me, startIndex ?? 0, length ?? me.Length);
    }

    /// <summary>
    ///   使用指定编码程序 <see cref="UTF8Encoding" /> 获取字节数组 <paramref name="me" /> 的字符串。
    /// </summary>
    /// <param name="me"> 字节数组。 </param>
    /// <param name="startIndex"> 字节数组 <paramref name="me" /> 起始索引。 </param>
    /// <param name="length"> 字节数组 <paramref name="me" /> 长度。 </param>
    /// <returns> 字节数组。 </returns>
    /// <seealso cref="Encoding" />
    /// <seealso cref="Encoding.UTF8" />
    /// <seealso cref="UTF8Encoding" />
    [SuppressMessage("Design", "Ex0100:Member may throw undocumented exception", Justification = "<挂起>")]
    public static string GetString(this byte[] me, int? startIndex = null, int? length = null) => me.GetString(Encoding.UTF8, startIndex, length);

    /// <summary> 将字节数组 <paramref name="me" /> 转换为 <c> BASE-64 </c> 字符串。 </summary>
    /// <param name="me"> 字节数组。 </param>
    /// <param name="startIndex"> 字节数组 <paramref name="me" /> 起始索引。 </param>
    /// <param name="length"> 字节数组 <paramref name="me" /> 长度。 </param>
    /// <param name="options"> <see cref="Base64FormattingOptions" /> 枚举类型中的一个值。 </param>
    /// <returns> <c> BASE-64 </c> 字符串。 </returns>
    /// <seealso cref="Base64FormattingOptions" />
    /// <seealso cref="Base64StringFormatter" />
    /// <seealso cref="IBase64StringEncoder" />
    public static string ToBase64String(this byte[] me, int? startIndex = null, int? length = null, Base64FormattingOptions options = Base64FormattingOptions.None)
    {
      return Base64StringFormatter.Encoder.Encode(me, startIndex, length, options);
    }

    #endregion Methods
  }
}