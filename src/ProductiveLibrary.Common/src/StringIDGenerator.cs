/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using System;

namespace Niacomsoft.ProductiveLibrary
{
  /// <summary> 提供了生成字符串类型标识符相关的基本方法。 </summary>
  /// <seealso cref="AsyncIDGenerator{T}" />
  public class StringIDGenerator : AsyncIDGenerator<string>
  {
    #region Methods

    /// <summary> 生成一个标识符。 </summary>
    /// <returns> <see cref="string" /> 类型的标识符。 </returns>
    public override string New()
    {
      return $"UID:{Guid.NewGuid().ToString().Replace("-", "")}";
    }

    #endregion Methods
  }
}