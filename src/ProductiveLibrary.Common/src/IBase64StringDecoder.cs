/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

namespace Niacomsoft.ProductiveLibrary
{
  #region Interfaces

  /// <summary> 提供了从 <c> BASE-64 </c> 字符串解码的接口。 </summary>
  public interface IBase64StringDecoder
  {
    #region Methods

    /// <summary> 从 <c> BASE-64 </c> 字符串解码获取字节数组。 </summary>
    /// <param name="base64Str"> <c> BASE-64 </c> 字符串。 </param>
    /// <returns> 字节数组。 </returns>
    byte[] Decode(string base64Str);

    #endregion Methods
  }

  #endregion Interfaces
}