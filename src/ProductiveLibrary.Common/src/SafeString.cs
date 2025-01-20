/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using System;

namespace Niacomsoft.ProductiveLibrary
{
  /// <summary> 提供了安全字符串相关的方法。 </summary>
  /// <seealso cref="ISafeString" />
  public readonly struct SafeString : ISafeString
  {
    #region Constructors

    /// <summary> 初始化 <see cref="SafeString" /> 类型值的新实例。 </summary>
    /// <param name="value"> 原始字符串。 </param>
    public SafeString(string value)
    {
      Value = value;
    }

    #endregion Constructors

    #region Properties

    /// <inheritdoc />
    public bool HasValue => Value.NotNull();

    /// <inheritdoc />
    public string Value { get; }

    #endregion Properties

    #region Methods

    /// <inheritdoc />
    public string GetDefaultIfEmpty(string @default) => Value.IsEmpty() ? @default : Value;

    /// <inheritdoc />
    public string GetDefaultIfWhiteSpace(string @default) => Value.IsWhiteSpace() ? @default : Value;

    /// <inheritdoc />
    /// <exception cref="NotImplementedException"> </exception>
    [Obsolete("CSC: This method has not been implemented.", true)]
    public string GetDefaultValueIfNull(Func<string> defaultBuilder)
    {
      throw new NotImplementedException();
    }

    /// <inheritdoc />
    public string GetDefaultValueIfNull(string defaultValue) => Value.IsNull() ? defaultValue : Value;

    #endregion Methods
  }
}