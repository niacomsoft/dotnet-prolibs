/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

namespace Niacomsoft.ProductiveLibrary
{
  #region Interfaces

  /// <summary> 提供了生成 <c> Nano ID </c> 格式标识符的接口。 </summary>
  /// <seealso cref="IIDGenerator{T}" />
  public interface INanoIDGenerator : IIDGenerator<string>
  {
    #region Methods

    /// <summary> 生成新的 <c> Nano ID </c> 标识符。 </summary>
    /// <param name="options">
    ///   生成 <c> Nano ID </c> 标识符的配置选项。
    ///   <para> <see cref="NanoIdGenerateOptions" /> 类型的对象实例。 </para>
    /// </param>
    /// <returns> <c> Nano ID </c> 标识符。 </returns>
    /// <seealso cref="NanoIdGenerateOptions" />
    string New(NanoIdGenerateOptions options);

    #endregion Methods
  }

  #endregion Interfaces
}