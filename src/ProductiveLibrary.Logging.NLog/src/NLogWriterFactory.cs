/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using Niacomsoft.ProductiveLibrary.Utilities;

using NLog;

namespace Niacomsoft.ProductiveLibrary.Runtime.Diagnostics
{
  /// <summary> 提供了创建 <see cref="ILogWriter" /> 对象实例的工厂方法相关的基本方法。 </summary>
  /// <seealso cref="INLogWriterFactory" />
  /// <seealso cref="LogWriterFactory" />
  public class NLogWriterFactory : LogWriterFactory, INLogWriterFactory
  {
    #region Methods

    /// <summary> 创建 <see cref="ILogWriter" /> 类型的对象实例。 </summary>
    /// <returns> <see cref="ILogWriter" /> 类型的对象实例。 </returns>
    public override ILogWriter CreateInstance()
    {
      return new NLogWriter(LogManager.GetCurrentClassLogger());
    }

    /// <summary> 创建 <see cref="ILogWriter" /> 类型的对象实例。 </summary>
    /// <param name="args"> 未知类型的参数数组。 </param>
    /// <returns> <see cref="ILogWriter" /> 类型的对象实例。 </returns>
    public override ILogWriter CreateInstance(params object[] args)
    {
      if (AssertUtilities.IsEmptyArray(args) || !AssertUtilities.InstanceOf<string>(args[0]))
      {
        return CreateInstance();
      }

      return CreateInstance(args[0] as string);
    }

    /// <summary> 创建 <see cref="ILogWriter" /><see cref="ILogWriter" /> 类型的对象实例。 </summary>
    /// <param name="loggerName"> NLog 日志服务标识名称。 </param>
    /// <returns> <see cref="ILogWriter" /> 类型的对象实例。 </returns>
    public virtual ILogWriter CreateInstance(string loggerName)
    {
      return new NLogWriter(LogManager.GetLogger(loggerName));
    }

    #endregion Methods
  }
}