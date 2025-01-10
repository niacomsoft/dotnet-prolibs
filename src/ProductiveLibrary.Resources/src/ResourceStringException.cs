/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using Niacomsoft.ProductiveLibrary.Resources.Internal;

using System;

namespace Niacomsoft.ProductiveLibrary.Resources
{
  /// <summary>
  ///   提供了访问多语言支持资源字符串异常相关的方法。
  ///   <para> 密闭的，不能从此类型派生。 </para>
  /// </summary>
  /// <seealso cref="Exception" />
  public sealed class ResourceStringException : Exception
  {
    #region Constructors

    /// <summary> 初始化 <see cref="ResourceStringException" /> 类的新实例。 </summary>
    public ResourceStringException() : base(Strings.ResourceStringException_default_message)
    {
    }

    /// <summary> 初始化 <see cref="ResourceStringException" /> 类的新实例。 </summary>
    /// <param name="innerException"> 引发此异常的 <see cref="Exception" /> 类型的对象实例。 </param>
    /// <seealso cref="Exception" />
    public ResourceStringException(Exception innerException) : base(Strings.ResourceStringException_default_message, innerException)
    {
    }

    #endregion Constructors
  }
}