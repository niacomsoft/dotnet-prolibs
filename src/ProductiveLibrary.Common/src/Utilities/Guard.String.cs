/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

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

    #endregion Methods
  }
}