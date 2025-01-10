/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using Niacomsoft.ProductiveLibrary.Resources.Internal;
using Niacomsoft.ProductiveLibrary.Resources.Utilities;

using System;
using System.Globalization;
using System.Resources;

namespace Niacomsoft.ProductiveLibrary.Resources
{
  /// <summary> 提供了解析 <c> ProductiveLibrary </c> 多语言支持资源字符串相关的静态 <see langword="static" /> 方法。 </summary>
  public static class SR
  {
    #region Fields

    private static readonly IResourceStringResolver StringResolver = new ResourceStringResolver(Strings.ResourceManager);

    #endregion Fields

    #region Methods

    /// <inheritdoc />
    /// <exception cref="ResourceStringException">
    ///   当调用 <see cref="GetString(string, CultureInfo)" /> 方法时，可能引发此类型的异常。
    /// </exception>
    /// <exception cref="FormatException">
    ///   当调用 <c> <see cref="string" />.Format(string, object[]) </c> 方法时，可能引发此类型的异常。
    /// </exception>
    public static string Format(string resourceName, CultureInfo culture, params object[] args) => StringResolver.Format(resourceName, culture, args);

    /// <inheritdoc />
    /// <exception cref="ResourceStringException"> 当调用 <see cref="GetString(string)" /> 方法时，可能引发此类型的异常。 </exception>
    /// <exception cref="FormatException">
    ///   当调用 <c> <see cref="string" />.Format(string, object[]) </c> 方法时，可能引发此类型的异常。
    /// </exception>
    public static string Format(string resourceName, params object[] args) => StringResolver.Format(resourceName, args);

    /// <inheritdoc />
    /// <exception cref="ResourceStringException">
    ///   当调用 <see cref="GetString(string, CultureInfo)" /> 方法时，可能引发此类型的异常。
    /// </exception>
    public static string GetString(string resourceName) => StringResolver.GetString(resourceName);

    /// <inheritdoc />
    /// <exception cref="ResourceStringException">
    ///   当调用 <c> <see cref="ResourceManager" />.GetStream(string, CultureInfo) </c> 方法时，可能引发此类型的异常。
    /// </exception>
    public static string GetString(string resourceName, CultureInfo culture) => StringResolver.GetString(resourceName, culture);

    #endregion Methods
  }
}