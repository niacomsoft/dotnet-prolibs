/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using Niacomsoft.ProductiveLibrary.Resources;
using Niacomsoft.ProductiveLibrary.Resources.Internal;
using Niacomsoft.ProductiveLibrary.Text;

using System;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Niacomsoft.ProductiveLibrary.Utilities
{
  public static partial class Guard
  {
    #region Methods

    /// <summary>
    ///   当字符串 <paramref name="s" /> 等于 <see langword="null" /> 或 <see cref="string.Empty" /> 时返回
    ///   <paramref name="default" />；否则返回 <paramref name="s" />。
    /// </summary>
    /// <param name="s"> 字符串。 </param>
    /// <param name="default">
    ///   当字符串 <paramref name="s" /> 等于 <see langword="null" /> 或 <see cref="string.Empty" />
    ///   时返回的默认字符串。
    /// </param>
    /// <returns> 字符串。 </returns>
    public static string DefaultIfEmpty(string s, string @default)
    {
      return AssertUtilities.IsEmpty(s) ? @default : s;
    }

    /// <summary>
    ///   当字符串 <paramref name="s" /> 等于 <see langword="null" />、 <see cref="string.Empty" /> 或空格符时返回
    ///   <paramref name="default" />；否则返回 <paramref name="s" />。
    /// </summary>
    /// <param name="s"> 字符串。 </param>
    /// <param name="default">
    ///   当字符串 <paramref name="s" /> 等于 <see langword="null" />、 <see cref="string.Empty" /> 或空格符
    ///   时返回的默认字符串。
    /// </param>
    /// <returns> 字符串。 </returns>
    public static string DefaultIfWhiteSpace(string s, string @default)
    {
      return AssertUtilities.IsWhiteSpace(s) ? @default : s;
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
      if (AssertUtilities.IsNull(encoding))
      {
        throw new ArgumentNullException(nameof(encoding), SR.Format(nameof(Strings.ArgumentNullException_with_argument_name), nameof(encoding)));
      }

      return encoding.GetBytes(s);
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

    #endregion Methods
  }
}