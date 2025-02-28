/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using HashidsNet;

using Niacomsoft.ProductiveLibrary.Resources;
using Niacomsoft.ProductiveLibrary.Resources.Internal;
using Niacomsoft.ProductiveLibrary.Utilities;

using System;

namespace Niacomsoft.ProductiveLibrary.Security.Integer
{
  /// <summary> 提供了计算整型哈希值相关的抽象 <see langword="abstract" /> 方法。 </summary>
  /// <typeparam name="T"> 仅支持 <see cref="int" /> 和 <see cref="long" /> 类型。 </typeparam>
  /// <seealso cref="IIntegerHashDecoder{T}" />
  /// <seealso cref="IIntegerHashEncoder{T}" />
  public abstract class HashInteger<T> : IIntegerHashEncoder<T>, IIntegerHashDecoder<T> where T : struct
  {
    /// <summary> 初始化 <see cref="HashInteger{T}" /> 类的新实例。 </summary>
    protected HashInteger()
    {
      Provider = new Hashids(minHashLength: 8);
    }

    #region Properties

    /// <summary> 计算整型哈希值的方法。 </summary>
    /// <value> 获取 <see cref="IHashids" /> 类型的对象实例，用于表示计算整型哈希值的方法。 </value>
    /// <seealso cref="IHashids" />
    protected virtual IHashids Provider { get; }

    #endregion Properties

    #region Methods

    /// <summary> 从哈希字符串 <paramref name="hashStr" /> 获取 <typeparamref name="T" /> 类型的值。 </summary>
    /// <param name="hashStr"> 哈希字符串。 </param>
    /// <returns> <typeparamref name="T" /> 类型的值。 </returns>
    protected abstract T GetValueImpl(string hashStr);

    /// <summary> 计算 <paramref name="value" /> 的哈希字符串。 </summary>
    /// <param name="value"> <typeparamref name="T" /> 类型的值。 </param>
    /// <returns> 哈希字符串。 </returns>
    public abstract string ComputeHash(T value);

    /// <summary> 从哈希字符串 <paramref name="hashStr" /> 获取 <typeparamref name="T" /> 类型的值。 </summary>
    /// <param name="hashStr"> 哈希字符串。 </param>
    /// <returns> <typeparamref name="T" /> 类型的值。 </returns>
    /// <exception cref="System.ArgumentException">
    ///   当字符串 <paramref name="hashStr" /> 等于 <see langword="null" />、 <see cref="string.Empty" />
    ///   或空格符时，将引发此类型的异常。
    /// </exception>
    public virtual T GetValue(string hashStr)
    {
      if (AssertUtilities.IsWhiteSpace(hashStr))
      {
        throw new ArgumentException(SR.Format(nameof(Strings.ArgumentException_string_null_or_whitespace_with_argument_name), nameof(hashStr)), nameof(hashStr));
      }
      return GetValueImpl(hashStr);
    }

    /// <summary>
    ///   当从哈希字符串 <paramref name="hashStr" /> 解码成功时，返回解码值；否则返回 <paramref name="default" />。
    /// </summary>
    /// <param name="hashStr"> 哈希字符串。 </param>
    /// <param name="default"> 对 <paramref name="hashStr" /> 解码失败时，返回的默认值。 </param>
    /// <returns> <typeparamref name="T" /> 类型的值。 </returns>
    public virtual T GetValueOrDefault(string hashStr, T @default)
    {
      return TryGetValue(hashStr, out T value) ? value : @default;
    }

    /// <summary>
    ///   从哈希字符串 <paramref name="hashStr" /> 获取 <see cref="Result{T}" /> 类型的对象实例。
    /// </summary>
    /// <param name="hashStr"> 哈希字符串。 </param>
    /// <returns> <see cref="Result{T}" /> 类型的对象实例。 </returns>
    /// <seealso cref="Guard.Execute{TResult}(System.Func{TResult})" />
    /// <seealso cref="Result{T}" />
    public virtual Result<T> SafeGetValue(string hashStr)
    {
      return Guard.Execute(() => GetValue(hashStr));
    }

    /// <summary>
    ///   尝试从哈希字符串 <paramref name="hashStr" /> 获取 <typeparamref name="T" /> 类型的值。
    /// </summary>
    /// <param name="hashStr"> 哈希字符串。 </param>
    /// <param name="value"> <typeparamref name="T" /> 类型的值。 </param>
    /// <returns> 是否解码成功。 </returns>
    public virtual bool TryGetValue(string hashStr, out T value)
    {
      value = default;
      var result = SafeGetValue(hashStr);
      if (result.Completed)
      {
        value = result.Value;
        return true;
      }
      return false;
    }

    #endregion Methods
  }
}