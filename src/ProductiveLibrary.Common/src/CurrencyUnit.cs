/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

namespace Niacomsoft.ProductiveLibrary
{
  #region Enums

  /// <summary> 提供了货币单位的枚举类型。 </summary>
  public enum CurrencyUnit
  {
    /// <summary> 表示 “元” <c> 100 </c>。 </summary>
    Yuan = 0x64,

    /// <summary> 表示 “角” <c> 10 </c>。 </summary>
    Jiao = 0xA,

    /// <summary> 表示 “分” <c> 1 </c>。 </summary>
    Cent = 1,

    /// <summary> 默认的货币单位，等效于 <see cref="Yuan" />。 </summary>
    Default = Yuan
  }

  #endregion Enums
}