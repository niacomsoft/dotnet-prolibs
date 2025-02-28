/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using Niacomsoft.ProductiveLibrary.Resources;
using Niacomsoft.ProductiveLibrary.Resources.Internal;
using Niacomsoft.ProductiveLibrary.Utilities;

using System;

namespace Niacomsoft.ProductiveLibrary
{
  /// <summary> 提供了生成 Nano ID 的配置选项相关的基本方法。 </summary>
  public class NanoIdGenerateOptions
  {
    #region Constants

    private const int MIN_LENGTH = 0x10;

    /// <summary> 默认的字母表。 </summary>
    public const string DefaultAlphabets = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789_-";

    /// <summary> 默认的长度。 </summary>
    public const int DefaultLength = 21;

    #endregion Constants

    #region Fields

    /// <summary> 默认配置选项。 </summary>
    public static readonly NanoIdGenerateOptions Default = new NanoIdGenerateOptions();

    #endregion Fields

    #region Constructors

    /// <summary> 初始化 <see cref="NanoIdGenerateOptions" /> 类的新实例。 </summary>
    public NanoIdGenerateOptions() : this(DefaultAlphabets, DefaultLength)
    {
    }

    /// <summary> 初始化 <see cref="NanoIdGenerateOptions" /> 类的新实例。 </summary>
    /// <param name="length"> 生成 <c> Nano ID </c> 的长度。 </param>
    public NanoIdGenerateOptions(int length) : this(DefaultAlphabets, length)
    {
    }

    /// <summary> 初始化 <see cref="NanoIdGenerateOptions" /> 类的新实例。 </summary>
    /// <param name="alphabets"> 生成 <c> Nano ID </c> 的字母表。 </param>
    public NanoIdGenerateOptions(string alphabets) : this(alphabets, DefaultLength)
    {
    }

    /// <summary> 初始化 <see cref="NanoIdGenerateOptions" /> 类的新实例。 </summary>
    /// <param name="alphabets"> 生成 <c> Nano ID </c> 的字母表。 </param>
    /// <param name="length"> 生成 <c> Nano ID </c> 的长度。 </param>
    /// <exception cref="ArgumentException">
    ///   当字符串 <paramref name="alphabets" /> 等于 <see langword="null" />、 <see cref="string.Empty" />
    ///   或空格符时，将引发此类型的异常。
    /// </exception>
    /// <exception cref="ArgumentOutOfRangeException">
    ///   当 <paramref name="length" /> &lt; 16 时，将引发此类型的异常。
    /// </exception>
    public NanoIdGenerateOptions(string alphabets, int length)
    {
      if (AssertUtilities.IsWhiteSpace(alphabets))
      {
        throw new ArgumentException(SR.Format(nameof(Strings.ArgumentException_string_null_or_whitespace_with_argument_name), nameof(alphabets)), nameof(alphabets));
      }
      if (AssertUtilities.LessThan(length, MIN_LENGTH))
      {
        throw new ArgumentOutOfRangeException(nameof(length), length, SR.Format(nameof(Strings.ArgumentOutOfRangeException_with_argument_name_and_range), nameof(length), $"length >= {MIN_LENGTH}"));
      }

      Alphabets = alphabets.Trim();
      Length = length;
    }

    #endregion Constructors

    #region Properties

    /// <summary> 用于生成 <c> Nano ID </c> 的字母表。 </summary>
    /// <value> 获取一个字符串，用于表示用于生成 <c> Nano ID </c> 的字母表。 </value>
    public virtual string Alphabets { get; }

    /// <summary> 生成的 <c> Nano ID </c> 长度。 </summary>
    /// <value> 获取 <see cref="int" /> 类型的值，用于表示生成的 <c> Nano ID </c> 长度。 </value>
    public virtual int Length { get; }

    #endregion Properties
  }
}