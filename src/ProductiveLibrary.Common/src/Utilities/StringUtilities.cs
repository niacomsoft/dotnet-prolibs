/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using Niacomsoft.ProductiveLibrary.IO;
using Niacomsoft.ProductiveLibrary.Resources;
using Niacomsoft.ProductiveLibrary.Resources.Internal;
using Niacomsoft.ProductiveLibrary.Text;

using System;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Niacomsoft.ProductiveLibrary.Utilities
{
  /// <summary> 提供了字符串相关的静态 <see langword="static" /> 方法。 </summary>
  public static class StringUtilities
  {
    #region Methods

    /// <summary>
    ///   当 <paramref name="encoding" /> 等于 <see langword="null" /> 时，将引发一个
    ///   <see cref="ArgumentNullException" /> 类型的异常。
    /// </summary>
    /// <param name="encoding"> 需要校验的编码程序。 </param>
    [SuppressMessage("Design", "Ex0100:Member may throw undocumented exception", Justification = "<挂起>")]
    private static void NotSupportEncoding(Encoding encoding)
    {
      if (AssertUtilities.IsNull(encoding))
      {
        throw new ArgumentNullException(nameof(encoding), SR.Format(nameof(Strings.ArgumentNullException_with_argument_name), nameof(encoding)));
      }
    }

    /// <summary>
    ///   使用默认编码器 <c> <see cref="DefaultEncodingHolder.DefaultEncoding" />.Value </c> 获取字符串
    ///   <paramref name="s" /> 的字节数组。
    /// </summary>
    /// <param name="s"> 字符串。 </param>
    /// <returns>
    ///   <see cref="byte" /> 类型的数组。
    ///   <para>
    ///     当字符串 <paramref name="s" /> 等于 <see langword="null" /> 或 <see cref="string.Empty" /> 时将返回
    ///     <see langword="null" /> 值。
    ///   </para>
    /// </returns>
    /// <seealso cref="DefaultEncodingHolder" />
    /// <seealso cref="Encoding" />
    public static byte[] GetBytes(string s)
    {
      return GetBytes(s, DefaultEncodingHolder.DefaultEncoding.Value);
    }

    /// <summary> 使用编码器 <paramref name="encoding" /> 获取字符串 <paramref name="s" /> 的字节数组。 </summary>
    /// <param name="s"> 字符串。 </param>
    /// <param name="encoding">
    ///   编码程序。
    ///   <para> <see cref="Encoding" /> 类型的对象实例。 </para>
    /// </param>
    /// <returns>
    ///   <see cref="byte" /> 类型的数组。
    ///   <para>
    ///     当字符串 <paramref name="s" /> 等于 <see langword="null" /> 或 <see cref="string.Empty" /> 时将返回
    ///     <see langword="null" /> 值。
    ///   </para>
    /// </returns>
    /// <seealso cref="Encoding" />
    /// <exception cref="ArgumentNullException">
    ///   当 <paramref name="encoding" /> 等于 <see langword="null" /> 时，将引发此类型的异常。
    /// </exception>
    [SuppressMessage("Style", "IDE0046:转换为条件表达式", Justification = "<挂起>")]
    public static byte[] GetBytes(string s, Encoding encoding)
    {
      if (AssertUtilities.IsEmpty(s))
      {
        return null;
      }

      NotSupportEncoding(encoding);

      return encoding.GetBytes(s);
    }

    /// <summary>
    ///   使用指定编码程序 <paramref name="encoding" /> 获取字节数组 <paramref name="input" /> 等效的字符串。
    ///   <para>
    ///     当 <paramref name="input" /> 等于 <see langword="null" /> 或长度等于 <c> 0 </c> 时，返回
    ///     <see langword="null" />。
    ///   </para>
    /// </summary>
    /// <param name="input"> 字节数组。 </param>
    /// <param name="encoding">
    ///   编码程序。
    ///   <para> <see cref="Encoding" /> 类型的对象实例。 </para>
    /// </param>
    /// <param name="offset"> 字节数组 <paramref name="input" /> 的偏移量。 </param>
    /// <param name="length"> 字节数组 <paramref name="length" /> 的长度。 </param>
    /// <returns> 字符串。 </returns>
    /// <seealso cref="Encoding" />
    /// <exception cref="ArgumentNullException">
    ///   当 <paramref name="encoding" /> 等于 <see langword="null" /> 时，将引发此类型的异常。
    /// </exception>
    /// <exception cref="OverflowException">
    ///   当调用
    ///   <see cref="Bytes.FromBytes(System.Collections.Generic.IEnumerable{byte}, int?, int?)" />
    ///   方法时，可能引发此类型的异常。
    /// </exception>
    public static string GetString(byte[] input, Encoding encoding, int? offset = null, int? length = null)
    {
      return GetString(Bytes.FromBytes(input, offset, length), encoding);
    }

    /// <summary>
    ///   使用指定编码程序 <paramref name="encoding" /> 获取字节数组 <paramref name="input" /> 等效的字符串。
    ///   <para>
    ///     当 <c> <paramref name="input" />.HasData </c> 等于 <see langword="false" /> 时，返回
    ///     <see langword="null" />。
    ///   </para>
    /// </summary>
    /// <param name="input"> 字节数组。 </param>
    /// <param name="encoding">
    ///   编码程序。
    ///   <para> <see cref="Encoding" /> 类型的对象实例。 </para>
    /// </param>
    /// <returns> 字符串。 </returns>
    /// <seealso cref="Bytes" />
    /// <seealso cref="Encoding" />
    /// <exception cref="ArgumentNullException">
    ///   当 <paramref name="encoding" /> 等于 <see langword="null" /> 时，将引发此类型的异常。
    /// </exception>
    /// <exception cref="OverflowException">
    ///   当调用
    ///   <see cref="Bytes.FromBytes(System.Collections.Generic.IEnumerable{byte}, int?, int?)" />
    ///   方法时，可能引发此类型的异常。
    /// </exception>
    public static string GetString(Bytes input, Encoding encoding)
    {
      if (!input.HasData)
      {
        return null;
      }

      NotSupportEncoding(encoding);

      return encoding.GetString(input.Data, input.Offset, input.Length);
    }

    /// <summary>
    ///   使用默认编码程序 <c> <see cref="DefaultEncodingHolder.DefaultEncoding" />.Value </c> 获取字节数组
    ///   <paramref name="input" /> 等效的字符串。
    ///   <para>
    ///     当 <paramref name="input" /> 等于 <see langword="null" /> 或长度等于 <c> 0 </c> 时，返回
    ///     <see langword="null" />。
    ///   </para>
    /// </summary>
    /// <param name="input"> 字节数组。 </param>
    /// <param name="offset"> 字节数组 <paramref name="input" /> 的偏移量。 </param>
    /// <param name="length"> 字节数组 <paramref name="length" /> 的长度。 </param>
    /// <returns> 字符串。 </returns>
    /// <seealso cref="DefaultEncodingHolder" />
    /// <seealso cref="Encoding" />
    /// <exception cref="OverflowException">
    ///   当调用
    ///   <see cref="Bytes.FromBytes(System.Collections.Generic.IEnumerable{byte}, int?, int?)" />
    ///   方法时，可能引发此类型的异常。
    /// </exception>
    public static string GetString(byte[] input, int? offset = null, int? length = null)
    {
      return GetString(input, DefaultEncodingHolder.DefaultEncoding.Value, offset, length);
    }

    /// <summary>
    ///   使用默认编码程序 <c> <see cref="DefaultEncodingHolder.DefaultEncoding" />.Value </c> 获取字节数组
    ///   <paramref name="input" /> 等效的字符串。
    ///   <para>
    ///     当 <c> <paramref name="input" />.HasData </c> 等于 <see langword="false" /> 时，返回
    ///     <see langword="null" />。
    ///   </para>
    /// </summary>
    /// <param name="input"> 字节数组。 </param>
    /// <returns> 字符串。 </returns>
    /// <seealso cref="Bytes" />
    /// <seealso cref="DefaultEncodingHolder" />
    /// <exception cref="OverflowException">
    ///   当调用
    ///   <see cref="Bytes.FromBytes(System.Collections.Generic.IEnumerable{byte}, int?, int?)" />
    ///   方法时，可能引发此类型的异常。
    /// </exception>
    public static string GetString(Bytes input)
    {
      return GetString(input, DefaultEncodingHolder.DefaultEncoding.Value);
    }

    #endregion Methods
  }
}