/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using Niacomsoft.ProductiveLibrary.Resources;
using Niacomsoft.ProductiveLibrary.Resources.Internal;

using System;

namespace Niacomsoft.ProductiveLibrary.Utilities
{
  /// <summary> 提供了注解特性相关的静态 <see langword="static" /> 方法。 </summary>
  public static partial class AttributeUtilities
  {
    #region Methods

    /// <summary>
    ///   当 <paramref name="attrType" /> 不是一个 <see cref="Attribute" /> 类型时，将引发一个
    ///   <see cref="ArgumentException" /> 类型的异常。
    /// </summary>
    /// <param name="attrType"> 需要校验的类型。 </param>
    /// <exception cref="ArgumentException"> </exception>
    private static void NotAttributeType(Type attrType)
    {
      if (AssertUtilities.InheritFrom(attrType, typeof(Attribute), false))
      {
        throw new ArgumentException(SR.Format(nameof(Strings.ArgumentException_invalid_inheritance), attrType?.FullName, typeof(Attribute).FullName), nameof(attrType));
      }
    }

    #endregion Methods
  }
}