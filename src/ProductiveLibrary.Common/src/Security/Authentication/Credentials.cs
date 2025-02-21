/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using Niacomsoft.ProductiveLibrary.Resources;
using Niacomsoft.ProductiveLibrary.Resources.Internal;
using Niacomsoft.ProductiveLibrary.Utilities;

using System;
using System.Diagnostics.CodeAnalysis;

namespace Niacomsoft.ProductiveLibrary.Security.Authentication
{
  /// <summary> 提供了身份认证凭据相关的抽象 <see langword="abstract" /> 方法。 </summary>
  /// <seealso cref="ICredentials" />
  public abstract class Credentials : ICredentials
  {
    #region Methods

    /// <summary>
    ///   当关键信息字符串 <paramref name="value" /> 等于 <see langword="null" />、 <see cref="string.Empty" />
    ///   或空格符时，将引发一个 <see cref="ArgumentException" /> 类型的异常。
    /// </summary>
    /// <param name="value"> 关键身份认证凭据字段值。 </param>
    /// <param name="argName"> 参数名称。 </param>
    [SuppressMessage("Design", "Ex0100:Member may throw undocumented exception", Justification = "<挂起>")]
    protected virtual void ThrowIfMissingRequiredInfo(string value, string argName)
    {
      if (AssertUtilities.IsWhiteSpace(value))
      {
        throw new ArgumentException(SR.Format(nameof(Strings.ArgumentException_string_null_or_whitespace_with_argument_name), argName), argName);
      }
    }

    #endregion Methods
  }
}