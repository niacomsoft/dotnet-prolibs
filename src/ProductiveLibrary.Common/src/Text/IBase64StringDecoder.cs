/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

namespace Niacomsoft.ProductiveLibrary.Text
{
  #region Interfaces

  /// <summary> 提供了 <c> BASE-64 </c> 字符串解码的接口。 </summary>
  public interface IBase64StringDecoder
  {
    #region Methods

    /// <summary> 获取 <c> BASE-64 </c> 字符串 <paramref name="base64Str" /> 的字节数组。 </summary>
    /// <param name="base64Str"> <c> BASE-64 </c> 字符串。 </param>
    /// <returns> 字节数组。 </returns>
    byte[] GetBytes(string base64Str);

    #endregion Methods
  }

  #endregion Interfaces
}