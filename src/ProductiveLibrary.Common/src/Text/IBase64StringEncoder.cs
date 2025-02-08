/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using Niacomsoft.ProductiveLibrary.IO;

using System;

namespace Niacomsoft.ProductiveLibrary.Text
{
  #region Interfaces

  /// <summary> 提供了 <c> BASE-64 </c> 字符串编码的接口。 </summary>
  public interface IBase64StringEncoder
  {
    #region Methods

    /// <summary> 格式化字节数组为 <c> BASE-64 </c> 字符串。 </summary>
    /// <param name="input"> 字节数组。 </param>
    /// <param name="options">
    ///   格式化配置选项。
    ///   <para> <see cref="Base64FormattingOptions" /> 枚举类型中的一个值。 </para>
    /// </param>
    /// <param name="offset"> 字节数组偏移量。 </param>
    /// <param name="length"> 字节数组长度。 </param>
    /// <returns> <c> BASE-64 </c> 字符串。 </returns>
    /// <seealso cref="Base64FormattingOptions" />
    string GetString(byte[] input, Base64FormattingOptions options = Base64FormattingOptions.None, int? offset = null, int? length = null);

    /// <summary> 格式化字节数组为 <c> BASE-64 </c> 字符串。 </summary>
    /// <param name="input"> 字节数组。 </param>
    /// <param name="options">
    ///   格式化配置选项。
    ///   <para> <see cref="Base64FormattingOptions" /> 枚举类型中的一个值。 </para>
    /// </param>
    /// <returns> <c> BASE-64 </c> 字符串。 </returns>
    /// <seealso cref="Base64FormattingOptions" />
    /// <seealso cref="Bytes" />
    string GetString(Bytes input, Base64FormattingOptions options = Base64FormattingOptions.None);

    #endregion Methods
  }

  #endregion Interfaces
}