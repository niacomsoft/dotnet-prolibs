/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

namespace Niacomsoft.ProductiveLibrary.Utilities
{
  public static partial class StringUtilities
  {
    #region Methods

    /// <summary> 获取字符串 <paramref name="s" /> 等效的 <see cref="long" /> 类型的值。 </summary>
    /// <param name="s"> 字符串。 </param>
    /// <returns> <see cref="long" /> 类型的值。 </returns>
    /// <exception cref="System.OverflowException">
    ///   当调用 <see cref="long.Parse(string)" /> 方法时，可能引发此类型的异常。
    /// </exception>
    public static long GetInt64(string s)
    {
      return long.Parse(s);
    }

    /// <summary>
    ///   当调用 <see cref="TryGetInt64(string, out long)" /> 返回 <see langword="false" /> 时，返回
    ///   <see langword="null" />，否则返回真实值。
    /// </summary>
    /// <param name="s"> 字符串。 </param>
    /// <returns> 可能为空的 <see cref="long" /> 类型值。 </returns>
    public static long? SafeGetInt64(string s)
    {
      return TryGetInt64(s, out long value) ? new long?(value) : null;
    }

    /// <summary>
    ///   当调用 <see cref="TryGetInt64(string, out long)" /> 返回 <see langword="false" /> 时，返回
    ///   <paramref name="default" />，否则返回真实值。
    /// </summary>
    /// <param name="s"> 字符串。 </param>
    /// <param name="default">
    ///   当调用 <see cref="TryGetInt64(string, out long)" /> 返回 <see langword="false" /> 时需要返回的默认值。
    /// </param>
    /// <returns> <see cref="long" /> 类型的值。 </returns>
    public static long SafeGetInt64(string s, long @default)
    {
      return TryGetInt64(s, out long value) ? value : @default;
    }

    /// <summary>
    ///   尝试调用 <see cref="long.TryParse(string, out long)" /> 方法将字符串转换成等效的 <see cref="long" /> 类型的值。
    /// </summary>
    /// <param name="s"> 字符串。 </param>
    /// <param name="value"> <see cref="long" /> 类型的值。 </param>
    /// <returns> <see cref="long.TryParse(string, out long)" /> </returns>
    public static bool TryGetInt64(string s, out long value)
    {
      return long.TryParse(s, out value);
    }

    #endregion Methods
  }
}