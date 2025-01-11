/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

namespace Niacomsoft.ProductiveLibrary.Utilities
{
  /// <summary> 提供了字符串辅助方法相关的静态 <see langword="static" /> 方法。 </summary>
  public static class StringUtilities
  {
    #region Methods

    /// <summary> 比较字符串 <paramref name="s" /> 是否为空。 </summary>
    /// <param name="s"> 需要校验的字符串。 </param>
    /// <param name="options">
    ///   空字符串比较选项。
    ///   <para> <see cref="EmptyStringComparisonOptions" /> 枚举类型中的一个值。 </para>
    ///   <para>
    ///     当 <paramref name="options" /> == <see cref="EmptyStringComparisonOptions.OnlyNull" />：当 <paramref name="s" /> 等于
    ///     <see langword="null" /> 时，返回 <see langword="true" />；否则返回 <see langword="false" /> 。
    ///   </para>
    ///   <para>
    ///     当 <paramref name="options" /> == <see cref="EmptyStringComparisonOptions.NullOrEmpty" />：当字符串 <paramref name="s" />
    ///     等于 <see langword="null" /> 或 <see cref="string.Empty" /> 时，返回 <see langword="true" />；否则返回 <see langword="false" />
    ///     。
    ///   </para>
    ///   <para>
    ///     当 <paramref name="options" /> == <see cref="EmptyStringComparisonOptions.NullOrWhiteSpace" />：当字符串
    ///     <paramref name="s" /> 等于 <see langword="null" />、 <see cref="string.Empty" /> 或空格符时，返回 <see langword="true" />；否则返回
    ///     <see langword="false" /> 。
    ///   </para>
    /// </param>
    /// <returns> <see langword="true" /> 或 <see langword="false" /> </returns>
    public static bool IsEmpty(string s, EmptyStringComparisonOptions options = EmptyStringComparisonOptions.NullOrWhiteSpace)
    {
      if (options == EmptyStringComparisonOptions.OnlyNull)
        return ObjectUtilities.IsNull(s);
      else if (options == EmptyStringComparisonOptions.NullOrEmpty)
        return string.IsNullOrEmpty(s);
      return string.IsNullOrWhiteSpace(s);
    }

    #endregion Methods
  }
}