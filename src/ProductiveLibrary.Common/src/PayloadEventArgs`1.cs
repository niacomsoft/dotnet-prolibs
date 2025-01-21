/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

namespace Niacomsoft.ProductiveLibrary
{
  /// <summary> 提供了包含了 <typeparamref name="T" /> 类型的负载数据事件参数相关的基本方法。 </summary>
  /// <typeparam name="T"> 负载数据类型。 </typeparam>
  /// <seealso cref="PayloadEventArgs" />
  public class PayloadEventArgs<T> : PayloadEventArgs
  {
    #region Constructors

    /// <summary> 初始化 <see cref="PayloadEventArgs{T}" /> 类的新实例。 </summary>
    /// <param name="payload"> 事件负载数据。 </param>
    public PayloadEventArgs(T payload) : base(payload)
    {
      Payload = payload;
    }

    #endregion Constructors

    #region Properties

    /// <summary> 事件负载数据。 </summary>
    /// <value> 获取 <typeparamref name="T" /> 类型的值或对象实例，用于表示事件负载数据。 </value>
    public virtual new T Payload { get; }

    #endregion Properties
  }
}