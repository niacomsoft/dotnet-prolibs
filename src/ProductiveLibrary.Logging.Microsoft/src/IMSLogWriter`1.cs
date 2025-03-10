/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using Microsoft.Extensions.Logging;

namespace Niacomsoft.ProductiveLibrary.Runtime.Diagnostics
{
  #region Interfaces

  /// <summary> 提供了基于 <see cref="ILogger" /> 记录运行时诊断日志的接口。 </summary>
  /// <typeparam name="TCategoryName"> 标识日志类别类型。 </typeparam>
  /// <seealso cref="IMSLogWriter" />
  public interface IMSLogWriter<TCategoryName> : IMSLogWriter
  {
  }

  #endregion Interfaces
}