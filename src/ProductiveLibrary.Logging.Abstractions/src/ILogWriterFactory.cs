/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using Niacomsoft.ProductiveLibrary.Patterns;

namespace Niacomsoft.ProductiveLibrary.Runtime.Diagnostics
{
  #region Interfaces

  /// <summary> 提供了创建实现了 <see cref="ILogWriter" /> 类型接口的对象实例的工厂方法接口。 </summary>
  /// <seealso cref="IKnownTypeFactory{TResult}" />
  /// <seealso cref="ILogWriter" />
  /// <seealso cref="IUnknownTypeFactory{TResult}" />
  public interface ILogWriterFactory : IKnownTypeFactory<ILogWriter>, IUnknownTypeFactory<ILogWriter>
  {
  }

  #endregion Interfaces
}