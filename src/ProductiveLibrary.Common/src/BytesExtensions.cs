/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using System;

namespace Niacomsoft.ProductiveLibrary
{
  /// <summary> 为 <see cref="byte" /> 类型数组提供了扩展方法。 </summary>
  public static class BytesExtensions
  {
    #region Methods

    /// <summary> 将字节数组 <paramref name="me" /> 转换为 <c> BASE-64 </c> 字符串。 </summary>
    /// <param name="me"> 字节数组。 </param>
    /// <param name="startIndex"> 字节数组 <paramref name="me" /> 起始索引。 </param>
    /// <param name="length"> 字节数组 <paramref name="me" /> 长度。 </param>
    /// <param name="options"> <see cref="Base64FormattingOptions" /> 枚举类型中的一个值。 </param>
    /// <returns> <c> BASE-64 </c> 字符串。 </returns>
    /// <seealso cref="Base64FormattingOptions" />
    /// <seealso cref="Base64StringFormatter" />
    /// <seealso cref="IBase64StringEncoder" />
    public static string ToBase64String(this byte[] me, int? startIndex = null, int? length = null, Base64FormattingOptions options = Base64FormattingOptions.None)
    {
      return Base64StringFormatter.Encoder.Encode(me, startIndex, length, options);
    }

    #endregion Methods
  }
}