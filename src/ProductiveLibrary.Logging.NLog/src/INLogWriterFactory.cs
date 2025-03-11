/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using Niacomsoft.ProductiveLibrary.Patterns;

namespace Niacomsoft.ProductiveLibrary.Runtime.Diagnostics
{
  #region Interfaces

  /// <summary> 提供了创建 <see cref="ILogWriter" /> 对象实例的工厂方法接口。 </summary>
  /// <seealso cref="IKnownTypeFactory{T1, TResult}" />
  /// <seealso cref="ILogWriter" />
  /// <seealso cref="ILogWriterFactory" />
  public interface INLogWriterFactory : ILogWriterFactory, IKnownTypeFactory<string, ILogWriter>
  {
  }

  #endregion Interfaces
}