/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using Niacomsoft.ProductiveLibrary.Patterns;

using System;

namespace Niacomsoft.ProductiveLibrary.Runtime.Diagnostics
{
  #region Interfaces

  /// <summary>
  ///   提供了构建基于 <seealso cref="Microsoft.Extensions.Logging.ILogger" /> 记录运行时日志的服务的工厂方法接口。
  /// </summary>
  /// <seealso cref="IKnownTypeFactory{T1, TResult}" />
  /// <seealso cref="ILogWriterFactory" />
  public interface IMicrosoftLogWriterFactory : ILogWriterFactory, IKnownTypeFactory<string, ILogWriter>, IKnownTypeFactory<Type, ILogWriter>
  {
    #region Methods

    /// <summary> 创建记录运行时日志的方法。 </summary>
    /// <typeparam name="TCategoryName"> 标识日志类别名称的类型。 </typeparam>
    /// <returns> 实现了 <see cref="ILogWriter" /> 类型接口的对象实例。 </returns>
    ILogWriter CreateInstance<TCategoryName>();

    #endregion Methods
  }

  #endregion Interfaces
}