/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

namespace Niacomsoft.ProductiveLibrary.Runtime.Diagnostics
{
  /// <summary> 为 <see cref="ILogWriterFactory" /> 类型提供了扩展方法。 </summary>
  public static class NLogWriterFactoryExtensions
  {
    #region Methods

    /// <summary> 创建 <see cref="ILogWriter" /><see cref="ILogWriter" /> 类型的对象实例。 </summary>
    /// <param name="factory"> 实现了 <see cref="ILogWriterFactory" /> 类型接口的对象实例。 </param>
    /// <param name="loggerName"> NLog 日志服务标识名称。 </param>
    /// <returns> <see cref="ILogWriter" /> 类型的对象实例。 </returns>
    public static ILogWriter CreateInstance(this ILogWriterFactory factory, string loggerName)
    {
      return (factory as INLogWriterFactory).CreateInstance(loggerName);
    }

    #endregion Methods
  }
}