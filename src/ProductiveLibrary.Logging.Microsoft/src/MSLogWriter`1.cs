/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using Microsoft.Extensions.Logging;

namespace Niacomsoft.ProductiveLibrary.Runtime.Diagnostics
{
  /// <summary> 提供了基于记录运行时诊断日志相关的基本方法。 </summary>
  /// <typeparam name="TCategoryName"> 标识日志类别的类型。 </typeparam>
  /// <seealso cref="IMSLogWriter{TCategoryName}" />
  /// <seealso cref="MSLogWriter" />
  public class MSLogWriter<TCategoryName> : MSLogWriter, IMSLogWriter<TCategoryName>
  {
    #region Constructors

    /// <summary> 初始化 <see cref="MSLogWriter{TCategoryName}" /> 类的新实例。 </summary>
    /// <param name="logger"> 实现了 <see cref="ILogger{TCategoryName}" /> 类型接口的对象实例。 </param>
    public MSLogWriter(ILogger<TCategoryName> logger) : base(logger)
    {
    }

    #endregion Constructors
  }
}