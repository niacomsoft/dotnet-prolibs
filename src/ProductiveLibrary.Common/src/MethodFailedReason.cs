/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using System;

namespace Niacomsoft.ProductiveLibrary
{
  #region Enums

  /// <summary> 提供了方法执行失败原因的枚举类型。 </summary>
  [Flags]
  public enum MethodFailedReason
  {
    /// <summary> 无原因 <c> 0 </c>。 </summary>
    None = 0,

    /// <summary> 内部抛出的异常 <c> 1 </c>。 </summary>
    Exception = 1,

    /// <summary> 预期之外的参数 <c> 2 </c>。 </summary>
    UnexpectedParameter = 2,

    /// <summary> 预期之外的结果值 <c> 4 </c>。 </summary>
    UnexpectedResult = 4,

    /// <summary> 远程服务无响应 <c> 8 </c>。 </summary>
    RemoteServiceUnresponsive = 8,

    /// <summary> 不可用的远程服务 <c> 16 </c>。 </summary>
    RemoteServiceUnavailable = 0x10,

    /// <summary> 未知的原因 <c> 32 </c>。 </summary>
    Unknown = 0x20
  }

  #endregion Enums
}