/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using System;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace Niacomsoft.ProductiveLibrary.Resources.Utilities
{
  /// <summary> 提供了解析资源字符串相关的基本方法。 </summary>
  /// <seealso cref="IResourceStringResolver" />
  public class ResourceStringResolver : IResourceStringResolver
  {
    #region Fields

    private readonly ResourceManager _resourceManager;

    #endregion Fields

    #region Constructors

    /// <summary> 初始化 <see cref="ResourceStringResolver" /> 类的新实例。 </summary>
    /// <param name="resourceManager">
    ///   管理资源字符串的方法。
    ///   <para> <see cref="ResourceManager" /> 类型的对象实例。 </para>
    /// </param>
    public ResourceStringResolver(ResourceManager resourceManager) => _resourceManager = resourceManager;

    /// <summary> 初始化 <see cref="ResourceStringResolver" /> 类的新实例。 </summary>
    /// <param name="baseName">
    ///   资源文件的根名称，没有其扩展名但是包含所有完全限定的命名空间名称。
    ///   <para> 例如，名为 <c> MyApplication.MyResource.en-US.resources </c> 的资源文件的根名称为 <c> MyApplication.MyResource </c> </para>
    /// </param>
    /// <param name="assm">
    ///   资源文件所在的程序集。
    ///   <para> <see cref="Assembly" /> 类型的对象实例。 </para>
    /// </param>
    public ResourceStringResolver(string baseName, Assembly assm) : this(new ResourceManager(baseName, assm))
    {
    }

    /// <summary> 初始化 <see cref="ResourceStringResolver" /> 类的新实例。 </summary>
    /// <param name="resourceType">
    ///   一个类型，从资源管理器中派生所有用于查找 .resources 文件的信息。
    ///   <para> <see cref="Type" /> 类型的对象实例。 </para>
    /// </param>
    /// <seealso cref="Type" />
    public ResourceStringResolver(Type resourceType) : this(new ResourceManager(resourceType))
    {
    }

    #endregion Constructors

    #region Properties

    /// <inheritdoc />
    public virtual ResourceManager ResourceManager
    {
      get { return _resourceManager; }
    }

    #endregion Properties

    #region Methods

    /// <inheritdoc />
    /// <exception cref="ResourceStringException">
    ///   当调用 <see cref="GetString(string, CultureInfo)" /> 方法时，可能引发此类型的异常。
    /// </exception>
    /// <exception cref="FormatException">
    ///   当调用 <c> <see cref="string" />.Format(string, object[]) </c> 方法时，可能引发此类型的异常。
    /// </exception>
    public virtual string Format(string resourceName, CultureInfo culture, params object[] args) => string.Format(GetString(resourceName, culture), args);

    /// <inheritdoc />
    /// <exception cref="ResourceStringException"> 当调用 <see cref="GetString(string)" /> 方法时，可能引发此类型的异常。 </exception>
    /// <exception cref="FormatException">
    ///   当调用 <c> <see cref="string" />.Format(string, object[]) </c> 方法时，可能引发此类型的异常。
    /// </exception>
    public virtual string Format(string resourceName, params object[] args) => string.Format(GetString(resourceName), args);

    /// <inheritdoc />
    /// <exception cref="ResourceStringException">
    ///   当调用 <see cref="GetString(string, CultureInfo)" /> 方法时，可能引发此类型的异常。
    /// </exception>
    public virtual string GetString(string resourceName) => GetString(resourceName, null);

    /// <inheritdoc />
    /// <exception cref="ResourceStringException">
    ///   当调用 <c> <see cref="ResourceManager" />.GetStream(string, CultureInfo) </c> 方法时，可能引发此类型的异常。
    /// </exception>
    public virtual string GetString(string resourceName, CultureInfo culture)
    {
      try
      {
        return (culture is null) ? _resourceManager.GetString(resourceName) : _resourceManager.GetString(resourceName, culture);
      }
      catch (Exception error)
      {
        throw new ResourceStringException(error);
      }
    }

    #endregion Methods
  }
}