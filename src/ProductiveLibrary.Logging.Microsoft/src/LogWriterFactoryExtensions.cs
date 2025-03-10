/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using System;

namespace Niacomsoft.ProductiveLibrary.Runtime.Diagnostics
{
  /// <summary> 为 <see cref="ILogWriterFactory" /> 类型提供了扩展方法。 </summary>
  public static class LogWriterFactoryExtensions
  {
    #region Methods

    /// <summary> 创建实现了 <see cref="ILogWriter" /> 类型接口的对象实例。 </summary>
    /// <typeparam name="TCategoryName"> 标识日志类别名称的类型。 </typeparam>
    /// <param name="factory"> 实现了 <see cref="ILogWriterFactory" /> 类型接口的对象实例。 </param>
    /// <returns> 实现了 <see cref="ILogWriter" /> 类型接口的对象实例。 </returns>
    /// <seealso cref="ILogWriter" />
    /// <seealso cref="IMSLogWriter{TCategoryName}" />
    public static ILogWriter CreateInstance<TCategoryName>(this ILogWriterFactory factory)
    {
      return (factory as IMSLogWriterFactory).CreateInstance<TCategoryName>();
    }

    /// <summary> 创建 <see cref="ILogWriter" /> 类型的对象实例。 </summary>
    /// <param name="factory"> 实现了 <see cref="ILogWriterFactory" /> 类型接口的对象实例。 </param>
    /// <param name="categoryName"> 标识诊断类别的名称。 </param>
    /// <returns> <see cref="ILogWriter" /> 类型的对象实例。 </returns>
    public static ILogWriter CreateInstance(this ILogWriterFactory factory, string categoryName)
    {
      return (factory as IMSLogWriterFactory).CreateInstance(categoryName);
    }

    /// <summary> 创建 <see cref="ILogWriter" /> 类型的对象实例。 </summary>
    /// <param name="factory"> 实现了 <see cref="ILogWriterFactory" /> 类型接口的对象实例。 </param>
    /// <param name="category"> 标识诊断日志类别的 <see cref="Type" /> 类型的对象实例。 </param>
    /// <returns> <see cref="ILogWriter" /> 类型的对象实例。 </returns>
    public static ILogWriter CreateInstance(this ILogWriterFactory factory, Type category)
    {
      return (factory as IMSLogWriterFactory).CreateInstance(category);
    }

    #endregion Methods
  }
}