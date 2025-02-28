/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

namespace Niacomsoft.ProductiveLibrary.Security.Integer
{
  /// <summary> 提供了访问默认的整型哈希计算服务相关的静态 <see langword="static" /> 方法。 </summary>
  public static class HashIntegerProviders
  {
    #region Fields

    /// <summary> <see cref="int" /> 类型哈希编码、解码方法。 </summary>
    /// <seealso cref="HashInt32" />
    /// <seealso cref="HashInteger{T}" />
    /// <seealso cref="IIntegerHashDecoder{T}" />
    /// <seealso cref="IIntegerHashEncoder{T}" />
    public static readonly HashInteger<int> Int32 = new HashInt32();

    /// <summary> <see cref="long" /> 类型哈希编码、解码方法。 </summary>
    /// <seealso cref="HashInt64" />
    /// <seealso cref="HashInteger{T}" />
    /// <seealso cref="IIntegerHashDecoder{T}" />
    /// <seealso cref="IIntegerHashEncoder{T}" />
    public static readonly HashInteger<long> Int64 = new HashInt64();

    #endregion Fields
  }
}