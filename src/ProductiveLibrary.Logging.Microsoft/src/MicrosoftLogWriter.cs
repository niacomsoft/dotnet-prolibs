/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using Microsoft.Extensions.Logging;

namespace Niacomsoft.ProductiveLibrary.Runtime.Diagnostics
{
  /// <summary> 提供了基于 <see cref="ILogger" /> 记录运行时诊断日志相关的方法。 </summary>
  /// <seealso cref="MicrosoftLogWriterBase" />
  public class MicrosoftLogWriter : MicrosoftLogWriterBase
  {
    #region Constructors

    /// <summary> 初始化 <see cref="MicrosoftLogWriter" /> 类的新实例。 </summary>
    /// <param name="logger">
    ///   记录运行时诊断日志的方法。
    ///   <para> 实现了 <see cref="ILogger" /> 类型接口的对象实例。 </para>
    /// </param>
    public MicrosoftLogWriter(ILogger logger) : base(logger)
    {
    }

    #endregion Constructors
  }

  /// <summary> 提供了基于 <see cref="ILogger{TCategoryName}" /> 记录运行时诊断日志相关的 </summary>
  /// <typeparam name="T"> 类型。 </typeparam>
  /// <seealso cref="MicrosoftLogWriterBase{T}" />
  public class MicrosoftLogWriter<T> : MicrosoftLogWriterBase<T>
  {
    #region Constructors

    /// <summary> 初始化 <see cref="MicrosoftLogWriter{T}" /> 类的新实例。 </summary>
    /// <param name="logger">
    ///   记录运行时诊断日志的方法。
    ///   <para> 实现了 <see cref="ILogger{TCategoryName}" /> 类型接口的对象实例。 </para>
    /// </param>
    public MicrosoftLogWriter(ILogger<T> logger) : base(logger)
    {
    }

    #endregion Constructors
  }
}