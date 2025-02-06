/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using Niacomsoft.ProductiveLibrary.Utilities;

namespace Niacomsoft.ProductiveLibrary
{
  /// <summary> 提供了一组预置的真值验证方法相关的静态 <see langword="static" /> 方法。 </summary>
  public static class TrueValidatorPresets
  {
    #region Fields

    /// <summary> 默认的真值验证方法。 </summary>
    public static readonly TrueValidator<bool> Default = new TrueValidator<bool>((value) => value);

    /// <summary> 当值等于 <c> 1 </c> 时返回真值的验证方法。 </summary>
    public static readonly TrueValidator<int> EqualsOne = new TrueValidator<int>((value) => AssertUtilities.Equal(value, 1));

    /// <summary> 当值与字符串 <c> True </c> 近似相等时返回真值的验证方法。 </summary>
    public static readonly TrueValidator<string> TrueOrFalse = new TrueValidator<string>((value) => AssertUtilities.Like(value, bool.TrueString));

    /// <summary> 当值等于 <c> “T/t” </c> 时返回真值的验证方法。 </summary>
    public static readonly TrueValidator<char> TrueOrFalseCharacter = new TrueValidator<char>(value => Equals(value, 'T') || Equals(value, 't'));

    /// <summary> 当值与字符串 <c> Yes </c> 近似相等时返回真值的验证方法。 </summary>
    public static readonly TrueValidator<string> YesOrNo = new TrueValidator<string>((value) => AssertUtilities.Like(value, "Yes"));

    /// <summary> 当值等于 <c> “Y/y” </c> 时返回真值的验证方法。 </summary>
    public static readonly TrueValidator<char> YesOrNoCharacter = new TrueValidator<char>(value => Equals(value, 'Y') || Equals(value, 'y'));

    #endregion Fields
  }
}