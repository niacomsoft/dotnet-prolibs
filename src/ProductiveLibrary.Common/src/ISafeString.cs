/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

namespace Niacomsoft.ProductiveLibrary
{
  #region Interfaces

  /// <summary> 提供了安全字符串的接口。 </summary>
  /// <seealso cref="ISafeValue{T}" />
  public interface ISafeString : ISafeValue<string>
  {
    #region Methods

    /// <summary>
    ///   当字符串 <c> <see cref="ISafeString" />.Value </c> 等于 <see langword="null" /> 或
    ///   <see cref="string.Empty" /> 时返回 <paramref name="default" />。
    /// </summary>
    /// <param name="default">
    ///   当字符串 <c> <see cref="ISafeString" />.Value </c> 等于 <see langword="null" /> 或
    ///   <see cref="string.Empty" /> 时需要返回的默认值。
    /// </param>
    /// <returns> 字符串。 </returns>
    string GetDefaultIfEmpty(string @default);

    /// <summary>
    ///   当字符串 <c> <see cref="ISafeString" />.Value </c> 等于 <see langword="null" />、
    ///   <see cref="string.Empty" /> 或空格符时返回 <paramref name="default" />。
    /// </summary>
    /// <param name="default">
    ///   当字符串 <c> <see cref="ISafeString" />.Value </c> 等于 <see langword="null" />、
    ///   <see cref="string.Empty" /> 或空格符时需要返回的默认值。
    /// </param>
    /// <returns> 字符串。 </returns>
    string GetDefaultIfWhiteSpace(string @default);

    #endregion Methods
  }

  #endregion Interfaces
}