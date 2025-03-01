/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

namespace Niacomsoft.ProductiveLibrary.Runtime.Diagnostics
{
  /// <summary>
  ///   提供了构建实现了 <see cref="ILogWriter" /> 类型接口的对象实例相关的抽象 <see langword="abstract" /> 方法。
  /// </summary>
  public abstract class LogWriterFactory : ILogWriterFactory
  {
    #region Methods

    /// <summary> 创建 <see cref="ILogWriter" /> 类型的对象实例。 </summary>
    /// <returns> <see cref="ILogWriter" /> 类型的对象实例。 </returns>
    public abstract ILogWriter CreateInstance();

    /// <summary> 创建 <see cref="ILogWriter" /> 类型的对象实例。 </summary>
    /// <param name="args"> 未知类型的参数数组。 </param>
    /// <returns> <see cref="ILogWriter" /> 类型的对象实例。 </returns>
    public abstract ILogWriter CreateInstance(params object[] args);

    #endregion Methods
  }
}