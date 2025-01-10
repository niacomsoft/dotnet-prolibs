/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using System;

namespace Niacomsoft.ProductiveLibrary.Diagnostics
{
  #region Enums

  /// <summary> 提供了诊断级别的枚举类型。 </summary>
  [Serializable]
  public enum DiagnosticsLevel
  {
    /// <summary> 追踪级 ( <c> 值：0 </c>)。 </summary>
    Trace = 0,

    /// <summary> 调试级 ( <c> 值：1 </c>)。 </summary>
    Debug = 1,

    /// <summary> 信息级 ( <c> 值：2 </c>)。 </summary>
    Information = 2,

    /// <summary> 警告级 ( <c> 值：3 </c>)。 </summary>
    Warning = 3,

    /// <summary> 错误级 ( <c> 值：4 </c>)。 </summary>
    Error = 4,

    /// <summary> 危急的 ( <c> 值：5 </c>)。 </summary>
    Critical = 5
  }

  #endregion Enums
}