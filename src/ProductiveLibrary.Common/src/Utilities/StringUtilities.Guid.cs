/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using System;

namespace Niacomsoft.ProductiveLibrary.Utilities
{
  public static partial class StringUtilities
  {
    #region Methods

    /// <summary> 获取字符串 <paramref name="s" /> 等效的 <see cref="Guid" /> 类型的值。 </summary>
    /// <param name="s"> 字符串。 </param>
    /// <returns> <see cref="Guid" /> 类型的值。 </returns>
    /// <exception cref="System.OverflowException">
    ///   当调用 <see cref="Guid.Parse(string)" /> 方法时，可能引发此类型的异常。
    /// </exception>
    public static Guid GetGuid(string s)
    {
      return Guid.Parse(s);
    }

    /// <summary>
    ///   当调用 <see cref="TryGetGuid(string, out Guid)" /> 返回 <see langword="false" /> 时，返回
    ///   <see langword="null" />，否则返回真实值。
    /// </summary>
    /// <param name="s"> 字符串。 </param>
    /// <returns> 可能为空的 <see cref="Guid" /> 类型值。 </returns>
    public static Guid? SafeGetGuid(string s)
    {
      return TryGetGuid(s, out Guid value) ? new Guid?(value) : null;
    }

    /// <summary>
    ///   当调用 <see cref="TryGetGuid(string, out Guid)" /> 返回 <see langword="false" /> 时，返回
    ///   <paramref name="default" />，否则返回真实值。
    /// </summary>
    /// <param name="s"> 字符串。 </param>
    /// <param name="default">
    ///   当调用 <see cref="TryGetGuid(string, out Guid)" /> 返回 <see langword="false" /> 时需要返回的默认值。
    /// </param>
    /// <returns> <see cref="Guid" /> 类型的值。 </returns>
    public static Guid SafeGetGuid(string s, Guid @default)
    {
      return TryGetGuid(s, out Guid value) ? value : @default;
    }

    /// <summary>
    ///   尝试调用 <see cref="Guid.TryParse(string, out Guid)" /> 方法将字符串转换成等效的 <see cref="Guid" /> 类型的值。
    /// </summary>
    /// <param name="s"> 字符串。 </param>
    /// <param name="value"> <see cref="Guid" /> 类型的值。 </param>
    /// <returns> <see cref="Guid.TryParse(string, out Guid)" /> </returns>
    public static bool TryGetGuid(string s, out Guid value)
    {
      return Guid.TryParse(s, out value);
    }

    #endregion Methods
  }
}