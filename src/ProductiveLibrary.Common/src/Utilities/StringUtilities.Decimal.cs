/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

namespace Niacomsoft.ProductiveLibrary.Utilities
{
  public static partial class StringUtilities
  {
    #region Methods

    /// <summary> 获取字符串 <paramref name="s" /> 等效的 <see cref="decimal" /> 类型的值。 </summary>
    /// <param name="s"> 字符串。 </param>
    /// <returns> <see cref="decimal" /> 类型的值。 </returns>
    /// <exception cref="System.OverflowException">
    ///   当调用 <see cref="decimal.Parse(string)" /> 方法时，可能引发此类型的异常。
    /// </exception>
    public static decimal GetDecimal(string s)
    {
      return decimal.Parse(s);
    }

    /// <summary>
    ///   当调用 <see cref="TryGetDecimal(string, out decimal)" /> 返回 <see langword="false" /> 时，返回
    ///   <see langword="null" />，否则返回真实值。
    /// </summary>
    /// <param name="s"> 字符串。 </param>
    /// <returns> 可能为空的 <see cref="decimal" /> 类型值。 </returns>
    public static decimal? SafeGetDecimal(string s)
    {
      return TryGetDecimal(s, out decimal value) ? new decimal?(value) : null;
    }

    /// <summary>
    ///   当调用 <see cref="TryGetDecimal(string, out decimal)" /> 返回 <see langword="false" /> 时，返回
    ///   <paramref name="default" />，否则返回真实值。
    /// </summary>
    /// <param name="s"> 字符串。 </param>
    /// <param name="default">
    ///   当调用 <see cref="TryGetDecimal(string, out decimal)" /> 返回 <see langword="false" />
    ///   时需要返回的默认值。
    /// </param>
    /// <returns> <see cref="decimal" /> 类型的值。 </returns>
    public static decimal SafeGetDecimal(string s, decimal @default)
    {
      return TryGetDecimal(s, out decimal value) ? value : @default;
    }

    /// <summary>
    ///   尝试调用 <see cref="decimal.TryParse(string, out decimal)" /> 方法将字符串转换成等效的
    ///   <see cref="decimal" /> 类型的值。
    /// </summary>
    /// <param name="s"> 字符串。 </param>
    /// <param name="value"> <see cref="decimal" /> 类型的值。 </param>
    /// <returns> <see cref="decimal.TryParse(string, out decimal)" /> </returns>
    public static bool TryGetDecimal(string s, out decimal value)
    {
      return decimal.TryParse(s, out value);
    }

    #endregion Methods
  }
}