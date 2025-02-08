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
    /// <summary> 获取字符串 <paramref name="s" /> 等效的 <see cref="TimeOnly" /> 类型的值。 </summary>
    /// <param name="s"> 字符串。 </param>
    /// <returns> <see cref="TimeOnly" /> 类型的值。 </returns>
    /// <exception cref="System.OverflowException">
    ///   当调用 <see cref="TimeOnly.Parse(string)" /> 方法时，可能引发此类型的异常。
    /// </exception>
    public static TimeOnly GetTime(string s)
    {
      return TimeOnly.Parse(s);
    }

    /// <summary>
    ///   当调用 <see cref="TryGetTime(string, out TimeOnly)" /> 返回 <see langword="false" /> 时，返回
    ///   <see langword="null" />，否则返回真实值。
    /// </summary>
    /// <param name="s"> 字符串。 </param>
    /// <returns> 可能为空的 <see cref="TimeOnly" /> 类型值。 </returns>
    public static TimeOnly? SafeGetTime(string s)
    {
      return TryGetTime(s, out TimeOnly value) ? new TimeOnly?(value) : null;
    }

    /// <summary>
    ///   当调用 <see cref="TryGetTime(string, out TimeOnly)" /> 返回 <see langword="false" /> 时，返回
    ///   <paramref name="default" />，否则返回真实值。
    /// </summary>
    /// <param name="s"> 字符串。 </param>
    /// <param name="default">
    ///   当调用 <see cref="TryGetTime(string, out TimeOnly)" /> 返回 <see langword="false" />
    ///   时需要返回的默认值。
    /// </param>
    /// <returns> <see cref="TimeOnly" /> 类型的值。 </returns>
    public static TimeOnly SafeGetTime(string s, TimeOnly @default)
    {
      return TryGetTime(s, out TimeOnly value) ? value : @default;
    }

    /// <summary>
    ///   尝试调用 <see cref="TimeOnly.TryParse(string, out TimeOnly)" /> 方法将字符串转换成等效的
    ///   <see cref="TimeOnly" /> 类型的值。
    /// </summary>
    /// <param name="s"> 字符串。 </param>
    /// <param name="value"> <see cref="TimeOnly" /> 类型的值。 </param>
    /// <returns> <see cref="TimeOnly.TryParse(string, out TimeOnly)" /> </returns>
    public static bool TryGetTime(string s, out TimeOnly value)
    {
      return TimeOnly.TryParse(s, out value);
    }
  }
}

#endif