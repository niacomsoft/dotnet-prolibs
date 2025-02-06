/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

namespace Niacomsoft.ProductiveLibrary
{
  #region Enums

  /// <summary> 提供了日期时间精度的枚举类型。 </summary>
  public enum DateTimePrecision
  {
    /// <summary> 精确到年： <c> 1 </c> </summary>
    Year = 1,

    /// <summary> 精确到月： <c> 2 </c> </summary>
    Month = 2,

    /// <summary> 精确到天： <c> 3 </c> </summary>
    Day = 3,

    /// <summary> 精确到小时： <c> 4 </c> </summary>
    Hour = 4,

    /// <summary> 精确到分钟： <c> 5 </c> </summary>
    Minute = 5,

    /// <summary> 精确到秒： <c> 6 </c> </summary>
    Second = 6,

    /// <summary> 精确到毫秒： <c> 7 </c> </summary>
    Millisecond = 7,

    /// <summary> 默认值，等效于 <see cref="Second" />。 </summary>
    Default = Second
  }

  #endregion Enums
}