/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

namespace Niacomsoft.ProductiveLibrary.Security.Integer
{
  /// <summary>
  ///   提供了计算 32 位整型哈希值相关的方法。
  ///   <para> 密闭的，不能从此类型派生。 </para>
  /// </summary>
  /// <seealso cref="HashInteger{T}" />
  public sealed class HashInt32 : HashInteger<int>
  {
    #region Constructors

    /// <summary> 初始化 <see cref="HashInt32" /> 类的新实例。 </summary>
    public HashInt32()
    {
    }

    #endregion Constructors

    #region Methods

    /// <summary> 从哈希字符串 <paramref name="hashStr" /> 获取 <see cref="int" /> 类型的值。 </summary>
    /// <param name="hashStr"> 哈希字符串。 </param>
    /// <returns> <see cref="int" /> 类型的值。 </returns>
    /// <exception cref="System.OverflowException">
    ///   当调用 <see cref="HashidsNet.IHashids.DecodeSingle(string)" /> 方法时，可能引发此类型的异常。
    /// </exception>
    /// <exception cref="HashidsNet.NoResultException">
    ///   当调用 <see cref="HashidsNet.IHashids.DecodeSingle(string)" /> 方法时，可能引发此类型的异常。
    /// </exception>
    protected override int GetValueImpl(string hashStr)
    {
      return Provider.DecodeSingle(hashStr);
    }

    /// <summary> 计算 <paramref name="value" /> 的哈希字符串。 </summary>
    /// <param name="value"> <see cref="int" /> 类型的值。 </param>
    /// <returns> 哈希字符串。 </returns>
    public override string ComputeHash(int value)
    {
      return Provider.Encode(value);
    }

    #endregion Methods
  }
}