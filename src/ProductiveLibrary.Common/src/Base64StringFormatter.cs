/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using Niacomsoft.ProductiveLibrary.Resources;
using Niacomsoft.ProductiveLibrary.Resources.Internal;

using System;
using System.Diagnostics.CodeAnalysis;

namespace Niacomsoft.ProductiveLibrary
{
  /// <summary>
  ///   提供了 <c> BASE-64 </c> 字符串格式化相关的方法。
  ///   <para> 密闭的，不能从此类型派生。 </para>
  /// </summary>
  /// <seealso cref="IBase64StringDecoder" />
  /// <seealso cref="IBase64StringEncoder" />
  public sealed class Base64StringFormatter : IBase64StringDecoder, IBase64StringEncoder
  {
    #region Fields

    private static readonly Base64StringFormatter Formatter = new Base64StringFormatter();

    /// <summary> <c> BASE-64 </c> 字符串解码服务。 </summary>
    /// <seealso cref="IBase64StringDecoder" />
    public static readonly IBase64StringDecoder Decoder = Formatter;

    /// <summary> <c> BASE-64 </c> 字符串编码服务。 </summary>
    /// <seealso cref="IBase64StringEncoder" />
    public static readonly IBase64StringEncoder Encoder = Formatter;

    #endregion Fields

    #region Constructors

    /// <summary> 初始化 <see cref="Base64StringFormatter" /> 类的新实例。 </summary>
    private Base64StringFormatter()
    {
    }

    #endregion Constructors

    #region Methods

    /// <inheritdoc />
    /// <exception cref="ArgumentException">
    ///   当字符串 <paramref name="base64Str" /> 等于 <see langword="null" /> 或
    ///   <see cref="string.Empty" /> 时，将引发此类型的异常。
    /// </exception>
    public byte[] Decode(string base64Str)
    {
      if (base64Str.IsEmpty())
      {
        throw new ArgumentException(SR.Format(nameof(Strings.ArgumentException_string_null_or_empty_with_argument_name), nameof(base64Str)), nameof(base64Str));
      }

      return Convert.FromBase64String(base64Str);
    }

    /// <inheritdoc />
    /// <exception cref="ArgumentNullException">
    ///   当 <paramref name="input" /> 等于 <see langword="null" /> 时，将引发此类型的异常。
    /// </exception>
    /// <exception cref="OverflowException">
    ///   当访问 <c> <paramref name="input" />.Length </c> 属性时，可能引发此类型的异常。
    /// </exception>
    [SuppressMessage("Style", "IDE0046:转换为条件表达式", Justification = "<挂起>")]
    public string Encode(byte[] input, int? startIndex = null, int? length = null, Base64FormattingOptions options = Base64FormattingOptions.None)
    {
      if (input.Empty())
      {
        throw new ArgumentNullException(nameof(input), SR.Format(nameof(Strings.ArgumentNullException_with_argument_name), nameof(input)));
      }

      return Convert.ToBase64String(input, startIndex ?? 0, length ?? input.Length, options);
    }

    #endregion Methods
  }
}