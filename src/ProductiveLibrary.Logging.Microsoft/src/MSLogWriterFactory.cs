/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using Microsoft.Extensions.Logging;

using Niacomsoft.ProductiveLibrary.Utilities;

using System;

namespace Niacomsoft.ProductiveLibrary.Runtime.Diagnostics
{
  /// <summary> 提供了创建 <see cref="ILogWriter" /> 记录运行时诊断日志的工厂方法。 </summary>
  /// <seealso cref="IMSLogWriterFactory" />
  /// <seealso cref="LogWriterFactory" />
  public class MSLogWriterFactory : LogWriterFactory, IMSLogWriterFactory
  {
    #region Constructors

    /// <summary> 初始化 <see cref="MSLogWriterFactory" /> 类的新实例。 </summary>
    /// <param name="loggerFactory"> 实现了 <see cref="ILoggerFactory" /> 类型接口的对象实例。 </param>
    public MSLogWriterFactory(ILoggerFactory loggerFactory)
    {
      LoggerFactory = loggerFactory;
    }

    #endregion Constructors

    #region Properties

    /// <summary> .NET 框架默认提供的 <see cref="ILoggerFactory" />。 </summary>
    /// <value> 获取 <see cref="ILoggerFactory" /> 类型的对象实例，用于表示 .NET 框架默认提供的工厂方法。 </value>
    /// <seealso cref="ILoggerFactory" />
    protected virtual ILoggerFactory LoggerFactory { get; }

    #endregion Properties

    #region Methods

    /// <summary> 创建 <see cref="ILogWriter" /> 类型的对象实例。 </summary>
    /// <returns> <see cref="ILogWriter" /> 类型的对象实例。 </returns>
    public override ILogWriter CreateInstance()
    {
      return CreateInstance(typeof(MSLogWriter));
    }

    /// <summary> 创建实现了 <see cref="ILogWriter" /> 类型接口的对象实例。 </summary>
    /// <typeparam name="TCategoryName"> 标识日志类别名称的类型。 </typeparam>
    /// <returns> 实现了 <see cref="ILogWriter" /> 类型接口的对象实例。 </returns>
    /// <seealso cref="ILogWriter" />
    /// <seealso cref="IMSLogWriter{TCategoryName}" />
    public virtual ILogWriter CreateInstance<TCategoryName>()
    {
      return new MSLogWriter<TCategoryName>(LoggerFactory.CreateLogger<TCategoryName>());
    }

    /// <summary> 创建 <see cref="ILogWriter" /> 类型的对象实例。 </summary>
    /// <param name="args"> 未知类型的参数数组。 </param>
    /// <returns> <see cref="ILogWriter" /> 类型的对象实例。 </returns>
    public override ILogWriter CreateInstance(params object[] args)
    {
      if (AssertUtilities.IsEmptyArray(args) || (!AssertUtilities.InstanceOf<string>(args[0]) && !AssertUtilities.InstanceOf<Type>(args[0])))
      {
        return CreateInstance();
      }
      if (AssertUtilities.InstanceOf<string>(args[0]))
      {
        return CreateInstance(LoggerFactory.CreateLogger(args[0] as string));
      }
      return CreateInstance(LoggerFactory.CreateLogger(args[0] as Type));
    }

    /// <summary> 创建 <see cref="ILogWriter" /> 类型的对象实例。 </summary>
    /// <param name="categoryName"> 标识诊断类别的名称。 </param>
    /// <returns> <see cref="ILogWriter" /> 类型的对象实例。 </returns>
    public virtual ILogWriter CreateInstance(string categoryName)
    {
      return CreateInstance(categoryName);
    }

    /// <summary> 创建 <see cref="ILogWriter" /> 类型的对象实例。 </summary>
    /// <param name="category"> 标识诊断日志类别的 <see cref="Type" /> 类型的对象实例。 </param>
    /// <returns> <see cref="ILogWriter" /> 类型的对象实例。 </returns>
    public virtual ILogWriter CreateInstance(Type category)
    {
      return CreateInstance(category);
    }

    #endregion Methods
  }
}