/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

namespace Niacomsoft.ProductiveLibrary.Security.Integer
{
  /// <summary>
  ///   提供了计算 64 位整型哈希值相关的方法。
  ///   <para> 密闭的，不能从此类型派生。 </para>
  /// </summary>
  /// <seealso cref="HashInteger{T}" />
  public sealed class HashInt64 : HashInteger<long>
  {
    #region Constructors

    /// <summary> 初始化 <see cref="HashInt64" /> 类的新实例。 </summary>
    public HashInt64()
    {
    }

    #endregion Constructors

    #region Methods

    /// <summary> 从哈希字符串 <paramref name="hashStr" /> 获取 <see cref="long" /> 类型的值。 </summary>
    /// <param name="hashStr"> 哈希字符串。 </param>
    /// <returns> <see cref="long" /> 类型的值。 </returns>
    /// <exception cref="HashidsNet.NoResultException">
    ///   当调用 <see cref="HashidsNet.IHashids.DecodeSingleLong(string)" /> 方法时，可能引发此类型的异常。
    /// </exception>
    protected override long GetValueImpl(string hashStr)
    {
      return Provider.DecodeSingleLong(hashStr);
    }

    /// <summary> 计算 <paramref name="value" /> 的哈希字符串。 </summary>
    /// <param name="value"> <see cref="long" /> 类型的值。 </param>
    /// <returns> 哈希字符串。 </returns>
    public override string ComputeHash(long value)
    {
      return Provider.EncodeLong(value);
    }

    #endregion Methods
  }
}