/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

#if NET6_0_OR_GREATER

using System;

namespace Niacomsoft.ProductiveLibrary.Utilities
{
  public static partial class StringUtilities
  {
    /// <summary> 获取字符串 <paramref name="s" /> 等效的 <see cref="DateOnly" /> 类型的值。 </summary>
    /// <param name="s"> 字符串。 </param>
    /// <returns> <see cref="DateOnly" /> 类型的值。 </returns>
    /// <exception cref="System.OverflowException">
    ///   当调用 <see cref="DateOnly.Parse(string)" /> 方法时，可能引发此类型的异常。
    /// </exception>
    public static DateOnly GetDate(string s)
    {
      return DateOnly.Parse(s);
    }

    /// <summary>
    ///   当调用 <see cref="TryGetDate(string, out DateOnly)" /> 返回 <see langword="false" /> 时，返回
    ///   <see langword="null" />，否则返回真实值。
    /// </summary>
    /// <param name="s"> 字符串。 </param>
    /// <returns> 可能为空的 <see cref="DateOnly" /> 类型值。 </returns>
    public static DateOnly? SafeGetDate(string s)
    {
      return TryGetDate(s, out DateOnly value) ? new DateOnly?(value) : null;
    }

    /// <summary>
    ///   当调用 <see cref="TryGetDate(string, out DateOnly)" /> 返回 <see langword="false" /> 时，返回
    ///   <paramref name="default" />，否则返回真实值。
    /// </summary>
    /// <param name="s"> 字符串。 </param>
    /// <param name="default">
    ///   当调用 <see cref="TryGetDate(string, out DateOnly)" /> 返回 <see langword="false" />
    ///   时需要返回的默认值。
    /// </param>
    /// <returns> <see cref="DateOnly" /> 类型的值。 </returns>
    public static DateOnly SafeGetDate(string s, DateOnly @default)
    {
      return TryGetDate(s, out DateOnly value) ? value : @default;
    }

    /// <summary>
    ///   尝试调用 <see cref="DateOnly.TryParse(string, out DateOnly)" /> 方法将字符串转换成等效的
    ///   <see cref="DateOnly" /> 类型的值。
    /// </summary>
    /// <param name="s"> 字符串。 </param>
    /// <param name="value"> <see cref="DateOnly" /> 类型的值。 </param>
    /// <returns> <see cref="DateOnly.TryParse(string, out DateOnly)" /> </returns>
    public static bool TryGetDate(string s, out DateOnly value)
    {
      return DateOnly.TryParse(s, out value);
    }
  }
}

#endif