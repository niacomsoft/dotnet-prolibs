/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using Niacomsoft.ProductiveLibrary.Utilities;

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Niacomsoft.ProductiveLibrary.IO
{
  /// <summary> 提供了字节数组扩展相关的方法。 </summary>
  public readonly struct Bytes
  {
    #region Constructors

    /// <summary> 初始化 <see cref="Bytes" /> 类型值的新实例。 </summary>
    /// <param name="data"> 字节数据。 </param>
    [SuppressMessage("Design", "Ex0100:Member may throw undocumented exception", Justification = "<挂起>")]
    public Bytes(byte[] data) : this(data, 0, data?.Length ?? 0)
    {
    }

    /// <summary> 初始化 <see cref="Bytes" /> 类型值的新实例。 </summary>
    /// <param name="data"> 字节数据。 </param>
    /// <param name="offset"> 写入 <see cref="Data" /> 时的起始索引偏移量。 </param>
    /// <param name="length"> 写入 <see cref="Data" /> 时的字节长度。 </param>
    [SuppressMessage("Design", "Ex0100:Member may throw undocumented exception", Justification = "<挂起>")]
    public Bytes(byte[] data, int offset, int length)
    {
      Data = data;
      Length = AssertUtilities.IsNegative(length) ? (data?.Length ?? 0) : length;
      Offset = AssertUtilities.IsNegative(offset) ? 0 : offset;
    }

    #endregion Constructors

    #region Properties

    /// <summary> 字节数据。 </summary>
    /// <value> 获取 <see cref="byte" /> 类型的数组，用于表示字节数据。 </value>
    public byte[] Data { get; }

    /// <summary> 字节数组 <see cref="Data" /> 是否有数据。 </summary>
    /// <value> 获取 <see cref="bool" /> 类型的值，用于表示字节数组 <see cref="Data" /> 是否有数据。 </value>
    public bool HasData => AssertUtilities.NotEmptyArray(Data);

    /// <summary> 写入 <see cref="Data" /> 时的字节长度。 </summary>
    /// <value> 获取 <see cref="int" /> 类型的值，用于表示写入 <see cref="Data" /> 时的字节长度。 </value>
    public int Length { get; }

    /// <summary> 写入 <see cref="Data" /> 时的起始索引偏移量。 </summary>
    /// <value> 获取 <see cref="int" /> 类型的值，用于表示写入 <see cref="Data" /> 时的起始索引偏移量。 </value>
    public int Offset { get; }

    #endregion Properties

    #region Methods

    /// <summary> 从 <see cref="byte" /> 类型的数组或集合转换为 <see cref="Bytes" /> 类型的值。 </summary>
    /// <param name="bytes"> <see cref="byte" /> 类型的数组或集合。 </param>
    /// <param name="offset"> 写入 <see cref="Data" /> 时的起始索引偏移量。 </param>
    /// <param name="length"> 写入 <see cref="Data" /> 时的字节长度 </param>
    /// <returns> <see cref="Bytes" /> 类型的值。 </returns>
    /// <seealso cref="IEnumerable{T}" />
    /// <exception cref="OverflowException">
    ///   当访问 <c> <paramref name="bytes" />.Count </c> 属性时，可能引发此类型的异常。
    /// </exception>
    [SuppressMessage("Style", "IDE0046:转换为条件表达式", Justification = "<挂起>")]
    public static Bytes FromBytes(IEnumerable<byte> bytes, int? offset = null, int? length = null)
    {
      return new Bytes(bytes.ToArray(), offset ?? 0, length ?? ((bytes?.Count() ?? 0) - (offset ?? 0)));
    }

    #endregion Methods
  }
}