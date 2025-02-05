/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using Niacomsoft.ProductiveLibrary.Resources;
using Niacomsoft.ProductiveLibrary.Resources.Internal;

using System;

namespace Niacomsoft.ProductiveLibrary.Collections.Generic
{
  /// <summary> 提供了描述标识值相关的抽象 <see langword="abstract" /> 方法。 </summary>
  /// <typeparam name="T"> 标识值类型。 </typeparam>
  /// <seealso cref="IKey{T}" />
  public abstract class KeyBase<T> : IKey<T>
  {
    #region Fields

    private T _value;

    #endregion Fields

    #region Constructors

    /// <summary> 初始化 <see cref="KeyBase{T}" /> 类的新实例。 </summary>
    /// <param name="value"> <typeparamref name="T" /> 类型的标识值。 </param>
    /// <exception cref="ArgumentNullException">
    ///   当 <paramref name="value" /> 等于 <see langword="null" /> 时，将引发此类型的异常。
    /// </exception>
    protected KeyBase(T value)
    {
      if (value.IsNull())
      {
        throw new ArgumentNullException(nameof(value), SR.Format(nameof(Strings.ArgumentNullException_with_argument_name), nameof(value)));
      }
      _value = value;
    }

    #endregion Constructors

    #region Properties

    /// <inheritdoc />
    public virtual T Value
    {
      get { return _value; }
      protected set { _value = value; }
    }

    #endregion Properties
  }
}