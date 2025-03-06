/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using Microsoft.Extensions.Logging;

using Niacomsoft.ProductiveLibrary.Utilities;

using System;

namespace Niacomsoft.ProductiveLibrary.Runtime.Diagnostics
{
  /// <summary> 提供了构建 <see cref="ILogWriter" /> 类型的对象实例相关的工厂方法。 </summary>
  /// <seealso cref="LogWriterFactory" />
  public class MicrosoftLogWriterFactory : LogWriterFactory
  {
    #region Constructors

    /// <summary> 初始化 <see cref="MicrosoftLogWriterFactory" /> 类的新实例。 </summary>
    /// <param name="loggerFactory"> 实现了 <see cref="ILoggerFactory" /> 类型接口的对象实例。 </param>
    public MicrosoftLogWriterFactory(ILoggerFactory loggerFactory)
    {
      LoggerFactory = loggerFactory;
    }

    #endregion Constructors

    #region Properties

    /// <summary> 创建 <see cref="ILogger" /> 的工厂方法。 </summary>
    /// <value>
    ///   获取 <see cref="ILoggerFactory" /> 类型的对象实例，用于表示创建 <see cref="ILogger" /> 的工厂方法。
    /// </value>
    /// <seealso cref="ILoggerFactory" />
    protected virtual ILoggerFactory LoggerFactory { get; }

    #endregion Properties

    #region Methods

    /// <inheritdoc />
    public override ILogWriter CreateInstance()
    {
      return new MicrosoftLogWriter(LoggerFactory.CreateLogger<MicrosoftLogWriterFactory>());
    }

    /// <inheritdoc />
    public override ILogWriter CreateInstance(params object[] args)
    {
      if (AssertUtilities.IsEmptyArray(args) || (!AssertUtilities.InstanceOf<Type>(args[0]) && !AssertUtilities.InstanceOf<string>(args[0])))
      {
        return CreateInstance();
      }

      return new MicrosoftLogWriter(AssertUtilities.InstanceOf<Type>(args[0]) ? LoggerFactory.CreateLogger(args[0] as Type) : LoggerFactory.CreateLogger(args[0] as string));
    }

    #endregion Methods
  }
}