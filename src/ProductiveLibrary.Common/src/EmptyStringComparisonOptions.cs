/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using System;

namespace Niacomsoft.ProductiveLibrary
{
  #region Enums

  /// <summary> 提供了空字符串比较选项的枚举类型。 </summary>
  [Serializable]
  public enum EmptyStringComparisonOptions
  {
    /// <summary> 比较 <see langword="null" /> 值（ <c> 值：1 </c>）。 </summary>
    OnlyNull = 1,

    /// <summary> 比较 <see langword="null" /> 和空字符串（ <c> 值：2 </c>）。 </summary>
    NullOrEmpty = 2,

    /// <summary> 比较 <see langword="null" /> 、空字符串和空白符（ <c> 值：3 </c>）。 </summary>
    NullOrWhiteSpace = 3
  }

  #endregion Enums
}