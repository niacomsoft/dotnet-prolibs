/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using System;
using System.Diagnostics.CodeAnalysis;

namespace Niacomsoft.ProductiveLibrary.Utilities
{
  public static partial class AssertUtilities
  {
    #region Methods

    /// <summary>
    ///   当字符串 <paramref name="s" /> 等于 <see langword="null" /> 或 <see cref="string.Empty" /> 时，返回
    ///   <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </summary>
    /// <param name="s"> 字符串。 </param>
    /// <returns> <see cref="bool" /> 类型的值。 </returns>
    /// <seealso cref="string.IsNullOrEmpty(string)" />
    public static bool IsEmpty(string s)
    {
      return string.IsNullOrEmpty(s);
    }

    /// <summary>
    ///   当字符串 <paramref name="s" /> 等于 <see langword="null" />、 <see cref="string.Empty" />
    ///   或空格符时，返回 <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </summary>
    /// <param name="s"> 字符串。 </param>
    /// <returns> <see cref="bool" /> 类型的值。 </returns>
    /// <seealso cref="string.IsNullOrWhiteSpace(string)" />
    public static bool IsWhiteSpace(string s)
    {
      return string.IsNullOrWhiteSpace(s);
    }

    /// <summary>
    ///   当 <paramref name="s1" /> 与 <paramref name="s2" /> 近似相等 （忽略大小写的） 时，返回
    ///   <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </summary>
    /// <param name="s1"> 字符串。 </param>
    /// <param name="s2"> 字符串。 </param>
    /// <returns> <see cref="bool" /> 类型的值。 </returns>
    /// <seealso cref="string.Equals(string, string, StringComparison)" />
    /// <seealso cref="StringComparison" />
    /// <seealso cref="StringComparison.CurrentCultureIgnoreCase" />
    [SuppressMessage("Style", "IDE0046:转换为条件表达式", Justification = "<挂起>")]
    public static bool Like(string s1, string s2)
    {
      if (IsNull(s1) && IsNull(s2))
      {
        return true;
      }
      else if (IsNull(s1) || IsNull(s2))
      {
        return false;
      }
      else
      {
        return s1.Equals(s2, StringComparison.CurrentCultureIgnoreCase);
      }
    }

    /// <summary>
    ///   当字符串 <paramref name="s" /> 不等于 <see langword="null" /> 和 <see cref="string.Empty" /> 时，返回
    ///   <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </summary>
    /// <param name="s"> 字符串。 </param>
    /// <returns> <see cref="bool" /> 类型的值。 </returns>
    /// <seealso cref="string.IsNullOrEmpty(string)" />
    public static bool NotEmpty(string s)
    {
      return !string.IsNullOrEmpty(s);
    }

    /// <summary>
    ///   当字符串 <paramref name="s" /> 不等于 <see langword="null" />、 <see cref="string.Empty" />
    ///   和空格符时，返回 <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </summary>
    /// <param name="s"> 字符串。 </param>
    /// <returns> <see cref="bool" /> 类型的值。 </returns>
    /// <seealso cref="string.IsNullOrWhiteSpace(string)" />
    public static bool NotWhiteSpace(string s)
    {
      return !string.IsNullOrWhiteSpace(s);
    }

    #endregion Methods
  }
}