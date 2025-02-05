/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using Niacomsoft.ProductiveLibrary.Resources;
using Niacomsoft.ProductiveLibrary.Resources.Internal;

using System;
using System.Text.RegularExpressions;

namespace Niacomsoft.ProductiveLibrary.Collections.Generic
{
  /// <summary>
  ///   提供了使用字符串描述标识值相关的方法。
  ///   <para> 密闭的，不能从此类型派生。 </para>
  /// </summary>
  /// <seealso cref="IKey{T}" />
  /// <seealso cref="KeyBase{T}" />
  public sealed class StringKey : KeyBase<string>
  {
    #region Constants

    private const string TYPENAME_REPLACEMENT_PATTERN = @"\.";

    private const string TYPENAME_REPLACEMENT_STRING = "__";

    #endregion Constants

    #region Fields

    private static readonly Regex TypeNameReplacement = new Regex(TYPENAME_REPLACEMENT_PATTERN, RegexOptions.Singleline | RegexOptions.IgnoreCase);

    #endregion Fields

    #region Constructors

    /// <summary> 初始化 <see cref="StringKey" /> 类的新实例。 </summary>
    /// <param name="value"> 描述标识值的字符串。 </param>
    /// <exception cref="ArgumentNullException">
    ///   当 <paramref name="value" /> 等于 <see langword="null" /> 时，将引发此类型的异常。
    /// </exception>
    /// <exception cref="ArgumentException"> </exception>
    public StringKey(string value) : base(value)
    {
      if (value.IsWhiteSpace())
      {
        throw new ArgumentException(SR.Format(nameof(Strings.ArgumentException_string_null_or_whitespace_with_argument_name), nameof(value)), nameof(value));
      }

      Value = value;
    }

    #endregion Constructors

    #region Methods

    /// <summary> 从 <paramref name="type" /> 转换为 <see cref="IKey{T}" /> 类型的对象实例。 </summary>
    /// <param name="type"> 目标类型。 </param>
    /// <returns> <see cref="StringKey" /> 类型的对象实例。 </returns>
    /// <seealso cref="Type" />
    /// <exception cref="RegexMatchTimeoutException">
    ///   当调用 <see cref="Regex.Replace(string, string)" /> 方法时，可能引发此类型的异常。
    /// </exception>
    public static IKey<string> FromType(Type type) => new StringKey($"dotnet_{TypeNameReplacement.Replace(type.FullName, TYPENAME_REPLACEMENT_STRING)}");

    #endregion Methods
  }
}