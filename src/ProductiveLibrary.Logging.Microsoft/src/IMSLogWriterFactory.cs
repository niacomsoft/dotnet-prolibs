/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using Niacomsoft.ProductiveLibrary.Patterns;

using System;

namespace Niacomsoft.ProductiveLibrary.Runtime.Diagnostics
{
  #region Interfaces

  /// <summary> 提供了动态创建 <see cref="IMSLogWriter" /> 运行时诊断日志服务的工厂方法接口。 </summary>
  public interface IMSLogWriterFactory : ILogWriterFactory, IKnownTypeFactory<string, ILogWriter>, IKnownTypeFactory<Type, ILogWriter>
  {
    #region Methods

    /// <summary> 创建实现了 <see cref="ILogWriter" /> 类型接口的对象实例。 </summary>
    /// <typeparam name="TCategoryName"> 标识日志类别名称的类型。 </typeparam>
    /// <returns> 实现了 <see cref="ILogWriter" /> 类型接口的对象实例。 </returns>
    /// <seealso cref="ILogWriter" />
    /// <seealso cref="IMSLogWriter{TCategoryName}" />
    ILogWriter CreateInstance<TCategoryName>();

    #endregion Methods
  }

  #endregion Interfaces
}