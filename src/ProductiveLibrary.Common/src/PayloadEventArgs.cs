/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using System;

namespace Niacomsoft.ProductiveLibrary
{
  /// <summary> 提供了包含负载数据的事件参数相关的基本方法。 </summary>
  /// <seealso cref="EventArgs" />
  public class PayloadEventArgs : EventArgs
  {
    #region Constructors

    /// <summary> 初始化 <see cref="PayloadEventArgs" /> 类的新实例。 </summary>
    /// <param name="payload"> 事件负载数据。 </param>
    public PayloadEventArgs(object payload) => Payload = payload;

    #endregion Constructors

    #region Properties

    /// <summary> 事件负载数据。 </summary>
    /// <value> 获取 <see cref="object" /> 类型的值或对象实例，用于表示事件负载数据。 </value>
    public virtual object Payload { get; }

    #endregion Properties
  }
}