/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using Niacomsoft.ProductiveLibrary.IO;
using Niacomsoft.ProductiveLibrary.Utilities;

using System;
using System.Diagnostics.CodeAnalysis;

namespace Niacomsoft.ProductiveLibrary.Text
{
  /// <summary>
  ///   提供了 <c> BASE-64 </c> 字符串解码 / 编码相关的方法。
  ///   <para> 密闭的，不能从此类型派生。 </para>
  /// </summary>
  /// <seealso cref="IBase64StringDecoder" />
  /// <seealso cref="IBase64StringEncoder" />
  public sealed class Base64StringFormatter : IBase64StringEncoder, IBase64StringDecoder
  {
    #region Fields

    private static readonly Base64StringFormatter Formatter = new Base64StringFormatter();

    /// <summary> <c> BASE-64 </c> 字符串解码程序。 </summary>
    public static readonly Lazy<IBase64StringDecoder> Decoder = new Lazy<IBase64StringDecoder>(() => Formatter, true);

    /// <summary> <c> BASE-64 </c> 字符串编码程序。 </summary>
    public static readonly Lazy<IBase64StringEncoder> Encoder = new Lazy<IBase64StringEncoder>(() => Formatter, true);

    #endregion Fields

    #region Methods

    /// <inheritdoc />
    [SuppressMessage("Style", "IDE0046:转换为条件表达式", Justification = "<挂起>")]
    public byte[] GetBytes(string base64Str)
    {
      if (AssertUtilities.IsEmpty(base64Str))
      {
        return null;
      }

      return Convert.FromBase64String(base64Str);
    }

    /// <inheritdoc />
    /// <exception cref="OverflowException">
    ///   当调用
    ///   <see cref="Bytes.FromBytes(System.Collections.Generic.IEnumerable{byte}, int?, int?)" />
    ///   方法时，可能引发此类型的异常。
    /// </exception>
    public string GetString(byte[] input, Base64FormattingOptions options = Base64FormattingOptions.None, int? offset = null, int? length = null)
    {
      return GetString(Bytes.FromBytes(input, offset, length), options);
    }

    /// <inheritdoc />
    [SuppressMessage("Style", "IDE0046:转换为条件表达式", Justification = "<挂起>")]
    public string GetString(Bytes input, Base64FormattingOptions options = Base64FormattingOptions.None)
    {
      if (!input.HasData)
      {
        return null;
      }

      return Convert.ToBase64String(input.Data, input.Offset, input.Length, options);
    }

    #endregion Methods
  }
}