/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

namespace Niacomsoft.ProductiveLibrary
{
  /// <summary> 提供了生成标识符相关的抽象 <see langword="abstract" /> 方法。 </summary>
  /// <typeparam name="T"> 标识符类型。 </typeparam>
  /// <seealso cref="IIDGenerator{T}" />
  public abstract class IDGenerator<T> : IIDGenerator<T>
  {
    #region Methods

    /// <inheritdoc />
    public abstract T New();

    #endregion Methods
  }
}