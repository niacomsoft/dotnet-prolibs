/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

namespace Niacomsoft.ProductiveLibrary.Data.Models
{
  #region Interfaces

  /// <summary> 提供了描述是否为主要的的接口。 </summary>
  /// <typeparam name="T"> 描述是否为主要的的类型。 </typeparam>
  public interface IPrimary<T>
  {
    #region Properties

    /// <summary> 是否为主要的。 </summary>
    /// <value> 设置或获取 <typeparamref name="T" /> 类型的值或对象实例，用于表示是否为主要的。 </value>
    T IsPrimary { get; set; }

    #endregion Properties
  }

  /// <summary> 提供了使用 32 位整型值描述是否为主要的的接口。 </summary>
  /// <seealso cref="IPrimary{T}" />
  public interface IPrimary : IPrimary<int>
  { }

  #endregion Interfaces
}