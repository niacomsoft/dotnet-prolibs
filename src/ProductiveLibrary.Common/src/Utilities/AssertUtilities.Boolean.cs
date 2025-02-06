/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using Niacomsoft.ProductiveLibrary.Resources;
using Niacomsoft.ProductiveLibrary.Resources.Internal;

using System;
using System.Diagnostics.CodeAnalysis;

namespace Niacomsoft.ProductiveLibrary.Utilities
{
  public static partial class AssertUtilities
  {
    #region Methods

    /// <summary>
    ///   使用 <paramref name="validator" /> 验证 <paramref name="value" /> 是否等效于
    ///   <see langword="true" />。
    /// </summary>
    /// <typeparam name="T"> 等效值类型。 </typeparam>
    /// <param name="value"> <typeparamref name="T" /> 类型的值或对象实例。 </param>
    /// <param name="validator">
    ///   验证方法。
    ///   <para> <see cref="TrueValidator{T}" /> 类型的方法委托。 </para>
    /// </param>
    /// <returns> <see cref="bool" /> 类型的值。 </returns>
    /// <exception cref="ArgumentNullException">
    ///   当 <paramref name="validator" /> 等于 <see langword="null" /> 时，将引发此类型的异常。
    /// </exception>
    [SuppressMessage("Style", "IDE0046:转换为条件表达式", Justification = "<挂起>")]
    public static bool True<T>(T value, TrueValidator<T> validator)
    {
      if (IsNull(validator))
      {
        throw new ArgumentNullException(nameof(validator), SR.Format(nameof(Strings.ArgumentNullException_with_argument_name), nameof(validator)));
      }

      return validator(value);
    }

    #endregion Methods
  }
}