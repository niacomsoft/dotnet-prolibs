/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using Niacomsoft.ProductiveLibrary.Diagnostics;
using Niacomsoft.ProductiveLibrary.Resources;
using Niacomsoft.ProductiveLibrary.Resources.Internal;
using Niacomsoft.ProductiveLibrary.Utilities;

using System;
using System.Text;

namespace Niacomsoft.ProductiveLibrary.Text
{
  /// <summary> 提供了默认文本编码程序相关的静态 <see langword="static" /> 方法。 </summary>
  public static class DefaultEncodingHolder
  {
    #region Fields

    private static Lazy<Encoding> s_defaultEncoding;

    #endregion Fields

    #region Constructors

    /// <summary>
    ///   初始化 <see cref="DefaultEncodingHolder" /> 静态 <see langword="static" /> 类的新实例。
    /// </summary>
    static DefaultEncodingHolder()
    {
      s_defaultEncoding = new Lazy<Encoding>(() => Encoding.UTF8, true);
    }

    #endregion Constructors

    #region Properties

    /// <summary> 默认的编码程序。 </summary>
    /// <value> 获取 <see cref="Encoding" /> 类型的对象实例，用于表示默认的编码程序。 </value>
    /// <seealso cref="Encoding" />
    /// <seealso cref="Lazy{T}" />
    public static Lazy<Encoding> DefaultEncoding
    {
      get { return s_defaultEncoding; }
    }

    #endregion Properties

    #region Methods

    /// <summary> 设置默认的文本编码程序。 </summary>
    /// <param name="encoding"> <see cref="Encoding" /> 类型的对象实例。 </param>
    /// <seealso cref="Encoding" />
    public static void SetDefaultEncoding(Encoding encoding)
    {
      if (Doctor.TraceIf(AssertUtilities.NotNull(encoding), SR.Format(nameof(Strings.Diagnostics_default_encoding_reset), encoding.ToString(), encoding.EncodingName)))
      {
        s_defaultEncoding = new Lazy<Encoding>(() => encoding, true);
      }
    }

    /// <summary> 设置默认的文本编码程序。 </summary>
    /// <param name="encodingName"> 编码名称。 </param>
    public static void SetDefaultEncoding(string encodingName)
    {
      if (AssertUtilities.NotWhiteSpace(encodingName))
      {
        SetDefaultEncoding(Encoding.GetEncoding(encodingName));
      }
    }

    /// <summary> 设置默认的文本编码程序。 </summary>
    /// <param name="factory"> 默认编码程序工厂方法。 </param>
    /// <seealso cref="Encoding" />
    /// <seealso cref="System.Func{TResult}" />
    public static void SetDefaultEncoding(System.Func<Encoding> factory)
    {
      if (AssertUtilities.NotNull(factory))
      {
        s_defaultEncoding = new Lazy<Encoding>(factory, true);
      }
    }

    #endregion Methods
  }
}