/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using System;

namespace Niacomsoft.ProductiveLibrary
{
  #region Interfaces

  /// <summary> 提供了 <c> BASE-64 </c> 字符串编码的接口。 </summary>
  public interface IBase64StringEncoder
  {
    #region Methods

    /// <summary> 获取字节数组 <paramref name="input" /> 的 <c> BASE-64 </c> 字符串。 </summary>
    /// <param name="input"> 字节数组。 </param>
    /// <param name="startIndex"> 字节数组 <paramref name="input" /> 起始索引。 </param>
    /// <param name="length"> 字节数组 <paramref name="input" /> 长度。 </param>
    /// <param name="options"> <c> BASE-64 </c> 编码选项。 </param>
    /// <returns> <c> BASE-64 </c> 字符串。 </returns>
    /// <seealso cref="Base64FormattingOptions" />
    string Encode(byte[] input, int? startIndex = null, int? length = null, Base64FormattingOptions options = Base64FormattingOptions.None);

    #endregion Methods
  }

  #endregion Interfaces
}