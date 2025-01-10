/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using System.Globalization;
using System.Resources;

namespace Niacomsoft.ProductiveLibrary.Resources.Utilities
{
  #region Interfaces

  /// <summary> 提供了解析资源字符串的接口。 </summary>
  public interface IResourceStringResolver
  {
    #region Properties

    /// <summary>
    ///   访问资源字符串的方法。
    ///   <para> <see cref="ResourceManager" /> 类型的对象实例。 </para>
    /// </summary>
    /// <value> 获取 <see cref="ResourceManager" /> 类型的对象实例，用于表示访问资源字符串的方法。 </value>
    /// <seealso cref="ResourceManager" />
    ResourceManager ResourceManager { get; }

    #endregion Properties

    #region Methods

    /// <summary> 使用指定的资源字符串格式化。 </summary>
    /// <param name="resourceName"> 资源名称。 </param>
    /// <param name="culture">
    ///   当前的文化区域信息。
    ///   <para> <see cref="CultureInfo" /> 类型的对象实例。 </para>
    /// </param>
    /// <param name="args"> 格式化参数数组。 </param>
    /// <returns> 格式化的资源字符串。 </returns>
    /// <seealso cref="CultureInfo" />
    /// <seealso cref="string.Format(string, object[])" />
    string Format(string resourceName, CultureInfo culture, params object[] args);

    /// <summary> 使用指定的资源字符串格式化。 </summary>
    /// <param name="resourceName"> 资源名称。 </param>
    /// <param name="args"> 格式化参数数组。 </param>
    /// <returns> 格式化的资源字符串。 </returns>
    /// <seealso cref="string.Format(string, object[])" />
    string Format(string resourceName, params object[] args);

    /// <summary> 获取名称为 <paramref name="resourceName" /> 的资源字符串。 </summary>
    /// <param name="resourceName"> 资源名称。 </param>
    /// <returns> 资源字符串。 </returns>
    /// <seealso cref="CultureInfo" />
    string GetString(string resourceName);

    /// <summary> 获取名称为 <paramref name="resourceName" /> 的资源字符串。 </summary>
    /// <param name="resourceName"> 资源名称。 </param>
    /// <param name="culture">
    ///   当前的文化区域信息。
    ///   <para> <see cref="CultureInfo" /> 类型的对象实例。 </para>
    /// </param>
    /// <returns> 资源字符串。 </returns>
    /// <seealso cref="CultureInfo" />
    string GetString(string resourceName, CultureInfo culture);

    #endregion Methods
  }

  #endregion Interfaces
}