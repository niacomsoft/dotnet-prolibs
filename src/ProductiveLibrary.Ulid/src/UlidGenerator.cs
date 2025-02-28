/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using NUlid;

namespace Niacomsoft.ProductiveLibrary
{
  /// <summary>
  ///   提供了生成 Ulid 类型标识符相关的方法。
  ///   <para> 密闭的，不能从此类型派生。 </para>
  /// </summary>
  /// <seealso cref="AsyncIDGenerator{T}" />
  /// <seealso cref="Ulid" />
  public sealed class UlidGenerator : AsyncIDGenerator<Ulid>
  {
    #region Methods

    /// <summary> 生成一个标识符。 </summary>
    /// <returns> <see cref="Ulid" /> 类型的标识符。 </returns>
    public override Ulid New()
    {
      return Ulid.NewUlid();
    }

    #endregion Methods
  }
}