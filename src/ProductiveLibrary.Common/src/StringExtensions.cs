/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

namespace Niacomsoft.ProductiveLibrary
{
  /// <summary> 为 <see cref="string" /> 类型提供了扩展方法。 </summary>
  public static class StringExtensions
  {
    #region Methods

    /// <summary> 将 <c> BASE-64 </c> 字符串转换为字节数组。 </summary>
    /// <param name="me"> <c> BASE-64 </c> 字符串。 </param>
    /// <returns> 字节数组。 </returns>
    /// <seealso cref="Base64StringFormatter" />
    /// <seealso cref="IBase64StringDecoder" />
    public static byte[] FromBase64String(this string me) => Base64StringFormatter.Decoder.Decode(me);

    /// <summary> 获取字符串 <paramref name="me" /> 等效的安全字符串。 </summary>
    /// <param name="me"> 字符串。 </param>
    /// <returns> <see cref="SafeString" /> 类型的值。 </returns>
    /// <seealso cref="SafeString" />
    public static SafeString GetSafeString(this string me) => new SafeString(me);

    /// <summary>
    ///   当字符串 <paramref name="me" /> 等于 <see langword="null" /> 或 <see cref="string.Empty" /> 时，返回
    ///   <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </summary>
    /// <param name="me"> 需要校验的字符串。 </param>
    /// <returns>
    ///   当字符串 <paramref name="me" /> 等于 <see langword="null" /> 或 <see cref="string.Empty" /> 时，返回
    ///   <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </returns>
    /// <seealso cref="string.IsNullOrEmpty(string)" />
    public static bool IsEmpty(this string me) => string.IsNullOrEmpty(me);

    /// <summary>
    ///   当字符串 <paramref name="me" /> 等于 <see langword="null" />、 <see cref="string.Empty" />
    ///   或空格符时，返回 <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </summary>
    /// <param name="me"> 需要校验的字符串。 </param>
    /// <returns>
    ///   当字符串 <paramref name="me" /> 等于 <see langword="null" />、 <see cref="string.Empty" />
    ///   或空格符时，返回 <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </returns>
    /// <seealso cref="string.IsNullOrWhiteSpace(string)" />
    public static bool IsWhiteSpace(this string me) => string.IsNullOrWhiteSpace(me);

    /// <summary>
    ///   当字符串 <paramref name="me" /> 等于 <see langword="null" /> 或 <see cref="string.Empty" /> 时，返回
    ///   <see langword="false" />；否则返回 <see langword="true" /> 。
    /// </summary>
    /// <param name="me"> 需要校验的字符串。 </param>
    /// <returns>
    ///   当字符串 <paramref name="me" /> 等于 <see langword="null" /> 或 <see cref="string.Empty" /> 时，返回
    ///   <see langword="false" />；否则返回 <see langword="true" /> 。
    /// </returns>
    public static bool NotEmpty(this string me) => !me.IsEmpty();

    /// <summary>
    ///   当字符串 <paramref name="me" /> 等于 <see langword="null" />、 <see cref="string.Empty" />
    ///   或空格符时，返回 <see langword="false" />；否则返回 <see langword="true" /> 。
    /// </summary>
    /// <param name="me"> 需要校验的字符串。 </param>
    /// <returns>
    ///   当字符串 <paramref name="me" /> 等于 <see langword="null" />、 <see cref="string.Empty" />
    ///   或空格符时，返回 <see langword="false" />；否则返回 <see langword="true" /> 。
    /// </returns>
    public static bool NotWhiteSpace(this string me) => !me.IsWhiteSpace();

    #endregion Methods
  }
}