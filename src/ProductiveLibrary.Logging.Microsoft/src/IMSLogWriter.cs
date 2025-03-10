/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using Microsoft.Extensions.Logging;

namespace Niacomsoft.ProductiveLibrary.Runtime.Diagnostics
{
  #region Interfaces

  /// <summary> 提供了基于 <see cref="ILogger" /> 记录运行时诊断日志的接口。 </summary>
  /// <seealso cref="ILogWriter" />
  public interface IMSLogWriter : ILogWriter
  {
    #region Properties

    /// <summary> 记录运行时诊断日志的服务实例。 </summary>
    /// <value> 获取 <see cref="ILogger" /> 类型的对象实例，用于表示记录运行时诊断日志的服务实例。 </value>
    /// <seealso cref="ILogger" />
    ILogger Logger { get; }

    #endregion Properties
  }

  #endregion Interfaces
}