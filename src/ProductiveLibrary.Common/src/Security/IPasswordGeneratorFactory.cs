/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using Niacomsoft.ProductiveLibrary.Patterns;

namespace Niacomsoft.ProductiveLibrary.Security
{
  #region Interfaces

  /// <summary> 提供了创建密码生成器实例的工厂方法接口。 </summary>
  /// <seealso cref="IKnownTypeFactory{TResult}" />
  /// <seealso cref="IPasswordGenerator" />
  public interface IPasswordGeneratorFactory : IKnownTypeFactory<IPasswordGenerator>
  {
  }

  #endregion Interfaces
}