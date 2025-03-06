/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

namespace Niacomsoft.ProductiveLibrary.Runtime.Diagnostics
{
  #region Interfaces

  /// <summary> 提供了记录运行时诊断日志的接口。 </summary>
  /// <typeparam name="T"> 类型。 </typeparam>
  /// <seealso cref="ILogWriter" />
  public interface ILogWriter<T> : ILogWriter
  {
  }

  #endregion Interfaces
}