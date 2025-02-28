/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

namespace Niacomsoft.ProductiveLibrary.Security.Integer
{
  #region Interfaces

  /// <summary> 提供了对整型值进行哈希编码的接口。 </summary>
  /// <typeparam name="T"> 仅支持 <see cref="int" /> 和 <see cref="long" /> 类型。 </typeparam>
  public interface IIntegerHashEncoder<T> where T : struct
  {
    #region Methods

    /// <summary> 计算 <paramref name="value" /> 的哈希字符串。 </summary>
    /// <param name="value"> <typeparamref name="T" /> 类型的值。 </param>
    /// <returns> 哈希字符串。 </returns>
    string ComputeHash(T value);

    #endregion Methods
  }

  #endregion Interfaces
}