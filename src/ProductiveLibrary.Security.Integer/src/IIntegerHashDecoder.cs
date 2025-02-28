/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using Niacomsoft.ProductiveLibrary.Utilities;

namespace Niacomsoft.ProductiveLibrary.Security.Integer
{
  #region Interfaces

  /// <summary> 提供了对整型值哈希字符串进行解码的接口。 </summary>
  /// <typeparam name="T"> 仅支持 <see cref="int" /> 和 <see cref="long" /> 类型。 </typeparam>
  internal interface IIntegerHashDecoder<T> where T : struct
  {
    #region Methods

    /// <summary> 从哈希字符串 <paramref name="hashStr" /> 获取 <typeparamref name="T" /> 类型的值。 </summary>
    /// <param name="hashStr"> 哈希字符串。 </param>
    /// <returns> <typeparamref name="T" /> 类型的值。 </returns>
    /// <exception cref="System.ArgumentException">
    ///   当字符串 <paramref name="hashStr" /> 等于 <see langword="null" />、 <see cref="string.Empty" />
    ///   或空格符时，将引发此类型的异常。
    /// </exception>
    T GetValue(string hashStr);

    /// <summary>
    ///   当从哈希字符串 <paramref name="hashStr" /> 解码成功时，返回解码值；否则返回 <paramref name="default" />。
    /// </summary>
    /// <param name="hashStr"> 哈希字符串。 </param>
    /// <param name="default"> 对 <paramref name="hashStr" /> 解码失败时，返回的默认值。 </param>
    /// <returns> <typeparamref name="T" /> 类型的值。 </returns>
    T GetValueOrDefault(string hashStr, int @default);

    /// <summary>
    ///   从哈希字符串 <paramref name="hashStr" /> 获取 <see cref="Result{T}" /> 类型的对象实例。
    /// </summary>
    /// <param name="hashStr"> 哈希字符串。 </param>
    /// <returns> <see cref="Result{T}" /> 类型的对象实例。 </returns>
    /// <seealso cref="Guard.Execute{TResult}(System.Func{TResult})" />
    /// <seealso cref="Result{T}" />
    Result<T> SafeGetValue(string hashStr);

    /// <summary>
    ///   尝试从哈希字符串 <paramref name="hashStr" /> 获取 <typeparamref name="T" /> 类型的值。
    /// </summary>
    /// <param name="hashStr"> 哈希字符串。 </param>
    /// <param name="value"> <typeparamref name="T" /> 类型的值。 </param>
    /// <returns> 是否解码成功。 </returns>
    bool TryGetValue(string hashStr, out T value);

    #endregion Methods
  }

  #endregion Interfaces
}